using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
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
            CarregarCombosTela();
            CarregarEventos();
            ComboBoxHelper.Preencher(cmbStatusEventoRetorno, CatalogosSistema.StatusEvento);
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
            cmbEventoSelecionado.SelectedIndexChanged -= cmbEventoSelecionado_SelectedIndexChanged;
            cmbEventoSelecionado.DataSource = null;
            cmbEventoSelecionado.DataSource = DadosTemporarios.Eventos
                .Where(e => e.Status == "Separado" || e.Status == "Retorno em conferência")
                .ToList();
            cmbEventoSelecionado.DisplayMember = "Nome";
            cmbEventoSelecionado.ValueMember = "Id";
            cmbEventoSelecionado.SelectedIndex = -1;
            cmbEventoSelecionado.SelectedIndexChanged += cmbEventoSelecionado_SelectedIndexChanged;
        }

        // SELEÇÃO DE EVENTO
        private void cmbEventoSelecionado_SelectedIndexChanged(object sender, EventArgs e)
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
        private void AtualizarTabelaItens(string nomeFiltro = "", string unidadeFiltro = "Todas", string statusFiltro = "Todos")
        {
            if (_eventoAtual == null)
            {
                dgvRetorno.DataSource = null;
                return;
            }

            var itens = _eventoAtual.Itens.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(nomeFiltro))
                itens = itens.Where(ie => ie.Item != null && ie.Item.Nome.Contains(nomeFiltro, StringComparison.OrdinalIgnoreCase));

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

        private void ColorirItensConferidos()
        {
            foreach (DataGridViewRow row in dgvRetorno.Rows)
            {
                if (row.IsNewRow) continue;
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                if (status == "Retornado")
                {
                    row.DefaultCellStyle.BackColor = Color.FromArgb(220, 240, 220);
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ItemEvento? item = ObterItemSelecionado();
            if (item == null) { MessageBox.Show("Selecione um item na grid."); return; }

            if (item.Status == "Retornado")
            {
                MessageBox.Show("Este item já foi conferido e não pode ser alterado.");
                return;
            }

            using var tela = new frmAdicionarRetorno(_eventoAtual!, item);
            if (tela.ShowDialog() == DialogResult.OK)
            {
                JsonHelper.Salvar();
                AtualizarTabelaItens();
                ColorirItensConferidos();
                AtualizarResumo();

                VerificarConferenciaCompleta();
            }
        }

        private void VerificarConferenciaCompleta()
        {
            if (_eventoAtual == null) return;

            bool todos = _eventoAtual.Itens.All(ie => ie.Status == "Retornado");
            if (!todos) return;

            if (MessageBox.Show(
                    "Todos os itens foram conferidos! Deseja encerrar o evento agora?",
                    "Conferência completa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
            {
                _eventoAtual.Status = "Encerrado";
                MessageBox.Show("Evento encerrado com sucesso.");
                CarregarEventos();
                _eventoAtual = null;
                dgvRetorno.DataSource = null;
                lblEventoValor.Text = "-";
                lblDataValor.Text = "-";
                lblResponsavelValor.Text = "-";
            }
            else
            {
                _eventoAtual.Status = "Retorno em conferência";
            }
        }

        private void btnParaItensRetorno_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabItensRetorno;
        }

        private void btnConfirmarRetorno_Click(object sender, EventArgs e)
        {
            if (_eventoAtual == null) { MessageBox.Show("Selecione um evento."); return; }

            var pendentes = _eventoAtual.Itens
                .Where(i => i.Status != "Retornado").ToList();

            if (pendentes.Any())
            {
                var resp = MessageBox.Show(
                    $"Ainda há {pendentes.Count} item(ns) não conferido(s). Deseja confirmar mesmo assim?",
                    "Itens pendentes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.No) return;

                // Pendentes = consumidos totalmente, não voltaram
                foreach (var item in pendentes)
                {
                    item.QuantidadeRetornada = 0;
                    item.Status = "Retornado";
                    item.ConferidoRetorno = true;
                    // NÃO soma no estoque — quantidade retornada = 0
                }
            }

            // Devolve ao estoque apenas os que vieram de lá e ainda NÃO foram processados
            foreach (var item in _eventoAtual.Itens
                .Where(i => i.VeioDoEstoque && i.Item != null && !i.ConferidoRetorno))
            {
                item.Item!.QuantidadeAtual += item.QuantidadeRetornada;
                item.Item.UltimaAtualizacao = DateTime.Now;
                item.ConferidoRetorno = true;
            }

            _eventoAtual.Status = "Encerrado";
            AtualizarTabelaItens();
            ColorirItensConferidos();
            AtualizarResumo();

            JsonHelper.Salvar();

            MessageBox.Show("Retorno confirmado! Evento encerrado e estoque atualizado.",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregarEventos();
            _eventoAtual = null;
            dgvRetorno.DataSource = null;
            lblEventoValor.Text = "-";
            lblDataValor.Text = "-";
            lblResponsavelValor.Text = "-";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            MessageBox.Show("Dados salvos!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Tag = "Eventos";
            this.Close();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            JsonHelper.Salvar();
            this.Tag = "Estoque";
            this.Close();
        }
    }
}
