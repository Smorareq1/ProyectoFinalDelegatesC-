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
            nombreUsuario.Size = new Size(38, 15);
            nombreUsuario.TabIndex = 1;
            nombreUsuario.Text = "label2";
            // 
            // button1
            // 
            button1.Location = new Point(312, 60);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
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
            dataGridView1.Location = new Point(66, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(574, 198);
            dataGridView1.TabIndex = 3;
            // 
            // Iniciar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
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
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
    }
}