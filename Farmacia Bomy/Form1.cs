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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string NumEmpleado;
        int intentos = 0;
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (intentos == 3)
            {
                MessageBox.Show("Sobrepasaste el número de intentos", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                comboBoxUser.Enabled = false;
                maskedTextBoxPassword.Enabled = false;
                buttonIniciarSesion.Enabled = false;
            }
            else
            {
                if (comboBoxUser.SelectedIndex == 0 & maskedTextBoxPassword.Text == "12345")
                {
                    Hide();
                    FormInicio.Usuario = comboBoxUser.SelectedItem.ToString();
                    NumEmpleado = "R193609833";
                    MessageBox.Show("Bienvenido al Sistema", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormInicio Ventana = new FormInicio();
                    Ventana.ShowDialog();
                }
                else
                {
                    if (comboBoxUser.SelectedIndex == 1 & maskedTextBoxPassword.Text == "12345")
                    {
                        Hide();
                        FormInicio.Usuario = comboBoxUser.SelectedItem.ToString();
                        NumEmpleado = "R193609732";
                        MessageBox.Show("Bienvenido al Sistema", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormInicio Ventana = new FormInicio();
                        Ventana.ShowDialog();
                    }
                    else
                    {
                        if (comboBoxUser.SelectedIndex == 2 & maskedTextBoxPassword.Text == "12345")
                        {
                            Hide();
                            FormInicio.Usuario = comboBoxUser.SelectedItem.ToString();
                            NumEmpleado = "R193609733";
                            MessageBox.Show("Bienvenido al Sistema", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FormInicio Ventana = new FormInicio();
                            Ventana.ShowDialog();
                        }
                        else
                        {
                            intentos++;
                            MessageBox.Show("Contraseña Incorrecta", "Farmacia Bomy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            maskedTextBoxPassword.Focus();
                            maskedTextBoxPassword.Clear();
                        }
                    }
                }
            }

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBoxPassword.Focus();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maskedTextBoxPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            buttonIniciarSesion.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            comboBoxUser.Focus();
        }
    }
}
