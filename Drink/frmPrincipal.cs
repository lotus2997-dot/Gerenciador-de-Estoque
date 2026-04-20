using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Drink
{
    public partial class frmPrincipal : Form
    {
        private string _usuarioLogado = "";
        //Passando valores


        public frmPrincipal(string usuarioDoLogin)
        {
            InitializeComponent();
            _usuarioLogado = usuarioDoLogin; //Escopo local


            lblUsuario.Text = "Bem vindo" + _usuarioLogado + "!";

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 87, 51);
        }
    }
}
