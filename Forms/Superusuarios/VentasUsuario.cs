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
    public partial class VentasUsuario : Form
    {
        public VentasUsuario()
        {
            InitializeComponent();
            mostrarUsuarios();
            lblSeleccioneUsuario.Visible = false;
        }

        // Mostrar los usuarios (comunes) en el combobox
        private void mostrarUsuarios()
        {
            // Consulta 
            string consulta = "SELECT usuario FROM tbl_usuarios_comunes"; // Eliminado las comillas innecesarias

            try
            {
                // Creamos la conexion a la base de datos 
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                // Comando
                SqlCommand cmd = new SqlCommand(consulta, conexionConsulta); // Cambiado
                // Lemos
                SqlDataReader reader = cmd.ExecuteReader(); // Cambiado

                // Limpiamos
                cmbUsuarios.Items.Clear();

                // Leemos y guardamos en el ComboBox
                while (reader.Read())
                {
                    string usuario = reader.GetString(0);
                    cmbUsuarios.Items.Add(usuario);
                }

                // Cerramos la conexion y el objeto reader
                conexionConsulta.Close();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos desde la base: " + ex);
                throw;
            }
        }

        // Logica boton mostrar
        async private void btnMostrarVentas_Click(object sender, EventArgs e)
        {
            if (cmbUsuarios.Text != "")
            {
                // Asignatura selecionada por el usuario
                string usuario = cmbUsuarios.Text;

                // Consulta para obtener las coincidencias de la asignatura seleccionada por el usuario
                string consulta1 = $"SELECT * FROM tbl_usuarios_comunes WHERE usuario='{usuario}'";

                // Para almacenar el id del usuario seleccionada
                int idUsuario;

                try
                {
                    // Creamos la conexion
                    SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                    conexionConsulta.Open();

                    //Comando
                    SqlCommand cmd = new SqlCommand(consulta1, conexionConsulta); // Cambiado
                    // Leer
                    SqlDataReader reader = cmd.ExecuteReader(); // Cambiado

                    // leemos una ves
                    reader.Read();
                    idUsuario = reader.GetInt32(0); // Leemos de la primera columna - idUsuario

                    // Cerramos reader y la conexion
                    reader.Close();
                    conexionConsulta.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexion: " + ex);
                    throw;
                }

                // Consulta para obtener de tbl_ventas las coincidencias del id del usuario seleccionada
                string consulta2 = $"SELECT * FROM tbl_ventas WHERE idUsuarioComun='{idUsuario}'";

                // Para ordenar
                DataTable tabla = new DataTable();

                try
                {
                    // Conexion 
                    SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                    conexionConsulta.Open();

                    // Comando
                    SqlCommand cmd = new SqlCommand(consulta2, conexionConsulta); // Cambiado
                    // Leer
                    SqlDataReader reader = cmd.ExecuteReader(); // Cambiado

                    // Mostramos
                    limpiarDataGrid();
                    tabla.Load(reader);

                    // Cerramos la conexion y el objeto reader
                    conexionConsulta.Close();
                    reader.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos desde la base: " + ex);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Esperar 2 segundos usando Task.Delay
                lblSeleccioneUsuario.Visible = true;
                await Task.Delay(2000);
                lblSeleccioneUsuario.Visible = false;
            }
        }

        private void limpiarDataGrid()
        {
            dgvVentas.DataSource = null;
            dgvVentas.Rows.Clear();
            dgvVentas.Columns.Clear();
            dgvVentas.ClearSelection();
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
                string rutaPDF = Path.Combine(directorio, $"ventas_usuario_{fechaHora}.pdf");
                string rutaExcel = Path.Combine(directorio, $"ventas_usuario_{fechaHora}.xlsx");

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
