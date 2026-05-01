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

        private void MarcarBotaoSelecionado(Button botaoSelecionado)
        {
            // Cor padrão dos botões.
            Color corPadrao = Color.FromArgb(20, 59, 102);

            // Cor do botão selecionado.
            Color corSelecionada = Color.FromArgb(30, 100, 170);

            btnDashboard.BackColor = corPadrao;
            btnEstoque.BackColor = corPadrao;
            btnEventos.BackColor = corPadrao;
            btnRetorno.BackColor = corPadrao;
            btnHistorico.BackColor = corPadrao;

            botaoSelecionado.BackColor = corSelecionada;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblTituloPagina.Text = "Menu Principal";

            MarcarBotaoSelecionado(btnDashboard);
        }

        public frmPrincipal(string usuarioDoLogin)
        {
            InitializeComponent();
            _usuarioLogado = usuarioDoLogin; //Escopo local


            lblUsuario.Text = "Bem vindo " + _usuarioLogado + "!";

        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque tela = new frmEstoque();
            tela.Show();
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            frmEventos tela = new frmEventos();
            tela.Show();
        }

        private void btnRetorno_Click(object sender, EventArgs e)
        {
            var form = new frmRetorno();
            form.ShowDialog();
        }
    }
}
