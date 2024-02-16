namespace ProyectoFinalDelegatesC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido al sistema de ventas");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


                string Contrasena1 = textBox3.Text.ToString();
            

            
           
                this.Hide();
                Iniciar iniciar = new Iniciar();
                iniciar.SetInformacion(usuario1.Nombre, usuario1.Correo);
                iniciar.Show();
            
    
        }
    }
}
