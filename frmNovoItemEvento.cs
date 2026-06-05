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

        public ItemEvento? ItemCriado { get; private set; }

        public frmNovoItemEvento(List<Item> itensEstoque)
        {
            InitializeComponent();
            _itensEstoque = itensEstoque;
        }

        public void CarregarItemParaEdicao(ItemEvento itemEvento)
        {
            _modoEdicao = true;
            _itemEmEdicao = itemEvento;
        }

        private void frmNovoItemEvento_Load(object sender, EventArgs e)
        {
            CarregarItensDoEstoque();

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

                // Trava o tipo — não faz sentido trocar de estoque para externo na edição
                rdbItemExterno.Enabled = false;

                var itemNoCombo = _itensEstoque
                    .FirstOrDefault(i => i.Id == _itemEmEdicao.Item.Id);

                if (itemNoCombo != null)
                    cmbItensEstoque.SelectedItem = itemNoCombo;

                // Trava o combo — na edição não troca o item, só a quantidade
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

            // Ajusta título e botão para modo edição
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

            // No modo edição os campos já foram travados em PreencherCamposEdicao
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
            // Valida quantidade contra o estoque se vier do estoque
            if (_itemEmEdicao!.VeioDoEstoque && _itemEmEdicao.Item != null)
            {
                // A quantidade disponível é o que está no estoque + o que já estava separado
                // (porque a baixa ainda não foi refeita)
                decimal disponivelReal = _itemEmEdicao.Item.QuantidadeAtual + _itemEmEdicao.QuantidadeSeparada;

                if (nudQuantidade.Value > disponivelReal)
                {
                    MessageBox.Show(
                        $"A quantidade informada é maior que a disponível no estoque ({disponivelReal} {_itemEmEdicao.Item.Unidade}).");
                    return;
                }
            }

            // Atualiza só o que o usuário pode mudar
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
                QuantidadeSeparada = nudQuantidade.Value,
                QuantidadeRetornada = 0,
                Status = "Pendente",
                VeioDoEstoque = true
            };
        }

        private int GerarIdItemExterno()
        {
            int maxId = DadosTemporarios.Itens.Any()
                ? DadosTemporarios.Itens.Max(i => i.Id)
                : 0;
            return maxId + 1;
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
                QuantidadeSeparada = nudQuantidade.Value,
                QuantidadeRetornada = 0,
                Status = "Pendente",
                VeioDoEstoque = false
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}