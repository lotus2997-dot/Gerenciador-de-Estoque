using Drink.Dados;
using Drink.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmNovoItemEvento : Form
    {
        private List<Item> _itensEstoque;
        private bool _modoEdicao = false;
        private ItemEvento? _itemEmEdicao = null;

        // Referência ao evento atual para cálculo de IDs externos (Bug #8)
        // Passada opcionalmente pelo construtor; se null, usa lógica de fallback.
        private Evento? _eventoAtual;

        public ItemEvento? ItemCriado { get; private set; }

        public frmNovoItemEvento(List<Item> itensEstoque, Evento? eventoAtual = null)
        {
            InitializeComponent();
            _itensEstoque = itensEstoque;
            _eventoAtual = eventoAtual;
        }

        public void CarregarItemParaEdicao(ItemEvento itemEvento)
        {
            _modoEdicao = true;
            _itemEmEdicao = itemEvento;
        }

        private void frmNovoItemEvento_Load(object sender, EventArgs e)
        {
            CarregarItensDoEstoque();

            ComboBoxHelper.Preencher(txtCategoriaExterna, CatalogosSistema.Categorias);
            ComboBoxHelper.Preencher(txtUnidadeExterna, CatalogosSistema.Unidades);

            if (_modoEdicao && _itemEmEdicao != null)
            {
                PreencherCamposEdicao();
            }
            else
            {
                if (_itensEstoque.Count > 0)
                    rdbItemEstoque.Checked = true;
                else
                {
                    rdbItemEstoque.Enabled = false;
                    rdbItemExterno.Checked = true;
                }
            }

            AtualizarTipoItem();
        }

        private void PreencherCamposEdicao()
        {
            nudQuantidade.Value = _itemEmEdicao!.QuantidadeSeparada;

            if (_itemEmEdicao.VeioDoEstoque && _itemEmEdicao.Item != null)
            {
                rdbItemEstoque.Checked = true;
                rdbItemExterno.Enabled = false;

                var itemNoCombo = _itensEstoque
                    .FirstOrDefault(i => i.Id == _itemEmEdicao.Item.Id);

                if (itemNoCombo != null)
                    cmbItensEstoque.SelectedItem = itemNoCombo;

                cmbItensEstoque.Enabled = false;
            }
            else
            {
                rdbItemExterno.Checked = true;
                rdbItemEstoque.Enabled = false;

                txtNomeExterno.Text = _itemEmEdicao.Item?.Nome ?? "";
                txtCategoriaExterna.Text = _itemEmEdicao.Item?.Categoria ?? "";
                txtUnidadeExterna.Text = _itemEmEdicao.Item?.Unidade ?? "";
            }

            this.Text = "Editar Item do Evento";
            btnAdicionar.Text = "Salvar alterações";
        }

        private void CarregarItensDoEstoque()
        {
            cmbItensEstoque.DataSource = null;
            cmbItensEstoque.DataSource = _itensEstoque;
            cmbItensEstoque.DisplayMember = "Nome";
            cmbItensEstoque.ValueMember = "Id";
        }

        private void AtualizarTipoItem()
        {
            bool itemDoEstoque = rdbItemEstoque.Checked;

            if (!_modoEdicao)
            {
                cmbItensEstoque.Enabled = itemDoEstoque;
                txtNomeExterno.Enabled = !itemDoEstoque;
                txtCategoriaExterna.Enabled = !itemDoEstoque;
                txtUnidadeExterna.Enabled = !itemDoEstoque;
            }
        }

        private void rdbItemEstoque_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTipoItem();
        }

        private void rdbItemExterno_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarTipoItem();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (nudQuantidade.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade maior que zero.");
                return;
            }

            if (_modoEdicao && _itemEmEdicao != null)
            {
                SalvarEdicao();
                return;
            }

            if (rdbItemEstoque.Checked)
                AdicionarItemDoEstoque();
            else
                AdicionarItemExterno();

            if (ItemCriado == null) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SalvarEdicao()
        {
            if (_itemEmEdicao!.VeioDoEstoque && _itemEmEdicao.Item != null)
            {
                // A quantidade disponível real = estoque atual + o que já estava separado
                decimal disponivelReal = _itemEmEdicao.Item.QuantidadeAtual + _itemEmEdicao.QuantidadeSeparada;

                if (nudQuantidade.Value > disponivelReal)
                {
                    MessageBox.Show(
                        $"A quantidade informada é maior que a disponível no estoque ({disponivelReal} {_itemEmEdicao.Item.Unidade}).");
                    return;
                }
                var eventoDoItem = _eventoAtual
                    ?? DadosTemporarios.Eventos.FirstOrDefault(ev =>
                        ev.Itens.Any(i => i.Id == _itemEmEdicao.Id));

                bool separacaoJaConfirmada = eventoDoItem?.Status == "Separado";

                if (separacaoJaConfirmada)
                {
                    decimal diferenca = nudQuantidade.Value - _itemEmEdicao.QuantidadeSeparada;
                    _itemEmEdicao.Item.QuantidadeAtual -= diferenca;
                    _itemEmEdicao.Item.UltimaAtualizacao = DateTime.Now;
                }
            }

            // Atualiza a quantidade separada (e campos de item externo, se aplicável)
            _itemEmEdicao.QuantidadeSeparada = nudQuantidade.Value;

            if (!_itemEmEdicao.VeioDoEstoque && _itemEmEdicao.Item != null)
            {
                _itemEmEdicao.Item.Nome = txtNomeExterno.Text.Trim();
                _itemEmEdicao.Item.Categoria = txtCategoriaExterna.Text.Trim();
                _itemEmEdicao.Item.Unidade = txtUnidadeExterna.Text.Trim();
            }

            ItemCriado = _itemEmEdicao;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AdicionarItemDoEstoque()
        {
            Item? itemSelecionado = cmbItensEstoque.SelectedItem as Item;

            if (itemSelecionado == null)
            {
                MessageBox.Show("Selecione um item do estoque.");
                return;
            }

            if (nudQuantidade.Value > itemSelecionado.QuantidadeAtual)
            {
                MessageBox.Show("A quantidade informada é maior que a quantidade disponível no estoque.");
                return;
            }

            ItemCriado = new ItemEvento
            {
                Item = itemSelecionado,
                ItemId = itemSelecionado.Id,
                QuantidadeSeparada = nudQuantidade.Value,
                QuantidadeRetornada = 0,
                Status = "Pendente",
                VeioDoEstoque = true
            };
        }
        private int GerarIdItemExterno()
        {
            int minIdEstoque = DadosTemporarios.Itens.Any(i => i.Id < 0)
                ? DadosTemporarios.Itens.Where(i => i.Id < 0).Min(i => i.Id)
                : 0;

            int minIdEvento = 0;
            if (_eventoAtual != null && _eventoAtual.Itens.Any())
            {
                var idsExternos = _eventoAtual.Itens
                    .Where(ie => !ie.VeioDoEstoque && ie.Item != null && ie.Item.Id < 0)
                    .Select(ie => ie.Item!.Id);
                if (idsExternos.Any())
                    minIdEvento = idsExternos.Min();
            }

            int minId = Math.Min(minIdEstoque, minIdEvento);
            return minId - 1;
        }

        private void AdicionarItemExterno()
        {
            if (string.IsNullOrWhiteSpace(txtNomeExterno.Text))
            {
                MessageBox.Show("Informe o nome do item externo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCategoriaExterna.Text))
            {
                MessageBox.Show("Informe a categoria do item externo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUnidadeExterna.Text))
            {
                MessageBox.Show("Informe a unidade do item externo.");
                return;
            }

            Item itemExterno = new Item
            {
                Id = GerarIdItemExterno(),
                Nome = txtNomeExterno.Text.Trim(),
                Categoria = txtCategoriaExterna.Text.Trim(),
                Unidade = txtUnidadeExterna.Text.Trim(),
                QuantidadeAtual = 0,
                QuantidadeMinima = 0,
                Ativo = true
            };

            ItemCriado = new ItemEvento
            {
                Item = itemExterno,
                ItemId = itemExterno.Id,
                QuantidadeSeparada = nudQuantidade.Value,
                QuantidadeRetornada = 0,
                Status = "Pendente",
                VeioDoEstoque = false
            };
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nudQuantidade.Value = 0;
            cmbItensEstoque.SelectedIndex = -1;
            txtNomeExterno.Clear();
            txtCategoriaExterna.Text = "";
            txtUnidadeExterna.Text = "";
            txtObservacao.Clear();

            // Fecha o formulário como cancelamento
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
