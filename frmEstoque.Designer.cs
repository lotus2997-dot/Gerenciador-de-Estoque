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
            pnlCabecalho = new Panel();
            lblTitulo = new Label();
            pnlResumo = new Panel();
            panel1 = new Panel();
            lblVencimento = new Label();
            lblVencendoValor = new Label();
            panel2 = new Panel();
            lblMinimo = new Label();
            lblMinimoValor = new Label();
            pnlCardItens = new Panel();
            lblCardItensTitulo = new Label();
            lblItensCadastrados = new Label();
            tabEstoque = new TabControl();
            tabTodosItens = new TabPage();
            pnlBotoes = new Panel();
            btnRetorno = new Button();
            btnEvento = new Button();
            btnSalvarItemEstoque = new Button();
            btnAtualizarEstoque = new Button();
            btnEditar = new Button();
            btnRemover = new Button();
            btnNovoItem = new Button();
            dgvEstoque = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colQuantidade = new DataGridViewTextBoxColumn();
            colUnidade = new DataGridViewTextBoxColumn();
            colValidade = new DataGridViewTextBoxColumn();
            colQuantidadeMinima = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colObservacao = new DataGridViewTextBoxColumn();
            grpFiltros = new GroupBox();
            cmbFiltroStatus = new ComboBox();
            lblFilrosStatus = new Label();
            btnLimparFiltro = new Button();
            cmbFiltroCategoria = new ComboBox();
            btnPesquisar = new Button();
            lblFiltroCategoria = new Label();
            txtFiltroNome = new TextBox();
            lblFiltroNome = new Label();
            pnlCabecalho.SuspendLayout();
            pnlResumo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlCardItens.SuspendLayout();
            tabEstoque.SuspendLayout();
            tabTodosItens.SuspendLayout();
            pnlBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            grpFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1350, 70);
            pnlCabecalho.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(410, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GERENCIAMENTO DE ESTOQUE";
            // 
            // pnlResumo
            // 
            pnlResumo.Controls.Add(panel1);
            pnlResumo.Controls.Add(panel2);
            pnlResumo.Controls.Add(pnlCardItens);
            pnlResumo.Dock = DockStyle.Top;
            pnlResumo.Location = new Point(0, 70);
            pnlResumo.Name = "pnlResumo";
            pnlResumo.Size = new Size(1350, 95);
            pnlResumo.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblVencimento);
            panel1.Controls.Add(lblVencendoValor);
            panel1.Location = new Point(656, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 65);
            panel1.TabIndex = 20;
            // 
            // lblVencimento
            // 
            lblVencimento.AutoSize = true;
            lblVencimento.Location = new Point(60, 10);
            lblVencimento.Name = "lblVencimento";
            lblVencimento.Size = new Size(59, 15);
            lblVencimento.TabIndex = 0;
            lblVencimento.Text = "Vencendo";
            // 
            // lblVencendoValor
            // 
            lblVencendoValor.AutoSize = true;
            lblVencendoValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVencendoValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblVencendoValor.Location = new Point(75, 28);
            lblVencendoValor.Name = "lblVencendoValor";
            lblVencendoValor.Size = new Size(28, 32);
            lblVencendoValor.TabIndex = 1;
            lblVencendoValor.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblMinimo);
            panel2.Controls.Add(lblMinimoValor);
            panel2.Location = new Point(336, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(285, 65);
            panel2.TabIndex = 21;
            // 
            // lblMinimo
            // 
            lblMinimo.AutoSize = true;
            lblMinimo.Location = new Point(60, 10);
            lblMinimo.Name = "lblMinimo";
            lblMinimo.Size = new Size(105, 15);
            lblMinimo.TabIndex = 0;
            lblMinimo.Text = "Abaixo do mínimo";
            // 
            // lblMinimoValor
            // 
            lblMinimoValor.AutoSize = true;
            lblMinimoValor.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMinimoValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblMinimoValor.Location = new Point(87, 32);
            lblMinimoValor.Name = "lblMinimoValor";
            lblMinimoValor.Size = new Size(28, 32);
            lblMinimoValor.TabIndex = 1;
            lblMinimoValor.Text = "0";
            // 
            // pnlCardItens
            // 
            pnlCardItens.BackColor = Color.White;
            pnlCardItens.BorderStyle = BorderStyle.FixedSingle;
            pnlCardItens.Controls.Add(lblCardItensTitulo);
            pnlCardItens.Controls.Add(lblItensCadastrados);
            pnlCardItens.Location = new Point(15, 15);
            pnlCardItens.Name = "pnlCardItens";
            pnlCardItens.Size = new Size(285, 65);
            pnlCardItens.TabIndex = 18;
            // 
            // lblCardItensTitulo
            // 
            lblCardItensTitulo.AutoSize = true;
            lblCardItensTitulo.Location = new Point(60, 10);
            lblCardItensTitulo.Name = "lblCardItensTitulo";
            lblCardItensTitulo.Size = new Size(98, 15);
            lblCardItensTitulo.TabIndex = 0;
            lblCardItensTitulo.Text = "Itens cadastrados";
            // 
            // lblItensCadastrados
            // 
            lblItensCadastrados.AutoSize = true;
            lblItensCadastrados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItensCadastrados.ForeColor = Color.FromArgb(20, 59, 102);
            lblItensCadastrados.Location = new Point(82, 28);
            lblItensCadastrados.Name = "lblItensCadastrados";
            lblItensCadastrados.Size = new Size(28, 32);
            lblItensCadastrados.TabIndex = 1;
            lblItensCadastrados.Text = "0";
            // 
            // tabEstoque
            // 
            tabEstoque.Controls.Add(tabTodosItens);
            tabEstoque.Dock = DockStyle.Fill;
            tabEstoque.Location = new Point(0, 165);
            tabEstoque.Name = "tabEstoque";
            tabEstoque.SelectedIndex = 0;
            tabEstoque.Size = new Size(1350, 564);
            tabEstoque.TabIndex = 18;
            // 
            // tabTodosItens
            // 
            tabTodosItens.Controls.Add(pnlBotoes);
            tabTodosItens.Controls.Add(dgvEstoque);
            tabTodosItens.Controls.Add(grpFiltros);
            tabTodosItens.Location = new Point(4, 24);
            tabTodosItens.Name = "tabTodosItens";
            tabTodosItens.Padding = new Padding(3);
            tabTodosItens.Size = new Size(1342, 536);
            tabTodosItens.TabIndex = 0;
            tabTodosItens.Text = "Todos os itens";
            tabTodosItens.UseVisualStyleBackColor = true;
            // 
            // pnlBotoes
            // 
            pnlBotoes.BackColor = Color.White;
            pnlBotoes.Controls.Add(btnRetorno);
            pnlBotoes.Controls.Add(btnEvento);
            pnlBotoes.Controls.Add(btnSalvarItemEstoque);
            pnlBotoes.Controls.Add(btnAtualizarEstoque);
            pnlBotoes.Controls.Add(btnEditar);
            pnlBotoes.Controls.Add(btnRemover);
            pnlBotoes.Controls.Add(btnNovoItem);
            pnlBotoes.Dock = DockStyle.Bottom;
            pnlBotoes.Location = new Point(3, 463);
            pnlBotoes.Name = "pnlBotoes";
            pnlBotoes.Size = new Size(1336, 70);
            pnlBotoes.TabIndex = 7;
            // 
            // btnRetorno
            // 
            btnRetorno.BackColor = Color.FromArgb(30, 100, 170);
            btnRetorno.FlatStyle = FlatStyle.Flat;
            btnRetorno.ForeColor = Color.White;
            btnRetorno.Location = new Point(991, 18);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(140, 35);
            btnRetorno.TabIndex = 8;
            btnRetorno.Text = "<- Retorno";
            btnRetorno.UseVisualStyleBackColor = false;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // btnEvento
            // 
            btnEvento.BackColor = Color.FromArgb(30, 100, 170);
            btnEvento.FlatStyle = FlatStyle.Flat;
            btnEvento.ForeColor = Color.White;
            btnEvento.Location = new Point(1137, 18);
            btnEvento.Name = "btnEvento";
            btnEvento.Size = new Size(140, 35);
            btnEvento.TabIndex = 7;
            btnEvento.Text = "Evento ->";
            btnEvento.UseVisualStyleBackColor = false;
            btnEvento.Click += btnEvento_Click;
            // 
            // btnSalvarItemEstoque
            // 
            btnSalvarItemEstoque.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvarItemEstoque.FlatStyle = FlatStyle.Flat;
            btnSalvarItemEstoque.ForeColor = Color.White;
            btnSalvarItemEstoque.Location = new Point(483, 18);
            btnSalvarItemEstoque.Name = "btnSalvarItemEstoque";
            btnSalvarItemEstoque.Size = new Size(140, 35);
            btnSalvarItemEstoque.TabIndex = 6;
            btnSalvarItemEstoque.Text = "Salvar";
            btnSalvarItemEstoque.UseVisualStyleBackColor = false;
            btnSalvarItemEstoque.Click += btnSalvarItemEstoque_Click;
            // 
            // btnAtualizarEstoque
            // 
            btnAtualizarEstoque.BackColor = Color.FromArgb(20, 59, 102);
            btnAtualizarEstoque.FlatStyle = FlatStyle.Flat;
            btnAtualizarEstoque.ForeColor = Color.White;
            btnAtualizarEstoque.Location = new Point(337, 18);
            btnAtualizarEstoque.Name = "btnAtualizarEstoque";
            btnAtualizarEstoque.Size = new Size(140, 35);
            btnAtualizarEstoque.TabIndex = 5;
            btnAtualizarEstoque.Text = "Atualizar";
            btnAtualizarEstoque.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(20, 59, 102);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(191, 18);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(140, 35);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(140, 40, 40);
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(629, 18);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(140, 35);
            btnRemover.TabIndex = 3;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            btnRemover.Click += btnRemover_Click;
            // 
            // btnNovoItem
            // 
            btnNovoItem.BackColor = Color.FromArgb(20, 59, 102);
            btnNovoItem.FlatStyle = FlatStyle.Flat;
            btnNovoItem.ForeColor = Color.White;
            btnNovoItem.Location = new Point(45, 18);
            btnNovoItem.Name = "btnNovoItem";
            btnNovoItem.Size = new Size(140, 35);
            btnNovoItem.TabIndex = 0;
            btnNovoItem.Text = "Novo Item";
            btnNovoItem.UseVisualStyleBackColor = false;
            btnNovoItem.Click += btnNovoItem_Click;
            // 
            // dgvEstoque
            // 
            dgvEstoque.AllowUserToAddRows = false;
            dgvEstoque.AllowUserToDeleteRows = false;
            dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.BackgroundColor = Color.White;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colCategoria, colQuantidade, colUnidade, colValidade, colQuantidadeMinima, colStatus, colObservacao });
            dgvEstoque.EnableHeadersVisualStyles = false;
            dgvEstoque.Location = new Point(15, 120);
            dgvEstoque.MultiSelect = false;
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.ReadOnly = true;
            dgvEstoque.RowHeadersVisible = false;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstoque.Size = new Size(1300, 330);
            dgvEstoque.TabIndex = 6;
            // 
            // colId
            // 
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            // 
            // colQuantidade
            // 
            colQuantidade.HeaderText = "Quantidade";
            colQuantidade.Name = "colQuantidade";
            colQuantidade.ReadOnly = true;
            // 
            // colUnidade
            // 
            colUnidade.HeaderText = "Unidade";
            colUnidade.Name = "colUnidade";
            colUnidade.ReadOnly = true;
            // 
            // colValidade
            // 
            colValidade.HeaderText = "Validade";
            colValidade.Name = "colValidade";
            colValidade.ReadOnly = true;
            // 
            // colQuantidadeMinima
            // 
            colQuantidadeMinima.HeaderText = "Qtd. Mínima";
            colQuantidadeMinima.Name = "colQuantidadeMinima";
            colQuantidadeMinima.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status\n";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colObservacao
            // 
            colObservacao.HeaderText = "Observação";
            colObservacao.Name = "colObservacao";
            colObservacao.ReadOnly = true;
            // 
            // grpFiltros
            // 
            grpFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFiltros.Controls.Add(cmbFiltroStatus);
            grpFiltros.Controls.Add(lblFilrosStatus);
            grpFiltros.Controls.Add(btnLimparFiltro);
            grpFiltros.Controls.Add(cmbFiltroCategoria);
            grpFiltros.Controls.Add(btnPesquisar);
            grpFiltros.Controls.Add(lblFiltroCategoria);
            grpFiltros.Controls.Add(txtFiltroNome);
            grpFiltros.Controls.Add(lblFiltroNome);
            grpFiltros.Location = new Point(15, 15);
            grpFiltros.Name = "grpFiltros";
            grpFiltros.Size = new Size(1300, 90);
            grpFiltros.TabIndex = 0;
            grpFiltros.TabStop = false;
            grpFiltros.Text = "Filtros";
            // 
            // cmbFiltroStatus
            // 
            cmbFiltroStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroStatus.FormattingEnabled = true;
            cmbFiltroStatus.Location = new Point(520, 50);
            cmbFiltroStatus.Name = "cmbFiltroStatus";
            cmbFiltroStatus.Size = new Size(220, 23);
            cmbFiltroStatus.TabIndex = 5;
            // 
            // lblFilrosStatus
            // 
            lblFilrosStatus.AutoSize = true;
            lblFilrosStatus.Location = new Point(520, 25);
            lblFilrosStatus.Name = "lblFilrosStatus";
            lblFilrosStatus.Size = new Size(42, 15);
            lblFilrosStatus.TabIndex = 4;
            lblFilrosStatus.Text = "Status:";
            // 
            // btnLimparFiltro
            // 
            btnLimparFiltro.BackColor = Color.WhiteSmoke;
            btnLimparFiltro.FlatStyle = FlatStyle.Flat;
            btnLimparFiltro.ForeColor = Color.Black;
            btnLimparFiltro.Location = new Point(1155, 33);
            btnLimparFiltro.Name = "btnLimparFiltro";
            btnLimparFiltro.Size = new Size(120, 30);
            btnLimparFiltro.TabIndex = 5;
            btnLimparFiltro.Text = "Limpar";
            btnLimparFiltro.UseVisualStyleBackColor = false;
            btnLimparFiltro.Click += btnLimparFiltro_Click;
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(280, 50);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(220, 23);
            cmbFiltroCategoria.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.FromArgb(20, 59, 102);
            btnPesquisar.FlatStyle = FlatStyle.Flat;
            btnPesquisar.ForeColor = Color.White;
            btnPesquisar.Location = new Point(1029, 33);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(120, 30);
            btnPesquisar.TabIndex = 4;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.AutoSize = true;
            lblFiltroCategoria.Location = new Point(280, 25);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(61, 15);
            lblFiltroCategoria.TabIndex = 2;
            lblFiltroCategoria.Text = "Categoria:";
            // 
            // txtFiltroNome
            // 
            txtFiltroNome.Location = new Point(20, 50);
            txtFiltroNome.Name = "txtFiltroNome";
            txtFiltroNome.Size = new Size(240, 23);
            txtFiltroNome.TabIndex = 1;
            // 
            // lblFiltroNome
            // 
            lblFiltroNome.AutoSize = true;
            lblFiltroNome.Location = new Point(20, 25);
            lblFiltroNome.Name = "lblFiltroNome";
            lblFiltroNome.Size = new Size(43, 15);
            lblFiltroNome.TabIndex = 0;
            lblFiltroNome.Text = "Nome:";
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1350, 729);
            Controls.Add(tabEstoque);
            Controls.Add(pnlResumo);
            Controls.Add(pnlCabecalho);
            Name = "frmEstoque";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerenciamento de Estoque";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlResumo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlCardItens.ResumeLayout(false);
            pnlCardItens.PerformLayout();
            tabEstoque.ResumeLayout(false);
            tabTodosItens.ResumeLayout(false);
            pnlBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Panel pnlResumo;
        private Panel pnlCardItens;
        private Label lblItensCadastrados;
        private Label lblCardItensTitulo;
        private Panel panel1;
        private Label lblVencimento;
        private Label lblVencendoValor;
        private Panel panel2;
        private Label lblMinimo;
        private Label lblMinimoValor;
        private TabControl tabEstoque;
        private TabPage tabTodosItens;
        private GroupBox grpFiltros;
        private TextBox txtFiltroNome;
        private Label lblFiltroNome;
        private Label lblFiltroCategoria;
        private ComboBox cmbFiltroStatus;
        private Label lblFilrosStatus;
        private ComboBox cmbFiltroCategoria;
        private Button btnLimparFiltro;
        private Button btnPesquisar;
        private DataGridView dgvEstoque;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colQuantidade;
        private DataGridViewTextBoxColumn colUnidade;
        private DataGridViewTextBoxColumn colValidade;
        private DataGridViewTextBoxColumn colQuantidadeMinima;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colObservacao;
        private Panel pnlBotoes;
        private Button btnEditar;
        private Button btnRemover;
        private Button btnNovoItem;
        private Button btnAtualizarEstoque;
        private Button btnEvento;
        private Button btnSalvarItemEstoque;
        private Button btnRetorno;
    }
}