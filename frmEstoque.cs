using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Drink.Models;

namespace Drink
{
    public partial class frmEstoque : Form
    {

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            frmAdicionarEstoque telaCadastro = new frmAdicionarEstoque();
            telaCadastro.ShowDialog();
        }
    }
}