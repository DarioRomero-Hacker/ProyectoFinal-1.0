namespace ProyectoFinal_1._0.Forms.UsuariosComunes
{
    partial class UsuariosComunes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosComunes));
            groupBox1 = new GroupBox();
            lblUsuario = new Label();
            panelTodo = new Panel();
            lklCrearCuenta = new LinkLabel();
            lblMensaje = new Label();
            btnRegistrarVenta = new Button();
            btnClientesGestionar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnReportesGestion = new Button();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(panelTodo);
            groupBox1.Controls.Add(lklCrearCuenta);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(179, 145);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(421, 364);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(25, 134);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 54);
            lblUsuario.TabIndex = 41;
            // 
            // panelTodo
            // 
            panelTodo.Location = new Point(417, 269);
            panelTodo.Margin = new Padding(3, 4, 3, 4);
            panelTodo.Name = "panelTodo";
            panelTodo.Size = new Size(229, 133);
            panelTodo.TabIndex = 40;
            // 
            // lklCrearCuenta
            // 
            lklCrearCuenta.AutoSize = true;
            lklCrearCuenta.LinkColor = Color.White;
            lklCrearCuenta.Location = new Point(147, 269);
            lklCrearCuenta.Name = "lklCrearCuenta";
            lklCrearCuenta.Size = new Size(94, 20);
            lklCrearCuenta.TabIndex = 20;
            lklCrearCuenta.TabStop = true;
            lklCrearCuenta.Text = "Cerrar sesion";
            lklCrearCuenta.LinkClicked += lklCrearCuenta_LinkClicked;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(35, 24);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(353, 54);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Home Usuario Comun";
            // 
            // btnRegistrarVenta
            // 
            btnRegistrarVenta.BackColor = Color.FromArgb(86, 42, 20);
            btnRegistrarVenta.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnRegistrarVenta.FlatAppearance.BorderSize = 2;
            btnRegistrarVenta.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnRegistrarVenta.FlatStyle = FlatStyle.Flat;
            btnRegistrarVenta.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarVenta.ForeColor = Color.White;
            btnRegistrarVenta.Location = new Point(58, 276);
            btnRegistrarVenta.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarVenta.Name = "btnRegistrarVenta";
            btnRegistrarVenta.Size = new Size(230, 57);
            btnRegistrarVenta.TabIndex = 36;
            btnRegistrarVenta.Text = "Registrar Ventas";
            btnRegistrarVenta.UseVisualStyleBackColor = false;
            btnRegistrarVenta.Click += btnRegistrarVenta_Click;
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
            btnClientesGestionar.Location = new Point(58, 348);
            btnClientesGestionar.Margin = new Padding(3, 4, 3, 4);
            btnClientesGestionar.Name = "btnClientesGestionar";
            btnClientesGestionar.Size = new Size(230, 56);
            btnClientesGestionar.TabIndex = 32;
            btnClientesGestionar.Text = "Gestionar Clientes";
            btnClientesGestionar.UseVisualStyleBackColor = false;
            btnClientesGestionar.Click += btnClientesGestionar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 20, 16);
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 749);
            panel1.TabIndex = 39;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 20, 16);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btnReportesGestion);
            panel2.Controls.Add(btnClientesGestionar);
            panel2.Controls.Add(btnRegistrarVenta);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(758, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 749);
            panel2.TabIndex = 3;
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
            btnReportesGestion.Location = new Point(58, 412);
            btnReportesGestion.Margin = new Padding(3, 4, 3, 4);
            btnReportesGestion.Name = "btnReportesGestion";
            btnReportesGestion.Size = new Size(230, 59);
            btnReportesGestion.TabIndex = 33;
            btnReportesGestion.Text = "Gestion de reportes";
            btnReportesGestion.UseVisualStyleBackColor = false;
            btnReportesGestion.Click += btnReportesGestion_Click;
            // 
            // UsuariosComunes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UsuariosComunes";
            Text = "UsuariosComunes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel lklCrearCuenta;
        private Label lblMensaje;
        private Panel panelTodo;
        private Button btnCrearCuenta;
        private Button btnVentasSemanales;
        private Button btnVentasMensuales;
        private Button btnRegistrarVenta;
        private Button btnVentasDia;
        private Button btnMasVendidos;
        private Button btnClientesGestionar;
        private Button btnUsuariosGestionar;
        private Button btnProductosGestion;
        private Panel panel1;
        private Panel panel2;
        private Button btnReportesGestion;
        private Label lblUsuario;
    }
}