using System;
using System.Linq;
using System.Windows.Forms;
using Drink.Models;
using Drink.Dados;

namespace Drink
{
    public partial class frmRetorno : Form
    {
        public frmRetorno()
        {
            InitializeComponent();
            CarregarEventos();

            if (cmbEventoSelecionado.Items.Count > 0)
            {
                cmbEventoSelecionado.SelectedIndex = 0;
                CarregarDadosDoEventoSelecionado();
            }
        }
        private void CarregarEventos()
        {
            cmbEventoSelecionado.DataSource = DadosTemporarios.Eventos
                .Where(e => e.Status == "Separado" || e.Status == "Retorno em conferência")
                .ToList();

            cmbEventoSelecionado.DisplayMember = "Nome";
            cmbEventoSelecionado.ValueMember = "Id";
        }
        private void cmbEventoSelecionado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CarregarDadosDoEventoSelecionado();

            if (cmbEventoSelecionado.SelectedItem is Evento eventoDoRetorno)
            {
                dgvRetorno.DataSource = eventoDoRetorno.Itens.Select(itemEvento => new
                {
                    Nome = itemEvento.Item?.Nome ?? "Item sem nome",
                    itemEvento.QuantidadeSeparada,
                    itemEvento.QuantidadeRetornada,
                    itemEvento.QuantidadeConsumida,
                    itemEvento.Status,
                    itemEvento.Observacao
                }).ToList();

                lblEventoValor.Text = eventoDoRetorno.Nome;
                lblDataValor.Text = eventoDoRetorno.Data.ToString("dd/MM/yyyy");
                lblResponsavelValor.Text = eventoDoRetorno.Responsavel;
            }
        }
        private void CarregarDadosDoEventoSelecionado()
        {
            if (cmbEventoSelecionado.SelectedItem is Evento eventoDoRetorno)
            {
                dgvRetorno.DataSource = null;
                dgvRetorno.DataSource = eventoDoRetorno.Itens.Select(itemEvento => new
                {
                    Nome = itemEvento.Item?.Nome ?? "",
                    itemEvento.QuantidadeSeparada,
                    itemEvento.QuantidadeRetornada,
                    itemEvento.QuantidadeConsumida,
                    itemEvento.Status,
                    itemEvento.Observacao
                }).ToList();

                lblEventoValor.Text = eventoDoRetorno.Nome;
                lblDataValor.Text = eventoDoRetorno.Data.ToString("dd/MM/yyyy");
                lblResponsavelValor.Text = eventoDoRetorno.Responsavel;
            }
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            if (cmbEventoSelecionado.SelectedItem is Evento eventoDoRetorno)
            {
                frmAdicionarRetorno tela = new frmAdicionarRetorno(eventoDoRetorno);
                tela.ShowDialog();
                CarregarDadosDoEventoSelecionado();
            }
            else
            {
                MessageBox.Show("Selecione um evento antes de adicionar itens.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}