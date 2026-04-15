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
    public partial class FRM_ADDGRID : Form
    {
        FRM_ADICIONAR fgrid;
        public FRM_ADDGRID (FRM_ADICIONAR fg)
        {
            InitializeComponent();
            this.fgrid = fg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fgrid.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
