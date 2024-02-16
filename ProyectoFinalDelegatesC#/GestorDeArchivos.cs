using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDelegatesC_
{
    internal class GestorDeArchivos
    {
        //Variables
        public static Producto[] productos = new Producto[20];
        private static int indice = 0;

           


        public static void AgregarProductoAMatriz(string nombre, double precio, int cantidad, string descripcion)
        {
            // Verificamos si ya alcanzamos la capacidad máxima de la matriz
            if (indice < productos.Length)
            {
                // Creamos un nuevo producto y lo agregamos a la matriz
                productos[indice] = new Producto(nombre, precio, cantidad, descripcion);
                // Incrementamos el índice para la siguiente posición disponible
                indice++;
            }
            else
            {
                Console.WriteLine("La matriz de productos está llena.");
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
                    // Dividir la línea en las partes usando la coma como separador
                    string[] partes = linea.Split(',');

                    // Asegurar que haya al menos 4 partes para crear un producto
                    if (partes.Length >= 4)
                    {
                        // Las tres primeras partes son nombre, precio y cantidad, la última es la descripción
                        string nombre = partes[0].Trim();

                        // Unir las partes de la descripción con comas en caso de que haya más de 4 partes
                        string descripcion = string.Join(",", partes.Skip(3)).Trim();

                        double precio = Convert.ToDouble(partes[1].Trim());
                        int cantidad = Convert.ToInt32(partes[2].Trim());

                        // Agregar el producto a la matriz
                        AgregarProductoAMatriz(nombre, precio, cantidad, descripcion);
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
            if (productos.Length > 1)
            {
                // Recorrer todos los productos y mostrar sus propiedades en un MessageBox
                for (int i = 0; i < productos.Length; i++)
                {
                    if (productos[i] != null)
                    {
                        MessageBox.Show($"Producto {i + 1} - Nombre: {productos[i].Nombre}, Precio: {productos[i].Precio}, Cantidad: {productos[i].Cantidad}, Descripción: {productos[i].Descripcion}");
                    }
                    else
                    {
                        MessageBox.Show($"Producto {i + 1} no está disponible.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay suficientes productos disponibles.");
            }
        }

    }
}
