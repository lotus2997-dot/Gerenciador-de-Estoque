using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Drink.Models;

namespace Drink
{
    public partial class frmEstoque : Form
    {

        private int proximoId = 4;

        public frmEstoque()
        {
            InitializeComponent();
            CarregarTabela();
            CarregarCategorias();
        }

        private void CarregarTabela()
        {
            dgvEstoque.DataSource = null;
            dgvEstoque.DataSource = DadosApp.Ingredientes.ToList();

            if (dgvEstoque.Columns["QuantidadeMinima"] != null)
                dgvEstoque.Columns["QuantidadeMinima"].Visible = false;

            if (dgvEstoque.Columns["Validade"] != null)
            {
                dgvEstoque.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void CarregarCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Destilado");
            cmbCategoria.Items.Add("Suco");
            cmbCategoria.Items.Add("Xarope");
            cmbCategoria.Items.Add("Fruta");
            cmbCategoria.Items.Add("Outro");
            cmbCategoria.SelectedIndex = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencha o nome do ingrediente.");
                return;
            }

            var novo = new Ingrediente
            {
                Id = proximoId++,
                Nome = txtNome.Text,
                Unidade = cmbCategoria.SelectedItem.ToString(),
                QuantidadeAtual = nudQuantidade.Value,
                QuantidadeMinima = 0,
                Validade = dtpValidade.Value
            };

            DadosApp.Ingredientes.Add(novo);
            CarregarTabela();
            LimparCampos();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            var id = (int)dgvEstoque.SelectedRows[0].Cells["Id"].Value;
            DadosApp.Ingredientes.RemoveAll(i => i.Id == id);
            CarregarTabela();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um item para atualizar.");
                return;
            }

            var id = (int)dgvEstoque.SelectedRows[0].Cells["Id"].Value;
            var item = DadosApp.Ingredientes.Find(i => i.Id == id);

            if (item != null)
            {
                item.Nome = txtNome.Text;
                item.Unidade = cmbCategoria.SelectedItem.ToString();
                item.QuantidadeAtual = nudQuantidade.Value;
                item.Validade = dtpValidade.Value;
                CarregarTabela();
                LimparCampos();
            }
        }

        private void dgvEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvEstoque.Rows[e.RowIndex];
                txtNome.Text = row.Cells["Nome"].Value?.ToString();
                cmbCategoria.SelectedItem = row.Cells["Unidade"].Value?.ToString();
                nudQuantidade.Value = Convert.ToDecimal(row.Cells["QuantidadeAtual"].Value);
                dtpValidade.Value = Convert.ToDateTime(row.Cells["Validade"].Value);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cmbCategoria.SelectedIndex = 0;
            nudQuantidade.Value = 0;
            dtpValidade.Value = DateTime.Now;
        }

        private void dgvEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}