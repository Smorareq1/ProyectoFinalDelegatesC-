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
    public partial class Agregar : Form
    {
        //Variables
        string filePath;


        public Agregar()
        {
            InitializeComponent();
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

            GestorDeArchivos.LeerArchivo(filePath);
            filePath = null;



            GestorDeArchivos.MostrarProductos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Regresar al menú
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
