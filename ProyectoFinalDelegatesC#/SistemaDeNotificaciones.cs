using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalDelegatesC_
{
    internal class SistemaDeNotificaciones
    {

        public delegate void NotificarCantidadBajaDelegate(string nombre, int cantidad);

        
        public static void VerificarCantidadesBajas(Dictionary<string, Producto> productos, NotificarCantidadBajaDelegate notificarDelegate)
        {
            foreach (var producto in productos.Values)
            {
                if (producto.Cantidad <= 5)
                {
                    // Ejecutar el delegate para notificar la cantidad baja
                    notificarDelegate?.Invoke(producto.Nombre, producto.Cantidad);
                }
            }
        }

        public static void VerificarCantidadBaja(Producto producto, NotificarCantidadBajaDelegate notificarDelegate)
        {
            if (producto.Cantidad <= 5)
            {
                // Ejecutar el delegate para notificar la cantidad baja
                notificarDelegate?.Invoke(producto.Nombre, producto.Cantidad);
            }
        }

    }
}
