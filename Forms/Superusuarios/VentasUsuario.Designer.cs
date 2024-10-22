namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class VentasUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentasUsuario));
            panelSeleccionProductos = new Panel();
            lblSeleccioneUsuario = new Label();
            btnMostrarVentas = new Button();
            cmbUsuarios = new ComboBox();
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
            panelSeleccionProductos.Controls.Add(lblSeleccioneUsuario);
            panelSeleccionProductos.Controls.Add(btnMostrarVentas);
            panelSeleccionProductos.Controls.Add(cmbUsuarios);
            panelSeleccionProductos.Controls.Add(label2);
            panelSeleccionProductos.Controls.Add(lblMensaje);
            panelSeleccionProductos.Controls.Add(dgvVentas);
            panelSeleccionProductos.Location = new Point(60, 35);
            panelSeleccionProductos.Name = "panelSeleccionProductos";
            panelSeleccionProductos.Size = new Size(721, 534);
            panelSeleccionProductos.TabIndex = 5;
            // 
            // lblSeleccioneUsuario
            // 
            lblSeleccioneUsuario.AutoSize = true;
            lblSeleccioneUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccioneUsuario.ForeColor = Color.Red;
            lblSeleccioneUsuario.Location = new Point(129, 101);
            lblSeleccioneUsuario.Margin = new Padding(3);
            lblSeleccioneUsuario.Name = "lblSeleccioneUsuario";
            lblSeleccioneUsuario.Size = new Size(183, 28);
            lblSeleccioneUsuario.TabIndex = 36;
            lblSeleccioneUsuario.Text = "Seleccione un usuario";
            // 
            // btnMostrarVentas
            // 
            btnMostrarVentas.BackColor = Color.FromArgb(86, 42, 20);
            btnMostrarVentas.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnMostrarVentas.FlatAppearance.BorderSize = 2;
            btnMostrarVentas.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnMostrarVentas.FlatStyle = FlatStyle.Flat;
            btnMostrarVentas.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarVentas.ForeColor = Color.White;
            btnMostrarVentas.Location = new Point(398, 123);
            btnMostrarVentas.Name = "btnMostrarVentas";
            btnMostrarVentas.Size = new Size(201, 46);
            btnMostrarVentas.TabIndex = 23;
            btnMostrarVentas.Text = "VENTAS";
            btnMostrarVentas.UseVisualStyleBackColor = false;
            btnMostrarVentas.Click += btnMostrarVentas_Click;
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(129, 72);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(148, 23);
            cmbUsuarios.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(86, 42, 20);
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 72);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 21;
            label2.Text = "Usuario:";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(3, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(247, 43);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Ventas por usuario";
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
            dgvVentas.Location = new Point(25, 175);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.Size = new Size(574, 279);
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
            btnGenerarReporte.Location = new Point(240, 472);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(201, 43);
            btnGenerarReporte.TabIndex = 37;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // VentasUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(839, 581);
            Controls.Add(panelSeleccionProductos);
            Name = "VentasUsuario";
            Text = "VentasUsuario";
            panelSeleccionProductos.ResumeLayout(false);
            panelSeleccionProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSeleccionProductos;
        private ComboBox cmbUsuarios;
        private Label label2;
        private Label lblMensaje;
        private DataGridView dgvVentas;
        private Button btnMostrarVentas;
        private Label lblSeleccioneUsuario;
        private Button btnGenerarReporte;
    }
}