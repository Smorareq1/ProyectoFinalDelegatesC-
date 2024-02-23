namespace ProyectoFinalDelegatesC_
{
    public partial class Form1 : Form
    {   

        //Variables
        string filePath;


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
            string nombre = textBox1.Text.Trim();
            string contrasena = textBox3.Text.Trim();

            // Buscar el usuario por su nombre
            Usuario usuario = GestorDeUsuarios.BuscarUsuarioPorNombre(nombre);

            if (usuario != null) //null regresaria si no encuentra nada 
            {
                // Verificar si la contraseña coincide
                if (usuario.Contrasena == contrasena)
                {
                    // Si la contraseña coincide, puedes mostrar el otro formulario
                    this.Hide();
                    Menu menu = new Menu();
                    menu.SetInformacionMenu(nombre, usuario.Correo);
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1; // Índice del filtro predeterminado


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                MessageBox.Show("Ruta del archivo seleccionado: " + filePath);
            }

            GestorDeUsuarios.CargarUsuariosDesdeArchivo(filePath);
            MessageBox.Show("Archivo leído con éxito");
        }
    }
}
