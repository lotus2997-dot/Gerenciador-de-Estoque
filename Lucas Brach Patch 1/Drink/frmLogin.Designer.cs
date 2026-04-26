namespace Drink
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            btnLogin = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            BtVerSenha = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)BtVerSenha).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(12, 237);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 32);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Teal;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(12, 275);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(225, 31);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Silver;
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(12, 131);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(225, 22);
            txtUsuario.TabIndex = 4;
            // 
            // txtSenha
            // 
            txtSenha.AcceptsReturn = true;
            txtSenha.BackColor = Color.Silver;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(12, 182);
            txtSenha.MaxLength = 10;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(216, 22);
            txtSenha.TabIndex = 5;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Schoolbook", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(67, 53);
            label1.Name = "label1";
            label1.Size = new Size(116, 34);
            label1.TabIndex = 6;
            label1.Text = "LOGIN";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(260, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 455);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 163);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 8;
            label2.Text = "Senha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 112);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 9;
            label3.Text = "Login";
            // 
            // BtVerSenha
            // 
            BtVerSenha.Cursor = Cursors.Hand;
            BtVerSenha.Image = Properties.Resources.icons8_invisible_16;
            BtVerSenha.Location = new Point(229, 184);
            BtVerSenha.Name = "BtVerSenha";
            BtVerSenha.Size = new Size(27, 21);
            BtVerSenha.TabIndex = 10;
            BtVerSenha.TabStop = false;
            BtVerSenha.MouseDown += BtVerSenha_MouseDown;
            BtVerSenha.MouseUp += BtVerSenha_MouseUp;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(657, 386);
            Controls.Add(BtVerSenha);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(txtSenha);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(txtUsuario);
            Font = new Font("Century Schoolbook", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLogin";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drink Manager";
            ((System.ComponentModel.ISupportInitialize)BtVerSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogin;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private PictureBox BtVerSenha;
    }
}
