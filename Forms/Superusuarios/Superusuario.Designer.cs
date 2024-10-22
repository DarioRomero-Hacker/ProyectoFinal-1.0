namespace ProyectoFinal_1._0.Forms
{
    partial class Superusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Superusuario));
            panelDerecha = new Panel();
            btnCrearCuenta = new Button();
            btnVentasporUsuarios = new Button();
            btnVentas = new Button();
            btnMasVendidos = new Button();
            btnReportesGestion = new Button();
            btnClientesGestionar = new Button();
            btnUsuariosGestionar = new Button();
            btnProductosGestion = new Button();
            panelIzquierda = new Panel();
            groupBox1 = new GroupBox();
            lklCrearCuenta = new LinkLabel();
            lblMensaje = new Label();
            lblUsuario = new Label();
            panelTodo = new Panel();
            panelDerecha.SuspendLayout();
            panelIzquierda.SuspendLayout();
            groupBox1.SuspendLayout();
            panelTodo.SuspendLayout();
            SuspendLayout();
            // 
            // panelDerecha
            // 
            panelDerecha.BackColor = Color.FromArgb(31, 20, 16);
            panelDerecha.BackgroundImage = (Image)resources.GetObject("panelDerecha.BackgroundImage");
            panelDerecha.BackgroundImageLayout = ImageLayout.Zoom;
            panelDerecha.Controls.Add(btnCrearCuenta);
            panelDerecha.Controls.Add(btnVentasporUsuarios);
            panelDerecha.Controls.Add(btnVentas);
            panelDerecha.Controls.Add(btnMasVendidos);
            panelDerecha.Controls.Add(btnReportesGestion);
            panelDerecha.Controls.Add(btnClientesGestionar);
            panelDerecha.Controls.Add(btnUsuariosGestionar);
            panelDerecha.Controls.Add(btnProductosGestion);
            panelDerecha.Dock = DockStyle.Right;
            panelDerecha.ForeColor = Color.White;
            panelDerecha.Location = new Point(660, 0);
            panelDerecha.Name = "panelDerecha";
            panelDerecha.Size = new Size(286, 562);
            panelDerecha.TabIndex = 0;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.BackColor = Color.FromArgb(86, 42, 20);
            btnCrearCuenta.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnCrearCuenta.FlatAppearance.BorderSize = 2;
            btnCrearCuenta.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnCrearCuenta.FlatStyle = FlatStyle.Flat;
            btnCrearCuenta.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.Location = new Point(41, 69);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.Size = new Size(201, 46);
            btnCrearCuenta.TabIndex = 19;
            btnCrearCuenta.Text = "Crear cuentas";
            btnCrearCuenta.UseVisualStyleBackColor = false;
            btnCrearCuenta.Click += btnCrearCuenta_Click;
            // 
            // btnVentasporUsuarios
            // 
            btnVentasporUsuarios.BackColor = Color.FromArgb(86, 42, 20);
            btnVentasporUsuarios.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentasporUsuarios.FlatAppearance.BorderSize = 2;
            btnVentasporUsuarios.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentasporUsuarios.FlatStyle = FlatStyle.Flat;
            btnVentasporUsuarios.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentasporUsuarios.ForeColor = Color.White;
            btnVentasporUsuarios.Location = new Point(41, 382);
            btnVentasporUsuarios.Name = "btnVentasporUsuarios";
            btnVentasporUsuarios.Size = new Size(201, 43);
            btnVentasporUsuarios.TabIndex = 26;
            btnVentasporUsuarios.Text = "Ventas por Usuarios";
            btnVentasporUsuarios.UseVisualStyleBackColor = false;
            btnVentasporUsuarios.Click += btnVentasporUsuarios_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(86, 42, 20);
            btnVentas.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnVentas.FlatAppearance.BorderSize = 2;
            btnVentas.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(41, 333);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(201, 43);
            btnVentas.TabIndex = 25;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMasVendidos
            // 
            btnMasVendidos.BackColor = Color.FromArgb(86, 42, 20);
            btnMasVendidos.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnMasVendidos.FlatAppearance.BorderSize = 2;
            btnMasVendidos.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnMasVendidos.FlatStyle = FlatStyle.Flat;
            btnMasVendidos.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMasVendidos.ForeColor = Color.White;
            btnMasVendidos.Location = new Point(41, 431);
            btnMasVendidos.Name = "btnMasVendidos";
            btnMasVendidos.Size = new Size(201, 76);
            btnMasVendidos.TabIndex = 24;
            btnMasVendidos.Text = "Productos mas vendidos";
            btnMasVendidos.UseVisualStyleBackColor = false;
            btnMasVendidos.Click += btnMasVendidos_Click;
            // 
            // btnReportesGestion
            // 
            btnReportesGestion.BackColor = Color.FromArgb(86, 42, 20);
            btnReportesGestion.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnReportesGestion.FlatAppearance.BorderSize = 2;
            btnReportesGestion.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnReportesGestion.FlatStyle = FlatStyle.Flat;
            btnReportesGestion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportesGestion.ForeColor = Color.White;
            btnReportesGestion.Location = new Point(41, 283);
            btnReportesGestion.Name = "btnReportesGestion";
            btnReportesGestion.Size = new Size(201, 44);
            btnReportesGestion.TabIndex = 23;
            btnReportesGestion.Text = "Gestion de reportes";
            btnReportesGestion.UseVisualStyleBackColor = false;
            btnReportesGestion.Click += btnReportesGestion_Click;
            // 
            // btnClientesGestionar
            // 
            btnClientesGestionar.BackColor = Color.FromArgb(86, 42, 20);
            btnClientesGestionar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnClientesGestionar.FlatAppearance.BorderSize = 2;
            btnClientesGestionar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnClientesGestionar.FlatStyle = FlatStyle.Flat;
            btnClientesGestionar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientesGestionar.ForeColor = Color.White;
            btnClientesGestionar.Location = new Point(41, 235);
            btnClientesGestionar.Name = "btnClientesGestionar";
            btnClientesGestionar.Size = new Size(201, 42);
            btnClientesGestionar.TabIndex = 22;
            btnClientesGestionar.Text = "Gestionar Clientes";
            btnClientesGestionar.UseVisualStyleBackColor = false;
            btnClientesGestionar.Click += btnClientesGestionar_Click;
            // 
            // btnUsuariosGestionar
            // 
            btnUsuariosGestionar.BackColor = Color.FromArgb(86, 42, 20);
            btnUsuariosGestionar.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnUsuariosGestionar.FlatAppearance.BorderSize = 2;
            btnUsuariosGestionar.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnUsuariosGestionar.FlatStyle = FlatStyle.Flat;
            btnUsuariosGestionar.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsuariosGestionar.ForeColor = Color.White;
            btnUsuariosGestionar.Location = new Point(41, 181);
            btnUsuariosGestionar.Name = "btnUsuariosGestionar";
            btnUsuariosGestionar.Size = new Size(201, 48);
            btnUsuariosGestionar.TabIndex = 21;
            btnUsuariosGestionar.Text = "Gestionar usuarios";
            btnUsuariosGestionar.UseVisualStyleBackColor = false;
            btnUsuariosGestionar.Click += btnUsuariosGestionar_Click;
            // 
            // btnProductosGestion
            // 
            btnProductosGestion.BackColor = Color.FromArgb(86, 42, 20);
            btnProductosGestion.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnProductosGestion.FlatAppearance.BorderSize = 2;
            btnProductosGestion.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnProductosGestion.FlatStyle = FlatStyle.Flat;
            btnProductosGestion.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductosGestion.ForeColor = Color.White;
            btnProductosGestion.Location = new Point(41, 121);
            btnProductosGestion.Name = "btnProductosGestion";
            btnProductosGestion.Size = new Size(201, 54);
            btnProductosGestion.TabIndex = 20;
            btnProductosGestion.Text = "Gestionar productos";
            btnProductosGestion.UseVisualStyleBackColor = false;
            btnProductosGestion.Click += btnProductosGestion_Click;
            // 
            // panelIzquierda
            // 
            panelIzquierda.BackColor = Color.FromArgb(31, 20, 16);
            panelIzquierda.BackgroundImage = (Image)resources.GetObject("panelIzquierda.BackgroundImage");
            panelIzquierda.Controls.Add(groupBox1);
            panelIzquierda.Dock = DockStyle.Left;
            panelIzquierda.ForeColor = Color.White;
            panelIzquierda.Location = new Point(0, 0);
            panelIzquierda.Name = "panelIzquierda";
            panelIzquierda.Size = new Size(664, 568);
            panelIzquierda.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lklCrearCuenta);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(176, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 273);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // lklCrearCuenta
            // 
            lklCrearCuenta.AutoSize = true;
            lklCrearCuenta.LinkColor = Color.White;
            lklCrearCuenta.Location = new Point(141, 219);
            lklCrearCuenta.Name = "lklCrearCuenta";
            lklCrearCuenta.Size = new Size(75, 15);
            lklCrearCuenta.TabIndex = 20;
            lklCrearCuenta.TabStop = true;
            lklCrearCuenta.Text = "Cerrar sesion";
            lklCrearCuenta.LinkClicked += lklCrearCuenta_LinkClicked;
            lklCrearCuenta.Click += lklCrearCuenta_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(75, 18);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(203, 33);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Home Superusuario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(59, 75);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 33);
            lblUsuario.TabIndex = 42;
            // 
            // panelTodo
            // 
            panelTodo.BackColor = Color.FromArgb(86, 42, 20);
            panelTodo.Controls.Add(panelIzquierda);
            panelTodo.Location = new Point(0, 0);
            panelTodo.Name = "panelTodo";
            panelTodo.Size = new Size(934, 568);
            panelTodo.TabIndex = 1;
            // 
            // Superusuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 562);
            Controls.Add(panelDerecha);
            Controls.Add(panelTodo);
            ForeColor = Color.Cyan;
            Name = "Superusuario";
            Text = "Superusuarios";
            panelDerecha.ResumeLayout(false);
            panelIzquierda.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelTodo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDerecha;
        private Button btnCrearCuenta;
        private Button btnProductosGestion;
        private Button btnVentasporUsuarios;
        private Button btnVentas;
        private Button btnMasVendidos;
        private Button btnReportesGestion;
        private Button btnClientesGestionar;
        private Button btnUsuariosGestionar;
        private Panel panelIzquierda;
        private GroupBox groupBox1;
        private Label lblMensaje;
        private Panel panelTodo;
        private LinkLabel lklCrearCuenta;
        private Label lblUsuario;
    }
}