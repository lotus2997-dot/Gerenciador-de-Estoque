namespace Drink
{
    partial class frmHistorico
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Histórico de Eventos";

            Panel barraTopo = new Panel();
            barraTopo.BackColor = Color.FromArgb(28, 64, 107);
            barraTopo.Dock = DockStyle.Top;
            barraTopo.Height = 80;

            this.Controls.Add(barraTopo);

            Panel menuLateral = new Panel();
            menuLateral.BackColor = Color.FromArgb(28, 64, 107);
            menuLateral.Dock = DockStyle.Left;
            menuLateral.Width = 170;

            this.Controls.Add(menuLateral);

            Label titulo = new Label();
            titulo.Text = "Histórico de Eventos";
            titulo.ForeColor = Color.White;
            titulo.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            titulo.AutoSize = true;
            titulo.Location = new Point(20, 25);

            barraTopo.Controls.Add(titulo);
        }

        #endregion

        
        }
    }

    
