using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Data.SqlClient; 

namespace ProyectoFinal_1._0
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            // Enfocamos en el primer control
            this.BeginInvoke((Action)delegate {
                txtUsuario.Focus();
            });

            // Desactivamos los label de advertencia
            lblLetrasNumeros.Visible = false;
            lblClavesNoCoinciden1.Visible = false;
            lblClavesNoCoinciden2.Visible = false;
            lblExiste.Visible = false;
        }

        // -- Validaciones
        // Usuario solo letras y números
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8) // Permitir letras y números, tecla de borrar
            {
                e.Handled = true;
                lblLetrasNumeros.Visible = true; // Mensaje de error
                Task.Delay(2000).ContinueWith(_ =>
                {
                    lblLetrasNumeros.Visible = false;
                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        // Logica para crear cuenta
        // Logica para crear cuenta
        async private void btnSingUp_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "" && txtClaveConfirmar.Text != "" && cmbTiposUsuarios.Text != "")
            {
                if (txtClave.Text == txtClaveConfirmar.Text)
                {
                    // Encriptar contraseña
                    string hashedPassword = Encriptar.GetSHA256(txtClave.Text);
                    // Datos para la consulta de insercion de nuevo usuario
                    string usuario = txtUsuario.Text;
                    string clave = hashedPassword;
                    string tipoUsuario = cmbTiposUsuarios.Text;

                    // Consulta: Insercion de datos en la tabla correspondiente
                    string consulta = "INSERT INTO tbl_usuarios(usuario, clave, tipo_usuario) VALUES (@usuario, @clave, @tipoUsuario)";

                    // Consulta: Comprobamos si el usuario ya existe en la base de datos
                    string consultaExiste = "SELECT COUNT(*) FROM tbl_usuarios WHERE usuario=@usuario";

                    try
                    {
                        // Conexion
                        using (SqlConnection conexionConsulta = Conectar.crearConexion()) // Cambiado a SqlConnection
                        {
                            conexionConsulta.Open();

                            // Comprobar existencia de usuario
                            using (SqlCommand cmdExistencia = new SqlCommand(consultaExiste, conexionConsulta)) // Cambiado a SqlCommand
                            {
                                cmdExistencia.Parameters.AddWithValue("@usuario", usuario); // Asignar parámetro
                                int count = Convert.ToInt32(cmdExistencia.ExecuteScalar());

                                if (count > 0)
                                {
                                    MessageBox.Show("El usuario ya existe", "Existe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lblExiste.Visible = true;
                                    await Task.Delay(2000);
                                    lblExiste.Visible = false;
                                }
                                else
                                {
                                    // Insertar nuevo usuario
                                    using (SqlCommand cmdInsertar = new SqlCommand(consulta, conexionConsulta)) // Cambiado a SqlCommand
                                    {
                                        cmdInsertar.Parameters.AddWithValue("@usuario", usuario); // Asignar parámetros
                                        cmdInsertar.Parameters.AddWithValue("@clave", clave);
                                        cmdInsertar.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
                                        cmdInsertar.ExecuteNonQuery();
                                    }
                                    MessageBox.Show("Usuario creado exitosamente !!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    agregarOtroUsuario();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al crear la conexion: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Las claves no coinciden
                    MessageBox.Show("Las claves no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    lblClavesNoCoinciden1.Visible = true;
                    lblClavesNoCoinciden2.Visible = true;
                    txtClave.Focus();
                    await Task.Delay(5000);
                    lblClavesNoCoinciden1.Visible = false;
                    lblClavesNoCoinciden2.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Limpiar para agregar otro usuario
        private void agregarOtroUsuario()
        {
            DialogResult agregar = MessageBox.Show("Desea agregar otro usuario", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (agregar == DialogResult.Yes)
            {
                // Limpiamos campos
                txtUsuario.Text = "";
                txtClave.Text = "";
                txtClaveConfirmar.Text = "";
                cmbTiposUsuarios.Text = "";
            }
            else
            {
                this.Dispose(); // Cerramos el formulario
            }
        }

        // Para volver a Login
        private void lklCrearCuenta_Click(object sender, EventArgs e)
        {
            DialogResult volver = MessageBox.Show("Desea volver", "Volver a login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (volver == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
