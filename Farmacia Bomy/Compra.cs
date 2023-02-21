using Farmacia_Bomy.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_Bomy
{
    public partial class Compra : Form
    {
        public List<Producto> CarritoFinal = new List<Producto>();
        public Compra()
        {
            InitializeComponent();
        }
       
        public Compra(List<Producto> carrito)
        {
            InitializeComponent();
            CarritoFinal = carrito;
            List<String> productos = carrito.Select(c => c.Nombre + " - " + String.Format("{0:C}", c.Precio)).ToList();
            foreach(string producto in productos)
            { 
                listBoxProductosComprados.Items.Add(producto);
            }
            Carro = carrito;
        }
        public List<Producto> Carro = new List<Producto>();
        public static double cambio, recibi;
        public static string nombreC, FechaC, HoraC;
        public static string TotalCompra;
        private void buttonPagar_Click(object sender, EventArgs e)
        {           
            if (cambio > 0)
            {
                Hide();
                Ticket tick = new Ticket(Carro);
                tick.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Lo sentimos, el cliente no cuenta con el credito suficiente", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            nombreC = Ventas.nombre;
            FechaC = Ventas.fecha;
            HoraC = Ventas.hora;
            TotalCompra = Ventas.total.ToString();
            
        }

        private void textBoxRecibi_TextChanged(object sender, EventArgs e)
        {
            recibi = Convert.ToDouble(textBoxRecibi.Text);
            cambio = recibi- Ventas.total;
            labelCambio.Text = cambio.ToString();
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            labelTotal.Text = Ventas.total.ToString();
            labelCantidad.Text = Ventas.cont.ToString();
            textBoxRecibi.Focus();

        }

    }
}
