using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Drink.Models;

namespace Drink
{
    public partial class frmNovoItemEvento : Form
    {
        private List<Item> _itensEstoque;
        public ItemEvento? ItemCriado { get; private set; } //pega o item criado para poder usar ele na tela de eventos

        public frmNovoItemEvento(List<Item> itensEstoque)
        {
            InitializeComponent();

            _itensEstoque = itensEstoque;
        }

        private void frmNovoItemEvento_Load(object sender, EventArgs e)
        {
            rdbItemEstoque.Checked = true;

            CarregarItensDoEstoque();

            AtualizarTipoItem();
        }

        private void CarregarItensDoEstoque()  //método pra carregar os itens do estoque no combo box
        {
            cmbItensEstoque.DataSource = null; //limpa o combo box, pra evitar erros

            cmbItensEstoque.DataSource = _itensEstoque; //coloca a lista de itens do estoque feita logo acima dentro do combo box

            cmbItensEstoque.DisplayMember = "Nome"; //mostra o nome do item no combo box

            cmbItensEstoque.ValueMember = "Id"; //define que o valor interno do item é o id, ele mostra o nome, mas por trás o sistema sabe o id do item.
        }

        private void AtualizarTipoItem()
        {
            bool itemDoEstoque = rdbItemEstoque.Checked; //verifica se a opção item do estoque no radiobutton esta marcada (se estiver marcada = true, se não estiver marcada = false)

            cmbItensEstoque.Enabled = itemDoEstoque; //ativa o combo box dos itens do estoque se for um item do estoque

            txtNomeExterno.Enabled = !itemDoEstoque; //ativa o txtbox do nome externo se o bool do itemdoestoque for false
            txtCategoriaExterna.Enabled = !itemDoEstoque;//mesma coisa do acima só que com categoria
            txtUnidadeExterna.Enabled = !itemDoEstoque; //mesma coisa do de cima só que com unidade
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

            DialogResult = DialogResult.OK; //define que o resultado do dialog é OK, isso é usado para saber se o usuário realmente criou um item ou se ele fechou a janela sem criar um item

            Close();
        }

        private void AdicionarItemDoEstoque() //método usado quando o usuário marca a opção Item do estoque
        {
            Item? itemSelecionado = cmbItensEstoque.SelectedItem as Item; //pega o item selecionado no combo box e converte ele para o tipo Item

            if (itemSelecionado == null)  //verifica se algum item foi selecionado no combo box
            {
                MessageBox.Show("Selecione um item do estoque.");
                return;
            }

            if (nudQuantidade.Value > itemSelecionado.QuantidadeAtual) //verifica se a quantidade informada é maior que a quantidade disponivel no estoque
            {
                MessageBox.Show("A quantidade informada é maior que a quantidade disponível no estoque.");
                return;
            }

            ItemCriado = new ItemEvento //cria um novo item evento com as informações do item selecionado e a quantidade informada
            {
                Item = itemSelecionado,
                QuantidadeSeparada = nudQuantidade.Value,
                QuantidadeRetornada = 0,
                Status = "Pendente",
                VeioDoEstoque = true
            };
        }

        private void AdicionarItemExterno() //metodo usado quando a opcão item externo é marcada
        {
            if (string.IsNullOrWhiteSpace(txtNomeExterno.Text)) //verifica se nome do item externo foi colocado no txtbox
            {
                MessageBox.Show("Informe o nome do item externo.");
                return;
            }

            Item itemExterno = new Item //cria um novo item com as informações informadas nos txtbox
            {
                Id = 0,
                Nome = txtNomeExterno.Text,
                Categoria = txtCategoriaExterna.Text,
                Unidade = txtUnidadeExterna.Text,
                QuantidadeAtual = 0,
                QuantidadeMinima = 0
            };

            ItemCriado = new ItemEvento //cria um novo item evento com as informaçoes do item externo criado e a quantidade informada
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
            DialogResult = DialogResult.Cancel; //define que o resultado do dialog é Cancel, isso é usado para saber que o usuário cancelou a criação do item, ou seja, ele não criou um item e fechou a janela

            Close();
        }
    }
}