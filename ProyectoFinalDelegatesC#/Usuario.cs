using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDelegatesC_
{
    internal class Usuario
    {
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombre, string correo, string contrasena)
        {
            Nombre = nombre;
            Correo = correo;
            Contrasena = contrasena;
        }


    }
}
