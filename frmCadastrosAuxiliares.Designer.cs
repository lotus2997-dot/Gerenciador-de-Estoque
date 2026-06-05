namespace Drink
{
    partial class frmCadastrosAuxiliares
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
            btnLimparConfig = new Button();
            btnCancelarConfig = new Button();
            btnSalvarConfig = new Button();
            grpConfig = new GroupBox();
            txtCategoriaConfig = new TextBox();
            cmbUnidadeConfig = new ComboBox();
            cmbCategoriaConfig = new ComboBox();
            lblCategoria = new Label();
            txtUnidade = new TextBox();
            pnlCabecalhoConfig = new Panel();
            lblConfigTitulo = new Label();
            lblUniConfig = new Label();
            cbxStatusEvento = new ComboBox();
            txtStatusEvento = new TextBox();
            label1 = new Label();
            cbxStatusRetorno = new ComboBox();
            txtStatusRetorno = new TextBox();
            label2 = new Label();
            grpConfig.SuspendLayout();
            pnlCabecalhoConfig.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimparConfig
            // 
            btnLimparConfig.BackColor = Color.WhiteSmoke;
            btnLimparConfig.FlatStyle = FlatStyle.Flat;
            btnLimparConfig.Location = new Point(223, 373);
            btnLimparConfig.Name = "btnLimparConfig";
            btnLimparConfig.Size = new Size(120, 35);
            btnLimparConfig.TabIndex = 11;
            btnLimparConfig.Text = "Limpar";
            btnLimparConfig.UseVisualStyleBackColor = false;
            // 
            // btnCancelarConfig
            // 
            btnCancelarConfig.BackColor = Color.WhiteSmoke;
            btnCancelarConfig.FlatStyle = FlatStyle.Flat;
            btnCancelarConfig.Location = new Point(394, 373);
            btnCancelarConfig.Name = "btnCancelarConfig";
            btnCancelarConfig.Size = new Size(120, 35);
            btnCancelarConfig.TabIndex = 10;
            btnCancelarConfig.Text = "Cancelar";
            btnCancelarConfig.UseVisualStyleBackColor = false;
            // 
            // btnSalvarConfig
            // 
            btnSalvarConfig.BackColor = Color.FromArgb(20, 59, 102);
            btnSalvarConfig.FlatStyle = FlatStyle.Flat;
            btnSalvarConfig.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarConfig.ForeColor = Color.White;
            btnSalvarConfig.Location = new Point(45, 373);
            btnSalvarConfig.Name = "btnSalvarConfig";
            btnSalvarConfig.Size = new Size(120, 35);
            btnSalvarConfig.TabIndex = 9;
            btnSalvarConfig.Text = "Salvar";
            btnSalvarConfig.UseVisualStyleBackColor = false;
            // 
            // grpConfig
            // 
            grpConfig.Controls.Add(cbxStatusRetorno);
            grpConfig.Controls.Add(txtStatusRetorno);
            grpConfig.Controls.Add(label2);
            grpConfig.Controls.Add(cbxStatusEvento);
            grpConfig.Controls.Add(txtStatusEvento);
            grpConfig.Controls.Add(label1);
            grpConfig.Controls.Add(txtCategoriaConfig);
            grpConfig.Controls.Add(cmbUnidadeConfig);
            grpConfig.Controls.Add(cmbCategoriaConfig);
            grpConfig.Controls.Add(lblCategoria);
            grpConfig.Controls.Add(txtUnidade);
            grpConfig.Controls.Add(lblUniConfig);
            grpConfig.Location = new Point(25, 91);
            grpConfig.Name = "grpConfig";
            grpConfig.Size = new Size(629, 230);
            grpConfig.TabIndex = 7;
            grpConfig.TabStop = false;
            grpConfig.Text = "Dados para configurar";
            // 
            // txtCategoriaConfig
            // 
            txtCategoriaConfig.Location = new Point(290, 50);
            txtCategoriaConfig.Name = "txtCategoriaConfig";
            txtCategoriaConfig.Size = new Size(240, 23);
            txtCategoriaConfig.TabIndex = 15;
            // 
            // cmbUnidadeConfig
            // 
            cmbUnidadeConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUnidadeConfig.FormattingEnabled = true;
            cmbUnidadeConfig.Location = new Point(20, 89);
            cmbUnidadeConfig.Name = "cmbUnidadeConfig";
            cmbUnidadeConfig.Size = new Size(240, 23);
            cmbUnidadeConfig.TabIndex = 5;
            // 
            // cmbCategoriaConfig
            // 
            cmbCategoriaConfig.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoriaConfig.FormattingEnabled = true;
            cmbCategoriaConfig.Location = new Point(290, 89);
            cmbCategoriaConfig.Name = "cmbCategoriaConfig";
            cmbCategoriaConfig.Size = new Size(240, 23);
            cmbCategoriaConfig.TabIndex = 3;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(290, 30);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria:";
            // 
            // txtUnidade
            // 
            txtUnidade.Location = new Point(20, 50);
            txtUnidade.Name = "txtUnidade";
            txtUnidade.Size = new Size(240, 23);
            txtUnidade.TabIndex = 1;
            // 
            // pnlCabecalhoConfig
            // 
            pnlCabecalhoConfig.BackColor = Color.FromArgb(20, 59, 102);
            pnlCabecalhoConfig.Controls.Add(lblConfigTitulo);
            pnlCabecalhoConfig.Dock = DockStyle.Top;
            pnlCabecalhoConfig.Location = new Point(0, 0);
            pnlCabecalhoConfig.Name = "pnlCabecalhoConfig";
            pnlCabecalhoConfig.Size = new Size(681, 60);
            pnlCabecalhoConfig.TabIndex = 6;
            // 
            // lblConfigTitulo
            // 
            lblConfigTitulo.AutoSize = true;
            lblConfigTitulo.Font = new Font("Segoe UI", 17.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfigTitulo.ForeColor = Color.White;
            lblConfigTitulo.Location = new Point(25, 17);
            lblConfigTitulo.Name = "lblConfigTitulo";
            lblConfigTitulo.Size = new Size(168, 31);
            lblConfigTitulo.TabIndex = 0;
            lblConfigTitulo.Text = "Configurações";
            // 
            // lblUniConfig
            // 
            lblUniConfig.AutoSize = true;
            lblUniConfig.Location = new Point(20, 30);
            lblUniConfig.Name = "lblUniConfig";
            lblUniConfig.Size = new Size(54, 15);
            lblUniConfig.TabIndex = 0;
            lblUniConfig.Text = "Unidade:";
            // 
            // cbxStatusEvento
            // 
            cbxStatusEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatusEvento.FormattingEnabled = true;
            cbxStatusEvento.Location = new Point(20, 187);
            cbxStatusEvento.Name = "cbxStatusEvento";
            cbxStatusEvento.Size = new Size(240, 23);
            cbxStatusEvento.TabIndex = 18;
            // 
            // txtStatusEvento
            // 
            txtStatusEvento.Location = new Point(20, 148);
            txtStatusEvento.Name = "txtStatusEvento";
            txtStatusEvento.Size = new Size(240, 23);
            txtStatusEvento.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 128);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 16;
            label1.Text = "Status Evento:";
            // 
            // cbxStatusRetorno
            // 
            cbxStatusRetorno.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatusRetorno.FormattingEnabled = true;
            cbxStatusRetorno.Location = new Point(290, 187);
            cbxStatusRetorno.Name = "cbxStatusRetorno";
            cbxStatusRetorno.Size = new Size(240, 23);
            cbxStatusRetorno.TabIndex = 21;
            // 
            // txtStatusRetorno
            // 
            txtStatusRetorno.Location = new Point(290, 148);
            txtStatusRetorno.Name = "txtStatusRetorno";
            txtStatusRetorno.Size = new Size(240, 23);
            txtStatusRetorno.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 19;
            label2.Text = "Status Retorno:";
            // 
            // frmCadastrosAuxiliares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 427);
            Controls.Add(btnLimparConfig);
            Controls.Add(btnCancelarConfig);
            Controls.Add(btnSalvarConfig);
            Controls.Add(grpConfig);
            Controls.Add(pnlCabecalhoConfig);
            Name = "frmCadastrosAuxiliares";
            Text = "frmCadastrosAuxiliares";
            grpConfig.ResumeLayout(false);
            grpConfig.PerformLayout();
            pnlCabecalhoConfig.ResumeLayout(false);
            pnlCabecalhoConfig.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLimparConfig;
        private Button btnCancelarConfig;
        private Button btnSalvarConfig;
        private GroupBox grpConfig;
        private TextBox txtCategoriaConfig;
        private ComboBox cmbUnidadeConfig;
        private ComboBox cmbCategoriaConfig;
        private Label lblCategoria;
        private TextBox txtUnidade;
        private Label lblUniConfig;
        private Panel pnlCabecalhoConfig;
        private Label lblConfigTitulo;
        private ComboBox cbxStatusEvento;
        private TextBox txtStatusEvento;
        private Label label1;
        private ComboBox cbxStatusRetorno;
        private TextBox txtStatusRetorno;
        private Label label2;
    }
}