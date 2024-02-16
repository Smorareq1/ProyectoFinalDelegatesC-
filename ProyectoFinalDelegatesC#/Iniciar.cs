using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDelegatesC_
{
    public partial class Iniciar : Form
    {
        //Variables 
        string Nombre;
        string Correo;
        string filePath;


        public Iniciar()
        {
            InitializeComponent();
        }

        private void Iniciar_Load(object sender, EventArgs e)
        {
            nombreUsuario.Text = Nombre;
        }

        public void SetInformacion(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crear un objeto de OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Configurar propiedades del diálogo
            openFileDialog1.InitialDirectory = "c:\\"; 
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv"; 
            openFileDialog1.FilterIndex = 1; // Índice del filtro predeterminado

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                filePath = openFileDialog1.FileName;
                MessageBox.Show("Ruta del archivo seleccionado: " + filePath);
            }

            Producto.LeerArchivo(filePath);
            MessageBox.Show("Archivo leído con éxito");


        }
    }
}
