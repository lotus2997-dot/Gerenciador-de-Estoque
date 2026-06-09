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
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            pnlResumoEvento = new Panel();
            lblResponsavelValor = new Label();
            label13 = new Label();
            lblResponsavelTitulo = new Label();
            cmbEventoSelecionadoE = new ComboBox();
            lblLocalValor = new Label();
            lblLocalTitulo = new Label();
            lblDataValor = new Label();
            lblDataTitulo = new Label();
            lblEventoValor = new Label();
            lblEventoTitulo = new Label();
            tabItensEvento = new TabPage();
            pnlBotoesItens = new Panel();
            btnSalvar = new Button();
            btnRetorno = new Button();
            btnEstoque = new Button();
            btnConfirmarSeparacao = new Button();
            btnRemoverItem = new Button();
            btnEditarItem = new Button();
            btnNovoItem = new Button();
            dgvItensEvento = new DataGridView();
            btnLimparFiltro = new Button();
            btnPesquisar = new Button();
            grpFiltros = new GroupBox();
            lblFiltroStatus = new Label();
            cmbFiltroStatus = new ComboBox();
            cmbFiltroCategoria = new ComboBox();
            txtFiltroNome = new TextBox();
            lblFiltroCategoria = new Label();
            lblFiltroNome = new Label();
            tabDadosEvento = new TabPage();
            pnlDadosEvento = new Panel();
            btnParaItens = new Button();
            btnSalvarDadosEvento = new Button();
            btnLimparDadosEvento = new Button();
            grpDetalhesEvento = new GroupBox();
            nudQtdPessoas = new NumericUpDown();
            label9 = new Label();
            cmbStatusEvento = new ComboBox();
            label5 = new Label();
            grpInformaçõesPrincipais = new GroupBox();
            txtResponsavelEvento = new TextBox();
            txtLocalEvento = new TextBox();
            dtpDataEvento = new DateTimePicker();
            txtNomeEvento = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblSubitituloDadosEvento = new Label();
            lblTituloDadosEvento = new Label();
            tabControl1 = new TabControl();
            pnlCabecalho.SuspendLayout();
            pnlResumoEvento.SuspendLayout();
            tabItensEvento.SuspendLayout();
            pnlBotoesItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensEvento).BeginInit();
            grpFiltros.SuspendLayout();
            tabDadosEvento.SuspendLayout();
            pnlDadosEvento.SuspendLayout();
            grpDetalhesEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdPessoas).BeginInit();
            grpInformaçõesPrincipais.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1350, 75);
            pnlCabecalho.TabIndex = 9;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(423, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GERENCIAMENTO DE EVENTO";
            // 
            // pnlResumoEvento
            // 
            pnlResumoEvento.Controls.Add(lblResponsavelValor);
            pnlResumoEvento.Controls.Add(label13);
            pnlResumoEvento.Controls.Add(lblResponsavelTitulo);
            pnlResumoEvento.Controls.Add(cmbEventoSelecionadoE);
            pnlResumoEvento.Controls.Add(lblLocalValor);
            pnlResumoEvento.Controls.Add(lblLocalTitulo);
            pnlResumoEvento.Controls.Add(lblDataValor);
            pnlResumoEvento.Controls.Add(lblDataTitulo);
            pnlResumoEvento.Controls.Add(lblEventoValor);
            pnlResumoEvento.Controls.Add(lblEventoTitulo);
            pnlResumoEvento.Dock = DockStyle.Top;
            pnlResumoEvento.Location = new Point(0, 75);
            pnlResumoEvento.Name = "pnlResumoEvento";
            pnlResumoEvento.Size = new Size(1350, 90);
            pnlResumoEvento.TabIndex = 10;
            // 
            // lblResponsavelValor
            // 
            lblResponsavelValor.AutoSize = true;
            lblResponsavelValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsavelValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblResponsavelValor.Location = new Point(900, 45);
            lblResponsavelValor.Name = "lblResponsavelValor";
            lblResponsavelValor.Size = new Size(111, 20);
            lblResponsavelValor.TabIndex = 11;
            lblResponsavelValor.Text = "Administrador";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1102, 20);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 10;
            label13.Text = "Evento:";
            // 
            // lblResponsavelTitulo
            // 
            lblResponsavelTitulo.AutoSize = true;
            lblResponsavelTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResponsavelTitulo.Location = new Point(900, 20);
            lblResponsavelTitulo.Name = "lblResponsavelTitulo";
            lblResponsavelTitulo.Size = new Size(84, 17);
            lblResponsavelTitulo.TabIndex = 11;
            lblResponsavelTitulo.Text = "Responsável:";
            // 
            // cmbEventoSelecionadoE
            // 
            cmbEventoSelecionadoE.FormattingEnabled = true;
            cmbEventoSelecionadoE.Location = new Point(1102, 42);
            cmbEventoSelecionadoE.Name = "cmbEventoSelecionadoE";
            cmbEventoSelecionadoE.Size = new Size(165, 23);
            cmbEventoSelecionadoE.TabIndex = 9;
            cmbEventoSelecionadoE.SelectedIndexChanged += cmbEventoSelecionadoE_SelectedIndexChanged;
            // 
            // lblLocalValor
            // 
            lblLocalValor.AutoSize = true;
            lblLocalValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblLocalValor.Location = new Point(620, 45);
            lblLocalValor.Name = "lblLocalValor";
            lblLocalValor.Size = new Size(119, 20);
            lblLocalValor.TabIndex = 11;
            lblLocalValor.Text = "Local do Evento";
            // 
            // lblLocalTitulo
            // 
            lblLocalTitulo.AutoSize = true;
            lblLocalTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalTitulo.ForeColor = SystemColors.ControlText;
            lblLocalTitulo.Location = new Point(620, 20);
            lblLocalTitulo.Name = "lblLocalTitulo";
            lblLocalTitulo.Size = new Size(41, 17);
            lblLocalTitulo.TabIndex = 11;
            lblLocalTitulo.Text = "Local:";
            // 
            // lblDataValor
            // 
            lblDataValor.AutoSize = true;
            lblDataValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblDataValor.Location = new Point(360, 45);
            lblDataValor.Name = "lblDataValor";
            lblDataValor.Size = new Size(95, 20);
            lblDataValor.TabIndex = 12;
            lblDataValor.Text = "28/04/2026";
            // 
            // lblDataTitulo
            // 
            lblDataTitulo.AutoSize = true;
            lblDataTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataTitulo.Location = new Point(360, 20);
            lblDataTitulo.Name = "lblDataTitulo";
            lblDataTitulo.Size = new Size(38, 17);
            lblDataTitulo.TabIndex = 11;
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
            lblEventoValor.TabIndex = 1;
            lblEventoValor.Text = "Nome do Evento";
            // 
            // lblEventoTitulo
            // 
            lblEventoTitulo.AutoSize = true;
            lblEventoTitulo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEventoTitulo.ForeColor = Color.FromArgb(40, 40, 40);
            lblEventoTitulo.Location = new Point(40, 20);
            lblEventoTitulo.Name = "lblEventoTitulo";
            lblEventoTitulo.Size = new Size(50, 17);
            lblEventoTitulo.TabIndex = 0;
            lblEventoTitulo.Text = "Evento:";
            // 
            // tabItensEvento
            // 
            tabItensEvento.Controls.Add(pnlBotoesItens);
            tabItensEvento.Controls.Add(dgvItensEvento);
            tabItensEvento.Controls.Add(btnLimparFiltro);
            tabItensEvento.Controls.Add(btnPesquisar);
            tabItensEvento.Controls.Add(grpFiltros);
            tabItensEvento.Location = new Point(4, 26);
            tabItensEvento.Name = "tabItensEvento";
            tabItensEvento.Padding = new Padding(3);
            tabItensEvento.Size = new Size(1342, 534);
            tabItensEvento.TabIndex = 1;
            tabItensEvento.Text = "Itens do Evento";
            tabItensEvento.UseVisualStyleBackColor = true;
            // 
            // pnlBotoesItens
            // 
            pnlBotoesItens.BackColor = Color.White;
            pnlBotoesItens.Controls.Add(btnSalvar);
            pnlBotoesItens.Controls.Add(btnRetorno);
            pnlBotoesItens.Controls.Add(btnEstoque);
            pnlBotoesItens.Controls.Add(btnConfirmarSeparacao);
            pnlBotoesItens.Controls.Add(btnRemoverItem);
            pnlBotoesItens.Controls.Add(btnEditarItem);
            pnlBotoesItens.Controls.Add(btnNovoItem);
            pnlBotoesItens.Dock = DockStyle.Bottom;
            pnlBotoesItens.Location = new Point(3, 451);
            pnlBotoesItens.Name = "pnlBotoesItens";
            pnlBotoesItens.Size = new Size(1336, 80);
            pnlBotoesItens.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.ForeColor = Color.White;
            btnSalvar.Location = new Point(342, 20);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(150, 38);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnRetorno
            // 
            btnRetorno.BackColor = Color.FromArgb(30, 100, 170);
            btnRetorno.FlatStyle = FlatStyle.Flat;
            btnRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetorno.ForeColor = Color.White;
            btnRetorno.Location = new Point(1162, 20);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(150, 38);
            btnRetorno.TabIndex = 9;
            btnRetorno.Text = "Retorno ->";
            btnRetorno.UseVisualStyleBackColor = false;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.FromArgb(30, 100, 170);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Location = new Point(1006, 20);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(150, 38);
            btnEstoque.TabIndex = 8;
            btnEstoque.Text = "<- Estoque";
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnConfirmarSeparacao
            // 
            btnConfirmarSeparacao.BackColor = Color.FromArgb(0, 140, 70);
            btnConfirmarSeparacao.FlatStyle = FlatStyle.Flat;
            btnConfirmarSeparacao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmarSeparacao.ForeColor = Color.White;
            btnConfirmarSeparacao.Location = new Point(654, 20);
            btnConfirmarSeparacao.Name = "btnConfirmarSeparacao";
            btnConfirmarSeparacao.Size = new Size(190, 38);
            btnConfirmarSeparacao.TabIndex = 7;
            btnConfirmarSeparacao.Text = "Confirmar Separação";
            btnConfirmarSeparacao.UseVisualStyleBackColor = false;
            btnConfirmarSeparacao.Click += btnConfirmarSeparacao_Click;
            // 
            // btnRemoverItem
            // 
            btnRemoverItem.BackColor = Color.FromArgb(130, 40, 40);
            btnRemoverItem.FlatStyle = FlatStyle.Flat;
            btnRemoverItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverItem.ForeColor = Color.White;
            btnRemoverItem.Location = new Point(498, 20);
            btnRemoverItem.Name = "btnRemoverItem";
            btnRemoverItem.Size = new Size(150, 38);
            btnRemoverItem.TabIndex = 2;
            btnRemoverItem.Text = "Remover";
            btnRemoverItem.UseVisualStyleBackColor = false;
            btnRemoverItem.Click += btnRemoverItem_Click;
            // 
            // btnEditarItem
            // 
            btnEditarItem.BackColor = Color.FromArgb(20, 59, 102);
            btnEditarItem.FlatStyle = FlatStyle.Flat;
            btnEditarItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarItem.ForeColor = Color.White;
            btnEditarItem.Location = new Point(186, 20);
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.Size = new Size(150, 38);
            btnEditarItem.TabIndex = 1;
            btnEditarItem.Text = "Editar";
            btnEditarItem.UseVisualStyleBackColor = false;
            btnEditarItem.Click += btnEditarItem_Click;
            // 
            // btnNovoItem
            // 
            btnNovoItem.BackColor = Color.FromArgb(20, 59, 102);
            btnNovoItem.FlatStyle = FlatStyle.Flat;
            btnNovoItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoItem.ForeColor = Color.White;
            btnNovoItem.Location = new Point(30, 20);
            btnNovoItem.Name = "btnNovoItem";
            btnNovoItem.Size = new Size(150, 38);
            btnNovoItem.TabIndex = 0;
            btnNovoItem.Text = "Novo Item";
            btnNovoItem.UseVisualStyleBackColor = false;
            btnNovoItem.Click += btnNovoItem_Click;
            // 
            // dgvItensEvento
            // 
            dgvItensEvento.AllowUserToAddRows = false;
            dgvItensEvento.AllowUserToDeleteRows = false;
            dgvItensEvento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItensEvento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensEvento.BackgroundColor = Color.White;
            dgvItensEvento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensEvento.Location = new Point(15, 130);
            dgvItensEvento.MultiSelect = false;
            dgvItensEvento.Name = "dgvItensEvento";
            dgvItensEvento.ReadOnly = true;
            dgvItensEvento.RowHeadersVisible = false;
            dgvItensEvento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensEvento.Size = new Size(1300, 400);
            dgvItensEvento.TabIndex = 5;
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
            btnLimparFiltro.TabIndex = 4;
            btnLimparFiltro.Text = "Limpar";
            btnLimparFiltro.UseVisualStyleBackColor = false;
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPesquisar.BackColor = Color.FromArgb(20, 59, 102);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(1030, 52);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 32);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // grpFiltros
            // 
            grpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFiltros.Controls.Add(lblFiltroStatus);
            grpFiltros.Controls.Add(cmbFiltroStatus);
            grpFiltros.Controls.Add(cmbFiltroCategoria);
            grpFiltros.Controls.Add(txtFiltroNome);
            grpFiltros.Controls.Add(lblFiltroCategoria);
            grpFiltros.Controls.Add(lblFiltroNome);
            grpFiltros.Location = new Point(15, 15);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1300, 100);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // lblFiltroStatus
            // 
            lblFiltroStatus.AutoSize = true;
            lblFiltroStatus.Location = new Point(601, 30);
            lblFiltroStatus.Name = "lblFiltroStatus";
            lblFiltroStatus.Size = new Size(46, 17);
            lblFiltroStatus.TabIndex = 3;
            lblFiltroStatus.Text = "Status:";
            // 
            // cmbFiltroStatus
            // 
            cmbFiltroStatus.FormattingEnabled = true;
            cmbFiltroStatus.Items.AddRange(new object[] { "Todos", "", "Separado", "", "Pendente", "", "Disponíve", "l", "Retornado" });
            cmbFiltroStatus.Location = new Point(600, 55);
            cmbFiltroStatus.Name = "cmbFiltroStatus";
            cmbFiltroStatus.Size = new Size(220, 25);
            cmbFiltroStatus.TabIndex = 4;
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Items.AddRange(new object[] { "Todas", "Bebidas", "Frutas", "Utensílios", "Descartáveis", "Outros" });
            cmbFiltroCategoria.Location = new Point(350, 55);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(220, 25);
            cmbFiltroCategoria.TabIndex = 3;
            // 
            // txtFiltroNome
            // 
            txtFiltroNome.Location = new Point(20, 55);
            txtFiltroNome.Name = "txtFiltroNome";
            txtFiltroNome.Size = new Size(300, 25);
            txtFiltroNome.TabIndex = 1;
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Location = new Point(350, 30);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(65, 17);
            lblFiltroCategoria.TabIndex = 2;
            lblFiltroCategoria.Text = "Categoria";
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Location = new Point(20, 30);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(47, 17);
            lblFiltroNome.TabIndex = 0;
            lblFiltroNome.Text = "Nome:";
            // 
            // tabDadosEvento
            // 
            tabDadosEvento.BackColor = Color.FromArgb(245, 247, 250);
            tabDadosEvento.Controls.Add(pnlDadosEvento);
            tabDadosEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabDadosEvento.Location = new Point(4, 26);
            tabDadosEvento.Name = "tabDadosEvento";
            tabDadosEvento.Padding = new Padding(3);
            tabDadosEvento.Size = new Size(1342, 534);
            tabDadosEvento.TabIndex = 0;
            tabDadosEvento.Text = "Dados do Evento";
            // 
            // pnlDadosEvento
            // 
            pnlDadosEvento.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlDadosEvento.BackColor = Color.White;
            pnlDadosEvento.Controls.Add(btnParaItens);
            pnlDadosEvento.Controls.Add(btnSalvarDadosEvento);
            pnlDadosEvento.Controls.Add(btnLimparDadosEvento);
            pnlDadosEvento.Controls.Add(grpDetalhesEvento);
            pnlDadosEvento.Controls.Add(grpInformaçõesPrincipais);
            pnlDadosEvento.Controls.Add(lblSubitituloDadosEvento);
            pnlDadosEvento.Controls.Add(lblTituloDadosEvento);
            pnlDadosEvento.Location = new Point(20, 20);
            pnlDadosEvento.Name = "pnlDadosEvento";
            pnlDadosEvento.Size = new Size(1290, 480);
            pnlDadosEvento.TabIndex = 0;
            // 
            // btnParaItens
            // 
            btnParaItens.BackColor = Color.FromArgb(30, 100, 170);
            btnParaItens.FlatStyle = FlatStyle.Flat;
            btnParaItens.ForeColor = Color.White;
            btnParaItens.Location = new Point(1113, 412);
            btnParaItens.Name = "btnParaItens";
            btnParaItens.Size = new Size(130, 36);
            btnParaItens.TabIndex = 6;
            btnParaItens.Text = "Ir para Itens";
            btnParaItens.UseVisualStyleBackColor = false;
            btnParaItens.Click += btnParaItens_Click;
            // 
            // btnSalvarDadosEvento
            // 
            btnSalvarDadosEvento.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvarDadosEvento.FlatStyle = FlatStyle.Flat;
            btnSalvarDadosEvento.ForeColor = Color.White;
            btnSalvarDadosEvento.Location = new Point(781, 412);
            btnSalvarDadosEvento.Name = "btnSalvarDadosEvento";
            btnSalvarDadosEvento.Size = new Size(140, 36);
            btnSalvarDadosEvento.TabIndex = 5;
            btnSalvarDadosEvento.Text = "Salvar Dados";
            btnSalvarDadosEvento.UseVisualStyleBackColor = false;
            btnSalvarDadosEvento.Click += btnSalvarDadosEvento_Click;
            // 
            // btnLimparDadosEvento
            // 
            btnLimparDadosEvento.AutoSize = true;
            btnLimparDadosEvento.BackColor = Color.FromArgb(230, 230, 230);
            btnLimparDadosEvento.FlatStyle = FlatStyle.Flat;
            btnLimparDadosEvento.ForeColor = SystemColors.ControlText;
            btnLimparDadosEvento.Location = new Point(960, 412);
            btnLimparDadosEvento.Name = "btnLimparDadosEvento";
            btnLimparDadosEvento.Size = new Size(110, 36);
            btnLimparDadosEvento.TabIndex = 4;
            btnLimparDadosEvento.Text = "Limpar";
            btnLimparDadosEvento.UseVisualStyleBackColor = false;
            btnLimparDadosEvento.Click += btnLimparDadosEvento_Click;
            // 
            // grpDetalhesEvento
            // 
            grpDetalhesEvento.Controls.Add(nudQtdPessoas);
            grpDetalhesEvento.Controls.Add(label9);
            grpDetalhesEvento.Controls.Add(cmbStatusEvento);
            grpDetalhesEvento.Controls.Add(label5);
            grpDetalhesEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDetalhesEvento.Location = new Point(650, 90);
            grpDetalhesEvento.Name = "grpDetalhesEvento";
            grpDetalhesEvento.Size = new Size(600, 276);
            grpDetalhesEvento.TabIndex = 3;
            grpDetalhesEvento.TabStop = false;
            grpDetalhesEvento.Text = "Detalhes do evento";
            // 
            // nudQtdPessoas
            // 
            nudQtdPessoas.Font = new Font("Segoe UI", 9.75F);
            nudQtdPessoas.Location = new Point(20, 110);
            nudQtdPessoas.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQtdPessoas.Name = "nudQtdPessoas";
            nudQtdPessoas.Size = new Size(211, 25);
            nudQtdPessoas.TabIndex = 10;
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
            // cmbStatusEvento
            // 
            cmbStatusEvento.Font = new Font("Segoe UI", 9.75F);
            cmbStatusEvento.FormattingEnabled = true;
            cmbStatusEvento.Location = new Point(20, 57);
            cmbStatusEvento.Name = "cmbStatusEvento";
            cmbStatusEvento.Size = new Size(200, 25);
            cmbStatusEvento.TabIndex = 4;
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
            // grpInformaçõesPrincipais
            // 
            grpInformaçõesPrincipais.Controls.Add(txtResponsavelEvento);
            grpInformaçõesPrincipais.Controls.Add(txtLocalEvento);
            grpInformaçõesPrincipais.Controls.Add(dtpDataEvento);
            grpInformaçõesPrincipais.Controls.Add(txtNomeEvento);
            grpInformaçõesPrincipais.Controls.Add(label4);
            grpInformaçõesPrincipais.Controls.Add(label3);
            grpInformaçõesPrincipais.Controls.Add(label2);
            grpInformaçõesPrincipais.Controls.Add(label1);
            grpInformaçõesPrincipais.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpInformaçõesPrincipais.Location = new Point(25, 90);
            grpInformaçõesPrincipais.Name = "grpInformaçõesPrincipais";
            grpInformaçõesPrincipais.Size = new Size(600, 276);
            grpInformaçõesPrincipais.TabIndex = 2;
            grpInformaçõesPrincipais.TabStop = false;
            grpInformaçõesPrincipais.Text = "Informações principais";
            // 
            // txtResponsavelEvento
            // 
            txtResponsavelEvento.Font = new Font("Segoe UI", 9.75F);
            txtResponsavelEvento.Location = new Point(22, 216);
            txtResponsavelEvento.Name = "txtResponsavelEvento";
            txtResponsavelEvento.Size = new Size(197, 25);
            txtResponsavelEvento.TabIndex = 7;
            // 
            // txtLocalEvento
            // 
            txtLocalEvento.Font = new Font("Segoe UI", 9.75F);
            txtLocalEvento.Location = new Point(25, 161);
            txtLocalEvento.Name = "txtLocalEvento";
            txtLocalEvento.Size = new Size(197, 25);
            txtLocalEvento.TabIndex = 6;
            // 
            // dtpDataEvento
            // 
            dtpDataEvento.Font = new Font("Segoe UI", 9.75F);
            dtpDataEvento.Format = DateTimePickerFormat.Short;
            dtpDataEvento.Location = new Point(22, 110);
            dtpDataEvento.Name = "dtpDataEvento";
            dtpDataEvento.Size = new Size(200, 25);
            dtpDataEvento.TabIndex = 5;
            // 
            // txtNomeEvento
            // 
            txtNomeEvento.Font = new Font("Segoe UI", 9.75F);
            txtNomeEvento.Location = new Point(22, 57);
            txtNomeEvento.Name = "txtNomeEvento";
            txtNomeEvento.Size = new Size(200, 25);
            txtNomeEvento.TabIndex = 4;
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
            // lblSubitituloDadosEvento
            // 
            lblSubitituloDadosEvento.AutoSize = true;
            lblSubitituloDadosEvento.ForeColor = SystemColors.WindowFrame;
            lblSubitituloDadosEvento.Location = new Point(27, 55);
            lblSubitituloDadosEvento.Name = "lblSubitituloDadosEvento";
            lblSubitituloDadosEvento.Size = new Size(421, 17);
            lblSubitituloDadosEvento.TabIndex = 1;
            lblSubitituloDadosEvento.Text = "Preencha os dados principais antes de separar os itens para o evento.";
            // 
            // lblTituloDadosEvento
            // 
            lblTituloDadosEvento.AutoSize = true;
            lblTituloDadosEvento.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloDadosEvento.ForeColor = Color.FromArgb(20, 59, 102);
            lblTituloDadosEvento.Location = new Point(25, 20);
            lblTituloDadosEvento.Name = "lblTituloDadosEvento";
            lblTituloDadosEvento.Size = new Size(240, 30);
            lblTituloDadosEvento.TabIndex = 0;
            lblTituloDadosEvento.Text = "Informações do Evento";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDadosEvento);
            tabControl1.Controls.Add(tabItensEvento);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 165);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1350, 564);
            tabControl1.TabIndex = 11;
            // 
            // frmEventos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1350, 729);
            Controls.Add(tabControl1);
            Controls.Add(pnlResumoEvento);
            Controls.Add(pnlCabecalho);
            MinimumSize = new Size(1100, 650);
            Name = "frmEventos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Evento";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlResumoEvento.ResumeLayout(false);
            pnlResumoEvento.PerformLayout();
            tabItensEvento.ResumeLayout(false);
            pnlBotoesItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItensEvento).EndInit();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            tabDadosEvento.ResumeLayout(false);
            pnlDadosEvento.ResumeLayout(false);
            pnlDadosEvento.PerformLayout();
            grpDetalhesEvento.ResumeLayout(false);
            grpDetalhesEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQtdPessoas).EndInit();
            grpInformaçõesPrincipais.ResumeLayout(false);
            grpInformaçõesPrincipais.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Panel pnlResumoEvento;
        private Label lblEventoValor;
        private Label lblEventoTitulo;
        private Label lblDataTitulo;
        private Label lblLocalTitulo;
        private Label lblDataValor;
        private Label lblResponsavelTitulo;
        private Label lblLocalValor;
        private Label lblResponsavelValor;
        private Label label13;
        private ComboBox cmbEventoSelecionadoE;
        private TabPage tabItensEvento;
        private Panel pnlBotoesItens;
        private Button btnConfirmarSeparacao;
        private Button btnRemoverItem;
        private Button btnEditarItem;
        private Button btnNovoItem;
        private DataGridView dgvItensEvento;
        private Button btnLimparFiltro;
        private Button btnPesquisar;
        private GroupBox grpFiltros;
        private Label lblFiltroStatus;
        private ComboBox cmbFiltroStatus;
        private ComboBox cmbFiltroCategoria;
        private TextBox txtFiltroNome;
        private Label lblFiltroCategoria;
        private Label lblFiltroNome;
        private TabPage tabDadosEvento;
        private Panel pnlDadosEvento;
        private Button btnParaItens;
        private Button btnSalvarDadosEvento;
        private Button btnLimparDadosEvento;
        private GroupBox grpDetalhesEvento;
        private NumericUpDown nudQtdPessoas;
        private Label label9;
        private ComboBox cmbStatusEvento;
        private Label label5;
        private GroupBox grpInformaçõesPrincipais;
        private TextBox txtResponsavelEvento;
        private TextBox txtLocalEvento;
        private DateTimePicker dtpDataEvento;
        private TextBox txtNomeEvento;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label lblSubitituloDadosEvento;
        private Label lblTituloDadosEvento;
        private TabControl tabControl1;
        private Button btnRetorno;
        private Button btnEstoque;
        private Button btnSalvar;
    }
}