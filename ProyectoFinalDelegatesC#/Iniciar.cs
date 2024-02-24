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
        //INICIAR ES FILTRAR PRODUCTOS Y BUSCAR PRODUCTOS

        //Variables 
        private static string Nombre; //mantener su valor incluso si se crean múltiples instancias del Forms
        private static string Correo;
        string filePath;


        public Iniciar()
        {
            InitializeComponent();
        }

        private void Iniciar_Load(object sender, EventArgs e)
        {
            nombreUsuario.Text = Nombre;

            // Llenar el ComboBox con las categorías de los productos
            llenarComboBox();


        }

        public void SetInformacion(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {
            LlenarDataGridViewDeDiccionario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Por coincidencia de nombre

            string coincidencia = FiltrarPorCoincidencia.Text.Trim();

            List<Producto> productosCoincidentes = GestorDeArchivos.BuscarProductoPorCoincidencia(coincidencia);

            if (productosCoincidentes != null)
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

                // Recorrer la lista de productos coincidentes y agregarlos al DataGridView
                foreach (var producto in productosCoincidentes)
                {
                    dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion, producto.Categoria);
                }

                // Opcional: Autoajustar las columnas para que se ajusten al contenido
                dataGridView1.AutoResizeColumns();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Por categoria

            string categoriaSeleccionada = comboBoxCategorias.SelectedItem?.ToString();

            if (categoriaSeleccionada != null)
            {
                List<Producto> productosPorCategoria = GestorDeArchivos.BuscarProductosPorCategoria(categoriaSeleccionada);

                if (productosPorCategoria != null)
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

                    // Recorrer la lista de productos por categoría y agregarlos al DataGridView
                    foreach (var producto in productosPorCategoria)
                    {
                        dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion, producto.Categoria);
                    }

                    // Opcional: Autoajustar las columnas para que se ajusten al contenido
                    dataGridView1.AutoResizeColumns();
                }
            }   
        }

        private void llenarComboBox()
        {
            // Limpiar cualquier dato existente en el ComboBox
            comboBoxCategorias.Items.Clear();

            // Agregar las categorías al ComboBox
            foreach (var producto in GestorDeArchivos.productos.Values)
            {
                if (!comboBoxCategorias.Items.Contains(producto.Categoria))
                {
                    comboBoxCategorias.Items.Add(producto.Categoria);
                }
            }
        }
    }
}
