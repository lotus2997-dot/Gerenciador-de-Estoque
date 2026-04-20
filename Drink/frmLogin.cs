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

            if (usuario == "Admim" && senha == "1234")
            {
                this.Hide();
                frmPrincipal menu = new frmPrincipal(usuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha invalidos");
            }
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
        }



        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtVerSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = false;
            BtVerSenha.Image = Resources.icons8_visible_16;
        }

        private void BtVerSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtSenha.UseSystemPasswordChar = true;
            BtVerSenha.Image = Resources.icons8_invisible_16;

        }
    }
}       
