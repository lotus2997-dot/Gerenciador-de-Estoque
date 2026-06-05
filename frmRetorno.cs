using System;
using System.Linq;
using System.Windows.Forms;
using Drink.Dados;
using Drink.Models;

namespace Drink
{
    public partial class frmRetorno : Form
    {
        private Evento? _eventoAtual;

        public frmRetorno()
        {
            InitializeComponent();
        }

        private void frmRetorno_Load(object sender, EventArgs e)
        {
            CarregarCombosTela();
            CarregarEventos();
        }

        // INICIALIZAÇÃO
        private void CarregarCombosTela()
        {
            cmbFiltroStatus.Items.Clear();
            cmbFiltroStatus.Items.Add("Todos");
            cmbFiltroStatus.Items.Add("Separado");
            cmbFiltroStatus.Items.Add("Retornado");
            cmbFiltroStatus.SelectedIndex = 0;

            cmbFiltroUnidade.Items.Clear();
            cmbFiltroUnidade.Items.Add("Todas");
            foreach (var u in CatalogosSistema.Unidades)
                cmbFiltroUnidade.Items.Add(u);
            cmbFiltroUnidade.SelectedIndex = 0;
        }

        private void CarregarEventos()
        {
            cmbEventoSelecionado.SelectedIndexChanged -= cmbEventoSelecionado_SelectedIndexChanged_1;
            cmbEventoSelecionado.DataSource = null;
            cmbEventoSelecionado.DataSource = DadosTemporarios.Eventos
                .Where(e => e.Status == "Separado" || e.Status == "Retorno em conferência")
                .ToList();
            cmbEventoSelecionado.DisplayMember = "Nome";
            cmbEventoSelecionado.ValueMember = "Id";
            cmbEventoSelecionado.SelectedIndex = -1;
            cmbEventoSelecionado.SelectedIndexChanged += cmbEventoSelecionado_SelectedIndexChanged_1;
        }

        // SELEÇÃO DE EVENTO
        private void cmbEventoSelecionado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEventoSelecionado.SelectedItem is not Evento ev) return;

            _eventoAtual = ev;
            AtualizarResumo();
            CarregarCamposDadosEvento();
            AtualizarTabelaItens();
        }

        private void AtualizarResumo()
        {
            if (_eventoAtual == null) return;
            lblEventoValor.Text = _eventoAtual.Nome;
            lblDataValor.Text = _eventoAtual.Data.ToString("dd/MM/yyyy");
            lblResponsavelValor.Text = _eventoAtual.Responsavel;
        }

        private void CarregarCamposDadosEvento()
        {
            if (_eventoAtual == null) return;
            txtNomeEventoRetorno.Text = _eventoAtual.Nome;
            txtLocalEventoRetorno.Text = _eventoAtual.Local;
            txtResponsavelEventoRetorno.Text = _eventoAtual.Responsavel;
            dtpDataEventoRetorno.Value = _eventoAtual.Data == DateTime.MinValue ? DateTime.Today : _eventoAtual.Data;
            nudQtdPessoasRetorno.Value = _eventoAtual.QuantidadePessoas;
            cmbStatusEventoRetorno.Text = _eventoAtual.Status;
        }

        // TABELA DE ITENS
        private void AtualizarTabelaItens(string nomeFiltro = "", string unidadeFiltro = "", string statusFiltro = "")
        {
            if (_eventoAtual == null)
            {
                dgvRetorno.DataSource = null;
                return;
            }

            var itens = _eventoAtual.Itens.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(nomeFiltro))
                itens = itens.Where(ie => ie.Item != null &&
                            ie.Item.Nome.Contains(nomeFiltro, StringComparison.OrdinalIgnoreCase));

            if (unidadeFiltro != "Todas")
                itens = itens.Where(ie => ie.Item?.Unidade == unidadeFiltro);

            if (statusFiltro != "Todos")
                itens = itens.Where(ie => ie.Status == statusFiltro);

            var dados = itens.Select(ie => new
            {
                ID = ie.Id,
                Nome = ie.Item?.Nome ?? "",
                Unidade = ie.Item?.Unidade ?? "",
                QtdSeparada = ie.QuantidadeSeparada,
                QtdRetornada = ie.QuantidadeRetornada,
                QtdConsumida = ie.QuantidadeConsumida,
                Status = ie.Status,
                Origem = ie.VeioDoEstoque ? "Estoque" : "Compra direta",
                Observacao = ie.Observacao
            }).ToList();

            dgvRetorno.DataSource = null;
            dgvRetorno.DataSource = dados;
        }

        private ItemEvento? ObterItemSelecionado()
        {
            if (_eventoAtual == null || dgvRetorno.SelectedRows.Count == 0) return null;
            int id = Convert.ToInt32(dgvRetorno.SelectedRows[0].Cells["ID"].Value);
            return _eventoAtual.Itens.FirstOrDefault(ie => ie.Id == id);
        }

        // FILTROS
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarTabelaItens(
                nomeFiltro: txtFiltroNome.Text.Trim(),
                unidadeFiltro: cmbFiltroUnidade.Text,
                statusFiltro: cmbFiltroStatus.Text);
        }

        private void btnLimparFiltro_Click(object sender, EventArgs e)
        {
            txtFiltroNome.Clear();
            cmbFiltroUnidade.SelectedIndex = 0;
            cmbFiltroStatus.SelectedIndex = 0;
            AtualizarTabelaItens();
        }

        // BOTÕES DA TABELA
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            if (_eventoAtual == null)
            {
                MessageBox.Show("Selecione um evento primeiro.");
                return;
            }

            var tela = new frmAdicionarRetorno(_eventoAtual);
            tela.ShowDialog();
            AtualizarTabelaItens();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            ItemEvento? item = ObterItemSelecionado();
            if (item == null) { MessageBox.Show("Selecione um item para remover."); return; }

            if (item.Status == "Retornado")
            {
                MessageBox.Show("Este item já foi conferido e não pode ser removido.");
                return;
            }

            if (MessageBox.Show("Remover este item do retorno?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            _eventoAtual!.Itens.Remove(item);
            AtualizarTabelaItens();
        }

        // DEVOLVER AO ESTOQUE (btnConfirmar)
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ItemEvento? item = ObterItemSelecionado();
            if (item == null) { MessageBox.Show("Selecione um item na grid."); return; }

            if (item.Status == "Retornado")
            {
                MessageBox.Show("Este item já foi conferido.");
                return;
            }

            using var tela = new frmAdicionarRetorno(_eventoAtual!);
            tela.CarregarItemParaConferencia(item);

            if (tela.ShowDialog() == DialogResult.OK)
            {
                AtualizarTabelaItens();
                VerificarConferenciaCompleta();
            }
        }

        private void VerificarConferenciaCompleta()
        {
            if (_eventoAtual == null) return;

            bool todos = _eventoAtual.Itens.All(ie => ie.Status == "Retornado");
            if (!todos) return;

            _eventoAtual.Status = "Retorno em conferência";

            if (MessageBox.Show(
                    "Todos os itens foram conferidos! Deseja encerrar o evento agora?",
                    "Conferência completa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _eventoAtual.Status = "Encerrado";
                MessageBox.Show("Evento encerrado com sucesso.");
                CarregarEventos();
                dgvRetorno.DataSource = null;
                AtualizarResumo();
            }
        }

        // BOTÕES DE NAVEGAÇÃO E DADOS
        private void btnParaItensRetorno_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItensRetorno;
        }

        private void btnConferirRetorno_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItensRetorno;
        }

        private void btnLimparDadosEventoRetorno_Click(object sender, EventArgs e)
        {
            txtNomeEventoRetorno.Clear();
            txtLocalEventoRetorno.Clear();
            txtResponsavelEventoRetorno.Clear();
            nudQtdPessoasRetorno.Value = 0;
        }
    }
}