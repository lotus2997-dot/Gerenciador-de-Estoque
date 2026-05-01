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

            ConfigurarAparenciaTabela();
            CarregarDadosExemplo();
        }

        private void ConfigurarAparenciaTabela()
        {
            // Define a fonte geral da tabela.
            dgvItensEvento.Font = new Font("Segoe UI", 10);

            // Define a altura das linhas.
            dgvItensEvento.RowTemplate.Height = 32;

            // Remove a borda 3D padrão para deixar mais limpo.
            dgvItensEvento.BorderStyle = BorderStyle.FixedSingle;

            // Faz a linha inteira ser selecionada.
            dgvItensEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Impede edição direta na tabela.
            dgvItensEvento.ReadOnly = true;

            // Impede o usuário de adicionar linhas manualmente.
            dgvItensEvento.AllowUserToAddRows = false;

            // Remove a coluna lateral cinza.
            dgvItensEvento.RowHeadersVisible = false;

            // Ajusta as colunas automaticamente.
            dgvItensEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Cores do cabeçalho.
            dgvItensEvento.EnableHeadersVisualStyles = false;
            dgvItensEvento.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 59, 102);
            dgvItensEvento.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvItensEvento.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvItensEvento.ColumnHeadersHeight = 35;

            // Cor de seleção.
            dgvItensEvento.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 230, 250);
            dgvItensEvento.DefaultCellStyle.SelectionForeColor = Color.Black;
        }
        private void CarregarDadosExemplo()
        {
            dgvItensEvento.Rows.Clear();

            dgvItensEvento.Rows.Add("001", "Gelo", "Bebidas", "20,00", "28/04/2026", "Separado", "OK");
            dgvItensEvento.Rows.Add("002", "Limão", "Frutas", "5,00", "29/04/2026", "Separado", "OK");
            dgvItensEvento.Rows.Add("003", "Vodka", "Bebidas", "3,00", "28/04/2026", "Separado", "Conferido");
            dgvItensEvento.Rows.Add("004", "Whisky", "Bebidas", "2,00", "28/04/2026", "Separado", "OK");
            dgvItensEvento.Rows.Add("005", "Refrigerante Cola", "Bebidas", "10,00", "30/04/2026", "Pendente", "Aguardando");
            dgvItensEvento.Rows.Add("006", "Água Mineral", "Bebidas", "15,00", "30/04/2026", "Pendente", "OK");
            dgvItensEvento.Rows.Add("007", "Taças de Vidro", "Utensílios", "50,00", "-", "Disponível", "Limpar antes do uso");

            ColorirStatus();
        }

        // Este método percorre todas as linhas do DataGridView de itens do evento.
        // Para cada linha, ele lê o valor da coluna "colStatus".
        // Dependendo do status encontrado, ele muda a cor do texto dessa célula.
        private void ColorirStatus()
        {
            foreach (DataGridViewRow row in dgvItensEvento.Rows)
            {
                string status = row.Cells["colStatus"].Value?.ToString() ?? "";

                if (status == "Separado")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Green;
                }
                else if (status == "Pendente")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.DarkOrange;
                }
                else if (status == "Disponível")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Blue;
                }
                else if (status == "Retornado")
                {
                    row.Cells["colStatus"].Style.ForeColor = Color.Purple;
                }
            }
        }
    }
}