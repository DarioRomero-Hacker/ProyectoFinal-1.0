using System;
using Microsoft.Data.SqlClient;
using ProyectoFinal_1._0.Forms;
using ProyectoFinal_1._0.Forms.UsuariosComunes;

namespace ProyectoFinal_1._0
{
    public partial class Login : Form
    {
        // Definición del usuario local
        private const string LocalSuperUser = "super"; // Nombre de usuario
        private const string LocalSuperUserPassword = "2024"; // Contraseña

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // Enfocamos en el primer control
            this.BeginInvoke((Action)delegate
            {
                txtUsuario.Focus();
            });

            // Desactivamos los label de advertencia
            lblUsuarioInvalido.Visible = false;
            lblClaveIncorrecta.Visible = false;
            lblLetrasNumeros.Visible = false;
        }

        // -- BOTON btnLogin
        // Color del boton cuando el cursor esta sobre el
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.ForeColor = System.Drawing.Color.Black;
        }

        // Color del boton cuando el cursor no esta sobre el
        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = System.Drawing.Color.White;
        }

        // Limpiar controles
        private void limpiarControles()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
        }

        // Crear cuenta lklCrearCuenta
        private void lklCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            limpiarControles();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        // -- Validaciones
        async private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
                lblLetrasNumeros.Visible = true; // Mensaje de error

                // Esperar 2 segundos usando Task.Delay
                await Task.Delay(2000);
                lblLetrasNumeros.Visible = false;
            }
        }

        // Para hacer una consulta: averiguar si existe un usuario en la base de datos
        async public void consultaUsuario(string usuario, string clave)
        {
            // Verificación del usuario local
            if (usuario == LocalSuperUser && clave == Encriptar.GetSHA256(LocalSuperUserPassword))
            {
                // Usuario local autenticado
                MessageBox.Show($"Inicio de sesión exitoso como Superusuario !!!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Superusuario su = new Superusuario(usuario);
                su.Show();
                this.Hide(); // Ocultar el formulario de login
                return;
            }

            try
            {
                using (SqlConnection conexionConsulta = Conectar.crearConexion())
                {
                    conexionConsulta.Open();

                    // Comando parametrizado para evitar inyecciones SQL
                    string consulta = @"
                        SELECT tipo_usuario 
                        FROM tbl_usuarios 
                        WHERE usuario = @usuario AND clave = @clave";

                    using (SqlCommand cmd = new SqlCommand(consulta, conexionConsulta))
                    {
                        // Asignar parámetros
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@clave", clave);

                        // Obtener tipo de usuario
                        string tipoUsuario = cmd.ExecuteScalar()?.ToString();

                        if (!string.IsNullOrEmpty(tipoUsuario))
                        {
                            MessageBox.Show($"Inicio de sesión exitoso como {tipoUsuario} !!!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            // Redirigir al formulario correspondiente según el tipo de usuario
                            switch (tipoUsuario)
                            {
                                case "Superusuario":
                                    Superusuario su = new Superusuario(usuario);
                                    su.Show();
                                    this.Hide(); // Ocultar el formulario de login
                                    break;
                                case "Administrador":
                                    Administradores adminForm = new Administradores(usuario);
                                    adminForm.Show();
                                    this.Hide(); // Ocultar el formulario de login
                                    break;
                                case "Usuario Comun":
                                    UsuariosComunes usuarioComunForm = new UsuariosComunes(usuario);
                                    usuarioComunForm.Show();
                                    this.Hide(); // Ocultar el formulario de login
                                    break;
                                default:
                                    MessageBox.Show("Tipo de usuario no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            // Si no se encontró el usuario, mostrar error
                            MessageBox.Show("Inicio de sesión fallido !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lblClaveIncorrecta.Visible = true;
                            lblUsuarioInvalido.Visible = true;
                            await Task.Delay(2000);
                            lblClaveIncorrecta.Visible = false;
                            lblUsuarioInvalido.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Lógica del botón btnLogin
        async private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtClave.Text != "")
            {
                // Encriptar contraseña
                string usuario = txtUsuario.Text;
                string hashedPassword = Encriptar.GetSHA256(txtClave.Text); // Encriptar la contraseña usando SHA256

                // Llamar a la función que verifica el usuario
                consultaUsuario(usuario, hashedPassword);
            }
            else
            {
                MessageBox.Show("Llene todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para obtener el tipo de usuario (no se está usando en este contexto, se puede eliminar)
        private string obtenerTipoUsuario(string usuario)
        {
            string tipoUsuario = "";
            try
            {
                using (SqlConnection conexion = Conectar.crearConexion())
                {
                    conexion.Open();
                    string consulta = $"SELECT tipo_usuario FROM tbl_usuarios WHERE usuario=@usuario";
                    using (SqlCommand cmd = new SqlCommand(consulta, conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        tipoUsuario = cmd.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el tipo de usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return tipoUsuario;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Opcional: Preguntar al usuario si realmente desea salir
            DialogResult confirmarSalida = MessageBox.Show("¿Está seguro de que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmarSalida == DialogResult.Yes)
            {
                Application.Exit(); // Cierra todo el programa
            }

        }
    }
}
