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
    public partial class Ticket : Form
    {
        private List<Producto> carro;
        public List<Producto> CarroFinal = new List<Producto>();
        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(List<Producto> carro)
        {
            this.carro = carro;
            InitializeComponent();
            CarroFinal = carro;
            List<String> productos = carro.Select(c => c.Nombre).ToList();
            foreach (string producto in productos)
            {
                listBoxTicket.Items.Add(producto);
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                ClHistorial x = new ClHistorial();
                x.Nombre1 = Ventas.nombre;
                x.Fecha1 = Ventas.fecha;
                x.Hora1 = Ventas.hora;
                x.TotalCompra1 = Ventas.total.ToString();
                int res = ClMetodosHistorial.InsertarHistorial(x);
                if (res > 0)
                {
                    MessageBox.Show("La venta ha sido ingresada correctamente", "Historial De Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al ingresar", "Historial De Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }
            Hide();
            Ventas Ventana = new Ventas();
            Ventana.ShowDialog();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            labelCantidad.Text = Ventas.cont.ToString();
            labelTotalN.Text = Ventas.total.ToString();
            labelRecibiN.Text = Compra.recibi.ToString();
            labelCambioN.Text = Compra.cambio.ToString();
            if (Ventas.cont > 10)
            {
                label6.Visible = true;
            }
        }
    }
}