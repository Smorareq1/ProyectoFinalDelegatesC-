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
    public partial class CompraVenta : Form
    {
        //Variables
        private static int CantidadDeProducto;
        private Producto productoSeleccionado;

        public CompraVenta()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void button1_Click(object sender, EventArgs e) //Menu
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void CompraVenta_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Porfavor seleccione un producto");
            LlenarDataGridViewDeDiccionario();
        }

        private void button2_Click(object sender, EventArgs e) //Comprar
        {

            if (productoSeleccionado != null)
            {
                int cantidadAComprar = Convert.ToInt32(CantidadCompra.Text.Trim());
                productoSeleccionado.Cantidad += cantidadAComprar;
                MessageBox.Show("Compra realizada con éxito.");
                LlenarDataGridViewDeDiccionario();

            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de comprar.");
            }

            
        }

        private void button3_Click(object sender, EventArgs e) //Vender
        {

            if (productoSeleccionado != null)
            {
                int cantidadAVender = Convert.ToInt32(CantidadVenta.Text.Trim());
                int resultado = productoSeleccionado.Cantidad - cantidadAVender;
                if (resultado < 0)
                {
                    MessageBox.Show("No hay suficiente cantidad de producto para vender.");
                }
                else
                {
                    productoSeleccionado.Cantidad = resultado;
                    MessageBox.Show("Venta realizada con éxito.");
                    LlenarDataGridViewDeDiccionario();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de vender.");
            }

            
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

            // Agregar los productos al DataGridView
            foreach (KeyValuePair<string, Producto> producto in GestorDeArchivos.productos)
            {
                dataGridView1.Rows.Add(producto.Value.Nombre, producto.Value.Precio, producto.Value.Cantidad, producto.Value.Descripcion, producto.Value.Categoria);
            }

            dataGridView1.AutoResizeColumns();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una fila válida
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Obtener el nombre del producto seleccionado
                string nombreProducto = dataGridView1.Rows[e.RowIndex].Cells["NombreColumn"].Value.ToString();

                // Buscar el producto correspondiente en el diccionario de productos
                if (GestorDeArchivos.productos.TryGetValue(nombreProducto, out Producto producto))
                {
                    // Almacenar el producto seleccionado
                    productoSeleccionado = producto;                    
                }
                else
                {
                    MessageBox.Show("No se pudo encontrar el producto seleccionado en la lista de productos.");
                }
            }
        }
    }
}
