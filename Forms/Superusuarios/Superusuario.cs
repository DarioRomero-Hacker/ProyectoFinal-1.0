using ProyectoFinal_1._0.Forms.Superusuarios;
using ProyectoFinal_1._0.Gestion_Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_1._0.Forms
{
    public partial class Superusuario : Form
    {
        public Superusuario(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Ingresaste como " + usuario;
        }

        // Para cerrar el formulario (sesion)
        private void lklCrearCuenta_Click(object sender, EventArgs e)
        {
            DialogResult volver = MessageBox.Show("Desea volver a la pantalla de Login?", "Volver a Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (volver == DialogResult.Yes)
            {
                this.Dispose(); // Cierra el formulario actual (SignUp)
                Login loginForm = new Login(); // Crea una nueva instancia del formulario Login
                loginForm.Show(); // Muestra el formulario Login
            }
        }

        // Mostrar formulario
        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
        }

        // Ventas por usuarios -- usuarios comunes
        private void btnVentasporUsuarios_Click(object sender, EventArgs e)
        {
            VentasUsuario ventasUsuario = new VentasUsuario();
            ventasUsuario.Show();
        }

        // Ventas -- diarias/semanales/mensuales
        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        // Productos mas vendidos
        private void btnMasVendidos_Click(object sender, EventArgs e)
        {
            ProductosMaasVendidos productosMaasVendidos = new ProductosMaasVendidos();
            productosMaasVendidos.Show();
        }

        // Gestion de productos
        private void btnProductosGestion_Click(object sender, EventArgs e)
        {
            Menu_GP menu_GP = new Menu_GP();
            menu_GP.Show();
        }

        // Gestion de reportes
        private void btnReportesGestion_Click(object sender, EventArgs e)
        {
            gestionReportes reporte = new gestionReportes();
            reporte.Show();
        }

        private void btnUsuariosGestionar_Click(object sender, EventArgs e)
        {
            Menu_GU menu_GU = new Menu_GU();
            menu_GU.Show();
        }

        private void btnClientesGestionar_Click(object sender, EventArgs e)
        {
            Menu_GC menu_GC = new Menu_GC();
            menu_GC.Show();
        }

        private void lklCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
