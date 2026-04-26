namespace Drink
{
    partial class frmEstoque
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            nudQuantidade = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            dtpValidade = new DateTimePicker();
            txtNome = new TextBox();
            cmbCategoria = new ComboBox();
            btnRemover = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            dgvEstoque = new DataGridView();
            panel3 = new Panel();
            label7 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(19, 55, 99);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1392, 100);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(50, 32);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 3;
            label1.Text = "Estoque";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 55, 99);
            panel1.Controls.Add(nudQuantidade);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dtpValidade);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(cmbCategoria);
            panel1.Controls.Add(btnRemover);
            panel1.Controls.Add(btnAtualizar);
            panel1.Controls.Add(btnAdicionar);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 705);
            panel1.TabIndex = 2;
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(12, 151);
            nudQuantidade.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(211, 23);
            nudQuantidade.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 8;
            label3.Text = "Quantidade :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 195);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Validade :";
            // 
            // dtpValidade
            // 
            dtpValidade.CalendarTitleForeColor = Color.AntiqueWhite;
            dtpValidade.Location = new Point(12, 213);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(211, 23);
            dtpValidade.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 57);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(211, 23);
            txtNome.TabIndex = 5;
            txtNome.Text = "Nome";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Ingrdientes ", "Utensílios" });
            cmbCategoria.Location = new Point(12, 86);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(211, 23);
            cmbCategoria.TabIndex = 4;
            cmbCategoria.Text = "Categoria";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(119, 28);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(104, 23);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(12, 242);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(101, 23);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 28);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(101, 23);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoque.BackgroundColor = Color.White;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(229, 100);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(1163, 653);
            dgvEstoque.TabIndex = 3;
            dgvEstoque.CellClick += dgvEstoque_CellClick;
            dgvEstoque.CellContentClick += dgvEstoque_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(229, 756);
            panel3.Name = "panel3";
            panel3.Size = new Size(1163, 49);
            panel3.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(601, 32);
            label7.Name = "label7";
            label7.Size = new Size(318, 15);
            label7.TabIndex = 9;
            label7.Text = "(Back end)  Fazer barra de pesquisa para os produtos aqui!!!";
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 805);
            Controls.Add(panel3);
            Controls.Add(dgvEstoque);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmEstoque";
            Text = "frmEstoque";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private ComboBox cmbCategoria;
        private Button btnRemover;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private DataGridView dgvEstoque;
        private TextBox txtNome;
        private DateTimePicker dtpValidade;
        private Label label2;
        private NumericUpDown nudQuantidade;
        private Label label3;
        private Panel panel3;
        private Label label7;
    }
}