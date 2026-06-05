using Drink.Dados;
using Drink.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmAdicionarRetorno : Form
    {
        private Evento _eventoDoRetorno;

        public frmAdicionarRetorno(Evento eventoDoRetorno)
        {
            InitializeComponent();
            _eventoDoRetorno = eventoDoRetorno;
            CarregarCombosExternos();
            AtualizarCampos();
        }
        private void AtualizarCampos()
        {
            cmbItensEstoqueRetorno.DataSource = DadosTemporarios.Itens.ToList();
            cmbItensEstoqueRetorno.DisplayMember = "Nome";
            cmbItensEstoqueRetorno.ValueMember = "Id";

            if (rdbItemEventoRetorno.Checked)
            {
                cmbItensEstoqueRetorno.Enabled = true;
                txtNomeExternoRetorno.Enabled = false;
                txtCategoriaExternaRetorno.Enabled = false;
                txtUnidadeExternaRetorno.Enabled = false;
            }
            else
            {
                cmbItensEstoqueRetorno.Enabled = false;
                txtCategoriaExternaRetorno.Enabled = true;
                txtUnidadeExternaRetorno.Enabled = true;
                txtNomeExternoRetorno.Enabled = true;
            }

        }
        private void CarregarCombosExternos()
        {
            ComboBoxHelper.Preencher(txtCategoriaExternaRetorno, CatalogosSistema.Categorias);
            ComboBoxHelper.Preencher(txtUnidadeExternaRetorno, CatalogosSistema.Unidades);
        }

        private void rdbItemEventoRetorno_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void rdbItemExternoRetorno_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarCampos();
        }

        private void btnAdicionarRetorno_Click(object sender, EventArgs e)
        {
            if (nudQuantidadeRetorno.Value <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida!");
                return;
            }
            if (rdbItemEventoRetorno.Checked)
            {
                if (cmbItensEstoqueRetorno.SelectedItem is Item itemSelecionado)
                {
                    ItemEvento itemEvento = new ItemEvento
                    {
                        Item = itemSelecionado,
                        QuantidadeRetornada = nudQuantidadeRetorno.Value,
                        Status = "Retornado",
                        Observacao = txtObservacaoRetorno.Text
                    };
                    _eventoDoRetorno.Itens.Add(itemEvento);
                    MessageBox.Show("Item adicionado ao retorno do evento!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecione um item do estoque!");
                }
            }
            else
            {
                if (txtNomeExternoRetorno.Text == "")
                {
                    MessageBox.Show("Informe o nome do item externo!");
                    return;
                }
                if (txtCategoriaExternaRetorno.Text == "")
                {
                    MessageBox.Show("Informe a categoria do item externo!");
                    return;
                }
                if (txtUnidadeExternaRetorno.Text == "")
                {
                    MessageBox.Show("Informe a unidade do item externo!");
                    return;
                }

                ItemEvento itemExterno = new ItemEvento
                {
                    Item = new Item
                    {
                        Nome = txtNomeExternoRetorno.Text,
                        Categoria = txtCategoriaExternaRetorno.Text,
                        Unidade = txtUnidadeExternaRetorno.Text
                    },
                    QuantidadeRetornada = nudQuantidadeRetorno.Value,
                    Status = "Retornado",
                    Observacao = txtObservacaoRetorno.Text
                };
                _eventoDoRetorno.Itens.Add(itemExterno);
                MessageBox.Show("Item externo adicionado!");
                this.Close();
            }
        }
    }
}
