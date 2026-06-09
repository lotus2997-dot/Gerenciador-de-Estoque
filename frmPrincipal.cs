using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Drink.Dados;

namespace Drink
{
    public partial class frmPrincipal : Form
    {
        private string _usuarioLogado = "";

        public frmPrincipal(string usuarioDoLogin)
        {
            InitializeComponent();
            _usuarioLogado = usuarioDoLogin;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            JsonHelper.Carregar();
            AtualizarDashboard();
        }

        public void AtualizarDashboard()
        {
            lblTotalEstoque.Text = DadosTemporarios.Itens.Count.ToString();

            int eventosAtivos = DadosTemporarios.Eventos
                .Count(ev => ev.Status == "Separado" || ev.Status == "Em andamento");
            lblEventosAtivos.Text = eventosAtivos.ToString();

            int itensRetorno = DadosTemporarios.Eventos
                .SelectMany(ev => ev.Itens)
                .Count(i => i.Status == "Separado" && i.QuantidadeRetornada == 0);
            lblItensRetorno.Text = itensRetorno.ToString();

            int alertas = DadosTemporarios.Itens
                .Count(i => i.QuantidadeAtual <= i.QuantidadeMinima);
            lblAlertas.Text = alertas.ToString();

            var proximoEvento = DadosTemporarios.Eventos
                .Where(ev => ev.Data >= DateTime.Today)
                .OrderBy(ev => ev.Data)
                .FirstOrDefault();

            if (proximoEvento != null)
            {
                lblNomeProximoEvento.Text = proximoEvento.Nome;
                lblDataProximoEvento.Text = "Data: " + proximoEvento.Data.ToString("dd/MM/yyyy");
                lblLocalProximoEvento.Text = "Local: " + proximoEvento.Local;
                lblItensProximoEvento.Text = "Itens reservados: " + proximoEvento.Itens.Count;
            }
            else
            {
                lblNomeProximoEvento.Text = "Nenhum evento agendado";
                lblDataProximoEvento.Text = "";
                lblLocalProximoEvento.Text = "";
                lblItensProximoEvento.Text = "";
            }

            lstMovimentacoes.Items.Clear();
            foreach (var ev in DadosTemporarios.Eventos.OrderByDescending(ev => ev.Data).Take(20))
                lstMovimentacoes.Items.Add(
                    $"{ev.Data:dd/MM/yyyy}  |  {ev.Nome}  |  {ev.Local}  |  Status: {ev.Status}");
        }


        private void MarcarBotaoSelecionado(Button botaoSelecionado)
        {
            Color corPadrao = Color.FromArgb(20, 59, 102);
            Color corSelecionada = Color.FromArgb(30, 100, 170);

            btnEstoque.BackColor = corPadrao;
            btnEventos.BackColor = corPadrao;
            btnRetorno.BackColor = corPadrao;
            btnConfiguracao.BackColor = corPadrao;

            botaoSelecionado.BackColor = corSelecionada;
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // ── Abre telas e atualiza ao fechar ──────────────────

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnEstoque);
            using var tela = new frmEstoque();
            tela.ShowDialog();
            JsonHelper.Salvar();
            AtualizarDashboard();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnEventos);
            using var tela = new frmEventos();
            tela.ShowDialog();
            JsonHelper.Salvar();
            AtualizarDashboard();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnRetorno);
            using var tela = new frmRetorno();
            tela.ShowDialog();
            JsonHelper.Salvar();
            AtualizarDashboard();
        }

        private void btnConfiguracao_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnConfiguracao);
            using var tela = new frmCadastrosAuxiliares();
            tela.ShowDialog();
            JsonHelper.Salvar();
            AtualizarDashboard();
        }

        private void btnVerEvento_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnEventos);
            using var tela = new frmEventos();
            tela.ShowDialog();
            JsonHelper.Salvar();
            AtualizarDashboard();

        }
    }
}
