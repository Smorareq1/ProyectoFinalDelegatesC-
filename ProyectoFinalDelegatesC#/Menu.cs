using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinalDelegatesC_
{
    public partial class Menu : Form
    {

        //Variables
        private static string Nombre;
        string Correo;



        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void SetInformacionMenu(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;

        }

        private void button1_Click(object sender, EventArgs e) //Buscar
        {

            if (GestorDeArchivos.ListaSize() == 0)
            {
                MessageBox.Show("No hay productos en el inventario, porfavor agregue productos antes de realizar la busqueda de un producto.");
            }
            else
            {
                this.Hide();
                Iniciar buscar = new Iniciar();
                buscar.SetInformacion(Nombre, Correo);
                buscar.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Agregar
        {
            this.Hide();
            Agregar buscar = new Agregar();
            buscar.Show();
        }

        private void button3_Click(object sender, EventArgs e) //Compra venta
        {


            if (GestorDeArchivos.ListaSize() == 0)
            {
                MessageBox.Show("No hay productos en el inventario, porfavor agregue productos antes de realizar una compra o venta.");
            }
            else
            {
                this.Hide();
                CompraVenta compraVenta = new CompraVenta();
                compraVenta.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e) //Editar
        {
            if (GestorDeArchivos.ListaSize() == 0)
            {
                MessageBox.Show("No hay productos en el inventario para editar");
            }
            else
            {
                this.Hide();
                Editar editar = new Editar();
                editar.Show();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try {

                if (GestorDeArchivos.path == "")
                {
                    string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Obtiene la ruta de la carpeta de Documentos
                    string filePath = Path.Combine(directory, "ProductosChepe.txt"); // Combina la ruta con el nombre del archivo

                    // Crear un arreglo de strings con los datos de los productos
                    string[] lineas = new string[GestorDeArchivos.productos.Count];

                    int i = 0;
                    foreach (var producto in GestorDeArchivos.productos.Values)
                    {
                        lineas[i] = $"{producto.Nombre},{producto.Precio},{producto.Cantidad},{producto.Descripcion},{producto.Categoria}";
                        i++;
                    }

                    // Escribir el arreglo de strings en el archivo
                    File.WriteAllLines(filePath, lineas);

                    MessageBox.Show("Productos guardados en ProductosChepe.txt en la carpeta de Documentos.");
                }
                else
                {
                    GestorDeArchivos.GuardarProductosEnArchivo(GestorDeArchivos.path);
                }
           

                //Reestablecer todas las variables
                Nombre = "";
                Correo = "";

                //
                GestorDeArchivos.productos.Clear();
                GestorDeArchivos.path = "";

                // Regresar al menú
                Form1 form1 = new Form1();
                this.Close();
                form1.Show();
            
                }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message);
            }

        }
    }
}
