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
    public partial class Menu_GU : Form
    {
        private string ultimaConsulta;

        public Menu_GU()
        {
            InitializeComponent();
        }

        private void btn_btnShowUsers_Click(object sender, EventArgs e)
        {
            grp_filtro.Visible = true;
        }

        private void cmb_Filtros_TextChanged(object sender, EventArgs e)
        {
            switch (cmb_Filtros.Text)
            {
                case "Por nombre de usuario":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese Usuario: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    cmb_tipoUser.Visible = false;
                    break;
                case "Por tipo de usuario":
                    cmb_tipoUser.Visible = true;
                    break;
                case "Por ID":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese ID: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    cmb_tipoUser.Visible = false;
                    break;
                case "Sin filtro(Todos)":
                    txtFiltro.Text = "";
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void bnt_AplicarFiltro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Filtros.Text))
            {
                MessageBox.Show("Debe seleccionar un filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filtro = cmb_Filtros.Text;
            string consulta = "";

            switch (filtro)
            {
                case "Por nombre de usuario":
                    if (string.IsNullOrEmpty(txtFiltro.Text))
                    {
                        MessageBox.Show("Debe ingresar un nombre de usuario para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    consulta = $"SELECT * FROM tbl_usuarios WHERE usuario LIKE '%{txtFiltro.Text}%'";
                    break;
                case "Por tipo de usuario":
                    if (cmb_tipoUser.SelectedIndex == -1)
                    {
                        MessageBox.Show("Debe seleccionar un tipo de usuario para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string tipoUsuario = cmb_tipoUser.Text;
                    consulta = $"SELECT * FROM tbl_usuarios WHERE tipo_usuario = '{tipoUsuario}'";
                    break;
                case "Por ID":
                    if (!int.TryParse(txtFiltro.Text, out int idUser))
                    {
                        MessageBox.Show("Debe ingresar un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    consulta = $"SELECT * FROM tbl_usuarios WHERE id = {idUser}";
                    break;
                case "Sin filtro(Todos)":
                    consulta = "SELECT * FROM tbl_usuarios";
                    break;
                default:
                    break;
            }

            hacerConsulta(consulta, "No se encontraron usuarios.");
        }

        private void hacerConsulta(string consulta, string mensajeError)
        {
            dgvUsuarios.DataSource = null;
            DataTable usuarios = new DataTable();
            SqlConnection conexion = Conectar.crearConexion(); // Cambiado a SqlConnection

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Cambiado a SqlDataAdapter
                adapter.Fill(usuarios);

                if (usuarios.Rows.Count >= 1)
                {
                    dgvUsuarios.DataSource = usuarios;
                    ultimaConsulta = consulta;
                }
                else
                {
                    MessageBox.Show(mensajeError, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        private void EliminarDatos(int RowIndex)
        {
            if (RowIndex >= 0 && dgvUsuarios.Rows.Count > 0)
            {
                int iduser = Convert.ToInt32(dgvUsuarios.Rows[RowIndex].Cells["id"].Value);

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    EliminarDatoPorId(iduser);
                }
            }
        }

        private void EliminarDatoPorId(int iduser)
        {
            try
            {
                string consulta = $"DELETE FROM tbl_usuarios WHERE id = {iduser}";

                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hacerConsulta(ultimaConsulta, "No se encontraron usuarios.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios.Rows.Count > 0)
            {
                if (e.ColumnIndex == dgvUsuarios.Columns["Actualizar"].Index)
                {
                    ActualizarRegistro(e.RowIndex);
                }
                else if (e.ColumnIndex == dgvUsuarios.Columns["Eliminar"].Index)
                {
                    EliminarDatos(e.RowIndex);
                }
            }
        }

        private void ActualizarRegistro(int RowIndex)
        {
            if (RowIndex >= 0 && dgvUsuarios.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[RowIndex];

                int id = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                string usuario = filaSeleccionada.Cells["usuario"].Value.ToString();
                string clave = filaSeleccionada.Cells["clave"].Value.ToString();

                txt_Usuario.Text = usuario;
                txt_clave.Text = clave;
                // Opcional: asignar el id a una variable de clase si se necesita para la actualización
            }
        }

        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoUsuario = txt_Usuario.Text;
                string nuevaClave = txt_clave.Text;
                int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["id"].Value);

                // Encriptar la nueva clave utilizando la clase existente
                string claveEncriptada = Encriptar.GetSHA256(nuevaClave);

                string consulta = $"UPDATE tbl_usuarios SET usuario = @usuario, clave = @clave WHERE id = @id";

                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    cmd.Parameters.AddWithValue("@usuario", nuevoUsuario);
                    cmd.Parameters.AddWithValue("@clave", claveEncriptada);
                    cmd.Parameters.AddWithValue("@id", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hacerConsulta(ultimaConsulta, "No se encontraron usuarios.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_IngresarUsuario_Click(object sender, EventArgs e)
        {
            //accion registrar usuario llamamos al formulario singup
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
        }
    }
}
