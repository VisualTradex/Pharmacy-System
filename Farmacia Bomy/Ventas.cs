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
    public partial class Ventas : Form
    {
        public List<Producto> Carrito = new List<Producto>();
        public Ventas()
        {
            InitializeComponent();
        }
        private void Ventas_Load(object sender, EventArgs e)
        {
            labelUsuario.Text = FormInicio.Usuario;
            labelMatricula.Text = Form1.NumEmpleado;
        }

        private void buttonCerra_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHitorial_Click(object sender, EventArgs e)
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

        private void buttonCambiarUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 VentanaUsuario = new Form1();
            VentanaUsuario.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("hh:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            listBoxMedicamentos.SelectedIndex = listBoxMedicamentos.FindString(textBoxBuscar.Text);
        }
        public static double precio, total;
        public static int cont = 0;
        public static string fecha, hora, nombre;

        private void buttonContinuarCompra_Click(object sender, EventArgs e)
        {
            nombre=textBoxNombre.Text;
            fecha = labelFecha.Text;
            hora = labelHora.Text;
            Compra compra = new Compra(Carrito);
            compra.ShowDialog();
        }
        int cantidad;
        public void buttonAgregarCarrito_Click(object sender, EventArgs e)
        {
            cantidad = Convert.ToInt32(textBoxCantidad.Text);
            total = total + (precio*cantidad);
            labelTotal.Text = total.ToString();
            cont = cont + cantidad;
            
        }

        private void buttonGaleria_Click(object sender, EventArgs e)
        {
            Hide();
            Galeria Galeria = new Galeria();
            Galeria.ShowDialog();
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

        public string descrip, nombreM;

        private void listBoxMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            textBoxCantidad.Text = "1";
            switch (listBoxMedicamentos.SelectedIndex)
            {
                case 0:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Solución oleosa Frasco de 120mL";
                    precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 0;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 1:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 1;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 2:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 400 mcg";
                    precio = 116.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 2;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 3:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 5 mL en frasco o ampollas";
                    precio = 9.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 3;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 4:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Gas medicinal";
                    precio = 66.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 4;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 5:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "400 mg en frasco de 10 mL";
                    precio = 35.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 5;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 6:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "400 mg en frasco de 20 mL";
                    precio = 55.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 6;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 7:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 1 g (sal sódica) en vial";
                    precio = 76.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 8;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 8:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 20,000 UI/10 mL en vial de 10 mL";
                    precio = 90.15;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 9;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 9:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 100 mg";
                    precio = 30.33;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 10;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 10:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 11;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 11:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 600 mg";
                    precio = 90.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 12;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 12:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 5 mg";
                    precio = 45.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 13;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 13:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Cápsula o tableta oral 500 mg";
                    precio = 27.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 14;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 14:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Cápsula o Tableta oral 500 mg";
                    precio = 69.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 15;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 15:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 1 g en vial";
                    precio = 55.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 16;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 16:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 500 mg (sal sódica) en vial";
                    precio = 59.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 17;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 17:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 1 g (sal sódica) en vial";
                    precio = 76.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 18;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 18:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 200 mcg";
                    precio = 26.73;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 19;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 19:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 0.5 mg (500 mcg)";
                    precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 20;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 20:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 4 mg/1 mL en ampolla de 1 y 2 mL";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 21;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 21:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 50 mg";
                    precio = 50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 22;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 22:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 50 mg";
                    precio = 55.20;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 23;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 23:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "125 mg/5 mL en frasco de 100 - 120 mL";
                    precio = 78.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 24;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 24:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 38.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 25;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 25:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 50mg/1mL en ampolla de 1mL";
                    precio = 29.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 26;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 26:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 50mg/1mL en ampolla 2mL";
                    precio = 40.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 27;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 27:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 500 mg/ 1 mL en ampolla de 2 mL";
                    precio = 71.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 28;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 28:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 29;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 29:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "	Inyección 500 mg/ 1 mL en ampolla de 2 mL	"; precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 30;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 30:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "	Solución rectal 6g - 16g en frasco de 100mL";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 31;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 31:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Loción 2% en frasco de 120 mL";
                    precio = 116.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 32;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 32:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 2,000 UI/1 mL en vial de 1 mL";
                    precio = 9.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 33;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 33:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 0.5 mg/10 mL en ampolla de 10 mL";
                    precio = 66.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 34;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 34:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 0.1mg/1mL en";
                    precio = 35.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 35;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 35:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 5 mg";
                    precio = 55.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 36;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 36:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 500 mg en vial";
                    precio = 98.80;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 37;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 37:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 200 mg";
                    precio = 76.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 38;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 38:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 400 mg";
                    precio = 90.15;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 39;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 39:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 25 mg";
                    precio = 30.33;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 40;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 40:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 100 UI/1 mL en vial de 10 mL";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 41;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 41:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 50mg/ 1mL en vial de 10 mL";
                    precio = 90.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 42;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 42:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tabletas 150 mg + 300 mg";
                    precio = 45.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 43;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 43:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 0.05 mg";
                    precio = 27.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 44;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 44:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 2 mg";
                    precio = 69.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 45;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 45:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 10 mg";
                    precio = 55.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 46;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 46:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 500 mg en vial";
                    precio = 26.73;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 49;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 47:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 50;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 48:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 40 mg/1 mL en ampolla de 1 mL";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 51;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 49:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 500 mg en vial";
                    precio = 50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 52;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 50:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 5 mg";
                    precio = 55.20;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 53;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 51:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 5mg/mL en ampolla de 2mL";
                    precio = 78.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 54;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 52:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 10mg";
                    precio = 38.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 55;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 53:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 1mg/1 mL en ampolla de 5 mL";
                    precio = 71.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 58;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 54:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Caja con 24 tabletas 500 mg";
                    precio = 50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 59;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 55:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "mg/1 mL en frasco de 240 mL";
                    precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 60;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 56:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 50 mg";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 61;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 57:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 120 mg";
                    precio = 116.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 62;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 58:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Cápsula 20 mg";
                    precio = 9.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 63;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 59:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 2mg/1mL en ampolla de 2mL y 4mL";
                    precio = 66.78;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 64;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 60:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Gas inhalado	";
                    precio = 200.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 65;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 61:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Gas medicinal";
                    precio = 155.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 66;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 62:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 98.80;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 67;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 63:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Gel o Gel acuoso 5% en tubo de 30 g	";
                    precio = 76.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 68;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 64:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 150 mg";
                    precio = 90.15;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 69;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 65:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 600 mg";
                    precio = 30.33;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 70;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 66:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 10mg/1 mL en ampolla de 20 mL";
                    precio = 27.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 74;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 67:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 1mg/1 mL en ampolla de 1 mL";
                    precio = 69.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 75;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 68:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 300 mg";
                    precio = 55.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 76;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 69:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Cápsula/Perla 50,000 UI";
                    precio = 59.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 77;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 70:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 10 mg/1 mL en ampolla de 5 mL";
                    precio = 76.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 78;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 71:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Solución oral de yodo acuoso Yodo 5% + yoduro de potasio 10% en agua purificada (yodo total 130 mg/1 mL) en frasco de 100 ml";
                    precio = 26.73;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 79;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 72:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Solución Estándar USP en vial de 10 mL";
                    precio = 126.00;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 80;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 73:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Suspensión oral 60 gr en frasco";
                    precio = 55.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 81;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 74:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Tableta oral 500 mg";
                    precio = 50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 82;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 75:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Polvo para inyección 1 gr en vial";
                    precio = 55.20;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 83;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 76:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Crema 0.025% en tubo de 30 g";
                    precio = 78.50;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 84;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 77:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 20 mg/1 mL en ampolla de 1 mL";
                    precio = 38.90;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 85;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
                case 78:
                    nombreM = listBoxMedicamentos.SelectedItem.ToString();
                    producto.Nombre = nombreM;
                    descrip = "Inyección 10 mg/1 mL en vial de 20 mL";
                    precio = 29.99;
                    labelDescripcion.Text = descrip;
                    labelPrecio.Text = precio.ToString();
                    producto.Index = 86;
                    producto.Descripcion = descrip;
                    producto.Precio = precio;
                    Carrito.Add(producto);
                    break;
            }
            textBoxCantidad.Focus();
        }
    }
}
