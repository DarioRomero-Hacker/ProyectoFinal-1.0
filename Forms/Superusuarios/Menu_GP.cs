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

namespace ProyectoFinal_1._0.Gestion_Productos
{
    public partial class Menu_GP : Form
    {
        //campos de clase
        string? consulta;
        private string? ultimaConsulta;
        int? id;
        ///------------------------
        public Menu_GP()
        {
            InitializeComponent();
        }

        private void btn_ShowProducts_Click(object sender, EventArgs e)
        {
            grp_filtro.Visible = true;

        }

        //evento para ocultar/mostrar estos controles cuando se requiera
        private void cmb_Filtros_TextChanged(object sender, EventArgs e)
        {
            switch (cmb_Filtros.Text)
            {
                case "Por nombre":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese Nombre: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case "Por ID":
                    txtFiltro.Text = "";
                    lbl_filtro.Text = "Ingrese ID: ";
                    lbl_filtro.Visible = true;
                    txtFiltro.Visible = true;
                    break;
                case "Menor precio":
                    txtFiltro.Text = "";
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;

                    break;
                case "Mayor precio":
                    txtFiltro.Text = "";
                    txtFiltro.Visible = false;
                    lbl_filtro.Visible = false;

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

        //logica del boton aplicar filtro
        //INICIO BLOQUE DE CODIGO PARA CREAR LA CONSULTA RESPECTIVA SEGUN EL FILTRO SELECCIONDO
        private void bnt_AplicarFiltro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmb_Filtros.Text))
            {
                MessageBox.Show("Debe seleccionar un filtro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmb_Filtros.Text == "Por nombre")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre para filtrar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string consulta = $"SELECT idProducto, producto, precio, stock FROM tbl_productos WHERE producto = '{txtFiltro.Text}';";
                    hacerConsulta(consulta, "El producto especificado no existe en la base de datos.");
                }
            }
            else if (cmb_Filtros.Text == "Menor precio")
            {
                consulta = "SELECT idProducto, producto, precio, stock FROM tbl_productos ORDER BY precio ASC;";
                hacerConsulta(consulta, "No se encontraron productos.");
            }
            else if (cmb_Filtros.Text == "Mayor precio")
            {
                consulta = "SELECT idProducto, producto, precio, stock FROM tbl_productos ORDER BY precio DESC;";
                hacerConsulta(consulta, "No se encontraron productos.");
            }
            else if (cmb_Filtros.Text == "Precio")
            {
                // Implementar lógica de filtro por precio si es necesario
            }
            else if (cmb_Filtros.Text == "Por ID")
            {
                try
                {
                    if (int.TryParse(txtFiltro.Text, out int idProducto))
                    {
                        consulta = $"SELECT idProducto, producto, precio, stock FROM tbl_productos WHERE idProducto = {idProducto}";
                        hacerConsulta(consulta, "El producto con el ID especificado no existe en la base de datos");
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFiltro.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (cmb_Filtros.Text == "Sin filtro(Todos)")
            {
                consulta = "SELECT * FROM tbl_productos;";
                hacerConsulta(consulta, "No se encontraron productos.");
            }
        }//FIN BLOQUE DE CODIGO PARA GENERAR CONSULTAS

        //METODO QUE REALIZA LA CONSULTA Y CONEXION Y RECIBE LA CONSULTA COMO PAREMETRO YA QUE ESTA SE CREA EN EL EVENTO ANTERIOR
        private void hacerConsulta(string consulta, string mensajeError)
        {
            dgvProductos.DataSource = null;// limpia el datagrid cada vez que se hace una consulta nueva
            DataTable productos = new DataTable();
            SqlConnection conexion = Conectar.crearConexion(); // Cambiado a SqlConnection

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                SqlDataAdapter adapter = new SqlDataAdapter(cmd); // Cambiado a SqlDataAdapter
                adapter.Fill(productos);

                if (productos.Rows.Count >= 1)
                {
                    dgvProductos.DataSource = productos;
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
        }//FIN BLOQUE DE CODIGO QUE HACE LA CONSULTA

        //METODOS PARA LLEVAR A CABO LA ELIMINACION DE PRODUCTOS
        private void EliminarDatos(int RowIndex)//este metodo maneja la intereccion del usuario
        {
            //INT ROW INDEX REPRESENTA EL INDICE EN EL QUE SE HIZO CLICK; EL VALOR DE ROWINDEX SE PASA DENTRO DEL EVENTOCELLCLICK ATRAVES DEL ARGUMENTO 'e'
            int idProducto = int.Parse(dgvProductos.Rows[RowIndex].Cells["idProducto"].Value.ToString()!);

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                EliminarProductoPorId(idProducto);
            }
        }

        private void EliminarProductoPorId(int idProducto)//este metodo maneja la interaccion del code con la db 
        {
            try
            {
                string consulta = $"DELETE FROM tbl_productos WHERE idProducto = {idProducto};";

                SqlConnection conexion = Conectar.crearConexion(); // Cambiado a SqlConnection
                conexion.Open();

                SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Actualizar el DataGridView con la última consulta utilizada para obtener los datos
                    hacerConsulta(ultimaConsulta!, "No se encontraron productos.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//FINAL BLOQUE DE CODIGO DE ELIMINACION DE PRODUCTO

        //METODO PARA ACTUALIZAR UN PRODUCTO
        private void ActualizarProducto(int RowIndex)
        {
            DataGridViewRow filaSeleccionada = dgvProductos.Rows[RowIndex];

            txt_precio.Text = filaSeleccionada.Cells["precio"].Value.ToString();
            txt_Producto.Text = filaSeleccionada.Cells["producto"].Value.ToString();
            txt_stock.Text = filaSeleccionada.Cells["stock"].Value.ToString();
            id = Convert.ToInt32(filaSeleccionada.Cells["idProducto"].Value);
        }

        //EVENTO CELLCLICK SOLO HACEMOS USO DE UNA REFERENCIA Y UTILIZAMOS LOS INDICES EN EL QUE SE HIZO CLICK Y LO COMPARAMOS CON EL DE LA COLUMNA ACTUALIZAR/ELIMINAR
        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una fila válida
            if (e.RowIndex >= 0)//e.rowindex almacena el indice donde el usuario ha hecho click
            {
                // este indice se compara con el indice verdadero de cada columna el cual obtenemos de la propiedad .index
                if (e.ColumnIndex == dgvProductos.Columns["Actualizar"].Index)
                {
                    // llamamos al metodo para la funcion de editar datos
                    ActualizarProducto(e.RowIndex);
                }
                else if (e.ColumnIndex == dgvProductos.Columns["Eliminar"].Index)
                {
                    // LLAMAMOS AL METODO DE ELIMINAR
                    EliminarDatos(e.RowIndex);
                }
            }
        }

        //EVENTO CLICK GUARDAR CAMBIOS
        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                string nuevoProducto = txt_Producto.Text;
                decimal nuevoPrecio = decimal.Parse(txt_precio.Text);
                int nuevoStock = int.Parse(txt_stock.Text);

                string consulta = $"UPDATE tbl_productos SET producto = '{nuevoProducto}', precio = {nuevoPrecio}, stock = {nuevoStock} WHERE idProducto = {id};";

                // Ejecutar la consulta de actualización
                SqlConnection conexion = Conectar.crearConexion(); // Cambiado a SqlConnection
                conexion.Open();

                SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Actualizar el DataGridView si es necesario
                    hacerConsulta(ultimaConsulta!, "No se encontraron productos."); // POR MODIFICA MENSAJE DE ERROR

                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //boton para ingresar productos
        private void btn_IngresarProducts_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario AgregarProductos
            AgregarProductos formularioAgregar = new AgregarProductos();

            //se utiliza showdialog para que este form no se siga ejecutando hasta que el formulario se cierre
            formularioAgregar.ShowDialog();

            // Después de cerrar el formulario de agregar, actualizar el DataGridView
            hacerConsulta(ultimaConsulta!, "No se encontraron productos.");
        }

        //inicio validacion
        //solo letras
        private void txt_Producto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("No se permiten número o otros caracteres extraños", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_Producto_KeyPress_decimales(object sender, KeyPressEventArgs e)
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

        private void txtEntero_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8) // 8 == tecla borrar
            {
                MessageBox.Show("Solo ingrese números enteros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        //validaciones fin
    }
}
