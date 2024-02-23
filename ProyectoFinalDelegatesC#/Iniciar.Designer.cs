namespace ProyectoFinalDelegatesC_
{
    partial class Iniciar
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
            label1 = new Label();
            nombreUsuario = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 15);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido: ";
            // 
            // nombreUsuario
            // 
            nombreUsuario.AutoSize = true;
            nombreUsuario.Location = new Point(87, 15);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(59, 20);
            nombreUsuario.TabIndex = 1;
            nombreUsuario.Text = "Usuario";
            // 
            // button1
            // 
            button1.Location = new Point(783, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(163, 31);
            button1.TabIndex = 2;
            button1.Text = "Cargar Productos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 115);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(903, 264);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 401);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 4;
            label2.Text = "Filtrar por Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 453);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 5;
            label3.Text = "Filtrar por Categoria: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 401);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 27);
            textBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(473, 397);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 9;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(473, 453);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 10;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(783, 67);
            button5.Name = "button5";
            button5.Size = new Size(163, 29);
            button5.TabIndex = 11;
            button5.Text = "Restaurar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.Location = new Point(149, 530);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 12;
            button2.Text = "Compra";
            button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(206, 454);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 617);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(nombreUsuario);
            Controls.Add(label1);
            Name = "Iniciar";
            Text = "Iniciar";
            Load += Iniciar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nombreUsuario;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button2;
        private ComboBox comboBox1;
    }
}