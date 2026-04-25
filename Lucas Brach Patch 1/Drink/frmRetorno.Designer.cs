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
            panel2 = new Panel();
            label1 = new Label();
            dgvEstoque = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Validade = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnRemoverEstoque = new Button();
            btnAdicionarEstoque = new Button();
            txtNome = new TextBox();
            cbxCategoriaEstoque = new ComboBox();
            btnAtualizarEstoque = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(738, 94);
            panel2.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(33, 21);
            label1.Name = "label1";
            label1.Size = new Size(139, 34);
            label1.TabIndex = 19;
            label1.Text = "Retorno";
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = SystemColors.Control;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Quantidade, Categoria, Validade });
            dgvEstoque.Location = new Point(196, 94);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(542, 536);
            dgvEstoque.TabIndex = 21;
            dgvEstoque.Visible = false;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.Name = "Nome";
            // 
            // Quantidade
            // 
            Quantidade.HeaderText = "Quantidade";
            Quantidade.Name = "Quantidade";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Validade
            // 
            Validade.HeaderText = "Validade";
            Validade.Name = "Validade";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(btnRemoverEstoque);
            panel1.Controls.Add(btnAdicionarEstoque);
            panel1.Controls.Add(txtNome);
            panel1.Controls.Add(cbxCategoriaEstoque);
            panel1.Controls.Add(btnAtualizarEstoque);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 536);
            panel1.TabIndex = 24;
            // 
            // button1
            // 
            button1.Location = new Point(91, 162);
            button1.Name = "button1";
            button1.Size = new Size(81, 20);
            button1.TabIndex = 34;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 33;
            // 
            // btnRemoverEstoque
            // 
            btnRemoverEstoque.Location = new Point(91, 43);
            btnRemoverEstoque.Name = "btnRemoverEstoque";
            btnRemoverEstoque.Size = new Size(81, 23);
            btnRemoverEstoque.TabIndex = 29;
            btnRemoverEstoque.Text = "Remover";
            btnRemoverEstoque.UseVisualStyleBackColor = true;
            btnRemoverEstoque.Visible = false;
            // 
            // btnAdicionarEstoque
            // 
            btnAdicionarEstoque.Location = new Point(12, 43);
            btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            btnAdicionarEstoque.Size = new Size(73, 23);
            btnAdicionarEstoque.TabIndex = 28;
            btnAdicionarEstoque.Text = "Adicionar";
            btnAdicionarEstoque.UseVisualStyleBackColor = true;
            btnAdicionarEstoque.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 72);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(160, 23);
            txtNome.TabIndex = 32;
            txtNome.Text = "Nome";
            txtNome.Visible = false;
            // 
            // cbxCategoriaEstoque
            // 
            cbxCategoriaEstoque.FormattingEnabled = true;
            cbxCategoriaEstoque.Location = new Point(12, 101);
            cbxCategoriaEstoque.Name = "cbxCategoriaEstoque";
            cbxCategoriaEstoque.Size = new Size(160, 23);
            cbxCategoriaEstoque.TabIndex = 30;
            cbxCategoriaEstoque.Text = "Categoria";
            cbxCategoriaEstoque.Visible = false;
            // 
            // btnAtualizarEstoque
            // 
            btnAtualizarEstoque.Location = new Point(12, 159);
            btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            btnAtualizarEstoque.Size = new Size(73, 23);
            btnAtualizarEstoque.TabIndex = 31;
            btnAtualizarEstoque.Text = "Atualizar";
            btnAtualizarEstoque.UseVisualStyleBackColor = true;
            btnAtualizarEstoque.Visible = false;
            // 
            // frmRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 630);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvEstoque);
            Name = "frmRetorno";
            Text = "Form5";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label1;
        internal DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Validade;
        private Panel panel1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button btnRemoverEstoque;
        private Button btnAdicionarEstoque;
        private TextBox txtNome;
        private ComboBox cbxCategoriaEstoque;
        private Button btnAtualizarEstoque;
    }
}