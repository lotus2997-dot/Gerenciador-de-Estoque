using Drink.Dados;
using Drink.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
            ConfigurarAparenciaTabela();
            CarregarCombosFiltro();
            AtualizarDados();
        }

        public void AtualizarDados()
        {
            AtualizarTabelaEstoque(DadosTemporarios.Itens.Where(i => i.Ativo));
            AtualizarResumo();
            ColorirStatus();
        }

        private void AtualizarResumo()
        {
            var itens = DadosTemporarios.Itens.Where(i => i.Ativo).ToList();

            lblItensCadastrados.Text = itens.Count.ToString();
            lblMinimoValor.Text = itens.Count(i => i.Status == "Abaixo do mínimo").ToString();
            lblVencendoValor.Text = itens.Count(i => i.Status == "Vencendo" || i.Status == "Vencido").ToString();
        }

        private void ConfigurarAparenciaTabela()
        {
            dgvEstoque.Font = new Font("Segoe UI", 10);
            dgvEstoque.RowTemplate.Height = 32;
            dgvEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 102);
            dgvEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEstoque.ColumnHeadersHeight = 35;
            dgvEstoque.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvEstoque.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void AtualizarTabelaEstoque(IEnumerable<Item> itens)
        {
            dgvEstoque.Rows.Clear();
            foreach (var item in itens)
            {
                dgvEstoque.Rows.Add(
                    item.Id,
                    item.Nome,
                    item.Categoria,
                    item.QuantidadeAtual,
                    item.Unidade,
                    item.Validade.HasValue ? item.Validade.Value.ToString("dd/MM/yyyy") : "",
                    item.QuantidadeMinima,
                    item.Status,
                    item.Observacao
                );
            }
        }

        private void ColorirStatus()
        {
            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";
                var celula = row.Cells["colStatus"];

                celula.Style.ForeColor = Color.Black;
                celula.Style.Font = new Font(dgvEstoque.Font, FontStyle.Regular);

                switch (status)
                {
                    case "Normal": celula.Style.ForeColor = Color.Green; break;
                    case "Sem estoque": celula.Style.ForeColor = Color.DarkOrange; celula.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold); break;
                    case "Vencendo": celula.Style.ForeColor = Color.Blue; celula.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold); break;
                    case "Abaixo do mínimo": celula.Style.ForeColor = Color.Purple; celula.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold); break;
                    case "Vencido": celula.Style.ForeColor = Color.Red; celula.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold); break;
                }
            }
        }

        private void CarregarCombosFiltro()
        {
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.Add("Todas");
            foreach (var categoria in CatalogosSistema.Categorias)
                cmbFiltroCategoria.Items.Add(categoria);
            cmbFiltroCategoria.SelectedIndex = 0;

            cmbFiltroStatus.Items.Clear();
            cmbFiltroStatus.Items.Add("Todos");
            cmbFiltroStatus.Items.Add("Normal");
            cmbFiltroStatus.Items.Add("Sem estoque");
            cmbFiltroStatus.Items.Add("Vencendo");
            cmbFiltroStatus.Items.Add("Abaixo do mínimo");
            cmbFiltroStatus.Items.Add("Vencido");
            cmbFiltroStatus.SelectedIndex = 0;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtroNome = txtFiltroNome.Text.Trim().ToLower();
            var filtroCategoria = cmbFiltroCategoria.Text;
            var filtroStatus = cmbFiltroStatus.Text;

            var itensFiltrados = DadosTemporarios.Itens.Where(item =>
                item.Ativo &&
                (string.IsNullOrWhiteSpace(filtroNome) || (item.Nome ?? "").ToLower().Contains(filtroNome)) &&
                (filtroCategoria == "Todas" || item.Categoria == filtroCategoria) &&
                (filtroStatus == "Todos" || item.Status == filtroStatus)
            );

            AtualizarTabelaEstoque(itensFiltrados);
            ColorirStatus();
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroNome.Clear();
            cmbFiltroCategoria.SelectedIndex = 0;
            cmbFiltroStatus.SelectedIndex = 0;
            AtualizarDados();
        }

        private Item? ObterItemSelecionado()
        {
            if (dgvEstoque.SelectedRows.Count == 0) return null;
            int id = Convert.ToInt32(dgvEstoque.SelectedRows[0].Cells["colId"].Value);
            return DadosTemporarios.Itens.FirstOrDefault(i => i.Id == id);
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            new frmAdicionarEstoque(this).ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Item? item = ObterItemSelecionado();
            if (item == null) { MessageBox.Show("Selecione um item para editar."); return; }
            var tela = new frmAdicionarEstoque(this);
            tela.CarregarItemParaEdicao(item);
            tela.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Item? item = ObterItemSelecionado();
            if (item == null) { MessageBox.Show("Selecione um item para remover."); return; }

            var resposta = MessageBox.Show(
                "Tem certeza que deseja remover este item definitivamente?",
                "Confirmar remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

            DadosTemporarios.Itens.Remove(item);
            AtualizarDados();
            MessageBox.Show("Item removido com sucesso.");
        }

        private void btnSalvarItemEstoque_Click(object sender, EventArgs e)
        {
        
            JsonHelper.Salvar();
            MessageBox.Show("Dados salvos!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Tag = "Retorno"; 
            this.Close();
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Tag = "Eventos"; 
            this.Close();
        }
    }
}