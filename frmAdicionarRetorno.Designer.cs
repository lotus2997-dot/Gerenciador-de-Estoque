namespace Drink
{
    partial class frmAdicionarRetorno
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
            btnLimparRetorno = new Button();
            btnCancelarRetorno = new Button();
            btnAdicionarRetorno = new Button();
            grpDadosItemRetorno = new GroupBox();
            lblQuantidadeRetorno = new Label();
            txtObservacaoRetorno = new TextBox();
            lblObservacaoRetorno = new Label();
            dtpValidadeRetorno = new DateTimePicker();
            lblValidadeRetorno = new Label();
            nudQuantidadeRetorno = new NumericUpDown();
            lblItemEventoRetorno = new Label();
            txtUnidadeExternaRetorno = new ComboBox();
            cmbItensEstoqueRetorno = new ComboBox();
            lblUnidadeRetorno = new Label();
            txtCategoriaExternaRetorno = new ComboBox();
            lblCategoriaRetorno = new Label();
            txtNomeExternoRetorno = new TextBox();
            lblNomeRetorno = new Label();
            pnlCabecalhoRetorno = new Panel();
            lblTituloRetorno = new Label();
            label1 = new Label();
            gbTipoItemRetorno = new GroupBox();
            rdbItemExternoRetorno = new RadioButton();
            rdbItemEventoRetorno = new RadioButton();
            grpDadosItemRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeRetorno).BeginInit();
            pnlCabecalhoRetorno.SuspendLayout();
            gbTipoItemRetorno.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimparRetorno
            // 
            btnLimparRetorno.BackColor = Color.WhiteSmoke;
            btnLimparRetorno.FlatStyle = FlatStyle.Flat;
            btnLimparRetorno.Location = new Point(174, 369);
            btnLimparRetorno.Name = "btnLimparRetorno";
            btnLimparRetorno.Size = new Size(120, 35);
            btnLimparRetorno.TabIndex = 28;
            btnLimparRetorno.Text = "Limpar";
            btnLimparRetorno.UseVisualStyleBackColor = false;
            // 
            // btnCancelarRetorno
            // 
            btnCancelarRetorno.BackColor = Color.WhiteSmoke;
            btnCancelarRetorno.FlatStyle = FlatStyle.Flat;
            btnCancelarRetorno.Location = new Point(317, 369);
            btnCancelarRetorno.Name = "btnCancelarRetorno";
            btnCancelarRetorno.Size = new Size(120, 35);
            btnCancelarRetorno.TabIndex = 27;
            btnCancelarRetorno.Text = "Cancelar";
            btnCancelarRetorno.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarRetorno
            // 
            btnAdicionarRetorno.BackColor = Color.FromArgb(20, 59, 102);
            btnAdicionarRetorno.FlatStyle = FlatStyle.Flat;
            btnAdicionarRetorno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarRetorno.ForeColor = Color.White;
            btnAdicionarRetorno.Location = new Point(32, 369);
            btnAdicionarRetorno.Name = "btnAdicionarRetorno";
            btnAdicionarRetorno.Size = new Size(120, 35);
            btnAdicionarRetorno.TabIndex = 26;
            btnAdicionarRetorno.Text = "Salvar";
            btnAdicionarRetorno.UseVisualStyleBackColor = false;
            btnAdicionarRetorno.Click += btnAdicionarRetorno_Click;
            // 
            // grpDadosItemRetorno
            // 
            grpDadosItemRetorno.Controls.Add(lblQuantidadeRetorno);
            grpDadosItemRetorno.Controls.Add(txtObservacaoRetorno);
            grpDadosItemRetorno.Controls.Add(lblObservacaoRetorno);
            grpDadosItemRetorno.Controls.Add(dtpValidadeRetorno);
            grpDadosItemRetorno.Controls.Add(lblValidadeRetorno);
            grpDadosItemRetorno.Controls.Add(nudQuantidadeRetorno);
            grpDadosItemRetorno.Controls.Add(lblItemEventoRetorno);
            grpDadosItemRetorno.Controls.Add(txtUnidadeExternaRetorno);
            grpDadosItemRetorno.Controls.Add(cmbItensEstoqueRetorno);
            grpDadosItemRetorno.Controls.Add(lblUnidadeRetorno);
            grpDadosItemRetorno.Controls.Add(txtCategoriaExternaRetorno);
            grpDadosItemRetorno.Controls.Add(lblCategoriaRetorno);
            grpDadosItemRetorno.Controls.Add(txtNomeExternoRetorno);
            grpDadosItemRetorno.Controls.Add(lblNomeRetorno);
            grpDadosItemRetorno.Location = new Point(12, 105);
            grpDadosItemRetorno.Name = "grpDadosItemRetorno";
            grpDadosItemRetorno.Size = new Size(740, 230);
            grpDadosItemRetorno.TabIndex = 24;
            grpDadosItemRetorno.TabStop = false;
            grpDadosItemRetorno.Text = "Dados do Item";
            // 
            // lblQuantidadeRetorno
            // 
            lblQuantidadeRetorno.AutoSize = true;
            lblQuantidadeRetorno.Location = new Point(290, 140);
            lblQuantidadeRetorno.Name = "lblQuantidadeRetorno";
            lblQuantidadeRetorno.Size = new Size(72, 15);
            lblQuantidadeRetorno.TabIndex = 15;
            lblQuantidadeRetorno.Text = "Quantidade:";
            // 
            // txtObservacaoRetorno
            // 
            txtObservacaoRetorno.Location = new Point(524, 50);
            txtObservacaoRetorno.Multiline = true;
            txtObservacaoRetorno.Name = "txtObservacaoRetorno";
            txtObservacaoRetorno.Size = new Size(198, 133);
            txtObservacaoRetorno.TabIndex = 14;
            // 
            // lblObservacaoRetorno
            // 
            lblObservacaoRetorno.AutoSize = true;
            lblObservacaoRetorno.Location = new Point(524, 30);
            lblObservacaoRetorno.Name = "lblObservacaoRetorno";
            lblObservacaoRetorno.Size = new Size(72, 15);
            lblObservacaoRetorno.TabIndex = 13;
            lblObservacaoRetorno.Text = "Observação:";
            // 
            // dtpValidadeRetorno
            // 
            dtpValidadeRetorno.Format = DateTimePickerFormat.Short;
            dtpValidadeRetorno.Location = new Point(290, 105);
            dtpValidadeRetorno.Name = "dtpValidadeRetorno";
            dtpValidadeRetorno.Size = new Size(210, 23);
            dtpValidadeRetorno.TabIndex = 11;
            // 
            // lblValidadeRetorno
            // 
            lblValidadeRetorno.AutoSize = true;
            lblValidadeRetorno.Location = new Point(290, 85);
            lblValidadeRetorno.Name = "lblValidadeRetorno";
            lblValidadeRetorno.Size = new Size(54, 15);
            lblValidadeRetorno.TabIndex = 10;
            lblValidadeRetorno.Text = "Validade:";
            // 
            // nudQuantidadeRetorno
            // 
            nudQuantidadeRetorno.DecimalPlaces = 2;
            nudQuantidadeRetorno.Location = new Point(290, 160);
            nudQuantidadeRetorno.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidadeRetorno.Name = "nudQuantidadeRetorno";
            nudQuantidadeRetorno.Size = new Size(210, 23);
            nudQuantidadeRetorno.TabIndex = 6;
            // 
            // lblItemEventoRetorno
            // 
            lblItemEventoRetorno.AutoSize = true;
            lblItemEventoRetorno.Font = new Font("Segoe UI", 9F);
            lblItemEventoRetorno.Location = new Point(290, 30);
            lblItemEventoRetorno.Name = "lblItemEventoRetorno";
            lblItemEventoRetorno.Size = new Size(93, 15);
            lblItemEventoRetorno.TabIndex = 3;
            lblItemEventoRetorno.Text = "Item do evento :";
            // 
            // txtUnidadeExternaRetorno
            // 
            txtUnidadeExternaRetorno.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnidadeExternaRetorno.FormattingEnabled = true;
            txtUnidadeExternaRetorno.Location = new Point(20, 160);
            txtUnidadeExternaRetorno.Name = "txtUnidadeExternaRetorno";
            txtUnidadeExternaRetorno.Size = new Size(240, 23);
            txtUnidadeExternaRetorno.TabIndex = 5;
            // 
            // cmbItensEstoqueRetorno
            // 
            cmbItensEstoqueRetorno.FormattingEnabled = true;
            cmbItensEstoqueRetorno.Location = new Point(290, 50);
            cmbItensEstoqueRetorno.Name = "cmbItensEstoqueRetorno";
            cmbItensEstoqueRetorno.Size = new Size(210, 23);
            cmbItensEstoqueRetorno.TabIndex = 2;
            // 
            // lblUnidadeRetorno
            // 
            lblUnidadeRetorno.AutoSize = true;
            lblUnidadeRetorno.Location = new Point(20, 140);
            lblUnidadeRetorno.Name = "lblUnidadeRetorno";
            lblUnidadeRetorno.Size = new Size(54, 15);
            lblUnidadeRetorno.TabIndex = 4;
            lblUnidadeRetorno.Text = "Unidade:";
            // 
            // txtCategoriaExternaRetorno
            // 
            txtCategoriaExternaRetorno.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategoriaExternaRetorno.FormattingEnabled = true;
            txtCategoriaExternaRetorno.Location = new Point(20, 105);
            txtCategoriaExternaRetorno.Name = "txtCategoriaExternaRetorno";
            txtCategoriaExternaRetorno.Size = new Size(240, 23);
            txtCategoriaExternaRetorno.TabIndex = 3;
            // 
            // lblCategoriaRetorno
            // 
            lblCategoriaRetorno.AutoSize = true;
            lblCategoriaRetorno.Location = new Point(20, 85);
            lblCategoriaRetorno.Name = "lblCategoriaRetorno";
            lblCategoriaRetorno.Size = new Size(61, 15);
            lblCategoriaRetorno.TabIndex = 2;
            lblCategoriaRetorno.Text = "Categoria:";
            // 
            // txtNomeExternoRetorno
            // 
            txtNomeExternoRetorno.Location = new Point(20, 50);
            txtNomeExternoRetorno.Name = "txtNomeExternoRetorno";
            txtNomeExternoRetorno.Size = new Size(240, 23);
            txtNomeExternoRetorno.TabIndex = 1;
            // 
            // lblNomeRetorno
            // 
            lblNomeRetorno.AutoSize = true;
            lblNomeRetorno.Location = new Point(20, 30);
            lblNomeRetorno.Name = "lblNomeRetorno";
            lblNomeRetorno.Size = new Size(43, 15);
            lblNomeRetorno.TabIndex = 0;
            lblNomeRetorno.Text = "Nome:";
            // 
            // pnlCabecalhoRetorno
            // 
            pnlCabecalhoRetorno.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalhoRetorno.Controls.Add(lblTituloRetorno);
            pnlCabecalhoRetorno.Dock = DockStyle.Top;
            pnlCabecalhoRetorno.Location = new Point(0, 0);
            pnlCabecalhoRetorno.Name = "pnlCabecalhoRetorno";
            pnlCabecalhoRetorno.Size = new Size(789, 60);
            pnlCabecalhoRetorno.TabIndex = 23;
            // 
            // lblTituloRetorno
            // 
            lblTituloRetorno.AutoSize = true;
            lblTituloRetorno.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRetorno.ForeColor = Color.White;
            lblTituloRetorno.Location = new Point(25, 17);
            lblTituloRetorno.Name = "lblTituloRetorno";
            lblTituloRetorno.Size = new Size(287, 31);
            lblTituloRetorno.TabIndex = 0;
            lblTituloRetorno.Text = "Cadastro / Edição de Item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 22;
            label1.Text = "Novo item do Retorno";
            // 
            // gbTipoItemRetorno
            // 
            gbTipoItemRetorno.Controls.Add(rdbItemExternoRetorno);
            gbTipoItemRetorno.Controls.Add(rdbItemEventoRetorno);
            gbTipoItemRetorno.Font = new Font("Segoe UI", 9F);
            gbTipoItemRetorno.Location = new Point(473, 351);
            gbTipoItemRetorno.Name = "gbTipoItemRetorno";
            gbTipoItemRetorno.Size = new Size(279, 53);
            gbTipoItemRetorno.TabIndex = 21;
            gbTipoItemRetorno.TabStop = false;
            gbTipoItemRetorno.Text = "Tipo do item :";
            // 
            // rdbItemExternoRetorno
            // 
            rdbItemExternoRetorno.AutoSize = true;
            rdbItemExternoRetorno.Font = new Font("Segoe UI", 9F);
            rdbItemExternoRetorno.Location = new Point(156, 24);
            rdbItemExternoRetorno.Name = "rdbItemExternoRetorno";
            rdbItemExternoRetorno.Size = new Size(91, 19);
            rdbItemExternoRetorno.TabIndex = 1;
            rdbItemExternoRetorno.TabStop = true;
            rdbItemExternoRetorno.Text = "Item externo";
            rdbItemExternoRetorno.UseVisualStyleBackColor = true;
            rdbItemExternoRetorno.CheckedChanged += rdbItemExternoRetorno_CheckedChanged;
            // 
            // rdbItemEventoRetorno
            // 
            rdbItemEventoRetorno.AutoSize = true;
            rdbItemEventoRetorno.Font = new Font("Segoe UI", 9F);
            rdbItemEventoRetorno.Location = new Point(13, 24);
            rdbItemEventoRetorno.Name = "rdbItemEventoRetorno";
            rdbItemEventoRetorno.Size = new Size(105, 19);
            rdbItemEventoRetorno.TabIndex = 0;
            rdbItemEventoRetorno.TabStop = true;
            rdbItemEventoRetorno.Text = "Item do Evento";
            rdbItemEventoRetorno.UseVisualStyleBackColor = true;
            rdbItemEventoRetorno.CheckedChanged += rdbItemEventoRetorno_CheckedChanged;
            // 
            // frmAdicionarRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 461);
            Controls.Add(btnLimparRetorno);
            Controls.Add(btnCancelarRetorno);
            Controls.Add(btnAdicionarRetorno);
            Controls.Add(grpDadosItemRetorno);
            Controls.Add(pnlCabecalhoRetorno);
            Controls.Add(label1);
            Controls.Add(gbTipoItemRetorno);
            Name = "frmAdicionarRetorno";
            Text = "frmAdicionarRetorno";
            grpDadosItemRetorno.ResumeLayout(false);
            grpDadosItemRetorno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeRetorno).EndInit();
            pnlCabecalhoRetorno.ResumeLayout(false);
            pnlCabecalhoRetorno.PerformLayout();
            gbTipoItemRetorno.ResumeLayout(false);
            gbTipoItemRetorno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimparRetorno;
        private Button btnCancelarRetorno;
        private Button btnAdicionarRetorno;
        private GroupBox grpDadosItemRetorno;
        private Label lblQuantidadeRetorno;
        private TextBox txtObservacaoRetorno;
        private Label lblObservacaoRetorno;
        private DateTimePicker dtpValidadeRetorno;
        private Label lblValidadeRetorno;
        private NumericUpDown nudQuantidadeRetorno;
        private Label lblItemEventoRetorno;
        private ComboBox txtUnidadeExternaRetorno;
        private ComboBox cmbItensEstoqueRetorno;
        private Label lblUnidadeRetorno;
        private ComboBox txtCategoriaExternaRetorno;
        private Label lblCategoriaRetorno;
        private TextBox txtNomeExternoRetorno;
        private Label lblNomeRetorno;
        private Panel pnlCabecalhoRetorno;
        private Label lblTituloRetorno;
        private Label label1;
        private GroupBox gbTipoItemRetorno;
        private RadioButton rdbItemExternoRetorno;
        private RadioButton rdbItemEventoRetorno;
    }
}