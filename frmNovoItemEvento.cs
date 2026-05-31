using Drink.Dados;
using Drink.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmNovoItemEvento : Form
    {
        private List<Item> _itensEstoque;

        public ItemEvento? ItemCriado { get; private set; }

        public frmNovoItemEvento(List<Item> itensEstoque)
        {
            InitializeComponent();
            _itensEstoque = itensEstoque;
        }

        private void frmNovoItemEvento_Load(object sender, EventArgs e)
        {
            CarregarItensDoEstoque();

            if (_itensEstoque.Count > 0)
            {
                rdbItemEstoque.Checked = true;
            }
            else
            {
                rdbItemEstoque.Enabled = false;
                rdbItemExterno.Checked = true;
            }

            AtualizarTipoItem();
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
            cmbItensEstoque.Enabled = itemDoEstoque;
            txtNomeExterno.Enabled = !itemDoEstoque;
            txtCategoriaExterna.Enabled = !itemDoEstoque;
            txtUnidadeExterna.Enabled = !itemDoEstoque;
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

            if (rdbItemEstoque.Checked)
            {
                AdicionarItemDoEstoque();
            }
            else
            {
                AdicionarItemExterno();
            }

            if (ItemCriado == null)
            {
                return;
            }

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
            Random random = new Random();
            int idGerado;
            bool idJaExiste;

            do
            {
                idGerado = random.Next(1000, 10000);
                idJaExiste = false;

                foreach (Item item in DadosTemporarios.Itens)
                {
                    if (item.Id == idGerado)
                    {
                        idJaExiste = true;
                        break;
                    }
                }

            } while (idJaExiste);

            return idGerado;
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