using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Drink.Dados;
using Drink.Models;

namespace Drink
{
    public partial class frmEventos : Form
    {
        private Evento eventoAtual = new Evento();

        public frmEventos()
        {
            InitializeComponent();
            CriarEventoAtual();
            AtualizarTabelaItens();
        }

        private void CriarEventoAtual()
        {
            eventoAtual = new Evento();

            eventoAtual.Id = GerarProximoIdEvento();
            eventoAtual.Nome = "Evento em edição";
            eventoAtual.Data = DateTime.Today;
            eventoAtual.Status = "Em montagem";

            if (eventoAtual.Itens == null)
            {
                eventoAtual.Itens = new List<ItemEvento>();
            }
        }
        private int GerarProximoIdEvento()
        {
            if (DadosTemporarios.Eventos.Count == 0)
            {
                return 1;
            }
            else
            {
                int proximoIdEvento = DadosTemporarios.Eventos.Max(e => e.Id);
                return proximoIdEvento + 1;
            }
         }

        private List<Item> ObterItensDisponiveisDoEstoque()
        {
            return DadosTemporarios.Itens
                .Where(item =>
                    item.Ativo &&
                    item.QuantidadeAtual > 0 &&
                    (!item.Validade.HasValue || item.Validade.Value >= DateTime.Today)
                )
                .ToList();
        }

        private int GerarProximoIdItemEvento()
        {
            if (eventoAtual.Itens.Count == 0)
            {
                return 1;
            }

            return eventoAtual.Itens.Max(item => item.Id) + 1;
        }

        private void AtualizarTabelaItens()
        {
            var dadosTabela = eventoAtual.Itens
                .Select(itemEvento => new
                {
                    ID = itemEvento.Id,
                    Nome = itemEvento.Item?.Nome ?? "",
                    Categoria = itemEvento.Item?.Categoria ?? "",
                    Qtd = itemEvento.QuantidadeSeparada,
                    Unidade = itemEvento.Item?.Unidade ?? "",
                    Status = itemEvento.Status,
                    Origem = itemEvento.VeioDoEstoque ? "Estoque" : "Compra direta"
                })
                .ToList();

            dgvItensEvento.DataSource = null;
            dgvItensEvento.DataSource = dadosTabela;
        }
        private ItemEvento? ObterItemEventoSelecionado()
        {
            if (dgvItensEvento.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvItensEvento.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                return eventoAtual.Itens.FirstOrDefault(i => i.Id == id);
            }
            return null;
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            List<Item> itensDisponiveis = ObterItensDisponiveisDoEstoque();

            frmNovoItemEvento telaNovoItem = new frmNovoItemEvento(itensDisponiveis);

            if (telaNovoItem.ShowDialog() == DialogResult.OK)
            {
                ItemEvento? novoItem = telaNovoItem.ItemCriado;

                if (novoItem == null)
                {
                    return;
                }

                novoItem.Id = GerarProximoIdItemEvento();

                eventoAtual.Itens.Add(novoItem);

                AtualizarTabelaItens();
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            ItemEvento? itemEvento = ObterItemEventoSelecionado();

            if (itemEvento == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }
            DialogResult resposta = MessageBox.Show(
           "Tem certeza que deseja remover este item?",
           "Confirmar remoção",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
            {
                return;
            }

            eventoAtual.Itens.Remove(itemEvento);

            AtualizarTabelaItens();

            MessageBox.Show("Item removido com sucesso.");
        }

        private void btnConfirmarSeparacao_Click(object sender, EventArgs e)
        {
            if (!eventoAtual.Itens.Any())
            {
                MessageBox.Show("Adicione pelo menos um item antes de confirmar a separação.");
                return;
            }
            if (eventoAtual.Status == "Separado")
            {
                MessageBox.Show("A separação deste evento já foi confirmada.");
                return;
            }
            foreach (ItemEvento itemEvento in eventoAtual.Itens)
            {
                if (!itemEvento.VeioDoEstoque)
                {
                    continue;
                }
                Item? itemEstoque = itemEvento.Item;

                if (itemEstoque == null)
                {
                    MessageBox.Show("Um item vindo do estoque não foi encontrado.");
                    return;
                }

                if (itemEvento.QuantidadeSeparada > itemEstoque.QuantidadeAtual)
                {
                    MessageBox.Show(
                        $"A quantidade separada para o item '{itemEstoque.Nome}' é maior do que a quantidade disponível no estoque."
                    );
                    return;
                }
                if (itemEstoque.Validade.HasValue && itemEstoque.Validade.Value < DateTime.Today)
                {
                    MessageBox.Show(
                        $"O item '{itemEstoque.Nome}' está vencido e não pode ser separado."
                    );
                    return;
                }
                if (itemEstoque.QuantidadeAtual - itemEvento.QuantidadeSeparada <= itemEstoque.QuantidadeMinima)
                {
                    DialogResult resposta = MessageBox.Show(
                        $"Separar {itemEvento.QuantidadeSeparada} {itemEstoque.Unidade} do item '{itemEstoque.Nome}' deixará o estoque abaixo da quantidade mínima recomendada. Deseja continuar?",
                        "Aviso de estoque baixo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resposta == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            foreach (ItemEvento itemEvento in eventoAtual.Itens)
            {
                if (itemEvento.VeioDoEstoque)
                {
                    Item? itemEstoque = itemEvento.Item;

                    if (itemEstoque != null)
                    {
                        itemEstoque.QuantidadeAtual -= itemEvento.QuantidadeSeparada;
                        itemEstoque.UltimaAtualizacao = DateTime.Now;
                    }
                }

                itemEvento.Status = "Separado";
            }

                eventoAtual.Status = "Separado";

                bool eventoExiste = DadosTemporarios.Eventos.Any(evento => evento.Id == eventoAtual.Id);
                if (eventoExiste)
                {
                MessageBox.Show("Evento ja existe");
                }
                else
                {
                DadosTemporarios.Eventos.Add(eventoAtual);
                }

                btnEditarItem.Enabled = false;
                btnNovoItem.Enabled = false;
                btnRemoverItem.Enabled = false;
                btnConfirmarSeparacao.Enabled = false;
                AtualizarTabelaItens();
                MessageBox.Show("Separação confirmada com sucesso.");
        }
    }
}