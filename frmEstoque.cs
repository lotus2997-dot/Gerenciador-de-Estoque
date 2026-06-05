using Drink.Dados;
using Drink.Models;
using System;
using System.Diagnostics;
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
        private void ConfigurarAparenciaTabela()
        {
            // Define a fonte geral da tabela.
            dgvEstoque.Font = new Font("Segoe UI", 10);

            // Define a altura das linhas.
            dgvEstoque.RowTemplate.Height = 32;

            // Cores do cabeçalho.
            dgvEstoque.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 102);
            dgvEstoque.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEstoque.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvEstoque.ColumnHeadersHeight = 35;

            // Cor de seleção.
            dgvEstoque.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvEstoque.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void ColorirStatus()
        {
            foreach (DataGridViewRow row in dgvEstoque.Rows)
            {
                if (row.IsNewRow) continue;

                string status = row.Cells["colStatus"].Value?.ToString() ?? "";

                DataGridViewCell celulaStatus = row.Cells["colStatus"];

                // Reseta o estilo antes de aplicar uma nova cor
                celulaStatus.Style.ForeColor = Color.Black;
                celulaStatus.Style.Font = new Font(dgvEstoque.Font, FontStyle.Regular);

                if (status == "Normal")
                {
                    celulaStatus.Style.ForeColor = Color.Green;
                }
                else if (status == "Sem estoque")
                {
                    celulaStatus.Style.ForeColor = Color.DarkOrange;
                    celulaStatus.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold);
                }
                else if (status == "Vencendo")
                {
                    celulaStatus.Style.ForeColor = Color.Blue;
                    celulaStatus.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold);
                }
                else if (status == "Abaixo do mínimo")
                {
                    celulaStatus.Style.ForeColor = Color.Purple;
                    celulaStatus.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold);
                }
                else if (status == "Vencido")
                {
                    celulaStatus.Style.ForeColor = Color.Red;
                    celulaStatus.Style.Font = new Font(dgvEstoque.Font, FontStyle.Bold);
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
        private void AtualizarResumo()
        {
            var itens = DadosTemporarios.Itens;

            lblMinimoValor.Text = itens.Count(i => i.Status == "Abaixo do mínimo").ToString();
            lblVencendoValor.Text = itens.Count(i => i.Status == "Vencendo" || i.Status == "Vencido").ToString();
        }

        private Item? ObterItemSelecionado()
        {
            if (dgvEstoque.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvEstoque.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells["colId"].Value);
                return DadosTemporarios.Itens.FirstOrDefault(i => i.Id == id);
            }
            return null;
        }
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            frmAdicionarEstoque telaCadastro = new frmAdicionarEstoque(this);
            telaCadastro.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Item? item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show("Selecione um item para remover.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja remover este item definitivamente?",
                "Confirmar remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
                return;

            DadosTemporarios.Itens.Remove(item);
            AtualizarDados();
            MessageBox.Show("Item removido com sucesso.");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Item? item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show("Selecione um item para editar.");
                return;
            }

            frmAdicionarEstoque telaCadastro = new frmAdicionarEstoque(this);
            telaCadastro.CarregarItemParaEdicao(item);
            telaCadastro.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtroNome = txtFiltroNome.Text.Trim().ToLower();
            var filtroCategoria = cmbFiltroCategoria.Text;
            var filtroStatus = cmbFiltroStatus.Text;

            var itensFiltrados = DadosTemporarios.Itens.Where(item =>
                (string.IsNullOrWhiteSpace(filtroNome) || (item.Nome ?? "").ToLower().Contains(filtroNome)) &&
                (filtroCategoria == "Todas" || item.Categoria == filtroCategoria) &&
                (filtroStatus == "Todos" || item.Status == filtroStatus)
            ).ToList();

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
    }
}
