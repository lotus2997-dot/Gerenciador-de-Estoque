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
            lblTotalItens = new Label();
            lblStatus = new Label();
            lblTitulo = new Label();
            pnlResumoRetorno = new Panel();
            btnConferirRetorno = new Button();
            lblResponsavelValor = new Label();
            lblDataValor = new Label();
            lblResponsavelTitulo = new Label();
            lblDataTitulo = new Label();
            lblEventoValor = new Label();
            lblEventoTitulo = new Label();
            tabControl1 = new TabControl();
            tabDadosRetorno = new TabPage();
            tabItensRetorno = new TabPage();
            pnlBotoesRetorno = new Panel();
            btnConfirmar = new Button();
            btnRemover = new Button();
            btnNovoItem = new Button();
            btnEditarItem = new Button();
            dataGridView1 = new DataGridView();
            grpFiltros = new GroupBox();
            btnLimparFiltro = new Button();
            btnPesquisar = new Button();
            cmbFiltroStatus = new ComboBox();
            lblFiltroStatus = new Label();
            cmbFiltroUnidade = new ComboBox();
            lblFiltroUnidade = new Label();
            txtFiltroNome = new TextBox();
            lblFiltroNome = new Label();
            tabConferencia = new TabPage();
            tabHistorico = new TabPage();
            pnlCabecalho.SuspendLayout();
            pnlResumoRetorno.SuspendLayout();
            tabControl1.SuspendLayout();
            tabItensRetorno.SuspendLayout();
            pnlBotoesRetorno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grpFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalho.Controls.Add(lblTotalItens);
            pnlCabecalho.Controls.Add(lblStatus);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1334, 75);
            pnlCabecalho.TabIndex = 0;
            // 
            // lblTotalItens
            // 
            lblTotalItens.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotalItens.AutoSize = true;
            lblTotalItens.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalItens.ForeColor = Color.White;
            lblTotalItens.Location = new Point(1160, 28);
            lblTotalItens.Name = "lblTotalItens";
            lblTotalItens.Size = new Size(107, 20);
            lblTotalItens.TabIndex = 2;
            lblTotalItens.Text = "Total de itens:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(950, 28);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(170, 20);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status: Em Conferência";
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
            pnlResumoRetorno.Controls.Add(btnConferirRetorno);
            pnlResumoRetorno.Controls.Add(lblResponsavelValor);
            pnlResumoRetorno.Controls.Add(lblDataValor);
            pnlResumoRetorno.Controls.Add(lblResponsavelTitulo);
            pnlResumoRetorno.Controls.Add(lblDataTitulo);
            pnlResumoRetorno.Controls.Add(lblEventoValor);
            pnlResumoRetorno.Controls.Add(lblEventoTitulo);
            pnlResumoRetorno.Dock = DockStyle.Top;
            pnlResumoRetorno.Location = new Point(0, 75);
            pnlResumoRetorno.Name = "pnlResumoRetorno";
            pnlResumoRetorno.Size = new Size(1334, 90);
            pnlResumoRetorno.TabIndex = 2;
            // 
            // btnConferirRetorno
            // 
            btnConferirRetorno.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConferirRetorno.BackColor = Color.FromArgb(30, 100, 170);
            btnConferirRetorno.FlatStyle = FlatStyle.Flat;
            btnConferirRetorno.ForeColor = Color.White;
            btnConferirRetorno.Location = new Point(1117, 27);
            btnConferirRetorno.Name = "btnConferirRetorno";
            btnConferirRetorno.Size = new Size(150, 38);
            btnConferirRetorno.TabIndex = 3;
            btnConferirRetorno.Text = "Conferir Retorno";
            btnConferirRetorno.UseVisualStyleBackColor = false;
            // 
            // lblResponsavelValor
            // 
            lblResponsavelValor.AutoSize = true;
            lblResponsavelValor.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResponsavelValor.ForeColor = Color.FromArgb(20, 59, 102);
            lblResponsavelValor.Location = new Point(900, 45);
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
            lblResponsavelTitulo.Location = new Point(900, 20);
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
            tabControl1.Controls.Add(tabConferencia);
            tabControl1.Controls.Add(tabHistorico);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 165);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1334, 525);
            tabControl1.TabIndex = 3;
            // 
            // tabDadosRetorno
            // 
            tabDadosRetorno.Location = new Point(4, 24);
            tabDadosRetorno.Name = "tabDadosRetorno";
            tabDadosRetorno.Padding = new Padding(3);
            tabDadosRetorno.Size = new Size(1326, 497);
            tabDadosRetorno.TabIndex = 0;
            tabDadosRetorno.Text = "Dados do Retorno\n";
            tabDadosRetorno.UseVisualStyleBackColor = true;
            // 
            // tabItensRetorno
            // 
            tabItensRetorno.Controls.Add(pnlBotoesRetorno);
            tabItensRetorno.Controls.Add(dataGridView1);
            tabItensRetorno.Controls.Add(grpFiltros);
            tabItensRetorno.Location = new Point(4, 24);
            tabItensRetorno.Name = "tabItensRetorno";
            tabItensRetorno.Padding = new Padding(3);
            tabItensRetorno.Size = new Size(1326, 497);
            tabItensRetorno.TabIndex = 1;
            tabItensRetorno.Text = "Itens do Retorno";
            tabItensRetorno.UseVisualStyleBackColor = true;
            // 
            // pnlBotoesRetorno
            // 
            pnlBotoesRetorno.BackColor = Color.White;
            pnlBotoesRetorno.Controls.Add(btnConfirmar);
            pnlBotoesRetorno.Controls.Add(btnRemover);
            pnlBotoesRetorno.Controls.Add(btnNovoItem);
            pnlBotoesRetorno.Controls.Add(btnEditarItem);
            pnlBotoesRetorno.Dock = DockStyle.Bottom;
            pnlBotoesRetorno.Location = new Point(3, 414);
            pnlBotoesRetorno.Name = "pnlBotoesRetorno";
            pnlBotoesRetorno.Size = new Size(1320, 80);
            pnlBotoesRetorno.TabIndex = 2;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.FromArgb(0, 140, 70);
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(650, 20);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(190, 38);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "Devolver ao Estoque";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnRemover
            // 
            btnRemover.BackColor = Color.FromArgb(130, 40, 40);
            btnRemover.FlatStyle = FlatStyle.Flat;
            btnRemover.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemover.ForeColor = Color.White;
            btnRemover.Location = new Point(420, 20);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(150, 38);
            btnRemover.TabIndex = 5;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = false;
            // 
            // btnNovoItem
            // 
            btnNovoItem.BackColor = Color.FromArgb(20, 59, 102);
            btnNovoItem.FlatStyle = FlatStyle.Flat;
            btnNovoItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNovoItem.ForeColor = Color.White;
            btnNovoItem.Location = new Point(30, 20);
            btnNovoItem.Name = "btnNovoItem";
            btnNovoItem.Size = new Size(150, 38);
            btnNovoItem.TabIndex = 3;
            btnNovoItem.Text = "Novo Item";
            btnNovoItem.UseVisualStyleBackColor = false;
            // 
            // btnEditarItem
            // 
            btnEditarItem.BackColor = Color.FromArgb(20, 59, 102);
            btnEditarItem.FlatStyle = FlatStyle.Flat;
            btnEditarItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarItem.ForeColor = Color.White;
            btnEditarItem.Location = new Point(220, 20);
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.Size = new Size(150, 38);
            btnEditarItem.TabIndex = 4;
            btnEditarItem.Text = "Editar";
            btnEditarItem.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(15, 130);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1300, 400);
            dataGridView1.TabIndex = 1;
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
            // tabConferencia
            // 
            tabConferencia.Location = new Point(4, 24);
            tabConferencia.Name = "tabConferencia";
            tabConferencia.Size = new Size(1326, 497);
            tabConferencia.TabIndex = 2;
            tabConferencia.Text = "Conferência";
            tabConferencia.UseVisualStyleBackColor = true;
            // 
            // tabHistorico
            // 
            tabHistorico.Location = new Point(4, 24);
            tabHistorico.Name = "tabHistorico";
            tabHistorico.Size = new Size(1326, 497);
            tabHistorico.TabIndex = 3;
            tabHistorico.Text = "Histórico";
            tabHistorico.UseVisualStyleBackColor = true;
            // 
            // frmRetorno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1334, 690);
            Controls.Add(tabControl1);
            Controls.Add(pnlResumoRetorno);
            Controls.Add(lblTitulo);
            Controls.Add(pnlCabecalho);
            MinimumSize = new Size(1100, 650);
            Name = "frmRetorno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Retorno de Itens";
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            pnlResumoRetorno.ResumeLayout(false);
            pnlResumoRetorno.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabItensRetorno.ResumeLayout(false);
            pnlBotoesRetorno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grpFiltros.ResumeLayout(false);
            grpFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCabecalho;
        private Label lblTitulo;
        private Label lblTotalItens;
        private Label lblStatus;
        private Panel pnlResumoRetorno;
        private Label lblEventoTitulo;
        private Label lblEventoValor;
        private Label lblDataValor;
        private Label lblDataTitulo;
        private Button btnConferirRetorno;
        private Label lblResponsavelValor;
        private Label lblResponsavelTitulo;
        private TabControl tabControl1;
        private TabPage tabDadosRetorno;
        private TabPage tabItensRetorno;
        private GroupBox grpFiltros;
        private TextBox txtFiltroNome;
        private Label lblFiltroNome;
        private TabPage tabConferencia;
        private TabPage tabHistorico;
        private ComboBox cmbFiltroStatus;
        private Label lblFiltroStatus;
        private ComboBox cmbFiltroUnidade;
        private Label lblFiltroUnidade;
        private Button btnLimparFiltro;
        private Button btnPesquisar;
        private Panel pnlBotoesRetorno;
        private DataGridView dataGridView1;
        private Button btnRemover;
        private Button btnNovoItem;
        private Button btnEditarItem;
        private Button btnConfirmar;
    }
}