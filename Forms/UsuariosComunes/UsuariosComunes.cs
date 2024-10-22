using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 
using ProyectoFinal_1._0.Forms.Superusuarios;

namespace ProyectoFinal_1._0.Forms.UsuariosComunes
{
    public partial class UsuariosComunes : Form
    {
        public string usuario; // Usuario logeado

        public UsuariosComunes(string usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
            lblUsuario.Text = "Ingresaste como " + usuario;
        }

        // Cerrar
        private void lklCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Confirmacion
            DialogResult volver = MessageBox.Show("Desea cerrar sesión", "Volver a login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (volver == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        // Para registrar las ventas
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            RegistrarVentas registrarVentas = new RegistrarVentas(usuario);
            registrarVentas.Show();
        }

        // Gestión de reportes
        private void btnReportesGestion_Click(object sender, EventArgs e)
        {
            gestionReportes reporte = new gestionReportes();
            reporte.Show();
        }

        private void btnClientesGestionar_Click(object sender, EventArgs e)
        {
            Menu_GC menu_GC = new Menu_GC();
            menu_GC.Show();
        }
    }
}
