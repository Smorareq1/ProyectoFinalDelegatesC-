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
            button1.Location = new Point(765, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(136, 31);
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
            label1.Location = new Point(14, 124);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(14, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(89, 84);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NombreProducto
            // 
            NombreProducto.Location = new Point(120, 121);
            NombreProducto.Multiline = true;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Size = new Size(253, 33);
            NombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 173);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 4;
            label2.Text = "Precio: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(448, 124);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 5;
            label3.Text = "Cantidad Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 173);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 6;
            label4.Text = "Descripcion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 224);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 7;
            label5.Text = "Categoria";
            // 
            // PrecioProducto
            // 
            PrecioProducto.Location = new Point(120, 173);
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Size = new Size(125, 27);
            PrecioProducto.TabIndex = 8;
            // 
            // CategoriaProducto
            // 
            CategoriaProducto.Location = new Point(120, 224);
            CategoriaProducto.Name = "CategoriaProducto";
            CategoriaProducto.Size = new Size(125, 27);
            CategoriaProducto.TabIndex = 9;
            CategoriaProducto.TextChanged += CategoriaProducto_TextChanged;
            // 
            // CantidadInicialProducto
            // 
            CantidadInicialProducto.Location = new Point(615, 124);
            CantidadInicialProducto.Name = "CantidadInicialProducto";
            CantidadInicialProducto.Size = new Size(125, 27);
            CantidadInicialProducto.TabIndex = 10;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Location = new Point(555, 173);
            DescripcionProducto.Multiline = true;
            DescripcionProducto.Name = "DescripcionProducto";
            DescripcionProducto.Size = new Size(346, 47);
            DescripcionProducto.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(416, 281);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 351);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(869, 221);
            dataGridView1.TabIndex = 13;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
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