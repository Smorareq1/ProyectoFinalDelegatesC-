using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDelegatesC_
{
    internal class GestorDeUsuarios
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>();

        public static void AgregarUsuarioALista(string nombre, string correo, string contrasena)
        {
            ListaUsuarios.Add(new Usuario(nombre, correo, contrasena));
        }

        public static void CargarUsuariosDesdeArchivo(string rutaArchivo)
        {
            try
            {
                // Leemos todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    // Dividimos cada línea en sus partes usando la coma como separador
                    string[] partes = linea.Split(',');

                    // Aseguramos que tenemos suficientes partes para crear un usuario
                    if (partes.Length >= 3)
                    {
                        string nombre = partes[0].Trim();
                        string correo = partes[1].Trim();
                        string contrasena = partes[2].Trim();

                        // Creamos el usuario y lo agregamos a la lista
                        AgregarUsuarioALista(nombre, correo, contrasena);
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

        public static Usuario BuscarUsuarioPorNombre(string nombre)
        {
            // Buscar el usuario por su nombre en la lista de usuarios
            Usuario usuarioEncontrado = ListaUsuarios.Find(u => u.Nombre == nombre);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado; // Devolver el usuario encontrado
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                return null;
            }
        }



    }
}
