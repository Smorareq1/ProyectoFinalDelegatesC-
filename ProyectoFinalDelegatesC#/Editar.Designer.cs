namespace ProyectoFinalDelegatesC_
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            dataGridView1 = new DataGridView();
            DescripcionProducto = new TextBox();
            CantidadInicialProducto = new TextBox();
            CategoriaProducto = new TextBox();
            PrecioProducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NombreProducto = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 194);
            dataGridView1.TabIndex = 0;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Location = new Point(485, 140);
            DescripcionProducto.Margin = new Padding(3, 2, 3, 2);
            DescripcionProducto.Multiline = true;
            DescripcionProducto.Name = "DescripcionProducto";
            DescripcionProducto.Size = new Size(303, 61);
            DescripcionProducto.TabIndex = 21;
            // 
            // CantidadInicialProducto
            // 
            CantidadInicialProducto.Location = new Point(521, 103);
            CantidadInicialProducto.Margin = new Padding(3, 2, 3, 2);
            CantidadInicialProducto.Name = "CantidadInicialProducto";
            CantidadInicialProducto.Size = new Size(110, 23);
            CantidadInicialProducto.TabIndex = 20;
            // 
            // CategoriaProducto
            // 
            CategoriaProducto.Location = new Point(104, 178);
            CategoriaProducto.Margin = new Padding(3, 2, 3, 2);
            CategoriaProducto.Name = "CategoriaProducto";
            CategoriaProducto.Size = new Size(110, 23);
            CategoriaProducto.TabIndex = 19;
            // 
            // PrecioProducto
            // 
            PrecioProducto.Location = new Point(104, 140);
            PrecioProducto.Margin = new Padding(3, 2, 3, 2);
            PrecioProducto.Name = "PrecioProducto";
            PrecioProducto.Size = new Size(110, 23);
            PrecioProducto.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 178);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 17;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(391, 140);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 16;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(391, 103);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 15;
            label3.Text = "Cantidad Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 140);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 14;
            label2.Text = "Precio: ";
            // 
            // NombreProducto
            // 
            NombreProducto.Location = new Point(104, 101);
            NombreProducto.Margin = new Padding(3, 2, 3, 2);
            NombreProducto.Multiline = true;
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Size = new Size(222, 25);
            NombreProducto.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 103);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Nombre:";
            // 
            // button1
            // 
            button1.Location = new Point(324, 243);
            button1.Name = "button1";
            button1.Size = new Size(156, 23);
            button1.TabIndex = 22;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(71, 54);
            button2.TabIndex = 23;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Editar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(DescripcionProducto);
            Controls.Add(CantidadInicialProducto);
            Controls.Add(CategoriaProducto);
            Controls.Add(PrecioProducto);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NombreProducto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Editar";
            Text = "Editar";
            Load += Editar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox DescripcionProducto;
        private TextBox CantidadInicialProducto;
        private TextBox CategoriaProducto;
        private TextBox PrecioProducto;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NombreProducto;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}