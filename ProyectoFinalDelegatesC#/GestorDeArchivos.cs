using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDelegatesC_
{
    internal class GestorDeArchivos
    {
        // Lista para almacenar los productos
        public static List<Producto> productos = new List<Producto>();

        public static void AgregarProductoALista(string nombre, double precio, int cantidad, string descripcion, string categoria)
        {
            // Creamos un nuevo producto y lo agregamos a la lista
            productos.Add(new Producto(nombre, precio, cantidad, descripcion, categoria));
        }

        public static void LeerArchivo(string rutaArchivo)
        {
            try
            {
                // Leemos todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Dividimos cada línea en sus partes usando la coma como separador
                    string[] partes = linea.Split(',');

                    // Aseguramos que tenemos suficientes partes para crear un producto
                    if (partes.Length >= 5)
                    {
                        string nombre = partes[0].Trim();
                        double precio = Convert.ToDouble(partes[1].Trim());
                        int cantidad = Convert.ToInt32(partes[2].Trim());
                        string descripcion = partes[3].Trim();
                        string categoria = partes[4].Trim();

                        // Agregamos el producto a la lista
                        AgregarProductoALista(nombre, precio, cantidad, descripcion, categoria);
                    }
                    else
                    {
                        MessageBox.Show("La línea no tiene el formato adecuado: " + linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message);
            }
        }

        public static void MostrarProductos()
        {
            if (productos.Count > 0)
            {
                // Recorrer todos los productos y mostrar sus propiedades en un MessageBox
                foreach (var producto in productos)
                {
                    MessageBox.Show($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad: {producto.Cantidad}, Descripción: {producto.Descripcion}, Categoría: {producto.Categoria}");
                }
            }
            else
            {
                MessageBox.Show("No hay suficientes productos disponibles.");
            }
        }


        public static Producto BuscarProductoPorNombre(string nombre)
        {
            // Buscar un producto por su nombre
            Producto producto = productos.Find(p => p.Nombre == nombre);

            if (producto != null)
            {
                MessageBox.Show($"Nombre: {producto.Nombre}, Precio: {producto.Precio}, Cantidad: {producto.Cantidad}, Descripción: {producto.Descripcion}, Categoría: {producto.Categoria}");
                return producto;
            }
            else
            {
                MessageBox.Show("No se encontró el producto con el nombre especificado.");
                return null;
            }
        } 
        
        public static void ListaSize()
        {
            MessageBox.Show("El tamaño de la lista es: " + productos.Count);
        }
    }
}
