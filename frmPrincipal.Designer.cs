namespace Drink
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlMenuLateral = new Panel();
            btnConfiguracao = new Button();
            btnRetorno = new Button();
            btnEventos = new Button();
            btnEstoque = new Button();
            pnlAreaPrincipal = new Panel();
            pnlConteudo = new Panel();
            pnlProximoEvento = new Panel();
            btnVerEvento = new Button();
            lblLocalProximoEvento = new Label();
            lblItensProximoEvento = new Label();
            lblDataProximoEvento = new Label();
            lblNomeProximoEvento = new Label();
            lblProximoEventoTitulo = new Label();
            pnlMovimentacoes = new Panel();
            lstMovimentacoes = new ListBox();
            lblUltimasMovimentacoes = new Label();
            pnlCardAlertas = new Panel();
            lblDescAlertas = new Label();
            lblAlertas = new Label();
            lblTituloCardAlertas = new Label();
            pnlCardRetorno = new Panel();
            lblDescRetorno = new Label();
            lblItensRetorno = new Label();
            lblTituloCardRetorno = new Label();
            pnlCardEvento = new Panel();
            lblDescEventos = new Label();
            lblEventosAtivos = new Label();
            lblTituloCardEventos = new Label();
            pnlCardEstoque = new Panel();
            lblDescEstoque = new Label();
            lblTotalEstoque = new Label();
            lblTituloCardEstoque = new Label();
            pnlRodape = new Panel();
            lblRodape = new Label();
            pnlTopo = new Panel();
            lblTituloPagina = new Label();
            pnlMenuLateral.SuspendLayout();
            pnlAreaPrincipal.SuspendLayout();
            pnlConteudo.SuspendLayout();
            pnlProximoEvento.SuspendLayout();
            pnlMovimentacoes.SuspendLayout();
            pnlCardAlertas.SuspendLayout();
            pnlCardRetorno.SuspendLayout();
            pnlCardEvento.SuspendLayout();
            pnlCardEstoque.SuspendLayout();
            pnlRodape.SuspendLayout();
            pnlTopo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.BackColor = Color.FromArgb(20, 59, 102);
            pnlMenuLateral.Controls.Add(btnConfiguracao);
            pnlMenuLateral.Controls.Add(btnRetorno);
            pnlMenuLateral.Controls.Add(btnEventos);
            pnlMenuLateral.Controls.Add(btnEstoque);
            pnlMenuLateral.Dock = DockStyle.Left;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(220, 729);
            pnlMenuLateral.TabIndex = 1;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.BackColor = Color.FromArgb(30, 100, 170);
            btnConfiguracao.FlatAppearance.BorderSize = 0;
            btnConfiguracao.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 85, 145);
            btnConfiguracao.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 170);
            btnConfiguracao.FlatStyle = FlatStyle.Flat;
            btnConfiguracao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfiguracao.ForeColor = Color.White;
            btnConfiguracao.Image = (Image)resources.GetObject("btnConfiguracao.Image");
            btnConfiguracao.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.Location = new Point(0, 252);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Padding = new Padding(25, 0, 0, 0);
            btnConfiguracao.Size = new Size(220, 50);
            btnConfiguracao.TabIndex = 5;
            btnConfiguracao.Text = "Configuração";
            btnConfiguracao.TextAlign = ContentAlignment.MiddleLeft;
            btnConfiguracao.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConfiguracao.UseVisualStyleBackColor = false;
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // btnRetorno
            // 
            btnRetorno.BackColor = Color.FromArgb(30, 100, 170);
            btnRetorno.FlatAppearance.BorderSize = 0;
            btnRetorno.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 85, 145);
            btnRetorno.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 170);
            btnRetorno.FlatStyle = FlatStyle.Flat;
            btnRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetorno.ForeColor = Color.White;
            btnRetorno.Image = (Image)resources.GetObject("btnRetorno.Image");
            btnRetorno.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetorno.Location = new Point(0, 196);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Padding = new Padding(25, 0, 0, 0);
            btnRetorno.Size = new Size(220, 50);
            btnRetorno.TabIndex = 4;
            btnRetorno.Text = "Retorno";
            btnRetorno.TextAlign = ContentAlignment.MiddleLeft;
            btnRetorno.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetorno.UseVisualStyleBackColor = false;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // btnEventos
            // 
            btnEventos.BackColor = Color.FromArgb(30, 100, 170);
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 85, 145);
            btnEventos.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 170);
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEventos.ForeColor = Color.White;
            btnEventos.Image = (Image)resources.GetObject("btnEventos.Image");
            btnEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventos.Location = new Point(0, 141);
            btnEventos.Name = "btnEventos";
            btnEventos.Padding = new Padding(25, 0, 0, 0);
            btnEventos.Size = new Size(220, 50);
            btnEventos.TabIndex = 3;
            btnEventos.Text = "Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEventos.UseVisualStyleBackColor = false;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.BackColor = Color.FromArgb(30, 100, 170);
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatAppearance.MouseDownBackColor = Color.FromArgb(25, 85, 170);
            btnEstoque.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 100, 170);
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.Image = (Image)resources.GetObject("btnEstoque.Image");
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 85);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Padding = new Padding(25, 0, 0, 0);
            btnEstoque.Size = new Size(220, 50);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = false;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // pnlAreaPrincipal
            // 
            pnlAreaPrincipal.Controls.Add(pnlConteudo);
            pnlAreaPrincipal.Controls.Add(pnlRodape);
            pnlAreaPrincipal.Controls.Add(pnlTopo);
            pnlAreaPrincipal.Dock = DockStyle.Fill;
            pnlAreaPrincipal.Location = new Point(220, 0);
            pnlAreaPrincipal.Name = "pnlAreaPrincipal";
            pnlAreaPrincipal.Size = new Size(1130, 729);
            pnlAreaPrincipal.TabIndex = 3;
            // 
            // pnlConteudo
            // 
            pnlConteudo.AutoScroll = true;
            pnlConteudo.Controls.Add(pnlProximoEvento);
            pnlConteudo.Controls.Add(pnlMovimentacoes);
            pnlConteudo.Controls.Add(pnlCardAlertas);
            pnlConteudo.Controls.Add(pnlCardRetorno);
            pnlConteudo.Controls.Add(pnlCardEvento);
            pnlConteudo.Controls.Add(pnlCardEstoque);
            pnlConteudo.Dock = DockStyle.Fill;
            pnlConteudo.Location = new Point(0, 85);
            pnlConteudo.Name = "pnlConteudo";
            pnlConteudo.Size = new Size(1130, 609);
            pnlConteudo.TabIndex = 2;
            // 
            // pnlProximoEvento
            // 
            pnlProximoEvento.BackColor = Color.White;
            pnlProximoEvento.BorderStyle = BorderStyle.FixedSingle;
            pnlProximoEvento.Controls.Add(btnVerEvento);
            pnlProximoEvento.Controls.Add(lblLocalProximoEvento);
            pnlProximoEvento.Controls.Add(lblItensProximoEvento);
            pnlProximoEvento.Controls.Add(lblDataProximoEvento);
            pnlProximoEvento.Controls.Add(lblNomeProximoEvento);
            pnlProximoEvento.Controls.Add(lblProximoEventoTitulo);
            pnlProximoEvento.Location = new Point(675, 194);
            pnlProximoEvento.Name = "pnlProximoEvento";
            pnlProximoEvento.Size = new Size(350, 401);
            pnlProximoEvento.TabIndex = 5;
            // 
            // btnVerEvento
            // 
            btnVerEvento.BackColor = Color.FromArgb(20, 59, 102);
            btnVerEvento.FlatStyle = FlatStyle.Flat;
            btnVerEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerEvento.ForeColor = Color.White;
            btnVerEvento.Location = new Point(20, 326);
            btnVerEvento.Name = "btnVerEvento";
            btnVerEvento.Size = new Size(300, 35);
            btnVerEvento.TabIndex = 5;
            btnVerEvento.Text = "Ver detalhes";
            btnVerEvento.UseVisualStyleBackColor = false;
            btnVerEvento.Click += btnVerEvento_Click;
            // 
            // lblLocalProximoEvento
            // 
            lblLocalProximoEvento.AutoSize = true;
            lblLocalProximoEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocalProximoEvento.Location = new Point(20, 130);
            lblLocalProximoEvento.Name = "lblLocalProximoEvento";
            lblLocalProximoEvento.Size = new Size(130, 17);
            lblLocalProximoEvento.TabIndex = 4;
            lblLocalProximoEvento.Text = "Local: Espaço Jardim";
            // 
            // lblItensProximoEvento
            // 
            lblItensProximoEvento.AutoSize = true;
            lblItensProximoEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItensProximoEvento.Location = new Point(20, 160);
            lblItensProximoEvento.Name = "lblItensProximoEvento";
            lblItensProximoEvento.Size = new Size(125, 17);
            lblItensProximoEvento.TabIndex = 3;
            lblItensProximoEvento.Text = "Itens reservados: 86";
            // 
            // lblDataProximoEvento
            // 
            lblDataProximoEvento.AutoSize = true;
            lblDataProximoEvento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataProximoEvento.Location = new Point(20, 100);
            lblDataProximoEvento.Name = "lblDataProximoEvento";
            lblDataProximoEvento.Size = new Size(108, 17);
            lblDataProximoEvento.TabIndex = 2;
            lblDataProximoEvento.Text = "Data: 28/04/2026";
            // 
            // lblNomeProximoEvento
            // 
            lblNomeProximoEvento.AutoSize = true;
            lblNomeProximoEvento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeProximoEvento.ForeColor = Color.FromArgb(20, 59, 102);
            lblNomeProximoEvento.Location = new Point(20, 60);
            lblNomeProximoEvento.Name = "lblNomeProximoEvento";
            lblNomeProximoEvento.Size = new Size(123, 21);
            lblNomeProximoEvento.TabIndex = 1;
            lblNomeProximoEvento.Text = "Nome da Festa";
            // 
            // lblProximoEventoTitulo
            // 
            lblProximoEventoTitulo.AutoSize = true;
            lblProximoEventoTitulo.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProximoEventoTitulo.ForeColor = Color.FromArgb(30, 30, 30);
            lblProximoEventoTitulo.Location = new Point(20, 15);
            lblProximoEventoTitulo.Name = "lblProximoEventoTitulo";
            lblProximoEventoTitulo.Size = new Size(136, 23);
            lblProximoEventoTitulo.TabIndex = 0;
            lblProximoEventoTitulo.Text = "Próximo evento";
            // 
            // pnlMovimentacoes
            // 
            pnlMovimentacoes.BackColor = Color.White;
            pnlMovimentacoes.BorderStyle = BorderStyle.FixedSingle;
            pnlMovimentacoes.Controls.Add(lstMovimentacoes);
            pnlMovimentacoes.Controls.Add(lblUltimasMovimentacoes);
            pnlMovimentacoes.Location = new Point(30, 194);
            pnlMovimentacoes.Name = "pnlMovimentacoes";
            pnlMovimentacoes.Size = new Size(620, 400);
            pnlMovimentacoes.TabIndex = 4;
            // 
            // lstMovimentacoes
            // 
            lstMovimentacoes.BorderStyle = BorderStyle.None;
            lstMovimentacoes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstMovimentacoes.FormattingEnabled = true;
            lstMovimentacoes.Location = new Point(20, 55);
            lstMovimentacoes.Name = "lstMovimentacoes";
            lstMovimentacoes.Size = new Size(575, 306);
            lstMovimentacoes.TabIndex = 1;
            // 
            // lblUltimasMovimentacoes
            // 
            lblUltimasMovimentacoes.AutoSize = true;
            lblUltimasMovimentacoes.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUltimasMovimentacoes.ForeColor = Color.FromArgb(30, 30, 30);
            lblUltimasMovimentacoes.Location = new Point(20, 15);
            lblUltimasMovimentacoes.Name = "lblUltimasMovimentacoes";
            lblUltimasMovimentacoes.Size = new Size(201, 23);
            lblUltimasMovimentacoes.TabIndex = 0;
            lblUltimasMovimentacoes.Text = "Últimas movimentações";
            // 
            // pnlCardAlertas
            // 
            pnlCardAlertas.BackColor = Color.White;
            pnlCardAlertas.BorderStyle = BorderStyle.FixedSingle;
            pnlCardAlertas.Controls.Add(lblDescAlertas);
            pnlCardAlertas.Controls.Add(lblAlertas);
            pnlCardAlertas.Controls.Add(lblTituloCardAlertas);
            pnlCardAlertas.Location = new Point(795, 30);
            pnlCardAlertas.Name = "pnlCardAlertas";
            pnlCardAlertas.Size = new Size(230, 110);
            pnlCardAlertas.TabIndex = 3;
            // 
            // lblDescAlertas
            // 
            lblDescAlertas.AutoSize = true;
            lblDescAlertas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescAlertas.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescAlertas.Location = new Point(21, 80);
            lblDescAlertas.Name = "lblDescAlertas";
            lblDescAlertas.Size = new Size(161, 17);
            lblDescAlertas.TabIndex = 10;
            lblDescAlertas.Text = "Itens precisam de atenção";
            // 
            // lblAlertas
            // 
            lblAlertas.AutoSize = true;
            lblAlertas.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlertas.ForeColor = Color.FromArgb(20, 59, 102);
            lblAlertas.Location = new Point(21, 31);
            lblAlertas.Name = "lblAlertas";
            lblAlertas.Size = new Size(38, 45);
            lblAlertas.TabIndex = 9;
            lblAlertas.Text = "0";
            // 
            // lblTituloCardAlertas
            // 
            lblTituloCardAlertas.AutoSize = true;
            lblTituloCardAlertas.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloCardAlertas.ForeColor = Color.FromArgb(80, 80, 80);
            lblTituloCardAlertas.Location = new Point(21, 14);
            lblTituloCardAlertas.Name = "lblTituloCardAlertas";
            lblTituloCardAlertas.Size = new Size(48, 17);
            lblTituloCardAlertas.TabIndex = 8;
            lblTituloCardAlertas.Text = "Alertas";
            // 
            // pnlCardRetorno
            // 
            pnlCardRetorno.BackColor = Color.White;
            pnlCardRetorno.BorderStyle = BorderStyle.FixedSingle;
            pnlCardRetorno.Controls.Add(lblDescRetorno);
            pnlCardRetorno.Controls.Add(lblItensRetorno);
            pnlCardRetorno.Controls.Add(lblTituloCardRetorno);
            pnlCardRetorno.Location = new Point(540, 30);
            pnlCardRetorno.Name = "pnlCardRetorno";
            pnlCardRetorno.Size = new Size(230, 110);
            pnlCardRetorno.TabIndex = 2;
            // 
            // lblDescRetorno
            // 
            lblDescRetorno.AutoSize = true;
            lblDescRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescRetorno.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescRetorno.Location = new Point(18, 80);
            lblDescRetorno.Name = "lblDescRetorno";
            lblDescRetorno.Size = new Size(152, 17);
            lblDescRetorno.TabIndex = 7;
            lblDescRetorno.Text = "Aguardando conferência";
            // 
            // lblItensRetorno
            // 
            lblItensRetorno.AutoSize = true;
            lblItensRetorno.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItensRetorno.ForeColor = Color.FromArgb(20, 59, 102);
            lblItensRetorno.Location = new Point(18, 31);
            lblItensRetorno.Name = "lblItensRetorno";
            lblItensRetorno.Size = new Size(38, 45);
            lblItensRetorno.TabIndex = 6;
            lblItensRetorno.Text = "0";
            // 
            // lblTituloCardRetorno
            // 
            lblTituloCardRetorno.AutoSize = true;
            lblTituloCardRetorno.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloCardRetorno.ForeColor = Color.FromArgb(80, 80, 80);
            lblTituloCardRetorno.Location = new Point(18, 14);
            lblTituloCardRetorno.Name = "lblTituloCardRetorno";
            lblTituloCardRetorno.Size = new Size(108, 17);
            lblTituloCardRetorno.TabIndex = 5;
            lblTituloCardRetorno.Text = "Itens em Retorno";
            // 
            // pnlCardEvento
            // 
            pnlCardEvento.BackColor = Color.White;
            pnlCardEvento.BorderStyle = BorderStyle.FixedSingle;
            pnlCardEvento.Controls.Add(lblDescEventos);
            pnlCardEvento.Controls.Add(lblEventosAtivos);
            pnlCardEvento.Controls.Add(lblTituloCardEventos);
            pnlCardEvento.Location = new Point(280, 30);
            pnlCardEvento.Name = "pnlCardEvento";
            pnlCardEvento.Size = new Size(230, 110);
            pnlCardEvento.TabIndex = 1;
            // 
            // lblDescEventos
            // 
            lblDescEventos.AutoSize = true;
            lblDescEventos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescEventos.ForeColor = Color.FromArgb(80, 80, 80);
            lblDescEventos.Location = new Point(19, 82);
            lblDescEventos.Name = "lblDescEventos";
            lblDescEventos.Size = new Size(146, 17);
            lblDescEventos.TabIndex = 4;
            lblDescEventos.Text = "Eventos em Andamento";
            // 
            // lblEventosAtivos
            // 
            lblEventosAtivos.AutoSize = true;
            lblEventosAtivos.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEventosAtivos.ForeColor = Color.FromArgb(20, 59, 102);
            lblEventosAtivos.Location = new Point(19, 32);
            lblEventosAtivos.Name = "lblEventosAtivos";
            lblEventosAtivos.Size = new Size(38, 45);
            lblEventosAtivos.TabIndex = 3;
            lblEventosAtivos.Text = "0";
            // 
            // lblTituloCardEventos
            // 
            lblTituloCardEventos.AutoSize = true;
            lblTituloCardEventos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloCardEventos.ForeColor = Color.FromArgb(80, 80, 80);
            lblTituloCardEventos.Location = new Point(19, 17);
            lblTituloCardEventos.Name = "lblTituloCardEventos";
            lblTituloCardEventos.Size = new Size(86, 17);
            lblTituloCardEventos.TabIndex = 0;
            lblTituloCardEventos.Text = "Evento Ativos";
            // 
            // pnlCardEstoque
            // 
            pnlCardEstoque.BackColor = Color.White;
            pnlCardEstoque.BorderStyle = BorderStyle.FixedSingle;
            pnlCardEstoque.Controls.Add(lblDescEstoque);
            pnlCardEstoque.Controls.Add(lblTotalEstoque);
            pnlCardEstoque.Controls.Add(lblTituloCardEstoque);
            pnlCardEstoque.Location = new Point(30, 30);
            pnlCardEstoque.Name = "pnlCardEstoque";
            pnlCardEstoque.Size = new Size(230, 110);
            pnlCardEstoque.TabIndex = 0;
            // 
            // lblDescEstoque
            // 
            lblDescEstoque.AutoSize = true;
            lblDescEstoque.Location = new Point(15, 82);
            lblDescEstoque.Name = "lblDescEstoque";
            lblDescEstoque.Size = new Size(135, 15);
            lblDescEstoque.TabIndex = 3;
            lblDescEstoque.Text = "Ingredientes Disponíveis";
            // 
            // lblTotalEstoque
            // 
            lblTotalEstoque.AutoSize = true;
            lblTotalEstoque.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalEstoque.ForeColor = Color.FromArgb(20, 59, 102);
            lblTotalEstoque.Location = new Point(15, 32);
            lblTotalEstoque.Name = "lblTotalEstoque";
            lblTotalEstoque.Size = new Size(38, 45);
            lblTotalEstoque.TabIndex = 2;
            lblTotalEstoque.Text = "0";
            // 
            // lblTituloCardEstoque
            // 
            lblTituloCardEstoque.AutoSize = true;
            lblTituloCardEstoque.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloCardEstoque.ForeColor = Color.FromArgb(80, 80, 80);
            lblTituloCardEstoque.Location = new Point(15, 15);
            lblTituloCardEstoque.Name = "lblTituloCardEstoque";
            lblTituloCardEstoque.Size = new Size(108, 17);
            lblTituloCardEstoque.TabIndex = 1;
            lblTituloCardEstoque.Text = "Itens em estoque";
            // 
            // pnlRodape
            // 
            pnlRodape.BackColor = Color.FromArgb(20, 59, 102);
            pnlRodape.Controls.Add(lblRodape);
            pnlRodape.Dock = DockStyle.Bottom;
            pnlRodape.Location = new Point(0, 694);
            pnlRodape.Name = "pnlRodape";
            pnlRodape.Size = new Size(1130, 35);
            pnlRodape.TabIndex = 1;
            // 
            // lblRodape
            // 
            lblRodape.AutoSize = true;
            lblRodape.ForeColor = Color.White;
            lblRodape.Location = new Point(15, 9);
            lblRodape.Name = "lblRodape";
            lblRodape.Size = new Size(198, 15);
            lblRodape.TabIndex = 2;
            lblRodape.Text = "Sistema Drink Manager  •  Versão 1.0";
            // 
            // pnlTopo
            // 
            pnlTopo.BackColor = Color.FromArgb(20, 59, 102);
            pnlTopo.Controls.Add(lblTituloPagina);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(1130, 85);
            pnlTopo.TabIndex = 0;
            // 
            // lblTituloPagina
            // 
            lblTituloPagina.Anchor = AnchorStyles.Top;
            lblTituloPagina.AutoSize = true;
            lblTituloPagina.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPagina.ForeColor = Color.White;
            lblTituloPagina.Location = new Point(401, 9);
            lblTituloPagina.Name = "lblTituloPagina";
            lblTituloPagina.Size = new Size(225, 40);
            lblTituloPagina.TabIndex = 0;
            lblTituloPagina.Text = "Menu Principal";
            lblTituloPagina.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1350, 729);
            Controls.Add(pnlAreaPrincipal);
            Controls.Add(pnlMenuLateral);
            MinimumSize = new Size(1100, 650);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drink Manager";
            FormClosed += frmPrincipal_FormClosed;
            Load += frmPrincipal_Load;
            pnlMenuLateral.ResumeLayout(false);
            pnlAreaPrincipal.ResumeLayout(false);
            pnlConteudo.ResumeLayout(false);
            pnlProximoEvento.ResumeLayout(false);
            pnlProximoEvento.PerformLayout();
            pnlMovimentacoes.ResumeLayout(false);
            pnlMovimentacoes.PerformLayout();
            pnlCardAlertas.ResumeLayout(false);
            pnlCardAlertas.PerformLayout();
            pnlCardRetorno.ResumeLayout(false);
            pnlCardRetorno.PerformLayout();
            pnlCardEvento.ResumeLayout(false);
            pnlCardEvento.PerformLayout();
            pnlCardEstoque.ResumeLayout(false);
            pnlCardEstoque.PerformLayout();
            pnlRodape.ResumeLayout(false);
            pnlRodape.PerformLayout();
            pnlTopo.ResumeLayout(false);
            pnlTopo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenuLateral;
        private Button btnEstoque;
        private Button btnRetorno;
        private Button btnEventos;
        private Button btnConfiguracao;
        private Panel pnlAreaPrincipal;
        private Panel pnlTopo;
        private Label lblTituloPagina;
        private Label lblRodape;
        private Panel pnlRodape;
        private Panel pnlConteudo;
        private Panel pnlCardEstoque;
        private Label lblTotalEstoque;
        private Label lblTituloCardEstoque;
        private Label lblDescEstoque;
        private Panel pnlCardEvento;
        private Label lblDescEventos;
        private Label lblEventosAtivos;
        private Label lblTituloCardEventos;
        private Panel pnlCardRetorno;
        private Label lblDescRetorno;
        private Label lblItensRetorno;
        private Label lblTituloCardRetorno;
        private Panel pnlCardAlertas;
        private Label lblDescAlertas;
        private Label lblAlertas;
        private Label lblTituloCardAlertas;
        private Panel pnlProximoEvento;
        private Panel pnlMovimentacoes;
        private ListBox lstMovimentacoes;
        private Label lblUltimasMovimentacoes;
        private Label lblNomeProximoEvento;
        private Label lblProximoEventoTitulo;
        private Button btnVerEvento;
        private Label lblLocalProximoEvento;
        private Label lblItensProximoEvento;
        private Label lblDataProximoEvento;
    }
}