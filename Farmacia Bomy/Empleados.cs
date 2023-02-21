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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void buttonHitorial_Click(object sender, EventArgs e)
        {
            Hide();
            Historial VentanaHistorial = new Historial();
            VentanaHistorial.ShowDialog();
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
        
        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            Hide();
            Galeria Galeria = new Galeria();
            Galeria.ShowDialog();
        }

        private void buttonCambiarUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 VentanaUsuario = new Form1();
            VentanaUsuario.ShowDialog();
        }

        private void buttonAcercaDe_Click(object sender, EventArgs e)
        {
            Hide();
            AcercaDe VentanaAcercaDe = new AcercaDe();
            VentanaAcercaDe.ShowDialog();
        }

        private void buttonRedesSociales_Click(object sender, EventArgs e)
        {
            Hide();
            Redes_Sociales RedS = new Redes_Sociales();
            RedS.ShowDialog();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = FormInicio.Usuario;
            labelMatricula.Text = Form1.NumEmpleado;
            // TODO: esta línea de código carga datos en la tabla 'proyectoDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.proyectoDataSet.Empleados);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
