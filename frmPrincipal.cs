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
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!e.Cancel)
            {
                // Salva os dados sempre que o programa for fechado
                JsonHelper.Salvar();
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnEstoque);
            NavegacaoLoop("Estoque");
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnEventos);
            NavegacaoLoop("Eventos");
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            MarcarBotaoSelecionado(btnRetorno);
            NavegacaoLoop("Retorno");
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
            NavegacaoLoop("Eventos");
        }

        private void NavegacaoLoop(string destinoInicial)
        {
            string destino = destinoInicial;

            while (destino == "Estoque" || destino == "Eventos" || destino == "Retorno")
            {
                Form tela = destino switch
                {
                    "Estoque" => new frmEstoque(),
                    "Eventos" => new frmEventos(),
                    "Retorno" => new frmRetorno(),
                    _ => null!
                };

                tela.ShowDialog();

                string proximoDestino = tela.Tag?.ToString() ?? "";
                tela.Dispose();

                destino = proximoDestino;

                if (destino == "Estoque" || destino == "Eventos" || destino == "Retorno")
                    AtualizarDashboard();
            }

            JsonHelper.Salvar();
            AtualizarDashboard();
        }
    }
}
