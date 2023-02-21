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
    public partial class Galeria : Form
    {
        public Galeria()
        {
            InitializeComponent();
        }

        private void buttonVentas_Click(object sender, EventArgs e)
        {
            Hide();
            Ventas VentanaVentas = new Ventas();
            VentanaVentas.ShowDialog();
        }

        private void buttonHitorial_Click(object sender, EventArgs e)
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

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            Hide();
            Empleados Empleados = new Empleados();
            Empleados.ShowDialog();
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

        private void buttonCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int intImgNum = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
            pictureBoxMedicamentos.Image = imageListMedicamentos.Images[intImgNum];
            if (intImgNum == imageListMedicamentos.Images.Count - 1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }
        }
        
        private void pictureBoxMedicamentos_Click(object sender, EventArgs e)
        {
            
        }

        private void Galeria_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = FormInicio.Usuario;
            labelMatricula.Text = Form1.NumEmpleado;
            timer1.Start();
        }
    }
}
