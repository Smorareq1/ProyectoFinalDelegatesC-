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
            string filtrarNombre = textBox1.Text.Trim();

            Producto producto = GestorDeArchivos.BuscarProductoPorNombre(filtrarNombre);

            // Limpiar cualquier dato existente en el DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear(); // Limpiar columnas también

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add("NombreColumn", "Nombre");
            dataGridView1.Columns.Add("PrecioColumn", "Precio");
            dataGridView1.Columns.Add("CantidadColumn", "Cantidad");
            dataGridView1.Columns.Add("DescripcionColumn", "Descripción");
            dataGridView1.Columns.Add("CategoriaColumn", "Categoría");

            // Agregar una fila al DataGridView con los datos del producto
            dataGridView1.Rows.Add(producto.Nombre, producto.Precio, producto.Cantidad, producto.Descripcion, producto.Categoria);

            dataGridView1.AutoResizeColumns();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.Show();
        }
    }
}
