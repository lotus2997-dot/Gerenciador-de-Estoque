namespace Drink
{
    partial class frmEventos
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
            panel1 = new Panel();
            cmbUnidade = new ComboBox();
            label6 = new Label();
            dtpValidade = new DateTimePicker();
            panel5 = new Panel();
            label5 = new Label();
            label4 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            cmbIngrediente = new ComboBox();
            label2 = new Label();
            nudQuantidade = new NumericUpDown();
            btnRemover = new Button();
            btnRetirarEstoque = new Button();
            btnTransferirRetorno = new Button();
            btnAdicionar = new Button();
            dgvEvento = new DataGridView();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEvento).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 55, 99);
            panel1.Controls.Add(cmbUnidade);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtpValidade);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbIngrediente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nudQuantidade);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(203, 724);
            panel1.TabIndex = 5;
            // 
            // cmbUnidade
            // 
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(12, 73);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(163, 23);
            cmbUnidade.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(12, 111);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 15;
            label6.Text = "Validade :";
            // 
            // dtpValidade
            // 
            dtpValidade.Location = new Point(12, 129);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(163, 23);
            dtpValidade.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(19, 55, 99);
            panel5.ForeColor = Color.FromArgb(19, 55, 99);
            panel5.Location = new Point(0, 674);
            panel5.Name = "panel5";
            panel5.Size = new Size(203, 50);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(12, 55);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 13;
            label5.Text = "Unidade :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(12, 3);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 11;
            label4.Text = "Nome :";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 21);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(163, 23);
            txtNome.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 165);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Estoque :";
            // 
            // cmbIngrediente
            // 
            cmbIngrediente.FormattingEnabled = true;
            cmbIngrediente.Location = new Point(12, 183);
            cmbIngrediente.Name = "cmbIngrediente";
            cmbIngrediente.Size = new Size(163, 23);
            cmbIngrediente.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 218);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 7;
            label2.Text = "Quantidade :";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(12, 236);
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(166, 23);
            nudQuantidade.TabIndex = 6;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.LightGray;
            btnRemover.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.FromArgb(50, 80, 150);
            btnRemover.ImageAlign = ContentAlignment.MiddleLeft;
            btnRemover.Location = new Point(141, 8);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(97, 34);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnRetirarEstoque
            // 
            btnRetirarEstoque.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnRetirarEstoque.FlatStyle = FlatStyle.Flat;
            btnRetirarEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRetirarEstoque.ForeColor = Color.FromArgb(50, 80, 150);
            btnRetirarEstoque.Location = new Point(253, 8);
            btnRetirarEstoque.Name = "btnRetirarEstoque";
            btnRetirarEstoque.Size = new Size(143, 34);
            btnRetirarEstoque.TabIndex = 2;
            btnRetirarEstoque.Text = "Retirar do estoque";
            btnRetirarEstoque.UseVisualStyleBackColor = true;
            btnRetirarEstoque.Click += btnRetirarEstoque_Click;
            // 
            // btnTransferirRetorno
            // 
            btnTransferirRetorno.FlatAppearance.BorderColor = Color.FromArgb(50, 80, 150);
            btnTransferirRetorno.FlatStyle = FlatStyle.Flat;
            btnTransferirRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransferirRetorno.ForeColor = Color.FromArgb(50, 80, 150);
            btnTransferirRetorno.Location = new Point(411, 8);
            btnTransferirRetorno.Name = "btnTransferirRetorno";
            btnTransferirRetorno.Size = new Size(75, 34);
            btnTransferirRetorno.TabIndex = 1;
            btnTransferirRetorno.Text = "Retornar";
            btnTransferirRetorno.UseVisualStyleBackColor = true;
            btnTransferirRetorno.Click += btnTransferirRetorno_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.Orange;
            btnAdicionar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAdicionar.FlatAppearance.BorderSize = 0;
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdicionar.Location = new Point(26, 8);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(109, 34);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvEvento
            // 
            dgvEvento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvento.BackgroundColor = Color.White;
            dgvEvento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEvento.Location = new Point(200, 78);
            dgvEvento.Name = "dgvEvento";
            dgvEvento.Size = new Size(1084, 676);
            dgvEvento.TabIndex = 6;
            dgvEvento.CellContentClick += dgvEvento_CellContentClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 55, 99);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 103);
            panel2.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 1;
            label1.Text = "Eventos";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRetirarEstoque);
            panel3.Controls.Add(btnTransferirRetorno);
            panel3.Controls.Add(btnRemover);
            panel3.Controls.Add(btnAdicionar);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(203, 752);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 50);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(19, 55, 99);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1284, 78);
            panel4.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(588, 35);
            label7.Name = "label7";
            label7.Size = new Size(318, 15);
            label7.TabIndex = 8;
            label7.Text = "(Back end)  Fazer barra de pesquisa para os produtos aqui!!!";
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1284, 802);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(dgvEvento);
            Name = "frmEventos";
            Text = "Form4";
            Load += frmEventos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEvento).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnRemover;
        private Button btnRetirarEstoque;
        private Button btnTransferirRetorno;
        private Button btnAdicionar;
        private NumericUpDown nudQuantidade;
        private Label label2;
        private DataGridView dgvEvento;
        private Label label3;
        private ComboBox cmbIngrediente;
        private TextBox txtNome;
        private Label label4;
        private Label label6;
        private DateTimePicker dtpValidade;
        private Label label5;
        private ComboBox cmbUnidade;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label label7;
        private Panel panel5;
    }
}