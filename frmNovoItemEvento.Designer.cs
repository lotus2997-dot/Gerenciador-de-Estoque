namespace Drink
{
    partial class frmNovoItemEvento
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
            gbTipoItem = new GroupBox();
            rdbItemExterno = new RadioButton();
            rdbItemEstoque = new RadioButton();
            label1 = new Label();
            cmbItensEstoque = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtNomeExterno = new TextBox();
            txtCategoriaExterna = new TextBox();
            txtUnidadeExterna = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            nudQuantidade = new NumericUpDown();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            gbTipoItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            SuspendLayout();
            // 
            // gbTipoItem
            // 
            gbTipoItem.Controls.Add(rdbItemExterno);
            gbTipoItem.Controls.Add(rdbItemEstoque);
            gbTipoItem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbTipoItem.Location = new Point(3, 58);
            gbTipoItem.Name = "gbTipoItem";
            gbTipoItem.Size = new Size(200, 100);
            gbTipoItem.TabIndex = 0;
            gbTipoItem.TabStop = false;
            gbTipoItem.Text = "Tipo do item :";
            // 
            // rdbItemExterno
            // 
            rdbItemExterno.AutoSize = true;
            rdbItemExterno.Location = new Point(20, 60);
            rdbItemExterno.Name = "rdbItemExterno";
            rdbItemExterno.Size = new Size(105, 21);
            rdbItemExterno.TabIndex = 1;
            rdbItemExterno.TabStop = true;
            rdbItemExterno.Text = "Item externo";
            rdbItemExterno.UseVisualStyleBackColor = true;
            rdbItemExterno.CheckedChanged += rdbItemExterno_CheckedChanged;
            // 
            // rdbItemEstoque
            // 
            rdbItemEstoque.AutoSize = true;
            rdbItemEstoque.Location = new Point(20, 35);
            rdbItemEstoque.Name = "rdbItemEstoque";
            rdbItemEstoque.Size = new Size(127, 21);
            rdbItemEstoque.TabIndex = 0;
            rdbItemEstoque.TabStop = true;
            rdbItemEstoque.Text = "Item do estoque";
            rdbItemEstoque.UseVisualStyleBackColor = true;
            rdbItemEstoque.CheckedChanged += rdbItemEstoque_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 21);
            label1.TabIndex = 1;
            label1.Text = "Novo item do Evento";
            // 
            // cmbItensEstoque
            // 
            cmbItensEstoque.FormattingEnabled = true;
            cmbItensEstoque.Location = new Point(3, 195);
            cmbItensEstoque.Name = "cmbItensEstoque";
            cmbItensEstoque.Size = new Size(246, 23);
            cmbItensEstoque.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 177);
            label2.Name = "label2";
            label2.Size = new Size(116, 17);
            label2.TabIndex = 3;
            label2.Text = "Item do estoque :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 253);
            label3.Name = "label3";
            label3.Size = new Size(94, 17);
            label3.TabIndex = 4;
            label3.Text = "Item externo :";
            // 
            // txtNomeExterno
            // 
            txtNomeExterno.Location = new Point(69, 273);
            txtNomeExterno.Name = "txtNomeExterno";
            txtNomeExterno.Size = new Size(224, 23);
            txtNomeExterno.TabIndex = 5;
            // 
            // txtCategoriaExterna
            // 
            txtCategoriaExterna.Location = new Point(69, 302);
            txtCategoriaExterna.Name = "txtCategoriaExterna";
            txtCategoriaExterna.Size = new Size(224, 23);
            txtCategoriaExterna.TabIndex = 6;
            // 
            // txtUnidadeExterna
            // 
            txtUnidadeExterna.Location = new Point(69, 331);
            txtUnidadeExterna.Name = "txtUnidadeExterna";
            txtUnidadeExterna.Size = new Size(224, 23);
            txtUnidadeExterna.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(-1, 281);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(-1, 310);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(-1, 339);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Unidade :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 391);
            label7.Name = "label7";
            label7.Size = new Size(86, 17);
            label7.TabIndex = 11;
            label7.Text = "Quantidade :";
            // 
            // nudQuantidade
            // 
            nudQuantidade.Location = new Point(3, 411);
            nudQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(237, 23);
            nudQuantidade.TabIndex = 12;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(23, 478);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(129, 41);
            btnAdicionar.TabIndex = 13;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(205, 478);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(129, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmNovoItemEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 584);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(nudQuantidade);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtUnidadeExterna);
            Controls.Add(txtCategoriaExterna);
            Controls.Add(txtNomeExterno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbItensEstoque);
            Controls.Add(label1);
            Controls.Add(gbTipoItem);
            Name = "frmNovoItemEvento";
            Text = "frmNovoItemEvento";
            Load += frmNovoItemEvento_Load;
            gbTipoItem.ResumeLayout(false);
            gbTipoItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbTipoItem;
        private RadioButton rdbItemExterno;
        private RadioButton rdbItemEstoque;
        private Label label1;
        private ComboBox cmbItensEstoque;
        private Label label2;
        private Label label3;
        private TextBox txtNomeExterno;
        private TextBox txtCategoriaExterna;
        private TextBox txtUnidadeExterna;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private NumericUpDown nudQuantidade;
        private Button btnAdicionar;
        private Button btnCancelar;
    }
}