using Microsoft.Data.SqlClient; 
using ProyectoFinal_1._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Asegúrate de tener esta referencia para usar Path
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    public partial class ProductosMaasVendidos : Form
    {
        public ProductosMaasVendidos()
        {
            InitializeComponent();
        }

        private void ProductosMaasVendidos_Load(object sender, EventArgs e)
        {
            try
            {
                // Creamos la conexion
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado a SqlConnection
                conexionConsulta.Open();

                string query = @"SELECT v.idProducto, 
                                        p.producto, 
                                        SUM(v.cantidad) AS total_cantidad, 
                                        SUM(v.cantidad * p.precio) AS total_venta 
                                 FROM tbl_ventas v
                                 JOIN tbl_productos p ON v.idProducto = p.idProducto
                                 GROUP BY v.idProducto, p.producto
                                 ORDER BY total_cantidad DESC;";

                SqlCommand cmd = new SqlCommand(query, conexionConsulta); // Cambiado a SqlCommand

                SqlDataAdapter adaptar = new SqlDataAdapter(cmd); // Cambiado a SqlDataAdapter
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);

                // Mostrar datos en DataGridView
                dgvVentas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexión: " + ex.Message); // Cambiado el texto a español
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (dgvVentas.Rows.Count > 0)
            {
                // Creamos una instancia del tipo CrearReporte
                CrearReporte reporte = new CrearReporte(dgvVentas);

                // Obtenemos la fecha y hora actuales
                string fechaHora = DateTime.Now.ToString("yyyyMMdd_HHmmss");

                // Definimos el directorio donde deseamos guardar los archivos en Documentos
                string directorio = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Generamos los nombres de archivo con la fecha y hora
                string rutaPDF = Path.Combine(directorio, $"productos_mas_vendidos_{fechaHora}.pdf");
                string rutaExcel = Path.Combine(directorio, $"productos_mas_vendidos_{fechaHora}.xlsx");

                // Creamos los pdf
                reporte.ObtenerReporte(rutaPDF, rutaExcel);

                // Exito
                MessageBox.Show($"Reporte generado exitosamente.\nPDF: {rutaPDF}\nExcel: {rutaExcel}");
            }
            else
            {
                MessageBox.Show("El DataGridView está vacío. No se puede generar el PDF o Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
