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
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            FiltrarPorCoincidencia = new TextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            comboBoxCategorias = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido: ";
            // 
            // nombreUsuario
            // 
            nombreUsuario.AutoSize = true;
            nombreUsuario.Location = new Point(76, 11);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(47, 15);
            nombreUsuario.TabIndex = 1;
            nombreUsuario.Text = "Usuario";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(790, 198);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 301);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 4;
            label2.Text = "Filtrar por Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 340);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Filtrar por Categoria: ";
            // 
            // button2
            // 
            button2.Location = new Point(390, 404);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "MENU";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FiltrarPorCoincidencia
            // 
            FiltrarPorCoincidencia.Location = new Point(311, 301);
            FiltrarPorCoincidencia.Margin = new Padding(3, 2, 3, 2);
            FiltrarPorCoincidencia.Name = "FiltrarPorCoincidencia";
            FiltrarPorCoincidencia.Size = new Size(249, 23);
            FiltrarPorCoincidencia.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(685, 297);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 9;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(685, 336);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 22);
            button4.TabIndex = 10;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(685, 26);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(143, 22);
            button5.TabIndex = 11;
            button5.Text = "Mostrar Todo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(311, 340);
            comboBoxCategorias.Margin = new Padding(3, 2, 3, 2);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(249, 23);
            comboBoxCategorias.TabIndex = 12;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 463);
            Controls.Add(comboBoxCategorias);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(FiltrarPorCoincidencia);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(nombreUsuario);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Button button2;
        private TextBox FiltrarPorCoincidencia;
        private Button button3;
        private Button button4;
        private Button button5;
        private ComboBox comboBoxCategorias;
    }
}