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
            CarregarCombosTela();
            CriarEventoAtual();
            AtualizarTabelaItens();
            AtualizarResumoEvento();
        }

        private void CriarEventoAtual()
        {
            eventoAtual = new Evento
            {
                Id = GerarProximoIdEvento(),
                Nome = "Evento em edição",
                Data = DateTime.Today,
                Local = "",
                Responsavel = "",
                ContatoResponsavel = "",
                QuantidadePessoas = 0,
                Status = "Em montagem",
                Itens = new List<ItemEvento>()
            };

            AtualizarResumoEvento();
        }

        private int GerarProximoIdEvento()
        {
            if (DadosTemporarios.Eventos.Count == 0) return 1;
            return DadosTemporarios.Eventos.Max(e => e.Id) + 1;
        }

        private List<Item> ObterItensDisponiveisDoEstoque()
        {
            return DadosTemporarios.Itens
                .Where(item =>
                    item.Ativo &&
                    (!item.Validade.HasValue || item.Validade.Value >= DateTime.Today))
                .ToList();
        }


        private int GerarProximoIdItemEvento()
        {
            if (eventoAtual.Itens.Count == 0) return 1;
            return eventoAtual.Itens.Max(item => item.Id) + 1;
        }
        private void CarregarCombosTela()
        {
            ComboBoxHelper.Preencher(cmbStatusEvento, CatalogosSistema.StatusEvento);

            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add("Todas");
            foreach (var cat in CatalogosSistema.Categorias)
                cmbFiltroCategoria.Items.Add(cat);
            cmbFiltroCategoria.SelectedIndex = 0;

            cmbFiltroStatus.Items.Clear();
            cmbFiltroStatus.Items.Add("Todos");
            foreach (var st in CatalogosSistema.StatusRetorno)
                cmbFiltroStatus.Items.Add(st);
            cmbFiltroStatus.Items.Add("Separado");
            cmbFiltroStatus.SelectedIndex = 0;

            RecarregarComboEventos(); // carrega cmbEventoSelecionadoE
        }

        private void RecarregarComboEventos()
        {
            cmbEventoSelecionadoE.SelectedIndexChanged -= cmbEventoSelecionadoE_SelectedIndexChanged;

            cmbEventoSelecionadoE.DataSource = null;
            cmbEventoSelecionadoE.DataSource = DadosTemporarios.Eventos.ToList();
            cmbEventoSelecionadoE.DisplayMember = "Nome";
            cmbEventoSelecionadoE.ValueMember = "Id";
            cmbEventoSelecionadoE.SelectedIndex = -1;

            cmbEventoSelecionadoE.SelectedIndexChanged += cmbEventoSelecionadoE_SelectedIndexChanged;
        }


        private void AtualizarTabelaItens(
            string nomeFiltro = "",
            string categoriaFiltro = "Todas",
            string statusFiltro = "Todos")
        {
            var itens = eventoAtual.Itens.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(nomeFiltro))
                itens = itens.Where(ie => ie.Item != null &&
                            ie.Item.Nome.Contains(nomeFiltro, StringComparison.OrdinalIgnoreCase));

            if (categoriaFiltro != "Todas")
                itens = itens.Where(ie => ie.Item?.Categoria == categoriaFiltro);

            if (statusFiltro != "Todos")
                itens = itens.Where(ie => ie.Status == statusFiltro);

            var dados = itens.Select(ie => new
            {
                ID = ie.Id,
                Nome = ie.Item?.Nome ?? "",
                Categoria = ie.Item?.Categoria ?? "",
                Qtd = ie.QuantidadeSeparada,
                Unidade = ie.Item?.Unidade ?? "",
                Status = ie.Status,
                Origem = ie.VeioDoEstoque ? "Estoque" : "Compra direta"
            }).ToList();

            dgvItensEvento.DataSource = null;
            dgvItensEvento.DataSource = dados;
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

        private void SalvarOuAtualizarEvento()
        {
            bool eventoExiste = DadosTemporarios.Eventos.Any(e => e.Id == eventoAtual.Id);

            if (eventoExiste)
            {
                // Substitui o evento existente na lista pelo atualizado
                int index = DadosTemporarios.Eventos.FindIndex(e => e.Id == eventoAtual.Id);
                if (index >= 0)
                    DadosTemporarios.Eventos[index] = eventoAtual;
            }
            else
            {
                DadosTemporarios.Eventos.Add(eventoAtual);
            }
        }
        private void AtualizarResumoEvento()
        {
            lblEventoValor.Text = string.IsNullOrWhiteSpace(eventoAtual.Nome)
                ? "Evento sem nome"
                : eventoAtual.Nome;

            lblDataValor.Text = eventoAtual.Data == DateTime.MinValue
                ? "-"
                : eventoAtual.Data.ToString("dd/MM/yyyy");

            lblLocalValor.Text = string.IsNullOrWhiteSpace(eventoAtual.Local)
                ? "-"
                : eventoAtual.Local;

            lblResponsavelValor.Text = string.IsNullOrWhiteSpace(eventoAtual.Responsavel)
                ? "-"
                : eventoAtual.Responsavel;
        }

        private bool SalvarDadosEvento()
        {
            if (string.IsNullOrWhiteSpace(txtNomeEvento.Text) ||
                string.IsNullOrWhiteSpace(txtLocalEvento.Text))
            {
                MessageBox.Show("Preencha os campos obrigatórios: Nome e Local.");
                return false;
            }

            eventoAtual.Nome = txtNomeEvento.Text.Trim();
            eventoAtual.Local = txtLocalEvento.Text.Trim();
            eventoAtual.Responsavel = txtResponsavelEvento.Text.Trim();
            eventoAtual.Data = dtpDataEvento.Value.Date;
            eventoAtual.Status = cmbStatusEvento.Text;
            eventoAtual.QuantidadePessoas = (int)nudQtdPessoas.Value;

            SalvarOuAtualizarEvento();
            RecarregarComboEventos();
            AtualizarResumoEvento();
            return true;
        }


        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            List<Item> itensDisponiveis = ObterItensDisponiveisDoEstoque();
            frmNovoItemEvento telaNovoItem = new frmNovoItemEvento(itensDisponiveis);

            if (telaNovoItem.ShowDialog() == DialogResult.OK)
            {
                ItemEvento? novoItem = telaNovoItem.ItemCriado;
                if (novoItem == null) return;

                novoItem.Id = GerarProximoIdItemEvento();
                eventoAtual.Itens.Add(novoItem);
                AtualizarTabelaItens();
            }
        }


        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            ItemEvento? itemEvento = ObterItemEventoSelecionado();

            if (itemEvento == null)
            {
                MessageBox.Show("Selecione um item para editar.");
                return;
            }

            List<Item> itensDisponiveis = ObterItensDisponiveisDoEstoque();
            frmNovoItemEvento telaEditar = new frmNovoItemEvento(itensDisponiveis);

            telaEditar.CarregarItemParaEdicao(itemEvento);

            if (telaEditar.ShowDialog() == DialogResult.OK)
            {
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
                MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

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

            // 1ª passagem: só validações — nada é alterado aqui
            foreach (ItemEvento itemEvento in eventoAtual.Itens)
            {
                if (!itemEvento.VeioDoEstoque) continue;

                Item? itemEstoque = itemEvento.Item;

                if (itemEstoque == null)
                {
                    MessageBox.Show("Um item vindo do estoque não foi encontrado.");
                    return;
                }

                if (itemEvento.QuantidadeSeparada > itemEstoque.QuantidadeAtual)
                {
                    MessageBox.Show($"A quantidade separada para '{itemEstoque.Nome}' é maior do que a disponível no estoque.");
                    return;
                }

                if (itemEstoque.Validade.HasValue && itemEstoque.Validade.Value < DateTime.Today)
                {
                    MessageBox.Show($"O item '{itemEstoque.Nome}' está vencido e não pode ser separado.");
                    return;
                }

                if (itemEstoque.QuantidadeAtual - itemEvento.QuantidadeSeparada < itemEstoque.QuantidadeMinima)
                {
                    DialogResult resposta = MessageBox.Show(
                        $"Separar {itemEvento.QuantidadeSeparada} {itemEstoque.Unidade} de '{itemEstoque.Nome}' deixará o estoque abaixo do mínimo. Deseja continuar?",
                        "Aviso de estoque baixo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (resposta == DialogResult.No) return;
                }
            }

            // 2ª passagem: aplica as baixas e atualiza status
            foreach (ItemEvento itemEvento in eventoAtual.Itens)
            {
                if (itemEvento.VeioDoEstoque && itemEvento.Item != null)
                {
                    itemEvento.Item.QuantidadeAtual -= itemEvento.QuantidadeSeparada;
                    itemEvento.Item.UltimaAtualizacao = DateTime.Now;
                }

                itemEvento.Status = "Separado";
            }

            eventoAtual.Status = "Separado";
            SalvarOuAtualizarEvento();

            btnEditarItem.Enabled = false;
            btnNovoItem.Enabled = false;
            btnRemoverItem.Enabled = false;
            btnConfirmarSeparacao.Enabled = false;

            AtualizarTabelaItens();
            MessageBox.Show("Separação confirmada com sucesso.");
        }

        private void cmbEventoSelecionadoE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEventoSelecionadoE.SelectedItem is not Evento eventoEscolhido) return;

            eventoAtual = eventoEscolhido;
            CarregarCamposDadosEvento();
            AtualizarTabelaItens();
            AtualizarResumoEvento();
        }
        private void CarregarCamposDadosEvento()
        {
            txtNomeEvento.Text = eventoAtual.Nome;
            txtLocalEvento.Text = eventoAtual.Local;
            txtResponsavelEvento.Text = eventoAtual.Responsavel;
            nudQtdPessoas.Value = eventoAtual.QuantidadePessoas;
            dtpDataEvento.Value = eventoAtual.Data == DateTime.MinValue ? DateTime.Today : eventoAtual.Data;
            cmbStatusEvento.Text = eventoAtual.Status;
        }

        private void btnLimparDadosEvento_Click(object sender, EventArgs e)
        {

            // Limpa os campos do formulário
            txtNomeEvento.Clear();
            txtLocalEvento.Clear();
            txtResponsavelEvento.Clear();
            nudQtdPessoas.Value = 0;
            dtpDataEvento.Value = DateTime.Today;
            cmbStatusEvento.SelectedIndex = 0;

            // Deseleciona o combo para não parecer que ainda está editando um evento salvo
            cmbEventoSelecionadoE.SelectedIndexChanged -= cmbEventoSelecionadoE_SelectedIndexChanged;
            cmbEventoSelecionadoE.SelectedIndex = -1;
            cmbEventoSelecionadoE.SelectedIndexChanged += cmbEventoSelecionadoE_SelectedIndexChanged;
        }

        private void btnSalvarDadosEvento_Click(object sender, EventArgs e)
        {
            SalvarDadosEvento();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarTabelaItens(
            nomeFiltro: txtFiltroNome.Text.Trim(),
            categoriaFiltro: cmbFiltroCategoria.Text,
            statusFiltro: cmbFiltroStatus.Text
            );
        }

        private void btnParaItens_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItensEvento;
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroNome.Clear();
            cmbFiltroCategoria.SelectedIndex = 0; // "Todas"
            cmbFiltroStatus.SelectedIndex = 0; // "Todos"
            AtualizarTabelaItens();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            MessageBox.Show("Dados salvos!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Hide();
            var tela = new frmEstoque();
            tela.ShowDialog();
            this.Close();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Hide();
            var tela = new frmRetorno();
            tela.ShowDialog();
            this.Close();
        }
    }
}