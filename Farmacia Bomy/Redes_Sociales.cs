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
    public partial class Redes_Sociales : Form
    {
        public Redes_Sociales()
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

        private void buttonCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Redes_Sociales_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = FormInicio.Usuario;
            labelMatricula.Text = Form1.NumEmpleado;
        }

        private void pictureBoxFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/farmaciaguascalientes");
        }

        private void pictureBoxTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/TevaFarmacia");
        }

        private void pictureBoxInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/sanpablofarma/?hl=es-la");
        }

        private void pictureBoxYouTube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCTroUvxaviw7fzXJyMa9mFA");
        }

        private void pictureBoxWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.farmaciaguascalientes.com/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }
    }
}
