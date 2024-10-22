using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_1._0.Forms.UsuariosComunes
{
    public partial class RegistrarVentas : Form
    {
        // Usuario logeado
        public string usuario;

        // Constructor recibe el nombre del usuario logeado
        public RegistrarVentas(string usuario)
        {
            InitializeComponent();

            // Nombre de usuario con el que se inició sesión
            this.usuario = usuario;
            // Advertencias
            lblSoloNumeros.Visible = false;

            // Mostramos los productos
            actualizarProductos();
        }

        // Obtener el idUsuarioComun del usuario registrado (Usuario Comun)
        private int idUsuarioComun()
        {
            // Consulta 
            string consulta1 = $"SELECT * FROM tbl_usuarios_comunes WHERE usuario='{usuario}'";

            try
            {
                // Creamos la conexion
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                //Comando
                SqlCommand cmd = new SqlCommand(consulta1, conexionConsulta); // Cambiado
                // Leer
                SqlDataReader reader = cmd.ExecuteReader(); // Cambiado

                // Leemos una vez -- Solo debe haber una coincidencia de usuario
                reader.Read();
                int id = reader.GetInt32(0); // Leemos de la primera columna - idUsuarioComun

                // Cerramos reader y la conexion
                reader.Close();
                conexionConsulta.Close();

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex);
                throw;
            }
        }

        // -- Validaciones
        // Usuario solo letras y números
        async private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                lblSoloNumeros.Visible = true; // Mensaje de error

                // Esperar 2 segundos usando Task.Delay
                await Task.Delay(2000);
                lblSoloNumeros.Visible = false;
            }
        }

        // Lógica del botón registrar venta
        private void btnSeleccionar_Click_1(object sender, EventArgs e)
        {
            if (txtCantidad.Text != "")
            {
                // Verificar si hay alguna fila seleccionada
                if (dgvProductos.SelectedRows.Count > 0 && dgvProductos.SelectedRows.Count < 2)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow selectedRow = dgvProductos.SelectedRows[0];

                    // DATOS PARA CONSULTA
                    // Obtener el valor de la primera columna correspondiente al idProducto
                    int productoID = Convert.ToInt32(selectedRow.Cells[0].Value); // 0 --> idProducto

                    // idUsuarioComun
                    int usuarioID = idUsuarioComun();

                    // Cantidad de producto
                    int cantidad = Convert.ToInt32(txtCantidad.Text);

                    // Fecha
                    DateTime fechaVenta = dateTimePickerVenta.Value;

                    // Cantidad en stock
                    int stock = Convert.ToInt32(selectedRow.Cells[3].Value); // 3 --> Cantidad en stock

                    // Verificar que cantidad a ser vendida no supere a stock
                    if (stock > cantidad)
                    {
                        // Consulta: Inserción de datos en la tabla de ventas
                        string consulta = "INSERT INTO tbl_ventas(idProducto, idUsuarioComun, cantidad, fechaVenta) VALUES (@productoID, @usuarioID, @cantidad, @fechaVenta)";
                        try
                        {
                            // Conexión
                            SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                            conexionConsulta.Open();
                            //Comando
                            SqlCommand cmd = new SqlCommand(consulta, conexionConsulta); // Cambiado
                            cmd.Parameters.AddWithValue("@productoID", productoID);
                            cmd.Parameters.AddWithValue("@usuarioID", usuarioID);
                            cmd.Parameters.AddWithValue("@cantidad", cantidad);
                            cmd.Parameters.AddWithValue("@fechaVenta", fechaVenta);
                            cmd.ExecuteNonQuery(); // Ejecutamos

                            // Cerramos conexión
                            conexionConsulta.Close();

                            // Éxito
                            // Disminuimos stock
                            disminuirStock(productoID, stock, cantidad);
                            MessageBox.Show("Venta creada exitosamente !!!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // REGISTRAR VENTA TICKET
                            // Nombre del archivo PDF
                            string pdfFileName = $"registro_venta_{fechaVenta:yyyyMMdd_HHmmss}.pdf";

                            // Obtener la ruta de la carpeta de "Mis Documentos"
                            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                            string pdfPath = Path.Combine(documentsPath, pdfFileName);

                            // Crear el documento PDF
                            Document document = new Document();
                            PdfWriter.GetInstance(document, new FileStream(pdfPath, FileMode.Create));

                            // Abrir el documento para escritura
                            document.Open();

                            // Agregar contenido al PDF
                            document.Add(new Paragraph("Registro de Venta"));
                            document.Add(new Paragraph($"ID Producto: {productoID}"));
                            document.Add(new Paragraph($"ID Usuario: {usuarioID}"));
                            document.Add(new Paragraph($"Cantidad: {cantidad}"));
                            document.Add(new Paragraph($"Fecha de Venta: {fechaVenta}"));
                            // Cerrar el documento
                            document.Close();
                            MessageBox.Show("Ticket creado exitosamente !!!");

                            // Agregar otra venta
                            actualizarProductos();
                            agregarOtraVenta();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al crear la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cantidad en stock superada ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (dgvProductos.SelectedRows.Count < 0)
                    {
                        MessageBox.Show("No hay ninguna fila seleccionada. Por favor, seleccione una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione solo una fila.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("LLene todos los campos. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Disminuir stock en tbl_productos 
        public void disminuirStock(int productoID, int stockOriginal, int cantidadDisminuir)
        {
            int stockNuevo = stockOriginal - cantidadDisminuir;

            // Consulta para disminuir el stock
            string consulta = $"UPDATE tbl_productos SET stock = '{stockNuevo}' WHERE idProducto= '{productoID}'";

            try
            {
                // Creamos la conexión
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                // Comando
                SqlCommand cmd = new SqlCommand(consulta, conexionConsulta); // Cambiado
                cmd.ExecuteNonQuery();

                // Cerramos conexión
                conexionConsulta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexión: " + ex.Message);
                throw;
            }
        }

        // Limpiar para agregar otra venta
        private void agregarOtraVenta()
        {
            // Confirmación
            DialogResult agregar = MessageBox.Show("Desea agregar otra venta", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (agregar == DialogResult.Yes)
            {
                // Limpiamos
                txtCantidad.Text = "";
            }
            else
            {
                this.Dispose(); // Cerramos el formulario
            }
        }

        private void actualizarProductos()
        {
            // Consulta para mostrar la tabla de productos en dgvProductos
            string consulta = "SELECT * FROM tbl_productos";

            // Para ordenar los datos
            DataTable tabla = new DataTable();

            try
            {
                // Creamos la conexión
                SqlConnection conexionConsulta = Conectar.crearConexion(); // Cambiado
                conexionConsulta.Open();

                // Comando
                SqlCommand cmd = new SqlCommand(consulta, conexionConsulta); // Cambiado
                // Adaptar
                SqlDataAdapter adaptar = new SqlDataAdapter(cmd); // Cambiado
                adaptar.Fill(tabla);

                // Mostramos
                dgvProductos.DataSource = tabla;
                // Cerramos conexión
                conexionConsulta.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la conexión: " + ex.Message);
                throw;
            }
        }
    }
}
