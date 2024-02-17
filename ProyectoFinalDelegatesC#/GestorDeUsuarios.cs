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
        public static Dictionary<string, Usuario> Usuarios = new Dictionary<string, Usuario>();

        public static void AgregarUsuarioALista(string nombre, string correo, string contrasena)
        {
            // Verificar si el usuario ya existe en el diccionario
            if (Usuarios.ContainsKey(nombre))
            {
                MessageBox.Show("El usuario ya existe.");
                return;
            }

            // Agregar el usuario al diccionario
            Usuarios.Add(nombre, new Usuario(nombre, correo, contrasena));
        }

        public static void CargarUsuariosDesdeArchivo(string rutaArchivo)
        {
            try
            {
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');

                    if (partes.Length >= 3)
                    {
                        string nombre = partes[0].Trim();
                        string correo = partes[1].Trim();
                        string contrasena = partes[2].Trim();

                        // Agregar el usuario al diccionario
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
            // Buscar un usuario por su nombre en el diccionario
            if (Usuarios.ContainsKey(nombre))
            {
                return Usuarios[nombre]; // Devuelve el usuario encontrado
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                return null;
            }
        }
    }

}
