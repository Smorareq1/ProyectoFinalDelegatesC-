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
                
                string[] lineas = File.ReadAllLines(rutaArchivo);

                foreach (string linea in lineas)
                {
                    
                    string[] partes = linea.Split(',');

                   
                    if (partes.Length >= 3)
                    {
                        string nombre = partes[0].Trim();
                        string correo = partes[1].Trim();
                        string contrasena = partes[2].Trim();

                        
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

        public static Usuario BuscarUsuarioPorNombre(string nombre) // que pasa si hay dos usuarios con el mismo nombre? // decir que el usuario ya existe y que no se puede agregar
        {
            
            Usuario usuarioEncontrado = ListaUsuarios.Find(u => u.Nombre == nombre);

            if (usuarioEncontrado != null)
            {
                return usuarioEncontrado; //devuelve el usuario para poder poner los atributos :3
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                return null;
            }
        }



    }
}
