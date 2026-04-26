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

        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque1 tela = new frmEstoque1(); tela.ShowDialog();
            tela.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            dgvEvento.Visible = !dgvEvento.Visible;
            btnAdicionarEvento.Visible = !btnAdicionarEvento.Visible;
            btnRemoverEvento.Visible = !btnRemoverEvento.Visible;
            btnAtualizarEvento.Visible = !btnAtualizarEvento.Visible;
            cbxCategoriaEvento.Visible = !cbxCategoriaEvento.Visible;
            tbxDataEvento.Visible = !tbxDataEvento.Visible;

            if (dgvEvento.Visible)
                btnEventos.Text = "Esconder Evento";
            else
                btnEventos.Text = "Mostrar Evento";
        }

        private void btnAdicionarEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
