namespace ProyectoFinal_1._0
{
    partial class gestionReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gestionReportes));
            panelDerecha = new Panel();
            lblMensaje = new Label();
            btnProductosMasVendidos = new Button();
            btnVentasUsuarios = new Button();
            btnVentasDiariasSemanalesMensuales = new Button();
            panelDerecha.SuspendLayout();
            SuspendLayout();
            // 
            // panelDerecha
            // 
            panelDerecha.BackColor = Color.FromArgb(31, 20, 16);
            panelDerecha.BackgroundImage = (Image)resources.GetObject("panelDerecha.BackgroundImage");
            panelDerecha.BackgroundImageLayout = ImageLayout.Zoom;
            panelDerecha.Controls.Add(lblMensaje);
            panelDerecha.Controls.Add(btnProductosMasVendidos);
            panelDerecha.Controls.Add(btnVentasUsuarios);
            panelDerecha.Controls.Add(btnVentasDiariasSemanalesMensuales);
            panelDerecha.Dock = DockStyle.Fill;
            panelDerecha.ForeColor = Color.White;
            panelDerecha.Location = new Point(0, 0);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(555, 365);
            panelDerecha.TabIndex = 1;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(157, 55);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(254, 43);
            lblMensaje.TabIndex = 22;
            lblMensaje.Text = "Gestion de reportes";
            // 
            // btnProductosMasVendidos
            // 
            btnProductosMasVendidos.BackColor = Color.FromArgb(86, 42, 20);
            btnProductosMasVendidos.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnProductosMasVendidos.FlatAppearance.BorderSize = 2;
            btnProductosMasVendidos.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnProductosMasVendidos.FlatStyle = FlatStyle.Flat;
            btnProductosMasVendidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductosMasVendidos.ForeColor = Color.White;
            btnProductosMasVendidos.Location = new Point(120, 129);
            btnProductosMasVendidos.Name = "btnProductosMasVendidos";
            btnProductosMasVendidos.Size = new Size(319, 46);
            btnProductosMasVendidos.TabIndex = 19;
            btnProductosMasVendidos.Text = "Productos mas vendidos";
            btnProductosMasVendidos.UseVisualStyleBackColor = false;
            btnProductosMasVendidos.Click += btnProductosMasVendidos_Click;
            // 
            // btnVentasUsuarios
            // 
            btnVentasUsuarios.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasUsuarios.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasUsuarios.FlatAppearance.BorderSize = 2;
            btnVentasUsuarios.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasUsuarios.FlatStyle = FlatStyle.Flat;
            btnVentasUsuarios.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasUsuarios.ForeColor = Color.White;
            btnVentasUsuarios.Location = new Point(120, 241);
            btnVentasUsuarios.Name = "btnVentasUsuarios";
            btnVentasUsuarios.Size = new Size(319, 48);
            btnVentasUsuarios.TabIndex = 21;
            btnVentasUsuarios.Text = "Ventas por usuarios";
            btnVentasUsuarios.UseVisualStyleBackColor = false;
            btnVentasUsuarios.Click += btnVentasUsuarios_Click;
            // 
            // btnVentasDiariasSemanalesMensuales
            // 
            btnVentasDiariasSemanalesMensuales.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasDiariasSemanalesMensuales.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasDiariasSemanalesMensuales.FlatAppearance.BorderSize = 2;
            btnVentasDiariasSemanalesMensuales.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasDiariasSemanalesMensuales.FlatStyle = FlatStyle.Flat;
            btnVentasDiariasSemanalesMensuales.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasDiariasSemanalesMensuales.ForeColor = Color.White;
            btnVentasDiariasSemanalesMensuales.Location = new Point(120, 181);
            btnVentasDiariasSemanalesMensuales.Name = "btnVentasDiariasSemanalesMensuales";
            btnVentasDiariasSemanalesMensuales.Size = new Size(319, 54);
            btnVentasDiariasSemanalesMensuales.TabIndex = 20;
            btnVentasDiariasSemanalesMensuales.Text = "Ventas diarias/semanales/mensuales";
            btnVentasDiariasSemanalesMensuales.UseVisualStyleBackColor = false;
            btnVentasDiariasSemanalesMensuales.Click += btnVentasDiariasSemanalesMensuales_Click;
            // 
            // gestionReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 365);
            Controls.Add(panelDerecha);
            Name = "gestionReportes";
            Text = "gestionReportes";
            panelDerecha.ResumeLayout(false);
            panelDerecha.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDerecha;
        private Button btnProductosMasVendidos;
        private Button btnVentasUsuarios;
        private Button btnVentasDiariasSemanalesMensuales;
        private Label lblMensaje;
    }
}