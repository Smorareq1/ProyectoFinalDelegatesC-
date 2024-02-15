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
            Usuario usuario1 = new Usuario(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString());
            string Contrasena1 = textBox3.Text.ToString();
            string Contrasena2 = textBox4.Text.ToString();

            if (Contrasena1 != Contrasena2)
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
            else{
                this.Hide();
                Iniciar iniciar = new Iniciar();
                iniciar.SetInformacion(usuario1.Nombre, usuario1.Correo);
                iniciar.Show();
            }
    
        }
    }
}
