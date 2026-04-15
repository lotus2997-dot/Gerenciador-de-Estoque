namespace TREINAMENTO
{
    partial class FRM_ADICIONAR
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSalvarEstoque = new System.Windows.Forms.Button();
            this.btnFecharAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(555, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUTO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "QUANTIDADE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "VALIDADE";
            this.Column4.Name = "Column4";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(573, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 64);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSalvarEstoque
            // 
            this.btnSalvarEstoque.Location = new System.Drawing.Point(573, 152);
            this.btnSalvarEstoque.Name = "btnSalvarEstoque";
            this.btnSalvarEstoque.Size = new System.Drawing.Size(215, 64);
            this.btnSalvarEstoque.TabIndex = 2;
            this.btnSalvarEstoque.Text = "Salvar";
            this.btnSalvarEstoque.UseVisualStyleBackColor = true;
            // 
            // btnFecharAdd
            // 
            this.btnFecharAdd.Location = new System.Drawing.Point(573, 222);
            this.btnFecharAdd.Name = "btnFecharAdd";
            this.btnFecharAdd.Size = new System.Drawing.Size(215, 64);
            this.btnFecharAdd.TabIndex = 3;
            this.btnFecharAdd.Text = "Fechar";
            this.btnFecharAdd.UseVisualStyleBackColor = true;
            this.btnFecharAdd.Click += new System.EventHandler(this.btnFecharAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FRM_ADICIONAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFecharAdd);
            this.Controls.Add(this.btnSalvarEstoque);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FRM_ADICIONAR";
            this.Text = "FRM_ADICIONAR";
            this.Load += new System.EventHandler(this.FRM_ADICIONAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSalvarEstoque;
        private System.Windows.Forms.Button btnFecharAdd;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}