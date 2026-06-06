namespace Drink
{
    partial class frmAdicionarEstoque
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
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            grpDadosItem = new GroupBox();
            txtFornecedor = new TextBox();
            txtObservacao = new TextBox();
            lblObservacao = new Label();
            lblFornecedor = new Label();
            dtpValidade = new DateTimePicker();
            lblValidade = new Label();
            lblQuantidadeMinima = new Label();
            nudQuantidadeMinima = new NumericUpDown();
            lblQuantidadeAtual = new Label();
            nudQuantidadeAtual = new NumericUpDown();
            cmbUnidade = new ComboBox();
            lblUnidade = new Label();
            cmbCategoria = new ComboBox();
            lblCategoria = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            grpInformacoes = new GroupBox();
            lblStatusItemValor = new Label();
            lblStatusItem = new Label();
            lblUltimaAtualizacaoValor = new Label();
            lblUltimaAtualizacao = new Label();
            lblDataCadastroValor = new Label();
            lblDataCadastro = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnLimpar = new Button();
            pnlCabecalho.SuspendLayout();
            grpDadosItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeMinima).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeAtual).BeginInit();
            grpInformacoes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(784, 60);
            pnlCabecalho.TabIndex = 0;
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
            // grpDadosItem
            // 
            grpDadosItem.Controls.Add(txtFornecedor);
            grpDadosItem.Controls.Add(txtObservacao);
            grpDadosItem.Controls.Add(lblObservacao);
            grpDadosItem.Controls.Add(lblFornecedor);
            grpDadosItem.Controls.Add(dtpValidade);
            grpDadosItem.Controls.Add(lblValidade);
            grpDadosItem.Controls.Add(lblQuantidadeMinima);
            grpDadosItem.Controls.Add(nudQuantidadeMinima);
            grpDadosItem.Controls.Add(lblQuantidadeAtual);
            grpDadosItem.Controls.Add(nudQuantidadeAtual);
            grpDadosItem.Controls.Add(cmbUnidade);
            grpDadosItem.Controls.Add(lblUnidade);
            grpDadosItem.Controls.Add(cmbCategoria);
            grpDadosItem.Controls.Add(lblCategoria);
            grpDadosItem.Controls.Add(txtNome);
            grpDadosItem.Controls.Add(lblNome);
            grpDadosItem.Location = new Point(20, 80);
            grpDadosItem.Name = "grpDadosItem";
            grpDadosItem.Size = new Size(520, 230);
            grpDadosItem.TabIndex = 1;
            grpDadosItem.TabStop = false;
            grpDadosItem.Text = "Dados do Item";
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(370, 108);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(130, 23);
            txtFornecedor.TabIndex = 15;
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
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Location = new Point(290, 110);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(70, 15);
            lblFornecedor.TabIndex = 12;
            lblFornecedor.Text = "Fornecedor:";
            // 
            // dtpValidade
            // 
            dtpValidade.Format = DateTimePickerFormat.Short;
            dtpValidade.Location = new Point(360, 68);
            dtpValidade.Name = "dtpValidade";
            dtpValidade.Size = new Size(140, 23);
            dtpValidade.TabIndex = 11;
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(290, 70);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(54, 15);
            lblValidade.TabIndex = 10;
            lblValidade.Text = "Validade:";
            // 
            // lblQuantidadeMinima
            // 
            lblQuantidadeMinima.AutoSize = true;
            lblQuantidadeMinima.Location = new Point(290, 30);
            lblQuantidadeMinima.Name = "lblQuantidadeMinima";
            lblQuantidadeMinima.Size = new Size(116, 15);
            lblQuantidadeMinima.TabIndex = 9;
            lblQuantidadeMinima.Text = "Quantidade Mínima:";
            // 
            // nudQuantidadeMinima
            // 
            nudQuantidadeMinima.DecimalPlaces = 2;
            nudQuantidadeMinima.Location = new Point(410, 28);
            nudQuantidadeMinima.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidadeMinima.Name = "nudQuantidadeMinima";
            nudQuantidadeMinima.Size = new Size(90, 23);
            nudQuantidadeMinima.TabIndex = 8;
            // 
            // lblQuantidadeAtual
            // 
            lblQuantidadeAtual.AutoSize = true;
            lblQuantidadeAtual.Location = new Point(20, 195);
            lblQuantidadeAtual.Name = "lblQuantidadeAtual";
            lblQuantidadeAtual.Size = new Size(103, 15);
            lblQuantidadeAtual.TabIndex = 7;
            lblQuantidadeAtual.Text = "Quantidade Atual:";
            // 
            // nudQuantidadeAtual
            // 
            nudQuantidadeAtual.DecimalPlaces = 2;
            nudQuantidadeAtual.Location = new Point(140, 193);
            nudQuantidadeAtual.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantidadeAtual.Name = "nudQuantidadeAtual";
            nudQuantidadeAtual.Size = new Size(120, 23);
            nudQuantidadeAtual.TabIndex = 6;
            // 
            // cmbUnidade
            // 
            cmbUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidade.FormattingEnabled = true;
            cmbUnidade.Location = new Point(20, 160);
            cmbUnidade.Name = "cmbUnidade";
            cmbUnidade.Size = new Size(240, 23);
            cmbUnidade.TabIndex = 5;
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
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(20, 105);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(240, 23);
            cmbCategoria.TabIndex = 3;
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
            // txtNome
            // 
            txtNome.Location = new Point(20, 50);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(240, 23);
            txtNome.TabIndex = 1;
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
            // grpInformacoes
            // 
            grpInformacoes.Controls.Add(lblStatusItemValor);
            grpInformacoes.Controls.Add(lblStatusItem);
            grpInformacoes.Controls.Add(lblUltimaAtualizacaoValor);
            grpInformacoes.Controls.Add(lblUltimaAtualizacao);
            grpInformacoes.Controls.Add(lblDataCadastroValor);
            grpInformacoes.Controls.Add(lblDataCadastro);
            grpInformacoes.Location = new Point(560, 80);
            grpInformacoes.Name = "grpInformacoes";
            grpInformacoes.Size = new Size(200, 230);
            grpInformacoes.TabIndex = 2;
            grpInformacoes.TabStop = false;
            grpInformacoes.Text = "Informações";
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
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(250, 330);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 35);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Location = new Point(530, 330);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 35);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.WhiteSmoke;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(390, 330);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(120, 35);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmAdicionarEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(784, 391);
            Controls.Add(btnLimpar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(grpInformacoes);
            Controls.Add(grpDadosItem);
            Controls.Add(pnlCabecalho);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "frmAdicionarEstoque";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Item";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            grpDadosItem.ResumeLayout(false);
            grpDadosItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeMinima).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantidadeAtual).EndInit();
            grpInformacoes.ResumeLayout(false);
            grpInformacoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private GroupBox grpDadosItem;
        private ComboBox cmbCategoria;
        private Label lblCategoria;
        private TextBox txtNome;
        private Label lblNome;
        private ComboBox cmbUnidade;
        private Label lblUnidade;
        private NumericUpDown nudQuantidadeAtual;
        private Label lblQuantidadeAtual;
        private DateTimePicker dtpValidade;
        private Label lblValidade;
        private Label lblQuantidadeMinima;
        private NumericUpDown nudQuantidadeMinima;
        private TextBox txtFornecedor;
        private TextBox txtObservacao;
        private Label lblObservacao;
        private Label lblFornecedor;
        private GroupBox grpInformacoes;
        private Label lblUltimaAtualizacao;
        private Label lblDataCadastroValor;
        private Label lblDataCadastro;
        private Label lblStatusItemValor;
        private Label lblStatusItem;
        private Label lblUltimaAtualizacaoValor;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnLimpar;
    }
}