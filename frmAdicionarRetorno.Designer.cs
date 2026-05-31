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
            grpInformacoesRetorno = new GroupBox();
            lblStatusItemValorRetorno = new Label();
            lblStatusItemRetorno = new Label();
            lblUltimaAtualizacaoValorRetorno = new Label();
            lblUltimaAtualizacaoRetorno = new Label();
            lblDataCadastroValorRetorno = new Label();
            lblDataCadastroRetorno = new Label();
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
            grpInformacoesRetorno.SuspendLayout();
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
            // 
            // grpInformacoesRetorno
            // 
            grpInformacoesRetorno.Controls.Add(lblStatusItemValorRetorno);
            grpInformacoesRetorno.Controls.Add(lblStatusItemRetorno);
            grpInformacoesRetorno.Controls.Add(lblUltimaAtualizacaoValorRetorno);
            grpInformacoesRetorno.Controls.Add(lblUltimaAtualizacaoRetorno);
            grpInformacoesRetorno.Controls.Add(lblDataCadastroValorRetorno);
            grpInformacoesRetorno.Controls.Add(lblDataCadastroRetorno);
            grpInformacoesRetorno.Location = new Point(552, 119);
            grpInformacoesRetorno.Name = "grpInformacoesRetorno";
            grpInformacoesRetorno.Size = new Size(200, 230);
            grpInformacoesRetorno.TabIndex = 25;
            grpInformacoesRetorno.TabStop = false;
            grpInformacoesRetorno.Text = "Informações";
            // 
            // lblStatusItemValorRetorno
            // 
            lblStatusItemValorRetorno.AutoSize = true;
            lblStatusItemValorRetorno.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusItemValorRetorno.ForeColor = Color.Green;
            lblStatusItemValorRetorno.Location = new Point(15, 180);
            lblStatusItemValorRetorno.Name = "lblStatusItemValorRetorno";
            lblStatusItemValorRetorno.Size = new Size(62, 20);
            lblStatusItemValorRetorno.TabIndex = 5;
            lblStatusItemValorRetorno.Text = "Normal";
            // 
            // lblStatusItemRetorno
            // 
            lblStatusItemRetorno.AutoSize = true;
            lblStatusItemRetorno.Location = new Point(15, 155);
            lblStatusItemRetorno.Name = "lblStatusItemRetorno";
            lblStatusItemRetorno.Size = new Size(42, 15);
            lblStatusItemRetorno.TabIndex = 4;
            lblStatusItemRetorno.Text = "Status:";
            // 
            // lblUltimaAtualizacaoValorRetorno
            // 
            lblUltimaAtualizacaoValorRetorno.AutoSize = true;
            lblUltimaAtualizacaoValorRetorno.ForeColor = Color.FromArgb(80, 80, 80);
            lblUltimaAtualizacaoValorRetorno.Location = new Point(15, 120);
            lblUltimaAtualizacaoValorRetorno.Name = "lblUltimaAtualizacaoValorRetorno";
            lblUltimaAtualizacaoValorRetorno.Size = new Size(12, 15);
            lblUltimaAtualizacaoValorRetorno.TabIndex = 3;
            lblUltimaAtualizacaoValorRetorno.Text = "-";
            // 
            // lblUltimaAtualizacaoRetorno
            // 
            lblUltimaAtualizacaoRetorno.AutoSize = true;
            lblUltimaAtualizacaoRetorno.Location = new Point(15, 95);
            lblUltimaAtualizacaoRetorno.Name = "lblUltimaAtualizacaoRetorno";
            lblUltimaAtualizacaoRetorno.Size = new Size(109, 15);
            lblUltimaAtualizacaoRetorno.TabIndex = 2;
            lblUltimaAtualizacaoRetorno.Text = "Última Atualização:";
            // 
            // lblDataCadastroValorRetorno
            // 
            lblDataCadastroValorRetorno.AutoSize = true;
            lblDataCadastroValorRetorno.ForeColor = Color.FromArgb(80, 80, 80);
            lblDataCadastroValorRetorno.Location = new Point(15, 60);
            lblDataCadastroValorRetorno.Name = "lblDataCadastroValorRetorno";
            lblDataCadastroValorRetorno.Size = new Size(12, 15);
            lblDataCadastroValorRetorno.TabIndex = 1;
            lblDataCadastroValorRetorno.Text = "-";
            // 
            // lblDataCadastroRetorno
            // 
            lblDataCadastroRetorno.AutoSize = true;
            lblDataCadastroRetorno.Location = new Point(15, 35);
            lblDataCadastroRetorno.Name = "lblDataCadastroRetorno";
            lblDataCadastroRetorno.Size = new Size(101, 15);
            lblDataCadastroRetorno.TabIndex = 0;
            lblDataCadastroRetorno.Text = "Data do Cadastro:";
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
            grpDadosItemRetorno.Location = new Point(12, 119);
            grpDadosItemRetorno.Name = "grpDadosItemRetorno";
            grpDadosItemRetorno.Size = new Size(520, 230);
            grpDadosItemRetorno.TabIndex = 24;
            grpDadosItemRetorno.TabStop = false;
            grpDadosItemRetorno.Text = "Dados do Item";
            grpDadosItemRetorno.Enter += grpDadosItem_Enter;
            // 
            // lblQuantidadeRetorno
            // 
            lblQuantidadeRetorno.AutoSize = true;
            lblQuantidadeRetorno.Location = new Point(20, 195);
            lblQuantidadeRetorno.Name = "lblQuantidadeRetorno";
            lblQuantidadeRetorno.Size = new Size(72, 15);
            lblQuantidadeRetorno.TabIndex = 15;
            lblQuantidadeRetorno.Text = "Quantidade:";
            // 
            // txtObservacaoRetorno
            // 
            txtObservacaoRetorno.Location = new Point(290, 170);
            txtObservacaoRetorno.Multiline = true;
            txtObservacaoRetorno.Name = "txtObservacaoRetorno";
            txtObservacaoRetorno.Size = new Size(210, 50);
            txtObservacaoRetorno.TabIndex = 14;
            // 
            // lblObservacaoRetorno
            // 
            lblObservacaoRetorno.AutoSize = true;
            lblObservacaoRetorno.Location = new Point(290, 150);
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
            nudQuantidadeRetorno.Location = new Point(112, 193);
            nudQuantidadeRetorno.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidadeRetorno.Name = "nudQuantidadeRetorno";
            nudQuantidadeRetorno.Size = new Size(148, 23);
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
            pnlCabecalhoRetorno.Size = new Size(826, 60);
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
            gbTipoItemRetorno.Location = new Point(473, 355);
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
            // 
            // frmAdicionarRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(826, 461);
            Controls.Add(btnLimparRetorno);
            Controls.Add(btnCancelarRetorno);
            Controls.Add(btnAdicionarRetorno);
            Controls.Add(grpInformacoesRetorno);
            Controls.Add(grpDadosItemRetorno);
            Controls.Add(pnlCabecalhoRetorno);
            Controls.Add(label1);
            Controls.Add(gbTipoItemRetorno);
            Name = "frmAdicionarRetorno";
            Text = "frmAdicionarRetorno";
            grpInformacoesRetorno.ResumeLayout(false);
            grpInformacoesRetorno.PerformLayout();
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
        private GroupBox grpInformacoesRetorno;
        private Label lblStatusItemValorRetorno;
        private Label lblStatusItemRetorno;
        private Label lblUltimaAtualizacaoValorRetorno;
        private Label lblUltimaAtualizacaoRetorno;
        private Label lblDataCadastroValorRetorno;
        private Label lblDataCadastroRetorno;
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