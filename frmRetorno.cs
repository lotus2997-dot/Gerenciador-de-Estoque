using System;
using System.Linq;
using System.Windows.Forms;
using Drink.Models;

namespace Drink
{
    public partial class frmRetorno : Form
    {
        public frmRetorno()
        {
            InitializeComponent();
            CarregarCombo();
            CarregarUnidades();
            CarregarTabela();
        }

        private void CarregarCombo()
        {

        }
        private void CarregarUnidades()
        {
            cmbUnidade.Items.Clear();
            cmbUnidade.Items.Add("Destilado");
            cmbUnidade.Items.Add("Suco");
            cmbUnidade.Items.Add("Xarope");
            cmbUnidade.Items.Add("Fruta");
            cmbUnidade.Items.Add("Outro");
            cmbUnidade.SelectedIndex = 0;
        }

        private void CarregarTabela()
        {
            dgvRetorno.DataSource = null;
            dgvRetorno.DataSource = DadosApp.ItensRetorno.ToList();
            if (dgvRetorno.Columns["QuantidadeMinima"] != null)
                dgvRetorno.Columns["QuantidadeMinima"].Visible = false;
            if (dgvRetorno.Columns["Validade"] != null)
                dgvRetorno.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        // Adiciona item novo sem precisar estar no estoque
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) { MessageBox.Show("Digite o nome do ingrediente."); return; }
            if (nudQuantidade.Value <= 0) { MessageBox.Show("Informe uma quantidade maior que zero."); return; }

            var nome = txtNome.Text.Trim();
            var existente = DadosApp.ItensRetorno.Find(i => i.Nome == nome);

            if (existente != null)
                existente.QuantidadeAtual += nudQuantidade.Value;
            else
                DadosApp.ItensRetorno.Add(new Item
                {
                    Id = DadosApp.ItensRetorno.Count > 0?DadosApp.ItensRetorno.Max(i => i.Id) + 1: 1,
                    Nome = nome,
                    Unidade = cmbUnidade.SelectedItem.ToString().Trim(),
                    QuantidadeAtual = nudQuantidade.Value,
                    QuantidadeMinima = 0,
                    Validade = dtpValidade.Value
                });

            CarregarTabela();
            txtNome.Text = "";
            cmbUnidade.SelectedIndex = 0;
            nudQuantidade.Value = 0;
            dtpValidade.Value = DateTime.Now;
        }

        // Remove item do retorno
        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvRetorno.SelectedRows.Count == 0) { MessageBox.Show("Selecione um item para remover."); return; }
            var id = (int)dgvRetorno.SelectedRows[0].Cells["Id"].Value;
            DadosApp.ItensRetorno.RemoveAll(i => i.Id == id);
            CarregarTabela();
        }

        // Confirma devolução de quantidade específica ao estoque
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvRetorno.SelectedRows.Count == 0) { MessageBox.Show("Selecione um item para devolver ao estoque."); return; }
            if (nudQuantidade.Value <= 0) { MessageBox.Show("Informe uma quantidade a devolver."); return; }

            var id = (int)dgvRetorno.SelectedRows[0].Cells["Id"].Value;
            var item = DadosApp.ItensRetorno.Find(i => i.Id == id);

            if (item == null) return;

            if (nudQuantidade.Value > item.QuantidadeAtual)
            {
                MessageBox.Show($"Quantidade insuficiente no retorno! Disponível: {item.QuantidadeAtual}");
                return;
            }

            // Reduz do retorno
            item.QuantidadeAtual -= nudQuantidade.Value;
            if (item.QuantidadeAtual == 0)
                DadosApp.ItensRetorno.RemoveAll(i => i.Id == id);

            // Devolve ao estoque
            var ingrediente = DadosApp.Ingredientes.Find(i => i.Nome == item.Nome);
            if (ingrediente != null)
                ingrediente.QuantidadeAtual += nudQuantidade.Value;
            else
                DadosApp.Ingredientes.Add(new Item
                {
                    Id = DadosApp.Ingredientes.Count + 1,
                    Nome = item.Nome,
                    Unidade = item.Unidade,
                    QuantidadeAtual = nudQuantidade.Value,
                    QuantidadeMinima = 0
                });

            CarregarTabela();
            nudQuantidade.Value = 0;
            MessageBox.Show("Devolvido ao estoque!");
        }
    }
}