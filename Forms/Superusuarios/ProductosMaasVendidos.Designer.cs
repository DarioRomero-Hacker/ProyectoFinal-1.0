namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class ProductosMaasVendidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosMaasVendidos));
            panelSeleccionProductos = new Panel();
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
            panelSeleccionProductos.Controls.Add(lblMensaje);
            panelSeleccionProductos.Controls.Add(dgvVentas);
            panelSeleccionProductos.Location = new Point(54, 32);
            panelSeleccionProductos.Name = "panelSeleccionProductos";
            panelSeleccionProductos.Size = new Size(721, 415);
            panelSeleccionProductos.TabIndex = 7;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(3, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(319, 43);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Productos mas vendidos:";
            // 
            // dgvVentas
            // 
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(31, 20, 16);
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.Location = new Point(25, 61);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(660, 279);
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
            btnGenerarReporte.Location = new Point(247, 358);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(201, 43);
            btnGenerarReporte.TabIndex = 35;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // ProductosMaasVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(829, 481);
            Controls.Add(panelSeleccionProductos);
            Name = "ProductosMaasVendidos";
            Text = "ProductosMaasVendidos";
            Load += ProductosMaasVendidos_Load;
            panelSeleccionProductos.ResumeLayout(false);
            panelSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSeleccionProductos;
        private Label lblMensaje;
        private DataGridView dgvVentas;
        private Button btnGenerarReporte;
    }
}