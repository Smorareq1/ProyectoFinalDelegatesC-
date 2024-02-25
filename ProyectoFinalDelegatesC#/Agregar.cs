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
        public static string filePath;

        private static string Nombre;


        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BOTON ABRIR ARCHIVO
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos CSV (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 1; // Índice del filtro predeterminado

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filePath = openFileDialog1.FileName;
                MessageBox.Show("Ruta del archivo seleccionado: " + filePath);
            }

            GestorDeArchivos.LeerArchivo(filePath);
            GestorDeArchivos.GetFilePath(filePath);

            filePath = "";
            LlenarDataGridViewDeDiccionario();


            //GestorDeArchivos.MostrarProductos();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Regresar al menú
            this.Hide();
            Menu menu = new Menu();
            menu.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string nombre = NombreProducto.Text.Trim();
                double precio = Convert.ToDouble(PrecioProducto.Text.Trim());
                int cantidad = Convert.ToInt32(CantidadInicialProducto.Text.Trim());
                string descripcion = DescripcionProducto.Text.Trim();
                string categoria = CategoriaProducto.Text.Trim();

                // Agregamos el producto al diccionario
                GestorDeArchivos.AgregarProductoALista(nombre, precio, cantidad, descripcion, categoria); // 
                LlenarDataGridViewDeDiccionario();
                MessageBox.Show("Producto agregado con éxito");

                // Creamos el producto
                Producto productoAEvaular = new Producto(nombre, precio, cantidad, descripcion, categoria);

                //Limpiar los textbox
                limpiarTextBox();

                //Verificar si hay cantidades bajas
                SistemaDeNotificaciones.VerificarCantidadBaja(productoAEvaular, GestorDeArchivos.NotificarCantidadBaja);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el producto, una propiedad no tiene el formato adecuado");
            }

        }

        private void limpiarTextBox()
        {
            NombreProducto.Text = "";
            PrecioProducto.Text = "";
            CantidadInicialProducto.Text = "";
            DescripcionProducto.Text = "";
            CategoriaProducto.Text = "";
        }

        private void LlenarDataGridViewDeDiccionario()
        {
            // Limpiar cualquier dato existente en el DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Limpiar columnas también

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add("NombreColumn", "Nombre");
            dataGridView1.Columns.Add("PrecioColumn", "Precio");
            dataGridView1.Columns.Add("CantidadColumn", "Cantidad");
            dataGridView1.Columns.Add("DescripcionColumn", "Descripción");
            dataGridView1.Columns.Add("CategoriaColumn", "Categoría");

            // Recorrer los productos y agregarlos al DataGridView
            foreach (var producto in GestorDeArchivos.productos.Values)
            {

                if (producto != null)
                {
                    // Agregar una fila al DataGridView con los datos del producto
                    dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion, producto.Categoria);
                }
            }

            dataGridView1.AutoResizeColumns();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {

        }

        private void CategoriaProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
