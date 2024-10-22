using ProyectoFinal_1._0.Forms.Superusuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_1._0
{
    public partial class gestionReportes : Form
    {
        public gestionReportes()
        {
            InitializeComponent();
        }

        // Crear reportes de productos más vendidos 
        private void btnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            // Abrir el form para crear el reporte 
            ProductosMaasVendidos productosMaasVendidos = new ProductosMaasVendidos();
            productosMaasVendidos.Show();
        }

        // Crear reportes de ventas por períodos 
        private void btnVentasDiariasSemanalesMensuales_Click(object sender, EventArgs e)
        {
            // Abrir el form para crear el reporte 
            Ventas ventas = new Ventas();
            ventas.Show();
        }

        // Crear reportes de ventas por usuarios 
        private void btnVentasUsuarios_Click(object sender, EventArgs e)
        {
            // Abrir el form para crear el reporte 
            VentasUsuario ventasUsuario = new VentasUsuario();
            ventasUsuario.Show();
        }
    }
}
