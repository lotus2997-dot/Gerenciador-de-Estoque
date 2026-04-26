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
            lblUsuario = new Label();
            panelMenu = new Panel();
            button1 = new Button();
            btnRetorno = new Button();
            btnEventos = new Button();
            btnEstoque = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.None;
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.LightGray;
            lblUsuario.Location = new Point(167, 19);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(38, 15);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "label1";
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(51, 51, 76);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnRetorno);
            panelMenu.Controls.Add(btnEventos);
            panelMenu.Controls.Add(btnEstoque);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 588);
            panelMenu.TabIndex = 1;
            panelMenu.Paint += panelMenu_Paint;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11F);
            button1.ForeColor = Color.Gainsboro;
            button1.Image = Properties.Resources.Livro;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 260);
            button1.Name = "button1";
            button1.Size = new Size(220, 60);
            button1.TabIndex = 5;
            button1.Text = "Historico de eventos";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRetorno
            // 
            btnRetorno.Dock = DockStyle.Top;
            btnRetorno.FlatAppearance.BorderSize = 0;
            btnRetorno.FlatStyle = FlatStyle.Flat;
            btnRetorno.Font = new Font("Segoe UI", 11F);
            btnRetorno.ForeColor = Color.Gainsboro;
            btnRetorno.Image = Properties.Resources.revert;
            btnRetorno.ImageAlign = ContentAlignment.MiddleLeft;
            btnRetorno.Location = new Point(0, 200);
            btnRetorno.Name = "btnRetorno";
            btnRetorno.Size = new Size(220, 60);
            btnRetorno.TabIndex = 4;
            btnRetorno.Text = "Retorno";
            btnRetorno.TextAlign = ContentAlignment.MiddleLeft;
            btnRetorno.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRetorno.UseVisualStyleBackColor = true;
            // 
            // btnEventos
            // 
            btnEventos.Dock = DockStyle.Top;
            btnEventos.FlatAppearance.BorderSize = 0;
            btnEventos.FlatStyle = FlatStyle.Flat;
            btnEventos.Font = new Font("Segoe UI", 11F);
            btnEventos.ForeColor = Color.Gainsboro;
            btnEventos.Image = Properties.Resources.Calendario;
            btnEventos.ImageAlign = ContentAlignment.MiddleLeft;
            btnEventos.Location = new Point(0, 140);
            btnEventos.Name = "btnEventos";
            btnEventos.Size = new Size(220, 60);
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
            btnEstoque.ForeColor = Color.Gainsboro;
            btnEstoque.Image = Properties.Resources.Lista1;
            btnEstoque.ImageAlign = ContentAlignment.MiddleLeft;
            btnEstoque.Location = new Point(0, 80);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(220, 60);
            btnEstoque.TabIndex = 2;
            btnEstoque.Text = "Estoque";
            btnEstoque.TextAlign = ContentAlignment.MiddleLeft;
            btnEstoque.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(65, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 68);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Teal;
            panel1.CausesValidation = false;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Location = new Point(220, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 80);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(76, 42);
            label1.Name = "label1";
            label1.Size = new Size(209, 32);
            label1.TabIndex = 0;
            label1.Text = "Menu principal";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(734, 588);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drink Manager";
            FormClosed += frmPrincipal_FormClosed;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button button1;
        private PictureBox pictureBox1;
    }
}