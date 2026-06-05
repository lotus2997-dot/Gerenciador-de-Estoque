using Drink.Dados;
using Drink.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmAdicionarRetorno : Form
    {
        private Evento _evento;
        private bool _modoConferencia = false;
        private ItemEvento? _itemEmConferencia = null;

        public frmAdicionarRetorno(Evento evento)
        {
            InitializeComponent();
            _evento = evento;
        }

        // Chamado pelo frmRetorno quando vem do btnConfirmar
        public void CarregarItemParaConferencia(ItemEvento item)
        {
            _modoConferencia = true;
            _itemEmConferencia = item;
        }

        private void frmAdicionarRetorno_Load(object sender, EventArgs e)
        {
            if (_modoConferencia && _itemEmConferencia != null)
                CarregarModoConferencia();
            else
                CarregarModoNovoItem();
        }

        // MODO CONFERÊNCIA — item que já foi separado
        private void CarregarModoConferencia()
        {
            this.Text = "Conferir Retorno";

            // Trava tipo — não faz sentido trocar na conferência
            rdbItemEventoRetorno.Checked = true;
            rdbItemEventoRetorno.Enabled = false;
            rdbItemExternoRetorno.Enabled = false;
            gbTipoItemRetorno.Visible = false;

            // Carrega o item no combo e trava
            cmbItensEstoqueRetorno.DataSource = null;
            cmbItensEstoqueRetorno.DataSource = new[] { _itemEmConferencia!.Item };
            cmbItensEstoqueRetorno.DisplayMember = "Nome";
            cmbItensEstoqueRetorno.SelectedIndex = 0;
            cmbItensEstoqueRetorno.Enabled = false;

            // Trava campos externos — não são usados na conferência
            txtNomeExternoRetorno.Enabled = false;
            txtCategoriaExternaRetorno.Enabled = false;
            txtUnidadeExternaRetorno.Enabled = false;

            // Define máximo como a quantidade que foi separada
            nudQuantidadeRetorno.Maximum = _itemEmConferencia.QuantidadeSeparada;
            nudQuantidadeRetorno.Value = _itemEmConferencia.QuantidadeSeparada; // padrão: voltou tudo

            // Mostra validade se o item tiver
            if (_itemEmConferencia.Item?.Validade.HasValue == true)
                dtpValidadeRetorno.Value = _itemEmConferencia.Item.Validade.Value;

            lblItemEventoRetorno.Text =
                $"Item: {_itemEmConferencia.Item?.Nome} | Separado: " +
                $"{_itemEmConferencia.QuantidadeSeparada} {_itemEmConferencia.Item?.Unidade}";
        }

        // MODO NOVO ITEM — item avulso não estava na lista
        private void CarregarModoNovoItem()
        {
            this.Text = "Adicionar Item ao Retorno";
            CarregarCombosExternos();

            cmbItensEstoqueRetorno.DataSource = DadosTemporarios.Itens
                .Where(i => i.Ativo).ToList();
            cmbItensEstoqueRetorno.DisplayMember = "Nome";
            cmbItensEstoqueRetorno.ValueMember = "Id";

            if (cmbItensEstoqueRetorno.Items.Count > 0)
                rdbItemEventoRetorno.Checked = true;
            else
            {
                rdbItemEventoRetorno.Enabled = false;
                rdbItemExternoRetorno.Checked = true;
            }

            AtualizarCampos();
        }

        private void CarregarCombosExternos()
        {
            ComboBoxHelper.Preencher(txtCategoriaExternaRetorno, CatalogosSistema.Categorias);
            ComboBoxHelper.Preencher(txtUnidadeExternaRetorno, CatalogosSistema.Unidades);
        }

        private void AtualizarCampos()
        {
            bool doEstoque = rdbItemEventoRetorno.Checked;
            cmbItensEstoqueRetorno.Enabled = doEstoque;
            txtNomeExternoRetorno.Enabled = !doEstoque;
            txtCategoriaExternaRetorno.Enabled = !doEstoque;
            txtUnidadeExternaRetorno.Enabled = !doEstoque;
        }

        private void rdbItemEventoRetorno_CheckedChanged(object sender, EventArgs e)
        {
            if (!_modoConferencia) AtualizarCampos();
        }

        private void rdbItemExternoRetorno_CheckedChanged(object sender, EventArgs e)
        {
            if (!_modoConferencia) AtualizarCampos();
        }

        // SALVAR
        private void btnAdicionarRetorno_Click(object sender, EventArgs e)
        {
            if (nudQuantidadeRetorno.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            if (_modoConferencia)
                ConfirmarConferencia();
            else if (rdbItemEventoRetorno.Checked)
                AdicionarItemDoEstoque();
            else
                AdicionarItemExterno();
        }

        private void ConfirmarConferencia()
        {
            decimal qtdRetornada = nudQuantidadeRetorno.Value;

            if (_itemEmConferencia!.VeioDoEstoque && _itemEmConferencia.Item != null)
            {
                _itemEmConferencia.Item.QuantidadeAtual += qtdRetornada;
                _itemEmConferencia.Item.UltimaAtualizacao = DateTime.Now;
            }

            _itemEmConferencia.QuantidadeRetornada = qtdRetornada;
            _itemEmConferencia.Status = "Retornado";
            _itemEmConferencia.Observacao = txtObservacaoRetorno.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AdicionarItemDoEstoque()
        {
            if (cmbItensEstoqueRetorno.SelectedItem is not Item itemSelecionado)
            {
                MessageBox.Show("Selecione um item do estoque.");
                return;
            }

            // Gera próximo ID para o novo ItemEvento
            int novoId = _evento.Itens.Any()
                ? _evento.Itens.Max(i => i.Id) + 1 : 1;

            ItemEvento novoItem = new ItemEvento
            {
                Id = novoId,
                Item = itemSelecionado,
                QuantidadeSeparada = nudQuantidadeRetorno.Value,
                QuantidadeRetornada = nudQuantidadeRetorno.Value,
                Status = "Retornado",
                VeioDoEstoque = true,
                Observacao = txtObservacaoRetorno.Text.Trim()
            };

            _evento.Itens.Add(novoItem);
            MessageBox.Show("Item adicionado ao retorno.");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AdicionarItemExterno()
        {
            if (string.IsNullOrWhiteSpace(txtNomeExternoRetorno.Text))
            {
                MessageBox.Show("Informe o nome do item.");
                return;
            }

            int novoId = _evento.Itens.Any()
                ? _evento.Itens.Max(i => i.Id) + 1 : 1;

            ItemEvento novoItem = new ItemEvento
            {
                Id = novoId,
                Item = new Item
                {
                    Nome = txtNomeExternoRetorno.Text.Trim(),
                    Categoria = txtCategoriaExternaRetorno.Text.Trim(),
                    Unidade = txtUnidadeExternaRetorno.Text.Trim()
                },
                QuantidadeSeparada = nudQuantidadeRetorno.Value,
                QuantidadeRetornada = nudQuantidadeRetorno.Value,
                Status = "Retornado",
                VeioDoEstoque = false,
                Observacao = txtObservacaoRetorno.Text.Trim()
            };

            _evento.Itens.Add(novoItem);
            MessageBox.Show("Item externo adicionado ao retorno.");
            DialogResult = DialogResult.OK;
            Close();
        }

        // LIMPAR / CANCELAR
        private void btnLimparRetorno_Click(object sender, EventArgs e)
        {
            if (_modoConferencia)
            {
                nudQuantidadeRetorno.Value = _itemEmConferencia!.QuantidadeSeparada;
                txtObservacaoRetorno.Clear();
            }
            else
            {
                nudQuantidadeRetorno.Value = 0;
                txtNomeExternoRetorno.Clear();
                txtObservacaoRetorno.Clear();
                cmbItensEstoqueRetorno.SelectedIndex = -1;
            }
        }

        private void btnCancelarRetorno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}