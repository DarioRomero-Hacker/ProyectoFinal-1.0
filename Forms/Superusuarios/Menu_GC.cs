using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; 

namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    public partial class Menu_GC : Form
    {
        private string ultimaConsulta;

        public Menu_GC()
        {
            InitializeComponent();
        }

        private void btn_showClientes_Click(object sender, EventArgs e)
        {
            grp_filtro.Visible = true;
        }

        private void cmb_Filtros_TextChanged(object sender, EventArgs e)
        {
            switch (cmb_Filtros.Text)
            {
                case "Por nombre(A-Z)":
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
                    break;
                case "Por nombre(Z-A)":
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
                    break;
                case "Por apellido(A-Z)":
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
                    break;
                case "Por apellido(Z-A)":
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
                    break;
                case "Por direccion":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese Dirección: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case "Por Id":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese ID: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case "Por telefono":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese Teléfono: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                default:
                    txtFiltro.Text = "";
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;
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
                case "Por nombre(A-Z)":
                    consulta = "SELECT * FROM tbl_clientes ORDER BY nombre ASC";
                    break;
                case "Por nombre(Z-A)":
                    consulta = "SELECT * FROM tbl_clientes ORDER BY nombre DESC";
                    break;
                case "Por apellido(A-Z)":
                    consulta = "SELECT * FROM tbl_clientes ORDER BY apellido ASC";
                    break;
                case "Por apellido(Z-A)":
                    consulta = "SELECT * FROM tbl_clientes ORDER BY apellido DESC";
                    break;
                case "Por direccion":
                    if (string.IsNullOrEmpty(txtFiltro.Text))
                    {
                        MessageBox.Show("Debe ingresar una dirección para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    consulta = $"SELECT * FROM tbl_clientes WHERE direccion LIKE '%{txtFiltro.Text}%'";
                    break;
                case "Por Id":
                    if (!int.TryParse(txtFiltro.Text, out int idCliente))
                    {
                        MessageBox.Show("Debe ingresar un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    consulta = $"SELECT * FROM tbl_clientes WHERE idCliente = {idCliente}";
                    break;
                case "Por telefono":
                    if (string.IsNullOrEmpty(txtFiltro.Text))
                    {
                        MessageBox.Show("Debe ingresar un teléfono para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    consulta = $"SELECT * FROM tbl_clientes WHERE telefono LIKE '%{txtFiltro.Text}%'";
                    break;
                default:
                    consulta = "SELECT * FROM tbl_clientes";
                    break;
            }

            hacerConsulta(consulta, "No se encontraron clientes.");
        }

        private void hacerConsulta(string consulta, string mensajeError)
        {
            dgvClientes.DataSource = null;
            DataTable clientes = new DataTable();
            using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
            {
                try
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Cambiado a SqlDataAdapter
                    adapter.Fill(clientes);

                    if (clientes.Rows.Count >= 1)
                    {
                        dgvClientes.DataSource = clientes;
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
            }
        }

        private void EliminarDatos(int RowIndex)
        {
            if (RowIndex >= 0 && dgvClientes.Rows.Count > 0)
            {
                int idCliente = Convert.ToInt32(dgvClientes.Rows[RowIndex].Cells["idCliente"].Value);

                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    EliminarDatoPorId(idCliente);
                }
            }
        }

        private void EliminarDatoPorId(int idCliente)
        {
            try
            {
                string consulta = $"DELETE FROM tbl_clientes WHERE idCliente = {idCliente}";

                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hacerConsulta(ultimaConsulta, "No se encontraron clientes.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.Rows.Count > 0)
            {
                if (e.ColumnIndex == dgvClientes.Columns["Actualizar"].Index)
                {
                    ActualizarRegistro(e.RowIndex);
                }
                else if (e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index)
                {
                    EliminarDatos(e.RowIndex);
                }
            }
        }

        private void ActualizarRegistro(int RowIndex)
        {
            if (RowIndex >= 0 && dgvClientes.Rows.Count > 0)
            {
                DataGridViewRow filaSeleccionada = dgvClientes.Rows[RowIndex];

                int id = Convert.ToInt32(filaSeleccionada.Cells["idCliente"].Value);
                string nombre = filaSeleccionada.Cells["nombre"].Value.ToString();
                string apellido = filaSeleccionada.Cells["apellido"].Value.ToString();
                string direccion = filaSeleccionada.Cells["direccion"].Value.ToString();
                string telefono = filaSeleccionada.Cells["telefono"].Value.ToString();

                txt_Nombre.Text = nombre;
                txt_apellido.Text = apellido;
                txt_direccion.Text = direccion;
                txt_telefono.Text = telefono;
                // Opcional: asignar el id a una variable de clase si se necesita para la actualización
            }
        }

        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoNombre = txt_Nombre.Text;
                string nuevoApellido = txt_apellido.Text;
                string nuevaDireccion = txt_direccion.Text;
                string nuevoTelefono = txt_telefono.Text;
                int id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["idCliente"].Value);

                string consulta = $"UPDATE tbl_clientes SET nombre = @nombre, apellido = @apellido, direccion = @direccion, telefono = @telefono WHERE idCliente = @idCliente";

                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    cmd.Parameters.AddWithValue("@nombre", nuevoNombre);
                    cmd.Parameters.AddWithValue("@apellido", nuevoApellido);
                    cmd.Parameters.AddWithValue("@direccion", nuevaDireccion);
                    cmd.Parameters.AddWithValue("@telefono", nuevoTelefono);
                    cmd.Parameters.AddWithValue("@idCliente", id);

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        hacerConsulta(ultimaConsulta, "No se encontraron clientes.");
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
            Registrar_Cliente registrar_Cliente = new Registrar_Cliente();
            registrar_Cliente.ShowDialog();

            hacerConsulta(ultimaConsulta, "no se encontraron clientes");
        }
    }
}
