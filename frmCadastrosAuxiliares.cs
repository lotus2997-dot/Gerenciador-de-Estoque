using System;
using System.Windows.Forms;
using Drink.Dados;

namespace Drink
{
    public partial class frmCadastrosAuxiliares : Form
    {
        public frmCadastrosAuxiliares()
        {
            InitializeComponent();
        }

        private void frmCadastrosAuxiliares_Load(object sender, EventArgs e)
        {
            CarregarListas();
        }

        private void CarregarListas()
        {
            // Carrega Unidades
            cmbUnidadeConfig.Items.Clear();
            foreach (var u in CatalogosSistema.Unidades)
                cmbUnidadeConfig.Items.Add(u);

            // Carrega Categorias
            cmbCategoriaConfig.Items.Clear();
            foreach (var c in CatalogosSistema.Categorias)
                cmbCategoriaConfig.Items.Add(c);
        }

        //SALVAR

        private void btnSalvarConfig_Click(object sender, EventArgs e)
        {
            bool salvou = false;

            // Adiciona nova Unidade
            string novaUnidade = txtUnidade.Text.Trim();
            if (!string.IsNullOrEmpty(novaUnidade))
            {
                if (CatalogosSistema.Unidades.Contains(novaUnidade))
                    MessageBox.Show($"A unidade \"{novaUnidade}\" já existe.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    CatalogosSistema.Unidades.Add(novaUnidade);
                    salvou = true;
                }
            }

            // Adiciona nova Categoria
            string novaCategoria = txtCategoriaConfig.Text.Trim();
            if (!string.IsNullOrEmpty(novaCategoria))
            {
                if (CatalogosSistema.Categorias.Contains(novaCategoria))
                    MessageBox.Show($"A categoria \"{novaCategoria}\" já existe.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    CatalogosSistema.Categorias.Add(novaCategoria);
                    salvou = true;
                }
            }

            if (salvou)
            {
                CarregarListas();
                LimparCampos();
                MessageBox.Show("Salvo com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(novaUnidade) && string.IsNullOrEmpty(novaCategoria))
            {
                MessageBox.Show("Preencha ao menos um campo para salvar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // REMOVER

        private void btnLimparConfig_Click(object sender, EventArgs e)
        {
            bool removeu = false;

            // Remove Unidade selecionada
            if (cmbUnidadeConfig.SelectedItem != null)
            {
                string unidade = cmbUnidadeConfig.SelectedItem.ToString();
                var confirm = MessageBox.Show($"Remover a unidade \"{unidade}\"?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    CatalogosSistema.Unidades.Remove(unidade);
                    removeu = true;
                }
            }

            // Remove Categoria selecionada
            if (cmbCategoriaConfig.SelectedItem != null)
            {
                string categoria = cmbCategoriaConfig.SelectedItem.ToString();
                var confirm = MessageBox.Show($"Remover a categoria \"{categoria}\"?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    CatalogosSistema.Categorias.Remove(categoria);
                    removeu = true;
                }
            }

            if (removeu)
                CarregarListas();
        }

        //CANCELAR / LIMPAR CAMPOS 

        private void btnCancelarConfig_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtUnidade.Clear();
            txtCategoriaConfig.Clear();
            cmbUnidadeConfig.SelectedIndex = -1;
            cmbCategoriaConfig.SelectedIndex = -1;
        }
    }
}
