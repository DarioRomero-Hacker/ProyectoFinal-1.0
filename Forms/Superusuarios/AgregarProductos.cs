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
    public partial class AgregarProductos : Form
    {
        public AgregarProductos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario
            string producto = txtProducto.Text;
            decimal precio = decimal.Parse(txtPrecio.Text);
            int stock = int.Parse(txtStock.Text);

            // Construir la consulta SQL para insertar el nuevo producto
            string consulta = $"INSERT INTO tbl_productos (producto, precio, stock) VALUES ('{producto}', {precio}, {stock});";

            // Ejecutar la consulta para insertar el nuevo producto
            try
            {
                using (SqlConnection conexion = Conectar.crearConexion()) // Cambiado a SqlConnection
                {
                    conexion.Open();
                    SqlCommand cmd = new SqlCommand(consulta, conexion); // Cambiado a SqlCommand
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Cerrar el formulario después de agregar el producto
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // inicio validacion
        // solo letras
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

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        // validaciones fin
    }
}
