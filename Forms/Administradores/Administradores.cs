using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal_1._0.Forms.Superusuarios;
using ProyectoFinal_1._0.Gestion_Productos;

namespace ProyectoFinal_1._0.Forms
{
    public partial class Administradores : Form
    {
        public Administradores(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Ingresaste como " + usuario;
        }

        // Cerrar formulario
        private void lklCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Confirmacion
            DialogResult volver = MessageBox.Show("Desea cerrar sesion", "Volver a login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (volver == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        // Gestion de reportes
        private void btnReportesGestion_Click(object sender, EventArgs e)
        {
            gestionReportes reporte = new gestionReportes();
            reporte.Show();
        }

        private void btnProductosGestion_Click(object sender, EventArgs e)
        {
            Menu_GP menu_GP = new Menu_GP();
            menu_GP.Show();
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
    }
}
