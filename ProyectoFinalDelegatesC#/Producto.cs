using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;

namespace ProyectoFinalDelegatesC_
{
    internal class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        //Matriz de productos
        public static Producto[] productos = new Producto[20];
        private static int indice = 0; 

        //Constructor

        public Producto(string nombre, double precio, int cantidad, string descripcion)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Descripcion = descripcion;
        }

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
                    // Dividimos cada línea en sus partes usando la coma como separador
                    string[] partes = linea.Split(',');

                    // Aseguramos que tenemos suficientes partes para crear un producto
                    if (partes.Length >= 4)
                    {
                        string nombre = partes[0].Trim();
                        double precio = Convert.ToDouble(partes[1].Trim());
                        string descripcion = partes[2].Trim();
                        int cantidad = Convert.ToInt32(partes[3].Trim());

                        // Agregamos el producto a la matriz
                        AgregarProductoAMatriz(nombre, precio, cantidad, descripcion);
                    }
                    else
                    {
                        Console.WriteLine("La línea no tiene el formato adecuado: " + linea);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al leer el archivo: " + ex.Message);
            }
        }

        public static void MostrarProductos()
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null)
                {
                    Console.WriteLine("Nombre: " + productos[i].Nombre);
                    Console.WriteLine("Precio: " + productos[i].Precio);
                    Console.WriteLine("Cantidad: " + productos[i].Cantidad);
                    Console.WriteLine("Descripción: " + productos[i].Descripcion);
                    Console.WriteLine();
                }
            }
        }
    }
}

