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
    public partial class FRM_ADICIONAR : Form
    {
        public FRM_ADICIONAR()
        {
            InitializeComponent();
        }

        private void btnFecharAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FRM_PAINEL frmP = new FRM_PAINEL();
            frmP.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FRM_ADDGRID fAddGrdid = new FRM_ADDGRID(this);
            fAddGrdid.ShowDialog();
        }

        private void FRM_ADICIONAR_Load(object sender, EventArgs e)
        {

        }
    }
}
