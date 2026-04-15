using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TREINAMENTO
{
    public partial class Form1 : Form
    {
        FRM_PAINEL fPainel = new FRM_PAINEL();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tentativas = 0;
            if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                this.Hide();
                MessageBox.Show("Bem Vindo!", "Sucesso!");
                FRM_PAINEL fPainel = new FRM_PAINEL();
                fPainel.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Usuário ou senha incorretos!", "Atenção!");
            }

            if (tentativas < 3)
            {
                 tentativas += 1;
            }

            else
            {
                
                MessageBox.Show("Número de tentativas excedido, o programa será fechado!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
