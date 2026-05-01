namespace Drink
{
    partial class frmRetorno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvRetorno = new DataGridView();
            panel1 = new Panel();
            cmbUnidade = new ComboBox();
            label7 = new Label();
            dtpValidade = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            btnRemover = new Button();
            btnAdicionar = new Button();
            label4 = new Label();
            label3 = new Label();
            nudQuantidade = new NumericUpDown();
            btnConfirmar = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRetorno).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvRetorno
            // 
            dgvRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRetorno.BackgroundColor = Color.White;
            dgvRetorno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRetorno.Location = new Point(182, 99);
            dgvRetorno.Name = "dgvRetorno";
            dgvRetorno.Size = new Size(1139, 655);
            dgvRetorno.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 55, 99);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnAdicionar);
            panel1.Controls.Add(cmbUnidade);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dtpValidade);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(nudQuantidade);
            panel1.Controls.Add(btnConfirmar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 707);
            panel1.TabIndex = 5;
            // 
            // cmbUnidade
            // 
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(10, 84);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(168, 23);
            cmbUnidade.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(10, 122);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "Validade :";
            // 
            // dtpValidade
            // 
            dtpValidade.Location = new Point(10, 140);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(162, 23);
            dtpValidade.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(10, 66);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Unidade :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 13);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 12;
            label5.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(10, 31);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(168, 23);
            txtNome.TabIndex = 11;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(97, 243);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 31);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(10, 243);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 31);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 277);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 8;
            label4.Text = "Transferir itens :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 183);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade :";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(10, 201);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(166, 23);
            nudQuantidade.TabIndex = 5;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(10, 295);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(168, 23);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 55, 99);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1321, 99);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(37, 27);
            label1.Name = "label1";
            label1.Size = new Size(121, 37);
            label1.TabIndex = 3;
            label1.Text = "Retorno";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(183, 752);
            panel3.Name = "panel3";
            panel3.Size = new Size(1138, 54);
            panel3.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(554, 45);
            label2.Name = "label2";
            label2.Size = new Size(318, 15);
            label2.TabIndex = 9;
            label2.Text = "(Back end)  Fazer barra de pesquisa para os produtos aqui!!!";
            // 
            // frmRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 806);
            Controls.Add(panel3);
            Controls.Add(dgvRetorno);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmRetorno";
            Text = "Retorno";
            ((System.ComponentModel.ISupportInitialize)dgvRetorno).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRetorno;
        private Panel panel1;
        private Button btnConfirmar;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private NumericUpDown nudQuantidade;
        private Label label4;
        private Button btnRemover;
        private Button btnAdicionar;
        private Label label5;
        private TextBox txtNome;
        private DateTimePicker dtpValidade;
        private Label label6;
        private Label label7;
        private ComboBox cmbUnidade;
        private Panel panel3;
        private Label label2;
    }
}