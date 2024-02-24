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
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void button1_Click(object sender, EventArgs e) // Editar
        {
            try
            {
                // Verificar si se ha seleccionado una fila en el DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Obtener el índice de la fila seleccionada
                    int rowIndex = dataGridView1.SelectedRows[0].Index;

                    
                    string nombre = NombreProducto.Text.Trim();
                    double precio = Convert.ToDouble(PrecioProducto.Text.Trim());
                    int cantidad = Convert.ToInt32(CantidadInicialProducto.Text.Trim());
                    string descripcion = DescripcionProducto.Text.Trim();
                    string categoria = CategoriaProducto.Text.Trim();

                    
                    string nombreProductoSeleccionado = dataGridView1.Rows[rowIndex].Cells["NombreColumn"].Value.ToString().Trim();

                   
                    if (GestorDeArchivos.productos.Keys.Any(key => key != nombreProductoSeleccionado && key == nombre))
                    {
                        throw new ArgumentException("Ya existe un producto con el nuevo nombre.");
                    }
                    if (precio <= 0 || cantidad < 0 )
                    {
                        throw new ArgumentException("Cantidad o Precio con formato incorrecto");
                    }

                    // Eliminar el producto antiguo del diccionario
                    GestorDeArchivos.productos.Remove(nombreProductoSeleccionado);

                    //Agregar a la lista
                    GestorDeArchivos.AgregarProductoALista(nombre, precio, cantidad, descripcion, categoria);

                    // Actualizar la fila seleccionada en el DataGridView con los nuevos valores
                    dataGridView1.Rows[rowIndex].Cells["NombreColumn"].Value = nombre;
                    dataGridView1.Rows[rowIndex].Cells["PrecioColumn"].Value = precio;
                    dataGridView1.Rows[rowIndex].Cells["CantidadColumn"].Value = cantidad;
                    dataGridView1.Rows[rowIndex].Cells["DescripcionColumn"].Value = descripcion;
                    dataGridView1.Rows[rowIndex].Cells["CategoriaColumn"].Value = categoria;

                    
                    MessageBox.Show("Producto actualizado con éxito.");
                    LimpiarTextBoxes();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila en el DataGridView para editar el producto.");
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese datos válidos en los campos numéricos (precio y cantidad).");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al actualizar el producto: " + ex.Message);
            }
        }


        private void LimpiarTextBoxes()
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
            dataGridView1.Columns.Clear(); 

            // Agregar las columnas al DataGridView
            dataGridView1.Columns.Add("NombreColumn", "Nombre");
            dataGridView1.Columns.Add("PrecioColumn", "Precio");
            dataGridView1.Columns.Add("CantidadColumn", "Cantidad");
            dataGridView1.Columns.Add("DescripcionColumn", "Descripción");
            dataGridView1.Columns.Add("CategoriaColumn", "Categoría");

           
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

        private void Editar_Load(object sender, EventArgs e) //Cargar
        {
            LlenarDataGridViewDeDiccionario();
        }

        private void button2_Click(object sender, EventArgs e) //Menu
        {
            //Verificar cantidades bajas
            //Delegate
            SistemaDeNotificaciones.VerificarCantidadesBajas(GestorDeArchivos.productos, GestorDeArchivos.NotificarCantidadBaja);

            // Regresar al menú principal
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtener el índice de la fila seleccionada
            int rowIndex = e.RowIndex;

            // Verificar si el índice es válido y no es la fila de encabezado
            if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count - 1)
            {
                // Obtener los valores de la fila seleccionada y colocarlos en los TextBox
                NombreProducto.Text = dataGridView1.Rows[rowIndex].Cells["NombreColumn"].Value.ToString();
                PrecioProducto.Text = dataGridView1.Rows[rowIndex].Cells["PrecioColumn"].Value.ToString();
                CantidadInicialProducto.Text = dataGridView1.Rows[rowIndex].Cells["CantidadColumn"].Value.ToString();
                DescripcionProducto.Text = dataGridView1.Rows[rowIndex].Cells["DescripcionColumn"].Value.ToString();
                CategoriaProducto.Text = dataGridView1.Rows[rowIndex].Cells["CategoriaColumn"].Value.ToString();
            }
        }

    }
}
