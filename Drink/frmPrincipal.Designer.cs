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
            lblUsuario = new Label();
            panelMenu = new Panel();
            btnDashboard = new Button();
            btnHistorico = new Button();
            btnRetorno = new Button();
            btnEventos = new Button();
            btnEstoque = new Button();
            panelLogo = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            tcDrink = new TabControl();
            pgPrincipal = new TabPage();
            pgDash = new TabPage();
            panel2 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            lblProtudosV = new Label();
            label10 = new Label();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            pnlBancoPBE = new Panel();
            lblPrutudosB = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            pnlBancoPC = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            tcDrink.SuspendLayout();
            pgDash.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(511, 8);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(19, 55, 99);
            panelMenu.Controls.Add(btnDashboard);
            panelMenu.Controls.Add(btnHistorico);
            panelMenu.Controls.Add(btnRetorno);
            panelMenu.Controls.Add(btnEventos);
            panelMenu.Controls.Add(btnEstoque);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(163, 715);
            panelMenu.TabIndex = 1;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 369);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(163, 60);
            btnDashboard.TabIndex = 5;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Dock = DockStyle.Top;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI", 11F);
            btnHistorico.ForeColor = Color.White;
            btnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorico.Location = new Point(0, 309);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(163, 60);
            btnHistorico.TabIndex = 5;
            btnHistorico.Text = "Historico de eventos";
            btnHistorico.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnRetorno
            // 
            btnRetorno.Dock = DockStyle.Top;
            btnRetorno.FlatAppearance.BorderSize = 0;
            btnRetorno.FlatStyle = FlatStyle.Flat;
            btnRetorno.Font = new Font("Segoe UI", 11F);
            btnRetorno.ForeColor = Color.White;
            btnRetorno.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetorno.Location = new Point(0, 249);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(163, 60);
            btnRetorno.TabIndex = 4;
            btnRetorno.Text = "Retorno";
            btnRetorno.TextAlign = ContentAlignment.MiddleLeft;
            btnRetorno.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetorno.UseVisualStyleBackColor = true;
            btnRetorno.Click += btnRetorno_Click;
            // 
            // btnEventos
            // 
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 11F);
            btnEventos.ForeColor = Color.White;
            btnEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventos.Location = new Point(0, 189);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(163, 60);
            btnEventos.TabIndex = 3;
            btnEventos.Text = "Eventos";
            btnEventos.TextAlign = ContentAlignment.MiddleLeft;
            btnEventos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEventos.UseVisualStyleBackColor = true;
            btnEventos.Click += btnEventos_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Dock = DockStyle.Top;
            btnEstoque.FlatAppearance.BorderSize = 0;
            btnEstoque.FlatStyle = FlatStyle.Flat;
            btnEstoque.Font = new Font("Segoe UI", 11F);
            btnEstoque.ForeColor = Color.White;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 129);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(163, 60);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(19, 55, 99);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(163, 129);
            panelLogo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 55, 99);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(163, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 78);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 23);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 0;
            label1.Text = "Menu principal";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // tcDrink
            // 
            tcDrink.Alignment = TabAlignment.Bottom;
            tcDrink.Controls.Add(pgPrincipal);
            tcDrink.Controls.Add(pgDash);
            tcDrink.Location = new Point(163, 75);
            tcDrink.Multiline = true;
            tcDrink.Name = "tcDrink";
            tcDrink.SelectedIndex = 0;
            tcDrink.Size = new Size(1094, 661);
            tcDrink.TabIndex = 3;
            // 
            // pgPrincipal
            // 
            pgPrincipal.Location = new Point(4, 4);
            pgPrincipal.Name = "pgPrincipal";
            pgPrincipal.Padding = new Padding(3);
            pgPrincipal.Size = new Size(1086, 633);
            pgPrincipal.TabIndex = 0;
            pgPrincipal.Text = "pgPrincipal";
            pgPrincipal.UseVisualStyleBackColor = true;
            // 
            // pgDash
            // 
            pgDash.Controls.Add(panel2);
            pgDash.Location = new Point(4, 4);
            pgDash.Name = "pgDash";
            pgDash.Padding = new Padding(3);
            pgDash.Size = new Size(1086, 633);
            pgDash.TabIndex = 1;
            pgDash.Text = "pgDash";
            pgDash.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1080, 627);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(lblProtudosV);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(725, 47);
            panel5.Name = "panel5";
            panel5.Size = new Size(350, 577);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.WhiteSmoke;
            panel6.Location = new Point(3, 61);
            panel6.Name = "panel6";
            panel6.Size = new Size(344, 514);
            panel6.TabIndex = 9;
            // 
            // lblProtudosV
            // 
            lblProtudosV.AutoSize = true;
            lblProtudosV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProtudosV.ForeColor = Color.DarkSeaGreen;
            lblProtudosV.Location = new Point(111, 16);
            lblProtudosV.Name = "lblProtudosV";
            lblProtudosV.Size = new Size(173, 20);
            lblProtudosV.TabIndex = 8;
            lblProtudosV.Text = "NUMERO DE PROTUDOS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(59, 43);
            label10.Name = "label10";
            label10.Size = new Size(229, 15);
            label10.TabIndex = 7;
            label10.Text = "PROTUDOS COM VENCIMENTO PROXIMO";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 1);
            label11.Name = "label11";
            label11.Size = new Size(115, 15);
            label11.TabIndex = 6;
            label11.Text = "VALIDADE PROXIMA";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Livro;
            pictureBox3.Location = new Point(3, 1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(pnlBancoPBE);
            panel4.Controls.Add(lblPrutudosB);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(359, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(360, 577);
            panel4.TabIndex = 2;
            // 
            // pnlBancoPBE
            // 
            pnlBancoPBE.BackColor = Color.WhiteSmoke;
            pnlBancoPBE.Location = new Point(3, 61);
            pnlBancoPBE.Name = "pnlBancoPBE";
            pnlBancoPBE.Size = new Size(354, 514);
            pnlBancoPBE.TabIndex = 9;
            // 
            // lblPrutudosB
            // 
            lblPrutudosB.AutoSize = true;
            lblPrutudosB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrutudosB.ForeColor = Color.Goldenrod;
            lblPrutudosB.Location = new Point(116, 16);
            lblPrutudosB.Name = "lblPrutudosB";
            lblPrutudosB.Size = new Size(173, 20);
            lblPrutudosB.TabIndex = 8;
            lblPrutudosB.Text = "NUMERO DE PROTUDOS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 43);
            label7.Name = "label7";
            label7.Size = new Size(186, 15);
            label7.TabIndex = 7;
            label7.Text = "PROTUDOS COM BAIXO ESTUQUE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 1);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 6;
            label8.Text = "BAIXO ESTOQUE";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Livro;
            pictureBox2.Location = new Point(3, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(pnlBancoPC);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(3, 47);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 577);
            panel3.TabIndex = 1;
            // 
            // pnlBancoPC
            // 
            pnlBancoPC.BackColor = Color.WhiteSmoke;
            pnlBancoPC.Location = new Point(3, 63);
            pnlBancoPC.Name = "pnlBancoPC";
            pnlBancoPC.Size = new Size(344, 514);
            pnlBancoPC.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(111, 18);
            label5.Name = "label5";
            label5.Size = new Size(173, 20);
            label5.TabIndex = 3;
            label5.Text = "NUMERO DE PROTUDOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 45);
            label4.Name = "label4";
            label4.Size = new Size(203, 15);
            label4.TabIndex = 2;
            label4.Text = "TOTAL DE PROTUDOS CADASTRADOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 3);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "PROTUDOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Livro;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Silver;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(504, 10);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "DASHBOARD";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 252);
            ClientSize = new Size(1257, 715);
            Controls.Add(tcDrink);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drink Manager";
            FormClosed += frmPrincipal_FormClosed;
            Load += frmPrincipal_Load;
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tcDrink.ResumeLayout(false);
            pgDash.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsuario;
        private Panel panelMenu;
        private Panel panelLogo;
        private Button btnEstoque;
        private Button btnRetorno;
        private Button btnEventos;
        private Panel panel1;
        private Label label1;
        private Button btnHistorico;
        private Button btnDashboard;
        private TabControl tcDrink;
        private TabPage pgPrincipal;
        private Panel panel2;
        private Label label2;
        private TabPage pgDash;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel pnlBancoPC;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Label lblProtudosV;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox3;
        private Panel pnlBancoPBE;
        private Label lblPrutudosB;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox2;
    }
}