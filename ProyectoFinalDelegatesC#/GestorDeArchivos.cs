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
        // Diccionario para almacenar los productos, utilizando el nombre como clave
        public static Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

        public static void AgregarProductoALista(string nombre, double precio, int cantidad, string descripcion, string categoria)
        {
            // Si el producto ya está en el diccionario, sumamos la cantidad
            if (productos.ContainsKey(nombre))
            {
                productos[nombre].Cantidad += cantidad;
            }
            else
            {
                // Si no está en el diccionario, creamos un nuevo producto y lo agregamos
                productos.Add(nombre, new Producto(nombre, precio, cantidad, descripcion, categoria));
            }
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

                        // Agregamos el producto al diccionario
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
                foreach (var producto in productos.Values)
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
            // Buscar un producto por su nombre en el diccionario
            if (productos.ContainsKey(nombre))
            {
                Producto producto = productos[nombre];
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

        public static List<Producto> BuscarProductosPorCategoria(string categoria)
        {
            List<Producto> productosPorCategoria = new List<Producto>();

            foreach (var producto in productos.Values)
            {
                if (producto.Categoria.Equals(categoria, StringComparison.OrdinalIgnoreCase))
                {
                    productosPorCategoria.Add(producto);
                }
            }

            if (productosPorCategoria.Count == 0)
            {
                MessageBox.Show($"No se encontraron productos en la categoría \"{categoria}\".");
            }

            return productosPorCategoria;
        }

    }
}
