namespace ProyectoFinalDelegatesC_
{
    partial class CompraVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompraVenta));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            CantidadCompra = new TextBox();
            CantidadVenta = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(73, 54);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 234);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 204);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 109);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese la cantidad que desea comprar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 109);
            label2.Name = "label2";
            label2.Size = new Size(205, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingresar la cantidad que desea vender";
            // 
            // CantidadCompra
            // 
            CantidadCompra.Location = new Point(107, 127);
            CantidadCompra.Name = "CantidadCompra";
            CantidadCompra.Size = new Size(100, 23);
            CantidadCompra.TabIndex = 4;
            CantidadCompra.TextChanged += CantidadCompra_TextChanged;
            // 
            // CantidadVenta
            // 
            CantidadVenta.Location = new Point(560, 127);
            CantidadVenta.Name = "CantidadVenta";
            CantidadVenta.Size = new Size(100, 23);
            CantidadVenta.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(107, 178);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 6;
            button2.Text = "Comprar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(560, 178);
            button3.Name = "button3";
            button3.Size = new Size(100, 23);
            button3.TabIndex = 7;
            button3.Text = "Vender";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CompraVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(CantidadVenta);
            Controls.Add(CantidadCompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "CompraVenta";
            Text = "CompraVenta";
            Load += CompraVenta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox CantidadCompra;
        private TextBox CantidadVenta;
        private Button button2;
        private Button button3;
    }
}