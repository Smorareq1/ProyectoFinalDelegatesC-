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
            // Comprobar primero que la cantidad no sea negativa y que el precio no sea negativo
            if (cantidad <= 0 || precio < 0)
            {
                throw new ArgumentException("La cantidad no puede ser menor o igual a 0 y el precio no puede ser menor a 0 en el producto: " + nombre);
            }

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
                //Delegate
                SistemaDeNotificaciones.VerificarCantidadesBajas(productos, NotificarCantidadBaja);
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
        

        public static int ListaSize()
        {
            return productos.Count;
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

        public static List<Producto> BuscarProductoPorCoincidencia(string coincidencia)
        {
            List<Producto> productosCoincidentes = new List<Producto>();

            foreach (var producto in productos.Values)
            {
                if (producto.Nombre.Contains(coincidencia, StringComparison.OrdinalIgnoreCase)) 
                {
                    productosCoincidentes.Add(producto);
                }
            }

            if (productosCoincidentes.Count == 0)
            {
                MessageBox.Show($"No se encontraron productos que coincidan con \"{coincidencia}\".");
                return null;
            }
            
            return productosCoincidentes; 
        }

        
        //Usando delegates
        public static void NotificarCantidadBaja(string nombre, int cantidad)
        {
            MessageBox.Show($"Quedan pocas unidades del producto {nombre}. Cantidad disponible: {cantidad}");
        }

        //Sobbreescribir el archivo txt con los datos del diccionario
        public static void GuardarProductosEnArchivo(string rutaArchivo)
        {
            try
            {
                // Crear un arreglo de strings con los datos de los productos
                string[] lineas = new string[productos.Count];

                int i = 0;
                foreach (var producto in productos.Values)
                {
                    lineas[i] = $"{producto.Nombre},{producto.Precio},{producto.Cantidad},{producto.Descripcion},{producto.Categoria}";
                    i++;
                }

                // Escribir el arreglo de strings en el archivo
                File.WriteAllLines(rutaArchivo, lineas);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al escribir el archivo: " + ex.Message);
            }
        }

    }
}
