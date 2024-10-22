using DocumentFormat.OpenXml.Bibliography;
using Microsoft.Data.SqlClient; // Cambiado
using ProyectoFinal_1._0.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        // Ventas diarias
        private void ObtenerVentasDiarias(DateTime fechaConsulta)
        {
            try
            {
                // Creamos la conexion
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                // Consulta ventas diarias
                string query = @"SELECT v.idVenta, v.idProducto, p.producto, v.idUsuarioComun, u.usuario AS vendedor, v.cantidad, v.fechaVenta, 
                            (v.cantidad * p.precio) AS total_venta 
                            FROM tbl_ventas v
                            JOIN tbl_productos p ON v.idProducto = p.idProducto
                            JOIN tbl_usuarios_comunes u ON v.idUsuarioComun = u.idUsuarioComun
                            WHERE CAST(v.fechaVenta AS DATE) = @fechaConsulta;"; // Cambiado

                // Comando
                SqlCommand cmd = new SqlCommand(query, conexionConsulta); // Cambiado
                cmd.Parameters.AddWithValue("@fechaConsulta", fechaConsulta.Date); // Solo la fecha sin la hora

                // Adaptamos
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd); // Cambiado
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);

                // Mostramos
                dgvVentas.DataSource = tabla;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexion: " + ex.Message);
                throw;
            }
        }

        // Obtener ventas semanales
        private void ObtenerVentasSemanales(DateTime fechaConsulta)
        {
            try
            {
                // Creamos la conexion
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                string query = @"SELECT v.idVenta, 
                                        v.idProducto, 
                                        p.producto, 
                                        v.idUsuarioComun, 
                                        u.usuario AS vendedor, 
                                        v.cantidad, 
                                        v.fechaVenta, 
                                        (v.cantidad * p.precio) AS total_venta 
                                 FROM tbl_ventas v
                                 JOIN tbl_productos p ON v.idProducto = p.idProducto
                                 JOIN tbl_usuarios_comunes u ON v.idUsuarioComun = u.idUsuarioComun
                                 WHERE DATEPART(ISO_WEEK, v.fechaVenta) = DATEPART(ISO_WEEK, @fechaConsulta) 
                                 AND YEAR(v.fechaVenta) = YEAR(@fechaConsulta);"; // Cambiado

                SqlCommand cmd = new SqlCommand(query, conexionConsulta); // Cambiado
                cmd.Parameters.AddWithValue("@fechaConsulta", fechaConsulta.Date); // Solo la fecha sin la hora

                SqlDataAdapter adaptar = new SqlDataAdapter(cmd); // Cambiado
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);

                // Mostrar datos en DataGridView
                dgvVentas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexion: " + ex.Message);
            }
        }

        // Ventas mensuales
        private void ObtenerVentasMensuales(DateTime fechaConsulta)
        {
            try
            {
                // Creamos la conexion
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                string query = @"SELECT v.idVenta, 
                                        v.idProducto, 
                                        p.producto, 
                                        v.idUsuarioComun, 
                                        u.usuario AS vendedor, 
                                        v.cantidad, 
                                        v.fechaVenta, 
                                        (v.cantidad * p.precio) AS total_venta 
                                 FROM tbl_ventas v
                                 JOIN tbl_productos p ON v.idProducto = p.idProducto
                                 JOIN tbl_usuarios_comunes u ON v.idUsuarioComun = u.idUsuarioComun
                                 WHERE MONTH(v.fechaVenta) = MONTH(@fechaConsulta)
                                 AND YEAR(v.fechaVenta) = YEAR(@fechaConsulta);";

                SqlCommand cmd = new SqlCommand(query, conexionConsulta); // Cambiado
                cmd.Parameters.AddWithValue("@fechaConsulta", fechaConsulta.Date); // Solo la fecha sin la hora

                SqlDataAdapter adaptar = new SqlDataAdapter(cmd); // Cambiado
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);

                // Mostrar datos en DataGridView
                dgvVentas.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexion: " + ex.Message);
            }
        }

        private void limpiarDataGrid()
        {
            dgvVentas.DataSource = null;
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();
            dgvVentas.ClearSelection();
        }

        // Ventas diarias boton logica
        private void btnVentasDia_Click(object sender, EventArgs e)
        {
            limpiarDataGrid();
            DateTime fechaConsulta = dateTimePickerVenta.Value.ToUniversalTime();
            ObtenerVentasDiarias(fechaConsulta);
        }

        private void btnVentasSemanales_Click(object sender, EventArgs e)
        {
            limpiarDataGrid();
            DateTime fechaConsulta = dateTimePickerVenta.Value.ToUniversalTime();
            ObtenerVentasSemanales(fechaConsulta);
        }

        private void btnVentasMensuales_Click(object sender, EventArgs e)
        {
            limpiarDataGrid();
            DateTime fechaConsulta = dateTimePickerVenta.Value.ToUniversalTime();
            ObtenerVentasMensuales(fechaConsulta);
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
                string rutaPDF = Path.Combine(directorio, $"ventas_{fechaHora}.pdf");
                string rutaExcel = Path.Combine(directorio, $"ventas_{fechaHora}.xlsx");

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
