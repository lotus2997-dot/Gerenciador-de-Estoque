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
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            pnlResumoRetorno = new Panel();
            label10 = new Label();
            cmbEventoSelecionado = new ComboBox();
            lblResponsavelValor = new Label();
            lblDataValor = new Label();
            lblResponsavelTitulo = new Label();
            lblDataTitulo = new Label();
            lblEventoValor = new Label();
            lblEventoTitulo = new Label();
            tabControl1 = new TabControl();
            tabDadosRetorno = new TabPage();
            pnlDadosEventoRetorno = new Panel();
            btnParaItensRetorno = new Button();
            grpDetalhesEventoRetorno = new GroupBox();
            nudQtdPessoasRetorno = new NumericUpDown();
            label9 = new Label();
            cmbStatusEventoRetorno = new ComboBox();
            label5 = new Label();
            grpInformações = new GroupBox();
            txtResponsavelEventoRetorno = new TextBox();
            txtLocalEventoRetorno = new TextBox();
            dtpDataEventoRetorno = new DateTimePicker();
            txtNomeEventoRetorno = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSubitituloDadosEventoRetorno = new Label();
            lblTituloDadosEventoRetorno = new Label();
            tabItensRetorno = new TabPage();
            pnlBotoesRetorno = new Panel();
            btnConfirmarRetorno = new Button();
            btnDevolverEstoque = new Button();
            btnRemover = new Button();
            dgvRetorno = new DataGridView();
            grpFiltros = new GroupBox();
            btnLimparFiltro = new Button();
            btnPesquisar = new Button();
            cmbFiltroStatus = new ComboBox();
            lblFiltroStatus = new Label();
            cmbFiltroUnidade = new ComboBox();
            lblFiltroUnidade = new Label();
            txtFiltroNome = new TextBox();
            lblFiltroNome = new Label();
            btnEvento = new Button();
            btnEstoque = new Button();
            btnSalvarRetorno = new Button();
            pnlResumoRetorno.SuspendLayout();
            tabControl1.SuspendLayout();
            tabDadosRetorno.SuspendLayout();
            pnlDadosEventoRetorno.SuspendLayout();
            grpDetalhesEventoRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdPessoasRetorno).BeginInit();
            grpInformações.SuspendLayout();
            tabItensRetorno.SuspendLayout();
            pnlBotoesRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRetorno).BeginInit();
            grpFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1350, 75);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(20, 59, 102);
            lblTitulo.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(277, 38);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "RETORNO DE ITENS";
            // 
            // pnlResumoRetorno
            // 
            pnlResumoRetorno.Controls.Add(label10);
            pnlResumoRetorno.Controls.Add(cmbEventoSelecionado);
            pnlResumoRetorno.Controls.Add(lblResponsavelValor);
            pnlResumoRetorno.Controls.Add(lblDataValor);
            pnlResumoRetorno.Controls.Add(lblResponsavelTitulo);
            pnlResumoRetorno.Controls.Add(lblDataTitulo);
            pnlResumoRetorno.Controls.Add(lblEventoValor);
            pnlResumoRetorno.Controls.Add(lblEventoTitulo);
            pnlResumoRetorno.Dock = DockStyle.Top;
            pnlResumoRetorno.Location = new Point(0, 75);
            pnlResumoRetorno.Name = "pnlResumoRetorno";
            pnlResumoRetorno.Size = new Size(1350, 90);
            pnlResumoRetorno.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(903, 20);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 8;
            label10.Text = "Evento:";
            // 
            // cmbEventoSelecionado
            // 
            cmbEventoSelecionado.FormattingEnabled = true;
            cmbEventoSelecionado.Location = new Point(903, 42);
            cmbEventoSelecionado.Name = "cmbEventoSelecionado";
            cmbEventoSelecionado.Size = new Size(165, 23);
            cmbEventoSelecionado.TabIndex = 7;
            cmbEventoSelecionado.SelectedIndexChanged += cmbEventoSelecionado_SelectedIndexChanged;
            // 
            // lblResponsavelValor
            // 
            lblResponsavelValor.AutoSize = true;
            lblResponsavelValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsavelValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblResponsavelValor.Location = new Point(613, 45);
            lblResponsavelValor.Name = "lblResponsavelValor";
            lblResponsavelValor.Size = new Size(111, 20);
            lblResponsavelValor.TabIndex = 4;
            lblResponsavelValor.Text = "Administrador";
            // 
            // lblDataValor
            // 
            lblDataValor.AutoSize = true;
            lblDataValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblDataValor.Location = new Point(360, 45);
            lblDataValor.Name = "lblDataValor";
            lblDataValor.Size = new Size(95, 20);
            lblDataValor.TabIndex = 6;
            lblDataValor.Text = "28/04/2026";
            // 
            // lblResponsavelTitulo
            // 
            lblResponsavelTitulo.AutoSize = true;
            lblResponsavelTitulo.Location = new Point(613, 20);
            lblResponsavelTitulo.Name = "lblResponsavelTitulo";
            lblResponsavelTitulo.Size = new Size(75, 15);
            lblResponsavelTitulo.TabIndex = 3;
            lblResponsavelTitulo.Text = "Responsável:";
            // 
            // lblDataTitulo
            // 
            lblDataTitulo.AutoSize = true;
            lblDataTitulo.Location = new Point(360, 20);
            lblDataTitulo.Name = "lblDataTitulo";
            lblDataTitulo.Size = new Size(34, 15);
            lblDataTitulo.TabIndex = 5;
            lblDataTitulo.Text = "Data:";
            // 
            // lblEventoValor
            // 
            lblEventoValor.AutoSize = true;
            lblEventoValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEventoValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblEventoValor.Location = new Point(40, 45);
            lblEventoValor.Name = "lblEventoValor";
            lblEventoValor.Size = new Size(126, 20);
            lblEventoValor.TabIndex = 4;
            lblEventoValor.Text = "Nome do Evento";
            // 
            // lblEventoTitulo
            // 
            lblEventoTitulo.AutoSize = true;
            lblEventoTitulo.Location = new Point(40, 20);
            lblEventoTitulo.Name = "lblEventoTitulo";
            lblEventoTitulo.Size = new Size(46, 15);
            lblEventoTitulo.TabIndex = 3;
            lblEventoTitulo.Text = "Evento:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDadosRetorno);
            tabControl1.Controls.Add(tabItensRetorno);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 165);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 564);
            tabControl1.TabIndex = 3;
            // 
            // tabDadosRetorno
            // 
            tabDadosRetorno.Controls.Add(pnlDadosEventoRetorno);
            tabDadosRetorno.Location = new Point(4, 24);
            tabDadosRetorno.Name = "tabDadosRetorno";
            tabDadosRetorno.Padding = new Padding(3);
            tabDadosRetorno.Size = new Size(1342, 536);
            tabDadosRetorno.TabIndex = 0;
            tabDadosRetorno.Text = "Dados do Retorno\n";
            tabDadosRetorno.UseVisualStyleBackColor = true;
            // 
            // pnlDadosEventoRetorno
            // 
            pnlDadosEventoRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosEventoRetorno.BackColor = Color.White;
            pnlDadosEventoRetorno.Controls.Add(btnParaItensRetorno);
            pnlDadosEventoRetorno.Controls.Add(grpDetalhesEventoRetorno);
            pnlDadosEventoRetorno.Controls.Add(grpInformações);
            pnlDadosEventoRetorno.Controls.Add(lblSubitituloDadosEventoRetorno);
            pnlDadosEventoRetorno.Controls.Add(lblTituloDadosEventoRetorno);
            pnlDadosEventoRetorno.Location = new Point(20, 20);
            pnlDadosEventoRetorno.Name = "pnlDadosEventoRetorno";
            pnlDadosEventoRetorno.Size = new Size(1290, 480);
            pnlDadosEventoRetorno.TabIndex = 1;
            // 
            // btnParaItensRetorno
            // 
            btnParaItensRetorno.BackColor = Color.FromArgb(30, 100, 170);
            btnParaItensRetorno.FlatStyle = FlatStyle.Flat;
            btnParaItensRetorno.ForeColor = Color.White;
            btnParaItensRetorno.Location = new Point(47, 418);
            btnParaItensRetorno.Name = "btnParaItensRetorno";
            btnParaItensRetorno.Size = new Size(130, 36);
            btnParaItensRetorno.TabIndex = 6;
            btnParaItensRetorno.Text = "Ir para Itens";
            btnParaItensRetorno.UseVisualStyleBackColor = false;
            btnParaItensRetorno.Click += btnParaItensRetorno_Click;
            // 
            // grpDetalhesEventoRetorno
            // 
            grpDetalhesEventoRetorno.Controls.Add(nudQtdPessoasRetorno);
            grpDetalhesEventoRetorno.Controls.Add(label9);
            grpDetalhesEventoRetorno.Controls.Add(cmbStatusEventoRetorno);
            grpDetalhesEventoRetorno.Controls.Add(label5);
            grpDetalhesEventoRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalhesEventoRetorno.Location = new Point(650, 90);
            grpDetalhesEventoRetorno.Name = "grpDetalhesEventoRetorno";
            grpDetalhesEventoRetorno.Size = new Size(600, 304);
            grpDetalhesEventoRetorno.TabIndex = 3;
            grpDetalhesEventoRetorno.TabStop = false;
            grpDetalhesEventoRetorno.Text = "Detalhes do evento";
            // 
            // nudQtdPessoasRetorno
            // 
            nudQtdPessoasRetorno.Font = new Font("Segoe UI", 9.75F);
            nudQtdPessoasRetorno.Location = new Point(20, 114);
            nudQtdPessoasRetorno.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQtdPessoasRetorno.Name = "nudQtdPessoasRetorno";
            nudQtdPessoasRetorno.Size = new Size(211, 25);
            nudQtdPessoasRetorno.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F);
            label9.Location = new Point(20, 90);
            label9.Name = "label9";
            label9.Size = new Size(204, 17);
            label9.TabIndex = 9;
            label9.Text = "Quantidade estimada de pessoas";
            // 
            // cmbStatusEventoRetorno
            // 
            cmbStatusEventoRetorno.Font = new Font("Segoe UI", 9.75F);
            cmbStatusEventoRetorno.FormattingEnabled = true;
            cmbStatusEventoRetorno.Location = new Point(20, 57);
            cmbStatusEventoRetorno.Name = "cmbStatusEventoRetorno";
            cmbStatusEventoRetorno.Size = new Size(200, 25);
            cmbStatusEventoRetorno.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(20, 37);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 0;
            label5.Text = "Status";
            // 
            // grpInformações
            // 
            grpInformações.Controls.Add(txtResponsavelEventoRetorno);
            grpInformações.Controls.Add(txtLocalEventoRetorno);
            grpInformações.Controls.Add(dtpDataEventoRetorno);
            grpInformações.Controls.Add(txtNomeEventoRetorno);
            grpInformações.Controls.Add(label4);
            grpInformações.Controls.Add(label3);
            grpInformações.Controls.Add(label2);
            grpInformações.Controls.Add(label1);
            grpInformações.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInformações.Location = new Point(25, 90);
            grpInformações.Name = "grpInformações";
            grpInformações.Size = new Size(600, 304);
            grpInformações.TabIndex = 2;
            grpInformações.TabStop = false;
            grpInformações.Text = "Informações principais";
            // 
            // txtResponsavelEventoRetorno
            // 
            txtResponsavelEventoRetorno.Font = new Font("Segoe UI", 9.75F);
            txtResponsavelEventoRetorno.Location = new Point(22, 216);
            txtResponsavelEventoRetorno.Name = "txtResponsavelEventoRetorno";
            txtResponsavelEventoRetorno.Size = new Size(197, 25);
            txtResponsavelEventoRetorno.TabIndex = 7;
            // 
            // txtLocalEventoRetorno
            // 
            txtLocalEventoRetorno.Font = new Font("Segoe UI", 9.75F);
            txtLocalEventoRetorno.Location = new Point(25, 161);
            txtLocalEventoRetorno.Name = "txtLocalEventoRetorno";
            txtLocalEventoRetorno.Size = new Size(197, 25);
            txtLocalEventoRetorno.TabIndex = 6;
            // 
            // dtpDataEventoRetorno
            // 
            dtpDataEventoRetorno.Font = new Font("Segoe UI", 9.75F);
            dtpDataEventoRetorno.Format = DateTimePickerFormat.Short;
            dtpDataEventoRetorno.Location = new Point(22, 110);
            dtpDataEventoRetorno.Name = "dtpDataEventoRetorno";
            dtpDataEventoRetorno.Size = new Size(200, 25);
            dtpDataEventoRetorno.TabIndex = 5;
            // 
            // txtNomeEventoRetorno
            // 
            txtNomeEventoRetorno.Font = new Font("Segoe UI", 9.75F);
            txtNomeEventoRetorno.Location = new Point(22, 57);
            txtNomeEventoRetorno.Name = "txtNomeEventoRetorno";
            txtNomeEventoRetorno.Size = new Size(200, 25);
            txtNomeEventoRetorno.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(22, 196);
            label4.Name = "label4";
            label4.Size = new Size(164, 17);
            label4.TabIndex = 3;
            label4.Text = "Responsável / Proprietário";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(22, 37);
            label3.Name = "label3";
            label3.Size = new Size(107, 17);
            label3.TabIndex = 2;
            label3.Text = "Nome do evento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(22, 141);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 1;
            label2.Text = "Local";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(22, 90);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 0;
            label1.Text = "Data do evento";
            // 
            // lblSubitituloDadosEventoRetorno
            // 
            lblSubitituloDadosEventoRetorno.AutoSize = true;
            lblSubitituloDadosEventoRetorno.ForeColor = SystemColors.WindowFrame;
            lblSubitituloDadosEventoRetorno.Location = new Point(27, 55);
            lblSubitituloDadosEventoRetorno.Name = "lblSubitituloDadosEventoRetorno";
            lblSubitituloDadosEventoRetorno.Size = new Size(369, 15);
            lblSubitituloDadosEventoRetorno.TabIndex = 1;
            lblSubitituloDadosEventoRetorno.Text = "Preencha os dados principais antes de separar os itens para o evento.";
            // 
            // lblTituloDadosEventoRetorno
            // 
            lblTituloDadosEventoRetorno.AutoSize = true;
            lblTituloDadosEventoRetorno.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloDadosEventoRetorno.ForeColor = Color.FromArgb(20, 59, 102);
            lblTituloDadosEventoRetorno.Location = new Point(25, 20);
            lblTituloDadosEventoRetorno.Name = "lblTituloDadosEventoRetorno";
            lblTituloDadosEventoRetorno.Size = new Size(240, 30);
            lblTituloDadosEventoRetorno.TabIndex = 0;
            lblTituloDadosEventoRetorno.Text = "Informações do Evento";
            // 
            // tabItensRetorno
            // 
            tabItensRetorno.Controls.Add(pnlBotoesRetorno);
            tabItensRetorno.Controls.Add(dgvRetorno);
            tabItensRetorno.Controls.Add(grpFiltros);
            tabItensRetorno.Location = new Point(4, 24);
            tabItensRetorno.Name = "tabItensRetorno";
            tabItensRetorno.Padding = new Padding(3);
            tabItensRetorno.Size = new Size(1342, 536);
            tabItensRetorno.TabIndex = 1;
            tabItensRetorno.Text = "Itens do Retorno";
            tabItensRetorno.UseVisualStyleBackColor = true;
            // 
            // pnlBotoesRetorno
            // 
            pnlBotoesRetorno.BackColor = Color.White;
            pnlBotoesRetorno.Controls.Add(btnSalvarRetorno);
            pnlBotoesRetorno.Controls.Add(btnEstoque);
            pnlBotoesRetorno.Controls.Add(btnEvento);
            pnlBotoesRetorno.Controls.Add(btnConfirmarRetorno);
            pnlBotoesRetorno.Controls.Add(btnDevolverEstoque);
            pnlBotoesRetorno.Controls.Add(btnRemover);
            pnlBotoesRetorno.Dock = DockStyle.Bottom;
            pnlBotoesRetorno.Location = new Point(3, 453);
            pnlBotoesRetorno.Name = "pnlBotoesRetorno";
            pnlBotoesRetorno.Size = new Size(1336, 80);
            pnlBotoesRetorno.TabIndex = 2;
            // 
            // btnConfirmarRetorno
            // 
            btnConfirmarRetorno.BackColor = Color.FromArgb(0, 140, 70);
            btnConfirmarRetorno.FlatStyle = FlatStyle.Flat;
            btnConfirmarRetorno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarRetorno.ForeColor = Color.White;
            btnConfirmarRetorno.Location = new Point(526, 21);
            btnConfirmarRetorno.Name = "btnConfirmarRetorno";
            btnConfirmarRetorno.Size = new Size(190, 38);
            btnConfirmarRetorno.TabIndex = 7;
            btnConfirmarRetorno.Text = "Confirmar Retorno";
            btnConfirmarRetorno.UseVisualStyleBackColor = false;
            btnConfirmarRetorno.Click += btnConfirmarRetorno_Click;
            // 
            // btnDevolverEstoque
            // 
            btnDevolverEstoque.BackColor = Color.FromArgb(20, 59, 102);
            btnDevolverEstoque.FlatStyle = FlatStyle.Flat;
            btnDevolverEstoque.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDevolverEstoque.ForeColor = Color.White;
            btnDevolverEstoque.Location = new Point(18, 20);
            btnDevolverEstoque.Name = "btnDevolverEstoque";
            btnDevolverEstoque.Size = new Size(190, 38);
            btnDevolverEstoque.TabIndex = 6;
            btnDevolverEstoque.Text = "Devolver ao Estoque";
            btnDevolverEstoque.UseVisualStyleBackColor = false;
            btnDevolverEstoque.Click += btnConfirmar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(130, 40, 40);
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(370, 20);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(150, 38);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvRetorno
            // 
            dgvRetorno.AllowUserToAddRows = false;
            dgvRetorno.AllowUserToDeleteRows = false;
            dgvRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRetorno.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRetorno.BackgroundColor = Color.White;
            dgvRetorno.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRetorno.Location = new Point(15, 130);
            dgvRetorno.MultiSelect = false;
            dgvRetorno.Name = "dgvRetorno";
            dgvRetorno.ReadOnly = true;
            dgvRetorno.RowHeadersVisible = false;
            dgvRetorno.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRetorno.Size = new Size(1300, 400);
            dgvRetorno.TabIndex = 1;
            // 
            // grpFiltros
            // 
            grpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFiltros.Controls.Add(btnLimparFiltro);
            grpFiltros.Controls.Add(btnPesquisar);
            grpFiltros.Controls.Add(cmbFiltroStatus);
            grpFiltros.Controls.Add(lblFiltroStatus);
            grpFiltros.Controls.Add(cmbFiltroUnidade);
            grpFiltros.Controls.Add(lblFiltroUnidade);
            grpFiltros.Controls.Add(txtFiltroNome);
            grpFiltros.Controls.Add(lblFiltroNome);
            grpFiltros.Location = new Point(15, 15);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1300, 100);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimparFiltro.BackColor = SystemColors.ButtonFace;
            btnLimparFiltro.FlatStyle = FlatStyle.Flat;
            btnLimparFiltro.ForeColor = Color.FromArgb(30, 30, 30);
            btnLimparFiltro.Location = new Point(1160, 52);
            btnLimparFiltro.Name = "btnLimparFiltro";
            btnLimparFiltro.Size = new Size(120, 32);
            btnLimparFiltro.TabIndex = 1;
            btnLimparFiltro.Text = "Limpar";
            btnLimparFiltro.UseVisualStyleBackColor = false;
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.FromArgb(20, 59, 102);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(1030, 52);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 32);
            btnPesquisar.TabIndex = 7;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // cmbFiltroStatus
            // 
            cmbFiltroStatus.AccessibleRole = AccessibleRole.OutlineButton;
            cmbFiltroStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroStatus.FormattingEnabled = true;
            cmbFiltroStatus.Location = new Point(600, 55);
            cmbFiltroStatus.Name = "cmbFiltroStatus";
            cmbFiltroStatus.Size = new Size(220, 23);
            cmbFiltroStatus.TabIndex = 6;
            // 
            // lblFiltroStatus
            // 
            lblFiltroStatus.AccessibleRole = AccessibleRole.OutlineButton;
            lblFiltroStatus.AutoSize = true;
            lblFiltroStatus.Location = new Point(600, 30);
            lblFiltroStatus.Name = "lblFiltroStatus";
            lblFiltroStatus.Size = new Size(42, 15);
            lblFiltroStatus.TabIndex = 5;
            lblFiltroStatus.Text = "Status:";
            // 
            // cmbFiltroUnidade
            // 
            cmbFiltroUnidade.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroUnidade.FormattingEnabled = true;
            cmbFiltroUnidade.Location = new Point(350, 55);
            cmbFiltroUnidade.Name = "cmbFiltroUnidade";
            cmbFiltroUnidade.Size = new Size(220, 23);
            cmbFiltroUnidade.TabIndex = 4;
            // 
            // lblFiltroUnidade
            // 
            lblFiltroUnidade.AutoSize = true;
            lblFiltroUnidade.Location = new Point(350, 30);
            lblFiltroUnidade.Name = "lblFiltroUnidade";
            lblFiltroUnidade.Size = new Size(54, 15);
            lblFiltroUnidade.TabIndex = 3;
            lblFiltroUnidade.Text = "Unidade:";
            // 
            // txtFiltroNome
            // 
            txtFiltroNome.Location = new Point(20, 55);
            txtFiltroNome.Name = "txtFiltroNome";
            txtFiltroNome.Size = new Size(300, 23);
            txtFiltroNome.TabIndex = 2;
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Location = new Point(20, 30);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(43, 15);
            lblFiltroNome.TabIndex = 1;
            lblFiltroNome.Text = "Nome:";
            // 
            // btnEvento
            // 
            btnEvento.BackColor = Color.FromArgb(30, 100, 170);
            btnEvento.FlatStyle = FlatStyle.Flat;
            btnEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvento.ForeColor = Color.White;
            btnEvento.Location = new Point(990, 20);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(150, 38);
            btnEvento.TabIndex = 8;
            btnEvento.Text = "<- Evento ";
            btnEvento.UseVisualStyleBackColor = false;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.FromArgb(30, 100, 170);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(1162, 19);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(150, 38);
            btnEstoque.TabIndex = 9;
            btnEstoque.Text = "Estoque ->";
            btnEstoque.UseVisualStyleBackColor = false;
            // 
            // btnSalvarRetorno
            // 
            btnSalvarRetorno.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvarRetorno.FlatStyle = FlatStyle.Flat;
            btnSalvarRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarRetorno.ForeColor = Color.White;
            btnSalvarRetorno.Location = new Point(214, 20);
            btnSalvarRetorno.Name = "btnSalvarRetorno";
            btnSalvarRetorno.Size = new Size(150, 38);
            btnSalvarRetorno.TabIndex = 10;
            btnSalvarRetorno.Text = "Salvar";
            btnSalvarRetorno.UseVisualStyleBackColor = false;
            // 
            // frmRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1350, 729);
            Controls.Add(tabControl1);
            Controls.Add(pnlResumoRetorno);
            Controls.Add(lblTitulo);
            Controls.Add(pnlCabecalho);
            MinimumSize = new Size(1100, 650);
            Name = "frmRetorno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retorno de Itens";
            pnlResumoRetorno.ResumeLayout(false);
            pnlResumoRetorno.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabDadosRetorno.ResumeLayout(false);
            pnlDadosEventoRetorno.ResumeLayout(false);
            pnlDadosEventoRetorno.PerformLayout();
            grpDetalhesEventoRetorno.ResumeLayout(false);
            grpDetalhesEventoRetorno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdPessoasRetorno).EndInit();
            grpInformações.ResumeLayout(false);
            grpInformações.PerformLayout();
            tabItensRetorno.ResumeLayout(false);
            pnlBotoesRetorno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRetorno).EndInit();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Panel pnlResumoRetorno;
        private Label lblEventoTitulo;
        private Label lblEventoValor;
        private Label lblDataValor;
        private Label lblDataTitulo;
        private Label lblResponsavelValor;
        private Label lblResponsavelTitulo;
        private TabControl tabControl1;
        private TabPage tabDadosRetorno;
        private TabPage tabItensRetorno;
        private GroupBox grpFiltros;
        private TextBox txtFiltroNome;
        private Label lblFiltroNome;
        private ComboBox cmbFiltroStatus;
        private Label lblFiltroStatus;
        private ComboBox cmbFiltroUnidade;
        private Label lblFiltroUnidade;
        private Button btnLimparFiltro;
        private Button btnPesquisar;
        private Panel pnlBotoesRetorno;
        private DataGridView dgvRetorno;
        private Button btnRemover;
        private Button btnDevolverEstoque;
        private Panel pnlDadosEventoRetorno;
        private GroupBox grpDetalhesEventoRetorno;
        private ComboBox cmbStatusEventoRetorno;
        private Label label5;
        private GroupBox grpInformações;
        private TextBox txtResponsavelEventoRetorno;
        private TextBox txtLocalEventoRetorno;
        private DateTimePicker dtpDataEventoRetorno;
        private TextBox txtNomeEventoRetorno;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblSubitituloDadosEventoRetorno;
        private Label lblTituloDadosEventoRetorno;
        private Label label10;
        private ComboBox cmbEventoSelecionado;
        private Button btnParaItensRetorno;
        private NumericUpDown nudQtdPessoasRetorno;
        private Label label9;
        private Button btnConfirmarRetorno;
        private Button btnEstoque;
        private Button btnEvento;
        private Button btnSalvarRetorno;
    }
}