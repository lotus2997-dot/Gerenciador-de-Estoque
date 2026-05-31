using System;
using System.Windows.Forms;
using Drink.Models;
using Drink.Dados;

namespace Drink
{


    public partial class frmAdicionarEstoque : Form
    {
        private readonly frmEstoque TLcadastro;
        
        private bool _modoEdicao = false;
        private Item? _itemEdicao = null;

        public frmAdicionarEstoque(frmEstoque tL)
        {
            InitializeComponent();
            TLcadastro = tL;
            CarregarComboBoxes();
        }
        private void CarregarComboBoxes()
        {
            cmbCategoria.Items.Clear();

            cmbCategoria.Items.Add("Bebidas");
            cmbCategoria.Items.Add("Frutas");
            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Descartáveis");
            cmbCategoria.Items.Add("Limpeza");
            cmbCategoria.Items.Add("Outros");

            cmbUnidade.Items.Clear();

            cmbUnidade.Items.Add("Unidade");
            cmbUnidade.Items.Add("Kg");
            cmbUnidade.Items.Add("g");
            cmbUnidade.Items.Add("L");
            cmbUnidade.Items.Add("ml");
            cmbUnidade.Items.Add("Garrafa");
            cmbUnidade.Items.Add("Caixa");
            cmbUnidade.Items.Add("Pacote");
        }

        public void CarregarItemParaEdicao(Item item)
        {
            _modoEdicao = true;
            _itemEdicao = item;

            txtNome.Text = item.Nome ?? "";
            cmbCategoria.Text = item.Categoria ?? "";
            nudQuantidadeAtual.Value = item.QuantidadeAtual;
            cmbUnidade.Text = item.Unidade ?? "";
            dtpValidade.Value = item.Validade ?? DateTime.Today;
            nudQuantidadeMinima.Value = item.QuantidadeMinima;
            txtObservacao.Text = item.Observacao ?? "";
            chkItemAtivo.Checked = item.Ativo;

            btnSalvar.Text = "Salvar Alterações";
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(cmbCategoria.Text)
                 || string.IsNullOrWhiteSpace(cmbUnidade.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios.");
                return;
            }

            if (_modoEdicao && _itemEdicao != null)
            {
                _itemEdicao.Nome = txtNome.Text.Trim();
                _itemEdicao.Categoria = cmbCategoria.Text.Trim();
                _itemEdicao.QuantidadeAtual = nudQuantidadeAtual.Value;
                _itemEdicao.Unidade = cmbUnidade.Text.Trim();
                _itemEdicao.Validade = dtpValidade.Value;
                _itemEdicao.QuantidadeMinima = nudQuantidadeMinima.Value;
                _itemEdicao.Observacao = txtObservacao.Text.Trim();
                _itemEdicao.Ativo = chkItemAtivo.Checked;
                _itemEdicao.UltimaAtualizacao = DateTime.Now;

                TLcadastro.AtualizarDados();
                MessageBox.Show("Item atualizado com sucesso!");
                this.Close();
                return;
            }
            
            Item novoItem = new Item
            {
                Id = GerarId(),
                Nome = txtNome.Text.Trim(),
                Categoria = cmbCategoria.Text.Trim(),
                QuantidadeAtual = nudQuantidadeAtual.Value,
                Unidade = cmbUnidade.Text.Trim(),
                Validade = dtpValidade.Value,
                QuantidadeMinima = nudQuantidadeMinima.Value,
                Observacao = txtObservacao.Text.Trim(),
                Ativo = chkItemAtivo.Checked,
                UltimaAtualizacao = DateTime.Now
            };
            
            DadosTemporarios.Itens.Add(novoItem);
            TLcadastro.AtualizarDados();
            MessageBox.Show("Item adicionado com sucesso!");
            this.Close();
        }

        private int GerarId()
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
    }
}