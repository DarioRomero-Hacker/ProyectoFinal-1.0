namespace ProyectoFinal_1._0.Forms
{
    partial class Administradores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administradores));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            lblUsuario = new Label();
            lklCrearCuenta = new LinkLabel();
            lblMensaje = new Label();
            panel2 = new Panel();
            btnReportesGestion = new Button();
            btnClientesGestionar = new Button();
            btnUsuariosGestionar = new Button();
            btnProductosGestion = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 20, 1);
            panel1.BackgroundImage = Properties.Resources.background;
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 749);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblUsuario);
            groupBox1.Controls.Add(lklCrearCuenta);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(170, 143);
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
            lblUsuario.Location = new Point(35, 118);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 54);
            lblUsuario.TabIndex = 42;
            // 
            // lklCrearCuenta
            // 
            lklCrearCuenta.AutoSize = true;
            lklCrearCuenta.LinkColor = Color.White;
            lklCrearCuenta.Location = new Point(139, 305);
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
            lblMensaje.Location = new Point(46, 24);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(345, 54);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Home Administrador";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 20, 1);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Controls.Add(btnReportesGestion);
            panel2.Controls.Add(btnClientesGestionar);
            panel2.Controls.Add(btnUsuariosGestionar);
            panel2.Controls.Add(btnProductosGestion);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(756, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(325, 749);
            panel2.TabIndex = 1;
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
            btnReportesGestion.Location = new Point(59, 459);
            btnReportesGestion.Margin = new Padding(3, 4, 3, 4);
            btnReportesGestion.Name = "btnReportesGestion";
            btnReportesGestion.Size = new Size(230, 59);
            btnReportesGestion.TabIndex = 33;
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
            btnClientesGestionar.Location = new Point(59, 395);
            btnClientesGestionar.Margin = new Padding(3, 4, 3, 4);
            btnClientesGestionar.Name = "btnClientesGestionar";
            btnClientesGestionar.Size = new Size(230, 56);
            btnClientesGestionar.TabIndex = 32;
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
            btnUsuariosGestionar.Location = new Point(59, 323);
            btnUsuariosGestionar.Margin = new Padding(3, 4, 3, 4);
            btnUsuariosGestionar.Name = "btnUsuariosGestionar";
            btnUsuariosGestionar.Size = new Size(230, 64);
            btnUsuariosGestionar.TabIndex = 31;
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
            btnProductosGestion.Location = new Point(59, 243);
            btnProductosGestion.Margin = new Padding(3, 4, 3, 4);
            btnProductosGestion.Name = "btnProductosGestion";
            btnProductosGestion.Size = new Size(230, 72);
            btnProductosGestion.TabIndex = 30;
            btnProductosGestion.Text = "Gestionar productos";
            btnProductosGestion.UseVisualStyleBackColor = false;
            btnProductosGestion.Click += btnProductosGestion_Click;
            // 
            // Administradores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1081, 749);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administradores";
            Text = "Administradores";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private GroupBox groupBox1;
        private LinkLabel lklCrearCuenta;
        private Label lblMensaje;
        private Button btnReportesGestion;
        private Button btnClientesGestionar;
        private Button btnUsuariosGestionar;
        private Button btnProductosGestion;
        private Label lblUsuario;
    }
}