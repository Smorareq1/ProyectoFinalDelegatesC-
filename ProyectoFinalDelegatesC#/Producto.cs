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

        public string Categoria { get; set; }

        //Constructor

        public Producto(string nombre, double precio, int cantidad, string descripcion, string categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Descripcion = descripcion;
            Categoria = categoria;
        }

        

    }
}

