using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoFinalDelegatesC_
{
    public partial class Menu : Form
    {

        //Variables
        private static string Nombre;
        string Correo;



        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void SetInformacionMenu(string nombre, string correo)
        {
            Nombre = nombre;
            Correo = correo;

        }

        private void button1_Click(object sender, EventArgs e) //Buscar
        {
            this.Hide();
            if (GestorDeArchivos.ListaSize() == 0)
            {
                MessageBox.Show("No hay productos en el inventario, porfavor agregue productos antes de realizar la busqueda de un producto.");
                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                Iniciar buscar = new Iniciar();
                buscar.SetInformacion(Nombre, Correo);
                buscar.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e) //Agregar
        {
            this.Hide();
            Agregar buscar = new Agregar();
            buscar.Show();
        }

        private void button3_Click(object sender, EventArgs e) //Compra venta
        {
            
            this.Hide();
            if (GestorDeArchivos.ListaSize() ==0)
            {
                   MessageBox.Show("No hay productos en el inventario, porfavor agregue productos antes de realizar una compra o venta.");
                Menu menu = new Menu();   
                menu.Show();
            }
            else {
                CompraVenta compraVenta = new CompraVenta();
                compraVenta.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e) //Editar
        {
            this.Hide();
            Editar editar = new Editar();
            editar.Show();
        }
    }
}
