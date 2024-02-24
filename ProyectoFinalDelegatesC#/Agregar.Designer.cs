namespace ProyectoFinalDelegatesC_
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button2 = new Button();
            NombreProducto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            PrecioProducto = new TextBox();
            CategoriaProducto = new TextBox();
            CantidadInicialProducto = new TextBox();
            DescripcionProducto = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(669, 12);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 0;
            button1.Text = "Abrir Archivo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 93);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(78, 63);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NombreProducto
            // 
            NombreProducto.Location = new Point(105, 91);
            NombreProducto.Margin = new Padding(3, 2, 3, 2);
            NombreProducto.Multiline = true;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Size = new Size(222, 26);
            NombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 93);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 130);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // PrecioProducto
            // 
            PrecioProducto.Location = new Point(105, 130);
            PrecioProducto.Margin = new Padding(3, 2, 3, 2);
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Size = new Size(110, 23);
            PrecioProducto.TabIndex = 8;
            // 
            // CategoriaProducto
            // 
            CategoriaProducto.Location = new Point(105, 168);
            CategoriaProducto.Margin = new Padding(3, 2, 3, 2);
            CategoriaProducto.Name = "CategoriaProducto";
            CategoriaProducto.Size = new Size(110, 23);
            CategoriaProducto.TabIndex = 9;
            // 
            // CantidadInicialProducto
            // 
            CantidadInicialProducto.Location = new Point(538, 93);
            CantidadInicialProducto.Margin = new Padding(3, 2, 3, 2);
            CantidadInicialProducto.Name = "CantidadInicialProducto";
            CantidadInicialProducto.Size = new Size(110, 23);
            CantidadInicialProducto.TabIndex = 10;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Location = new Point(486, 130);
            DescripcionProducto.Margin = new Padding(3, 2, 3, 2);
            DescripcionProducto.Multiline = true;
            DescripcionProducto.Name = "DescripcionProducto";
            DescripcionProducto.Size = new Size(303, 36);
            DescripcionProducto.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(364, 211);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(82, 22);
            button3.TabIndex = 12;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 263);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(760, 166);
            dataGridView1.TabIndex = 13;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(DescripcionProducto);
            Controls.Add(CantidadInicialProducto);
            Controls.Add(CategoriaProducto);
            Controls.Add(PrecioProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NombreProducto);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Agregar";
            Text = "Agregar";
            Load += Agregar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button button2;
        private TextBox NombreProducto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox PrecioProducto;
        private TextBox CategoriaProducto;
        private TextBox CantidadInicialProducto;
        private TextBox DescripcionProducto;
        private Button button3;
        private DataGridView dataGridView1;
    }
}