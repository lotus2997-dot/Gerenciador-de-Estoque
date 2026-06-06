using System;
using System.Windows.Forms;
using Drink.Models;
using Drink.Dados;

namespace Drink
{
    public partial class frmAdicionarEstoque : Form
    {
        private readonly frmEstoque TLcadastro;
        private bool _modoEdicao = false;
        private Item? _itemEdicao = null;

        public frmAdicionarEstoque(frmEstoque tL)
        {
            InitializeComponent();
            TLcadastro = tL;
            CarregarComboBoxes();

            lblDataCadastroValor.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblUltimaAtualizacaoValor.Text = "-";
            lblStatusItemValor.Text = "-";
        }

        private void CarregarComboBoxes()
        {
            ComboBoxHelper.Preencher(cmbCategoria, CatalogosSistema.Categorias);
            ComboBoxHelper.Preencher(cmbUnidade, CatalogosSistema.Unidades);
        }

        public void CarregarItemParaEdicao(Item item)
        {
            _modoEdicao = true;
            _itemEdicao = item;

            txtNome.Text = item.Nome ?? "";
            cmbCategoria.Text = item.Categoria ?? "";
            nudQuantidadeAtual.Value = item.QuantidadeAtual;
            cmbUnidade.Text = item.Unidade ?? "";
            dtpValidade.Value = item.Validade ?? DateTime.Today;
            nudQuantidadeMinima.Value = item.QuantidadeMinima;
            txtObservacao.Text = item.Observacao ?? "";

            lblDataCadastroValor.Text = item.UltimaAtualizacao?.ToString("dd/MM/yyyy") ?? "-";
            lblUltimaAtualizacaoValor.Text = item.UltimaAtualizacao?.ToString("dd/MM/yyyy HH:mm") ?? "-";
            lblStatusItemValor.Text = item.Status ?? "-";

            btnSalvar.Text = "Salvar Alterações";
            this.Text = "Editar Item";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(cmbCategoria.Text) ||
                string.IsNullOrWhiteSpace(cmbUnidade.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.",
                    "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_modoEdicao && _itemEdicao != null)
            {
                _itemEdicao.Nome = txtNome.Text.Trim();
                _itemEdicao.Categoria = cmbCategoria.Text.Trim();
                _itemEdicao.QuantidadeAtual = nudQuantidadeAtual.Value;
                _itemEdicao.Unidade = cmbUnidade.Text.Trim();
                _itemEdicao.Validade = dtpValidade.Value;
                _itemEdicao.QuantidadeMinima = nudQuantidadeMinima.Value;
                _itemEdicao.Observacao = txtObservacao.Text.Trim();
                _itemEdicao.UltimaAtualizacao = DateTime.Now;

                TLcadastro.AtualizarDados();
                MessageBox.Show("Item atualizado com sucesso!");
                this.Close();
                return;
            }

            Item novoItem = new Item
            {
                Id = GerarId(),
                Nome = txtNome.Text.Trim(),
                Categoria = cmbCategoria.Text.Trim(),
                QuantidadeAtual = nudQuantidadeAtual.Value,
                Unidade = cmbUnidade.Text.Trim(),
                Validade = dtpValidade.Value,
                QuantidadeMinima = nudQuantidadeMinima.Value,
                Observacao = txtObservacao.Text.Trim(),
                Ativo = true,
                UltimaAtualizacao = DateTime.Now
            };

            DadosTemporarios.Itens.Add(novoItem);
            TLcadastro.AtualizarDados();
            MessageBox.Show("Item adicionado com sucesso!");
            this.Close();
        }

        private int GerarId()
        {
            return DadosTemporarios.Itens.Any()
                ? DadosTemporarios.Itens.Max(i => i.Id) + 1
                : 1001;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            cmbCategoria.SelectedIndex = -1;
            nudQuantidadeAtual.Value = 0;
            cmbUnidade.SelectedIndex = -1;
            dtpValidade.Value = DateTime.Today;
            nudQuantidadeMinima.Value = 0;
            txtObservacao.Clear();
            txtFornecedor.Clear();
        }
    }
}