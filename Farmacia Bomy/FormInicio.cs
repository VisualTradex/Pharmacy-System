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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }
        public static string Usuario;

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

        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            Hide();
            AcercaDe VentanaAcercaDe = new AcercaDe();
            VentanaAcercaDe.ShowDialog();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCambiarUsuario_Click(object sender, EventArgs e)
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

        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            Hide();
            Galeria Galeria = new Galeria();
            Galeria.ShowDialog();
        }

        private void buttonRedesSociales_Click(object sender, EventArgs e)
        {
            Hide();
            Redes_Sociales RedS = new Redes_Sociales();
            RedS.ShowDialog();
        }
    }
}
