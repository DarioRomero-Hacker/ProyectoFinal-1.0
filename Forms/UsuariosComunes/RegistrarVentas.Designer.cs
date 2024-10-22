namespace ProyectoFinal_1._0.Forms.UsuariosComunes
{
    partial class RegistrarVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVentas));
            lblMensaje = new Label();
            label1 = new Label();
            panelSeleccionProductos = new Panel();
            lblSoloNumeros = new Label();
            dateTimePickerVenta = new DateTimePicker();
            label3 = new Label();
            txtCantidad = new TextBox();
            label2 = new Label();
            btnRegistrar = new Button();
            dgvProductos = new DataGridView();
            panelSeleccionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(3, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(218, 43);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Registrar Ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(86, 42, 20);
            label1.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(25, 130);
            label1.Name = "label1";
            label1.Size = new Size(305, 43);
            label1.TabIndex = 0;
            label1.Text = "Seleccione un producto:";
            // 
            // panelSeleccionProductos
            // 
            panelSeleccionProductos.BackColor = Color.FromArgb(86, 42, 20);
            panelSeleccionProductos.Controls.Add(lblSoloNumeros);
            panelSeleccionProductos.Controls.Add(dateTimePickerVenta);
            panelSeleccionProductos.Controls.Add(label3);
            panelSeleccionProductos.Controls.Add(txtCantidad);
            panelSeleccionProductos.Controls.Add(label2);
            panelSeleccionProductos.Controls.Add(btnRegistrar);
            panelSeleccionProductos.Controls.Add(lblMensaje);
            panelSeleccionProductos.Controls.Add(dgvProductos);
            panelSeleccionProductos.Controls.Add(label1);
            panelSeleccionProductos.Location = new Point(45, 37);
            panelSeleccionProductos.Name = "panelSeleccionProductos";
            panelSeleccionProductos.Size = new Size(861, 482);
            panelSeleccionProductos.TabIndex = 4;
            // 
            // lblSoloNumeros
            // 
            lblSoloNumeros.AutoSize = true;
            lblSoloNumeros.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSoloNumeros.ForeColor = Color.Red;
            lblSoloNumeros.Location = new Point(138, 101);
            lblSoloNumeros.Margin = new Padding(3);
            lblSoloNumeros.Name = "lblSoloNumeros";
            lblSoloNumeros.Size = new Size(120, 28);
            lblSoloNumeros.TabIndex = 35;
            lblSoloNumeros.Text = "Solo numeros";
            // 
            // dateTimePickerVenta
            // 
            dateTimePickerVenta.Location = new Point(470, 67);
            dateTimePickerVenta.Name = "dateTimePickerVenta";
            dateTimePickerVenta.Size = new Size(254, 23);
            dateTimePickerVenta.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(86, 42, 20);
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(392, 67);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 23;
            label3.Text = "Fecha:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(138, 72);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(177, 23);
            txtCantidad.TabIndex = 22;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(86, 42, 20);
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(91, 28);
            label2.TabIndex = 21;
            label2.Text = "Cantidad:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(86, 42, 20);
            btnRegistrar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnRegistrar.FlatAppearance.BorderSize = 2;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(623, 289);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(201, 46);
            btnRegistrar.TabIndex = 20;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnSeleccionar_Click_1;
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(31, 20, 16);
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Location = new Point(25, 176);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(574, 279);
            dgvProductos.TabIndex = 0;
            // 
            // RegistrarVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(946, 562);
            Controls.Add(panelSeleccionProductos);
            Name = "RegistrarVentas";
            Text = "RegistrarVentas";
            panelSeleccionProductos.ResumeLayout(false);
            panelSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblMensaje;
        private Label label1;
        private Panel panelSeleccionProductos;
        private DataGridView dgvProductos;
        private Button btnRegistrar;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePickerVenta;
        private Label lblSoloNumeros;
    }
}