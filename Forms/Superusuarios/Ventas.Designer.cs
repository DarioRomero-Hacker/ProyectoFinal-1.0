namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            panelSeleccionProductos = new Panel();
            dateTimePickerVenta = new DateTimePicker();
            label3 = new Label();
            btnVentasSemanales = new Button();
            btnVentasMensuales = new Button();
            btnVentasDia = new Button();
            label2 = new Label();
            lblMensaje = new Label();
            dgvVentas = new DataGridView();
            btnGenerarReporte = new Button();
            panelSeleccionProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // panelSeleccionProductos
            // 
            panelSeleccionProductos.BackColor = Color.FromArgb(86, 42, 20);
            panelSeleccionProductos.Controls.Add(btnGenerarReporte);
            panelSeleccionProductos.Controls.Add(dateTimePickerVenta);
            panelSeleccionProductos.Controls.Add(label3);
            panelSeleccionProductos.Controls.Add(btnVentasSemanales);
            panelSeleccionProductos.Controls.Add(btnVentasMensuales);
            panelSeleccionProductos.Controls.Add(btnVentasDia);
            panelSeleccionProductos.Controls.Add(label2);
            panelSeleccionProductos.Controls.Add(lblMensaje);
            panelSeleccionProductos.Controls.Add(dgvVentas);
            panelSeleccionProductos.Location = new Point(59, 40);
            panelSeleccionProductos.Name = "panelSeleccionProductos";
            panelSeleccionProductos.Size = new Size(853, 515);
            panelSeleccionProductos.TabIndex = 6;
            // 
            // dateTimePickerVenta
            // 
            dateTimePickerVenta.Location = new Point(400, 46);
            dateTimePickerVenta.Name = "dateTimePickerVenta";
            dateTimePickerVenta.Size = new Size(254, 23);
            dateTimePickerVenta.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(86, 42, 20);
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(322, 46);
            label3.Name = "label3";
            label3.Size = new Size(61, 28);
            label3.TabIndex = 32;
            label3.Text = "Fecha:";
            // 
            // btnVentasSemanales
            // 
            btnVentasSemanales.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasSemanales.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasSemanales.FlatAppearance.BorderSize = 2;
            btnVentasSemanales.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasSemanales.FlatStyle = FlatStyle.Flat;
            btnVentasSemanales.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasSemanales.ForeColor = Color.White;
            btnVentasSemanales.Location = new Point(255, 116);
            btnVentasSemanales.Name = "btnVentasSemanales";
            btnVentasSemanales.Size = new Size(201, 43);
            btnVentasSemanales.TabIndex = 31;
            btnVentasSemanales.Text = "Ventas Semanales";
            btnVentasSemanales.UseVisualStyleBackColor = false;
            btnVentasSemanales.Click += btnVentasSemanales_Click;
            // 
            // btnVentasMensuales
            // 
            btnVentasMensuales.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasMensuales.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasMensuales.FlatAppearance.BorderSize = 2;
            btnVentasMensuales.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasMensuales.FlatStyle = FlatStyle.Flat;
            btnVentasMensuales.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasMensuales.ForeColor = Color.White;
            btnVentasMensuales.Location = new Point(484, 116);
            btnVentasMensuales.Name = "btnVentasMensuales";
            btnVentasMensuales.Size = new Size(201, 42);
            btnVentasMensuales.TabIndex = 30;
            btnVentasMensuales.Text = "Ventas Mensuales";
            btnVentasMensuales.UseVisualStyleBackColor = false;
            btnVentasMensuales.Click += btnVentasMensuales_Click;
            // 
            // btnVentasDia
            // 
            btnVentasDia.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasDia.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasDia.FlatAppearance.BorderSize = 2;
            btnVentasDia.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasDia.FlatStyle = FlatStyle.Flat;
            btnVentasDia.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasDia.ForeColor = Color.White;
            btnVentasDia.Location = new Point(25, 116);
            btnVentasDia.Name = "btnVentasDia";
            btnVentasDia.Size = new Size(201, 43);
            btnVentasDia.TabIndex = 29;
            btnVentasDia.Text = "Ventas Diarias";
            btnVentasDia.UseVisualStyleBackColor = false;
            btnVentasDia.Click += btnVentasDia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(86, 42, 20);
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(191, 28);
            label2.TabIndex = 21;
            label2.Text = "Seleccione una opcion:";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(3, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(106, 43);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Ventas:";
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(31, 20, 16);
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.Location = new Point(25, 175);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.Size = new Size(795, 259);
            dgvVentas.TabIndex = 0;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(86, 42, 20);
            btnGenerarReporte.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnGenerarReporte.FlatAppearance.BorderSize = 2;
            btnGenerarReporte.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(322, 451);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(201, 43);
            btnGenerarReporte.TabIndex = 34;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(943, 578);
            Controls.Add(panelSeleccionProductos);
            Name = "Ventas";
            Text = "VentasDiarias";
            panelSeleccionProductos.ResumeLayout(false);
            panelSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSeleccionProductos;
        private Label label2;
        private Label lblMensaje;
        private DataGridView dgvVentas;
        private Button btnVentasSemanales;
        private Button btnVentasMensuales;
        private Button btnVentasDia;
        private DateTimePicker dateTimePickerVenta;
        private Label label3;
        private Button btnGenerarReporte;
    }
}