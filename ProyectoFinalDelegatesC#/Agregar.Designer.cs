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
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            label1 = new Label();
            button2 = new Button();
            NombreProducto = new TextBox();
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
            button2.Location = new Point(14, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(73, 56);
            button2.TabIndex = 2;
            button2.Text = "Regresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // NombreProducto
            // 
            NombreProducto.Location = new Point(120, 121);
            NombreProducto.Name = "NombreProducto";
            NombreProducto.Size = new Size(125, 27);
            NombreProducto.TabIndex = 3;
            // 
            // Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(NombreProducto);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Agregar";
            Text = "Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button button2;
        private TextBox NombreProducto;
    }
}