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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void buttonCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            Hide();
            Ventas VentanaVentas = new Ventas();
            VentanaVentas.ShowDialog();
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            Hide();
            Historial VentanaHistorial = new Historial();
            VentanaHistorial.ShowDialog();
        }

        private void buttonCambiarUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 VentanaUsuario = new Form1();
            VentanaUsuario.ShowDialog();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = FormInicio.Usuario;
            labelMatricula.Text = Form1.NumEmpleado;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void buttonHitorial_Click(object sender, EventArgs e)
        {
            Hide();
            Historial VentanaHistorial = new Historial();
            VentanaHistorial.ShowDialog();
        }

        private void buttonVentas_Click_1(object sender, EventArgs e)
        {
            Hide();
            Ventas VentanaVentas = new Ventas();
            VentanaVentas.ShowDialog();
        }

        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            Hide();
            Galeria Galeria = new Galeria();
            Galeria.ShowDialog();
        }

        private void buttonCambiarUsuario_Click_1(object sender, EventArgs e)
        {
            Hide();
            Form1 VentanaUsuario = new Form1();
            VentanaUsuario.ShowDialog();
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            Hide();
            Empleados Empleados = new Empleados();
            Empleados.ShowDialog();
        }

        private void buttonRedesSociales_Click(object sender, EventArgs e)
        {
            Hide();
            Redes_Sociales RedS = new Redes_Sociales();
            RedS.ShowDialog();
        }
    }
}
