using Drink.Dados;
using Drink.Models;
using System;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmAdicionarRetorno : Form
    {
        private readonly Evento _evento;
        private readonly ItemEvento _item;

        public frmAdicionarRetorno(Evento evento, ItemEvento item)
        {
            InitializeComponent();
            _evento = evento;
            _item = item;
        }

        private void frmAdicionarRetorno_Load(object sender, EventArgs e)
        {
            this.Text = "Devolver ao Estoque";

            txtNomeExternoRetorno.Text = _item.Item?.Nome ?? "";
            txtNomeExternoRetorno.ReadOnly = true;

            txtCategoriaExternaRetorno.Text = _item.Item?.Categoria ?? "";
            txtCategoriaExternaRetorno.Enabled = false;

            txtUnidadeExternaRetorno.Text = _item.Item?.Unidade ?? "";
            txtUnidadeExternaRetorno.Enabled = false;

            lblItemEventoRetorno.Text =
                $"Separado: {_item.QuantidadeSeparada} {_item.Item?.Unidade}  |  " +
                $"Origem: {(_item.VeioDoEstoque ? "Estoque" : "Compra direta")}";
            nudQuantidadeRetorno.Maximum = _item.QuantidadeSeparada;
            nudQuantidadeRetorno.Value = _item.QuantidadeSeparada;

            nudQuantidadeDevolvida.Minimum = 0;
            nudQuantidadeDevolvida.Maximum = _item.QuantidadeSeparada;
            nudQuantidadeDevolvida.Value = _item.QuantidadeSeparada;

            cmbItensEstoqueRetorno.Visible = false;
            dtpValidadeRetorno.Visible = false;
            lblValidadeRetorno.Visible = false;

            btnAdicionarRetorno.Text = "Confirmar Devolução";
        }

        private void btnAdicionarRetorno_Click(object sender, EventArgs e)
        {
            decimal quantidadeInformada = nudQuantidadeDevolvida.Value;

            if (quantidadeInformada <= 0)
            {
                var resposta = MessageBox.Show(
                    "Este item foi totalmente consumido? Nenhuma unidade voltará ao estoque.",
                    "Item totalmente consumido",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resposta == DialogResult.No)
                    return;

                _item.QuantidadeRetornada = 0;
                _item.Observacao = txtObservacaoRetorno.Text.Trim();
                _item.Status = "Retornado";
                _item.ConferidoRetorno = true;

                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            _item.QuantidadeRetornada = quantidadeInformada;
            _item.Observacao = txtObservacaoRetorno.Text.Trim();
            _item.Status = "Retornado";
            _item.ConferidoRetorno = true;
            if (_item.VeioDoEstoque && _item.Item != null)
            {
                _item.Item.QuantidadeAtual += _item.QuantidadeRetornada;
                _item.Item.UltimaAtualizacao = DateTime.Now;
            }
            else if (!_item.VeioDoEstoque && _item.Item != null && _item.QuantidadeRetornada > 0)
            {
                AdicionarItemExternoAoEstoque(_item.Item, _item.QuantidadeRetornada);
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AdicionarItemExternoAoEstoque(Item itemExterno, decimal quantidadeRetornada)
        {
            // Verifica se já existe no estoque pelo nome e unidade
            var existente = DadosTemporarios.Itens.Find(i =>
                i.Ativo &&
                string.Equals(i.Nome, itemExterno.Nome, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(i.Unidade, itemExterno.Unidade, StringComparison.OrdinalIgnoreCase));

            if (existente != null)
            {
                // se ja existe, apenas soma a quantidade retornada
                existente.QuantidadeAtual += quantidadeRetornada;
                existente.UltimaAtualizacao = DateTime.Now;

                MessageBox.Show(
                    $"O item '{existente.Nome}' já existe no estoque.\n" +
                    $"Quantidade somada: +{quantidadeRetornada} {existente.Unidade}\n" +
                    $"Novo total: {existente.QuantidadeAtual} {existente.Unidade}",
                    "Estoque atualizado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                // se não existe, cria novo item no estoque
                int novoId = DadosTemporarios.Itens.Count > 0
                    ? DadosTemporarios.Itens.Max(i => i.Id) + 1
                    : 1001;

                var novoItem = new Item
                {
                    Id = novoId,
                    Nome = itemExterno.Nome,
                    Categoria = itemExterno.Categoria,
                    Unidade = itemExterno.Unidade,
                    QuantidadeAtual = quantidadeRetornada,
                    QuantidadeMinima = 0,
                    Observacao = $"Entrada via retorno do evento: {_evento.Nome}",
                    DataCadastro = DateTime.Now,
                    UltimaAtualizacao = DateTime.Now,
                    Ativo = true
                };

                DadosTemporarios.Itens.Add(novoItem);

                MessageBox.Show(
                    $"O item externo '{novoItem.Nome}' foi adicionado ao estoque\n" +
                    $"com {quantidadeRetornada} {novoItem.Unidade}.",
                    "Item adicionado ao estoque",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnLimparRetorno_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Isso vai redefinir a quantidade para o valor separado. Deseja continuar?",
                    "Limpar campos",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            nudQuantidadeRetorno.Value = _item.QuantidadeSeparada;
            nudQuantidadeDevolvida.Value = _item.QuantidadeSeparada;
            txtObservacaoRetorno.Clear();
        }

        private void btnCancelarRetorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
