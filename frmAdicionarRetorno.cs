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

            // Campos somente leitura
            txtNomeExternoRetorno.Text = _item.Item?.Nome ?? "";
            txtNomeExternoRetorno.ReadOnly = true;

            txtCategoriaExternaRetorno.Text = _item.Item?.Categoria ?? "";
            txtCategoriaExternaRetorno.Enabled = false;

            txtUnidadeExternaRetorno.Text = _item.Item?.Unidade ?? "";
            txtUnidadeExternaRetorno.Enabled = false;

            lblItemEventoRetorno.Text =
                $"Separado: {_item.QuantidadeSeparada} {_item.Item?.Unidade}  |  " +
                $"Origem: {(_item.VeioDoEstoque ? "Estoque" : "Compra direta")}";

            // Único campo editável
            nudQuantidadeRetorno.Minimum = 0;
            nudQuantidadeRetorno.Maximum = _item.QuantidadeSeparada;
            nudQuantidadeRetorno.Value = _item.QuantidadeSeparada;

            // Esconde o que não é necessário
            cmbItensEstoqueRetorno.Visible = false;
            dtpValidadeRetorno.Visible = false;
            lblValidadeRetorno.Visible = false;

            btnAdicionarRetorno.Text = "Confirmar Devolução";
        }

        private void btnAdicionarRetorno_Click(object sender, EventArgs e)
        {
            if (nudQuantidadeRetorno.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.",
                    "Quantidade inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Apenas grava os dados — NÃO mexe no estoque aqui
            _item.QuantidadeRetornada = nudQuantidadeRetorno.Value;
            _item.Observacao = txtObservacaoRetorno.Text.Trim();
            _item.Status = "Retornado";
            _item.ConferidoRetorno = true;

            // REMOVIDO: o bloco if (_item.VeioDoEstoque) que somava aqui

            DialogResult = DialogResult.OK;
            Close();
        }


        private void btnLimparRetorno_Click(object sender, EventArgs e)
        {
            nudQuantidadeRetorno.Value = _item.QuantidadeSeparada;
            txtObservacaoRetorno.Clear();
        }

        private void btnCancelarRetorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}