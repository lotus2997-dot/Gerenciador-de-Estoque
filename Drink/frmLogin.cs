using Drink.Properties;
using System.Reflection;

namespace Drink
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234")   //Definição de usuario e senha
            {
                this.Hide();
                frmPrincipal menu = new frmPrincipal(usuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
            
        }

        //função permite usuario ver a senha escrita
        private void BtVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            BtVerSenha.Image = Resources.visivel;
        }

        private void BtVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            BtVerSenha.Image = Resources.invisivel;

        }

        private void BtVerSenha_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}       
