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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            idEstoque = new DataGridViewTextBoxColumn();
            nomeEstoque = new DataGridViewTextBoxColumn();
            categoriaEstoque = new DataGridViewTextBoxColumn();
            quantidadeEstoque = new DataGridViewTextBoxColumn();
            validadeEstique = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 76);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1409, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(44, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 94);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(646, 28);
            label1.Name = "label1";
            label1.Size = new Size(119, 37);
            label1.TabIndex = 3;
            label1.Text = "Estoque";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 552);
            panel1.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = Color.AntiqueWhite;
            dateTimePicker1.Location = new Point(12, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(211, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 57);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(211, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "Nome";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Ingrdientes ", "Utensílios" });
            comboBox1.Location = new Point(12, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Categoria";
            // 
            // button4
            // 
            button4.Location = new Point(119, 28);
            button4.Name = "button4";
            button4.Size = new Size(104, 23);
            button4.TabIndex = 3;
            button4.Text = "Remover";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 169);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 2;
            button3.Text = "Atualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(122, 169);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 1;
            button2.Text = "Transferir";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(12, 28);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 0;
            button1.Text = "Adicionar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idEstoque, nomeEstoque, categoriaEstoque, quantidadeEstoque, validadeEstique });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(229, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1180, 552);
            dataGridView1.TabIndex = 3;
            // 
            // idEstoque
            // 
            idEstoque.HeaderText = "ID";
            idEstoque.Name = "idEstoque";
            // 
            // nomeEstoque
            // 
            nomeEstoque.HeaderText = "Nome";
            nomeEstoque.Name = "nomeEstoque";
            // 
            // categoriaEstoque
            // 
            categoriaEstoque.HeaderText = "Categoria";
            categoriaEstoque.Name = "categoriaEstoque";
            // 
            // quantidadeEstoque
            // 
            quantidadeEstoque.HeaderText = "Quantidade";
            quantidadeEstoque.Name = "quantidadeEstoque";
            // 
            // validadeEstique
            // 
            validadeEstique.HeaderText = "Validade";
            validadeEstique.Name = "validadeEstique";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Validade";
            // 
            // frmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 652);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmEstoque";
            Text = "frmEstoque";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idEstoque;
        private DataGridViewTextBoxColumn nomeEstoque;
        private DataGridViewTextBoxColumn categoriaEstoque;
        private DataGridViewTextBoxColumn quantidadeEstoque;
        private DataGridViewTextBoxColumn validadeEstique;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
    }
}