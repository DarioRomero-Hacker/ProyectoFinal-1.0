using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Cambiado de MySql.Data.MySqlClient a Microsoft.Data.SqlClient

namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    public partial class Registrar_Cliente : Form
    {
        public Registrar_Cliente()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            // Construir la consulta SQL para insertar el nuevo cliente
            string consulta = $"INSERT INTO tbl_clientes (nombre, apellido, direccion, telefono) VALUES (@nombre, @apellido, @direccion, @telefono);";

            // Ejecutar la consulta para insertar el nuevo cliente
            try
            {
                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion)) // Cambiado a SqlCommand
                    {
                        // Asignar parámetros para evitar inyección SQL
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@apellido", apellido);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cerrar el formulario después de agregar el cliente
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //inicio validacion
        //solo letras
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números o otros caracteres extraños", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtApellido_KeyPress_decimales(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                MessageBox.Show("Solo ingrese números o un punto decimal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else if (e.KeyChar == 46) // 46 = punto en ascii code
            {
                if (textBox.Text.IndexOf('.') > -1)
                {
                    MessageBox.Show("Solo se permite un punto decimal", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;
                }
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 == tecla borrar
            {
                MessageBox.Show("Solo ingrese números enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
