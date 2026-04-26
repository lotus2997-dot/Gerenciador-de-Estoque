using Drink.Models;
using System;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;


namespace Drink
{
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
            CarregarCombo();
            CarregarUnidades();
            CarregarTabela();
        }

        private void CarregarCombo()
        {
            cmbIngrediente.Items.Clear();
            foreach (var item in DadosApp.Ingredientes)
                cmbIngrediente.Items.Add(item.Nome);
            if (cmbIngrediente.Items.Count > 0)
                cmbIngrediente.SelectedIndex = 0;
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
            dgvEvento.DataSource = null;
            dgvEvento.DataSource = DadosApp.ItensEvento.ToList();
            if (dgvEvento.Columns["QuantidadeMinima"] != null)
                dgvEvento.Columns["QuantidadeMinima"].Visible = false;
            if (dgvEvento.Columns["Validade"] != null)
                dgvEvento.Columns["Validade"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private int GetProximoId()
        {
            return DadosApp.ItensEvento.Count > 0 ? DadosApp.ItensEvento.Max(i => i.Id) + 1 : 1;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text)) { MessageBox.Show("Digite o nome do ingrediente."); return; }
            if (nudQuantidade.Value <= 0) { MessageBox.Show("Informe uma quantidade maior que zero."); return; }

            var nome = txtNome.Text.Trim();
            var existente = DadosApp.ItensEvento.Find(i => i.Nome == nome);

            if (existente != null)
                existente.QuantidadeAtual += nudQuantidade.Value;
            else
                DadosApp.ItensEvento.Add(new Ingrediente
                {
                    Id = GetProximoId(),
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvEvento.SelectedRows.Count == 0) { MessageBox.Show("Selecione um item para remover."); return; }
            var id = (int)dgvEvento.SelectedRows[0].Cells["Id"].Value;
            DadosApp.ItensEvento.RemoveAll(i => i.Id == id);
            CarregarTabela();
        }

        private void btnRetirarEstoque_Click(object sender, EventArgs e)
        {
            if (cmbIngrediente.SelectedItem == null) { MessageBox.Show("Selecione um ingrediente."); return; }
            if (nudQuantidade.Value <= 0) { MessageBox.Show("Informe uma quantidade maior que zero."); return; }

            var nome = cmbIngrediente.SelectedItem.ToString();
            var estoqueItem = DadosApp.Ingredientes.Find(i => i.Nome == nome);

            if (estoqueItem == null) { MessageBox.Show("Ingrediente não encontrado no estoque."); return; }
            if (estoqueItem.QuantidadeAtual < nudQuantidade.Value) { MessageBox.Show($"Estoque insuficiente! Disponível: {estoqueItem.QuantidadeAtual}"); return; }

            estoqueItem.QuantidadeAtual -= nudQuantidade.Value;

            var existente = DadosApp.ItensEvento.Find(i => i.Nome == nome);
            if (existente != null)
                existente.QuantidadeAtual += nudQuantidade.Value;
            else
                DadosApp.ItensEvento.Add(new Ingrediente
                {
                    Id = GetProximoId(),
                    Nome = nome,
                    Unidade = estoqueItem.Unidade,
                    QuantidadeAtual = nudQuantidade.Value,
                    Validade = estoqueItem.Validade
                });

            CarregarTabela();
            nudQuantidade.Value = 0;
            MessageBox.Show($"Retirado do estoque para o evento!");
        }

        private void btnTransferirRetorno_Click(object sender, EventArgs e)
        {
            if (dgvEvento.SelectedRows.Count == 0) { MessageBox.Show("Selecione um item para transferir."); return; }
            if (nudQuantidade.Value <= 0) { MessageBox.Show("Informe uma quantidade a transferir."); return; }

            var id = (int)dgvEvento.SelectedRows[0].Cells["Id"].Value;
            var item = DadosApp.ItensEvento.Find(i => i.Id == id);

            if (item == null) return;

            if (nudQuantidade.Value > item.QuantidadeAtual)
            {
                MessageBox.Show($"Quantidade insuficiente no evento! Disponível: {item.QuantidadeAtual}");
                return;
            }

            item.QuantidadeAtual -= nudQuantidade.Value;
            if (item.QuantidadeAtual == 0)
                DadosApp.ItensEvento.RemoveAll(i => i.Id == id);

            var existente = DadosApp.ItensRetorno.Find(i => i.Nome == item.Nome);
            if (existente != null)
                existente.QuantidadeAtual += nudQuantidade.Value;
            else
                DadosApp.ItensRetorno.Add(new Ingrediente
                {
                    Id = DadosApp.ItensRetorno.Count + 1,
                    Nome = item.Nome,
                    Unidade = item.Unidade,
                    QuantidadeAtual = nudQuantidade.Value,
                    Validade = item.Validade
                });

            CarregarTabela();
            nudQuantidade.Value = 0;
            MessageBox.Show($"Transferido para o Retorno!");
        }

        private void dgvEvento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void frmEventos_Load(object sender, EventArgs e)
        {
            

           
        }
    }
}