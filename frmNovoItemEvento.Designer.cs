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
            btnCancelar = new Button();
            button1 = new Button();
            btnAdicionar = new Button();
            grpInformacoes = new GroupBox();
            chkItemAtivo = new CheckBox();
            lblStatusItemValor = new Label();
            lblStatusItem = new Label();
            lblUltimaAtualizacaoValor = new Label();
            lblUltimaAtualizacao = new Label();
            lblDataCadastroValor = new Label();
            lblDataCadastro = new Label();
            grpDadosItem = new GroupBox();
            label3 = new Label();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            dtpValidade = new DateTimePicker();
            lblValidade = new Label();
            nudQuantidade = new NumericUpDown();
            txtUnidadeExterna = new ComboBox();
            lblUnidade = new Label();
            txtCategoriaExterna = new ComboBox();
            lblCategoria = new Label();
            txtNomeExterno = new TextBox();
            lblNome = new Label();
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            gbTipoItem.SuspendLayout();
            grpInformacoes.SuspendLayout();
            grpDadosItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).BeginInit();
            pnlCabecalho.SuspendLayout();
            SuspendLayout();
            // 
            // gbTipoItem
            // 
            gbTipoItem.Controls.Add(rdbItemExterno);
            gbTipoItem.Controls.Add(rdbItemEstoque);
            gbTipoItem.Font = new Font("Segoe UI", 9F);
            gbTipoItem.Location = new Point(473, 302);
            gbTipoItem.Name = "gbTipoItem";
            gbTipoItem.Size = new Size(279, 53);
            gbTipoItem.TabIndex = 0;
            gbTipoItem.TabStop = false;
            gbTipoItem.Text = "Tipo do item :";
            // 
            // rdbItemExterno
            // 
            rdbItemExterno.AutoSize = true;
            rdbItemExterno.Font = new Font("Segoe UI", 9F);
            rdbItemExterno.Location = new Point(156, 24);
            rdbItemExterno.Name = "rdbItemExterno";
            rdbItemExterno.Size = new Size(91, 19);
            rdbItemExterno.TabIndex = 1;
            rdbItemExterno.TabStop = true;
            rdbItemExterno.Text = "Item externo";
            rdbItemExterno.UseVisualStyleBackColor = true;
            rdbItemExterno.CheckedChanged += rdbItemExterno_CheckedChanged;
            // 
            // rdbItemEstoque
            // 
            rdbItemEstoque.AutoSize = true;
            rdbItemEstoque.Font = new Font("Segoe UI", 9F);
            rdbItemEstoque.Location = new Point(13, 24);
            rdbItemEstoque.Name = "rdbItemEstoque";
            rdbItemEstoque.Size = new Size(111, 19);
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
            cmbItensEstoque.Location = new Point(290, 52);
            cmbItensEstoque.Name = "cmbItensEstoque";
            cmbItensEstoque.Size = new Size(210, 23);
            cmbItensEstoque.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(290, 28);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Item do estoque :";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(174, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Limpar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.WhiteSmoke;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(317, 316);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 19;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(20, 59, 102);
            btnAdicionar.FlatStyle = FlatStyle.Flat;
            btnAdicionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = Color.White;
            btnAdicionar.Location = new Point(32, 316);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(120, 35);
            btnAdicionar.TabIndex = 18;
            btnAdicionar.Text = "Salvar";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // grpInformacoes
            // 
            grpInformacoes.Controls.Add(chkItemAtivo);
            grpInformacoes.Controls.Add(lblStatusItemValor);
            grpInformacoes.Controls.Add(lblStatusItem);
            grpInformacoes.Controls.Add(lblUltimaAtualizacaoValor);
            grpInformacoes.Controls.Add(lblUltimaAtualizacao);
            grpInformacoes.Controls.Add(lblDataCadastroValor);
            grpInformacoes.Controls.Add(lblDataCadastro);
            grpInformacoes.Location = new Point(552, 66);
            grpInformacoes.Name = "grpInformacoes";
            grpInformacoes.Size = new Size(200, 230);
            grpInformacoes.TabIndex = 17;
            grpInformacoes.TabStop = false;
            grpInformacoes.Text = "Informações";
            // 
            // chkItemAtivo
            // 
            chkItemAtivo.AutoSize = true;
            chkItemAtivo.Checked = true;
            chkItemAtivo.CheckState = CheckState.Checked;
            chkItemAtivo.Location = new Point(15, 205);
            chkItemAtivo.Name = "chkItemAtivo";
            chkItemAtivo.Size = new Size(81, 19);
            chkItemAtivo.TabIndex = 6;
            chkItemAtivo.Text = "Item Ativo";
            chkItemAtivo.UseVisualStyleBackColor = true;
            // 
            // lblStatusItemValor
            // 
            lblStatusItemValor.AutoSize = true;
            lblStatusItemValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusItemValor.ForeColor = Color.Green;
            lblStatusItemValor.Location = new Point(15, 180);
            lblStatusItemValor.Name = "lblStatusItemValor";
            lblStatusItemValor.Size = new Size(62, 20);
            lblStatusItemValor.TabIndex = 5;
            lblStatusItemValor.Text = "Normal";
            // 
            // lblStatusItem
            // 
            lblStatusItem.AutoSize = true;
            lblStatusItem.Location = new Point(15, 155);
            lblStatusItem.Name = "lblStatusItem";
            lblStatusItem.Size = new Size(42, 15);
            lblStatusItem.TabIndex = 4;
            lblStatusItem.Text = "Status:";
            // 
            // lblUltimaAtualizacaoValor
            // 
            lblUltimaAtualizacaoValor.AutoSize = true;
            lblUltimaAtualizacaoValor.ForeColor = Color.FromArgb(80, 80, 80);
            lblUltimaAtualizacaoValor.Location = new Point(15, 120);
            lblUltimaAtualizacaoValor.Name = "lblUltimaAtualizacaoValor";
            lblUltimaAtualizacaoValor.Size = new Size(12, 15);
            lblUltimaAtualizacaoValor.TabIndex = 3;
            lblUltimaAtualizacaoValor.Text = "-";
            // 
            // lblUltimaAtualizacao
            // 
            lblUltimaAtualizacao.AutoSize = true;
            lblUltimaAtualizacao.Location = new Point(15, 95);
            lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            lblUltimaAtualizacao.Size = new Size(109, 15);
            lblUltimaAtualizacao.TabIndex = 2;
            lblUltimaAtualizacao.Text = "Última Atualização:";
            // 
            // lblDataCadastroValor
            // 
            lblDataCadastroValor.AutoSize = true;
            lblDataCadastroValor.ForeColor = Color.FromArgb(80, 80, 80);
            lblDataCadastroValor.Location = new Point(15, 60);
            lblDataCadastroValor.Name = "lblDataCadastroValor";
            lblDataCadastroValor.Size = new Size(12, 15);
            lblDataCadastroValor.TabIndex = 1;
            lblDataCadastroValor.Text = "-";
            // 
            // lblDataCadastro
            // 
            lblDataCadastro.AutoSize = true;
            lblDataCadastro.Location = new Point(15, 35);
            lblDataCadastro.Name = "lblDataCadastro";
            lblDataCadastro.Size = new Size(101, 15);
            lblDataCadastro.TabIndex = 0;
            lblDataCadastro.Text = "Data do Cadastro:";
            // 
            // grpDadosItem
            // 
            grpDadosItem.Controls.Add(label3);
            grpDadosItem.Controls.Add(txtObservacao);
            grpDadosItem.Controls.Add(lblObservacao);
            grpDadosItem.Controls.Add(dtpValidade);
            grpDadosItem.Controls.Add(lblValidade);
            grpDadosItem.Controls.Add(nudQuantidade);
            grpDadosItem.Controls.Add(label2);
            grpDadosItem.Controls.Add(txtUnidadeExterna);
            grpDadosItem.Controls.Add(cmbItensEstoque);
            grpDadosItem.Controls.Add(lblUnidade);
            grpDadosItem.Controls.Add(txtCategoriaExterna);
            grpDadosItem.Controls.Add(lblCategoria);
            grpDadosItem.Controls.Add(txtNomeExterno);
            grpDadosItem.Controls.Add(lblNome);
            grpDadosItem.Location = new Point(12, 66);
            grpDadosItem.Name = "grpDadosItem";
            grpDadosItem.Size = new Size(520, 230);
            grpDadosItem.TabIndex = 16;
            grpDadosItem.TabStop = false;
            grpDadosItem.Text = "Dados do Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 195);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 15;
            label3.Text = "Quantidade:";
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(290, 170);
            txtObservacao.Multiline = true;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(210, 50);
            txtObservacao.TabIndex = 14;
            // 
            // lblObservacao
            // 
            lblObservacao.AutoSize = true;
            lblObservacao.Location = new Point(290, 150);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(72, 15);
            lblObservacao.TabIndex = 13;
            lblObservacao.Text = "Observação:";
            // 
            // dtpValidade
            // 
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(290, 105);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(210, 23);
            dtpValidade.TabIndex = 11;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(290, 85);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(54, 15);
            lblValidade.TabIndex = 10;
            lblValidade.Text = "Validade:";
            // 
            // nudQuantidade
            // 
            nudQuantidade.DecimalPlaces = 2;
            nudQuantidade.Location = new Point(112, 193);
            nudQuantidade.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidade.Name = "nudQuantidade";
            nudQuantidade.Size = new Size(148, 23);
            nudQuantidade.TabIndex = 6;
            // 
            // txtUnidadeExterna
            // 
            txtUnidadeExterna.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUnidadeExterna.FormattingEnabled = true;
            txtUnidadeExterna.Location = new Point(20, 160);
            txtUnidadeExterna.Name = "txtUnidadeExterna";
            txtUnidadeExterna.Size = new Size(240, 23);
            txtUnidadeExterna.TabIndex = 5;
            // 
            // lblUnidade
            // 
            lblUnidade.AutoSize = true;
            lblUnidade.Location = new Point(20, 140);
            lblUnidade.Name = "lblUnidade";
            lblUnidade.Size = new Size(54, 15);
            lblUnidade.TabIndex = 4;
            lblUnidade.Text = "Unidade:";
            // 
            // txtCategoriaExterna
            // 
            txtCategoriaExterna.DropDownStyle = ComboBoxStyle.DropDownList;
            txtCategoriaExterna.FormattingEnabled = true;
            txtCategoriaExterna.Location = new Point(20, 105);
            txtCategoriaExterna.Name = "txtCategoriaExterna";
            txtCategoriaExterna.Size = new Size(240, 23);
            txtCategoriaExterna.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(20, 85);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria:";
            // 
            // txtNomeExterno
            // 
            txtNomeExterno.Location = new Point(20, 50);
            txtNomeExterno.Name = "txtNomeExterno";
            txtNomeExterno.Size = new Size(240, 23);
            txtNomeExterno.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(20, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(785, 60);
            pnlCabecalho.TabIndex = 15;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 17);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(287, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cadastro / Edição de Item";
            // 
            // frmNovoItemEvento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 385);
            Controls.Add(btnCancelar);
            Controls.Add(button1);
            Controls.Add(btnAdicionar);
            Controls.Add(grpInformacoes);
            Controls.Add(grpDadosItem);
            Controls.Add(pnlCabecalho);
            Controls.Add(label1);
            Controls.Add(gbTipoItem);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmNovoItemEvento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNovoItemEvento";
            Load += frmNovoItemEvento_Load;
            gbTipoItem.ResumeLayout(false);
            gbTipoItem.PerformLayout();
            grpInformacoes.ResumeLayout(false);
            grpInformacoes.PerformLayout();
            grpDadosItem.ResumeLayout(false);
            grpDadosItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidade).EndInit();
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
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
        private NumericUpDown nudQuantidade;
        private Button btnAdicionar;
        private Button btnCancelar;
        private Button button1;
        private GroupBox grpInformacoes;
        private CheckBox chkItemAtivo;
        private Label lblStatusItemValor;
        private Label lblStatusItem;
        private Label lblUltimaAtualizacaoValor;
        private Label lblUltimaAtualizacao;
        private Label lblDataCadastroValor;
        private Label lblDataCadastro;
        private GroupBox grpDadosItem;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private DateTimePicker dtpValidade;
        private Label lblValidade;
        private ComboBox txtUnidadeExterna;
        private Label lblUnidade;
        private ComboBox txtCategoriaExterna;
        private Label lblCategoria;
        private TextBox txtNomeExterno;
        private Label lblNome;
        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label label3;
    }
}