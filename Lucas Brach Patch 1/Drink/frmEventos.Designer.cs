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
            panel2 = new Panel();
            label1 = new Label();
            dgvEstoque = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Quantidade = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Validade = new DataGridViewTextBoxColumn();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            btnRemoverEstoque = new Button();
            btnAdicionarEstoque = new Button();
            txtNome = new TextBox();
            cbxCategoriaEstoque = new ComboBox();
            btnAtualizarEstoque = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(200, 519);
            panel1.TabIndex = 27;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(736, 94);
            panel2.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(122, 34);
            label1.TabIndex = 19;
            label1.Text = "Evento";
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = SystemColors.Control;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Quantidade, Categoria, Validade });
            dgvEstoque.Location = new Point(196, 94);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(542, 518);
            dgvEstoque.TabIndex = 25;
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
            // button1
            // 
            button1.Location = new Point(91, 159);
            button1.Name = "button1";
            button1.Size = new Size(81, 20);
            button1.TabIndex = 27;
            button1.Text = "Transferir";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 127);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(160, 23);
            dateTimePicker1.TabIndex = 26;
            // 
            // btnRemoverEstoque
            // 
            btnRemoverEstoque.Location = new Point(91, 40);
            btnRemoverEstoque.Name = "btnRemoverEstoque";
            btnRemoverEstoque.Size = new Size(81, 23);
            btnRemoverEstoque.TabIndex = 22;
            btnRemoverEstoque.Text = "Remover";
            btnRemoverEstoque.UseVisualStyleBackColor = true;
            btnRemoverEstoque.Visible = false;
            // 
            // btnAdicionarEstoque
            // 
            btnAdicionarEstoque.Location = new Point(12, 40);
            btnAdicionarEstoque.Name = "btnAdicionarEstoque";
            btnAdicionarEstoque.Size = new Size(73, 23);
            btnAdicionarEstoque.TabIndex = 21;
            btnAdicionarEstoque.Text = "Adicionar";
            btnAdicionarEstoque.UseVisualStyleBackColor = true;
            btnAdicionarEstoque.Visible = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(160, 23);
            txtNome.TabIndex = 25;
            txtNome.Text = "Nome";
            txtNome.Visible = false;
            // 
            // cbxCategoriaEstoque
            // 
            cbxCategoriaEstoque.FormattingEnabled = true;
            cbxCategoriaEstoque.Location = new Point(12, 98);
            cbxCategoriaEstoque.Name = "cbxCategoriaEstoque";
            cbxCategoriaEstoque.Size = new Size(160, 23);
            cbxCategoriaEstoque.TabIndex = 23;
            cbxCategoriaEstoque.Text = "Categoria";
            cbxCategoriaEstoque.Visible = false;
            // 
            // btnAtualizarEstoque
            // 
            btnAtualizarEstoque.Location = new Point(12, 156);
            btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            btnAtualizarEstoque.Size = new Size(73, 23);
            btnAtualizarEstoque.TabIndex = 24;
            btnAtualizarEstoque.Text = "Atualizar";
            btnAtualizarEstoque.UseVisualStyleBackColor = true;
            btnAtualizarEstoque.Visible = false;
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 613);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(dgvEstoque);
            Name = "frmEventos";
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        internal DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Quantidade;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Validade;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Button btnRemoverEstoque;
        private Button btnAdicionarEstoque;
        private TextBox txtNome;
        private ComboBox cbxCategoriaEstoque;
        private Button btnAtualizarEstoque;
    }
}