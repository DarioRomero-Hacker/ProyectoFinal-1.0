namespace ProyectoFinal_1._0
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            pictureBox2 = new PictureBox();
            txtClave = new TextBox();
            lblClave = new Label();
            pictureBox1 = new PictureBox();
            lblUsuarioInvalido = new Label();
            panelLinea1 = new Panel();
            txtUsuario = new TextBox();
            llblUsuario = new Label();
            lblLogin = new Label();
            grbLogin = new GroupBox();
            lblLetrasNumeros = new Label();
            panelLinea2 = new Panel();
            lblClaveIncorrecta = new Label();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnLogin.FlatAppearance.BorderSize = 2;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(53, 312);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(215, 46);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(31, 20, 16);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.Silver;
            txtClave.Location = new Point(269, 203);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(265, 22);
            txtClave.TabIndex = 2;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.Location = new Point(101, 202);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(59, 28);
            lblClave.TabIndex = 15;
            lblClave.Text = "Clave:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblUsuarioInvalido
            // 
            lblUsuarioInvalido.AutoSize = true;
            lblUsuarioInvalido.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioInvalido.ForeColor = Color.Red;
            lblUsuarioInvalido.Location = new Point(269, 163);
            lblUsuarioInvalido.Margin = new Padding(3);
            lblUsuarioInvalido.Name = "lblUsuarioInvalido";
            lblUsuarioInvalido.Size = new Size(234, 28);
            lblUsuarioInvalido.TabIndex = 4;
            lblUsuarioInvalido.Text = "Nombre de usuario invalido";
            // 
            // panelLinea1
            // 
            panelLinea1.BackColor = Color.Lime;
            panelLinea1.Location = new Point(269, 156);
            panelLinea1.Name = "panelLinea1";
            panelLinea1.Size = new Size(265, 1);
            panelLinea1.TabIndex = 4;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(31, 20, 16);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Location = new Point(269, 127);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(265, 29);
            txtUsuario.TabIndex = 2;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // llblUsuario
            // 
            llblUsuario.AutoSize = true;
            llblUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llblUsuario.Location = new Point(101, 129);
            llblUsuario.Name = "llblUsuario";
            llblUsuario.Size = new Size(77, 28);
            llblUsuario.TabIndex = 12;
            llblUsuario.Text = "Usuario:";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.Location = new Point(208, 77);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(164, 35);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Login Barberia";
            // 
            // grbLogin
            // 
            grbLogin.BackColor = Color.FromArgb(31, 20, 16);
            grbLogin.Controls.Add(btnSalir);
            grbLogin.Controls.Add(lblUsuarioInvalido);
            grbLogin.Controls.Add(lblLetrasNumeros);
            grbLogin.Controls.Add(panelLinea2);
            grbLogin.Controls.Add(lblClaveIncorrecta);
            grbLogin.Controls.Add(panelLinea1);
            grbLogin.Controls.Add(txtClave);
            grbLogin.Controls.Add(lblLogin);
            grbLogin.Controls.Add(txtUsuario);
            grbLogin.Controls.Add(llblUsuario);
            grbLogin.Controls.Add(btnLogin);
            grbLogin.Controls.Add(pictureBox2);
            grbLogin.Controls.Add(pictureBox1);
            grbLogin.Controls.Add(lblClave);
            grbLogin.Location = new Point(219, 23);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(594, 409);
            grbLogin.TabIndex = 20;
            grbLogin.TabStop = false;
            // 
            // lblLetrasNumeros
            // 
            lblLetrasNumeros.AutoSize = true;
            lblLetrasNumeros.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetrasNumeros.ForeColor = Color.Red;
            lblLetrasNumeros.Location = new Point(269, 162);
            lblLetrasNumeros.Margin = new Padding(3);
            lblLetrasNumeros.Name = "lblLetrasNumeros";
            lblLetrasNumeros.Size = new Size(185, 28);
            lblLetrasNumeros.TabIndex = 34;
            lblLetrasNumeros.Text = "Solo letras y numeros";
            // 
            // panelLinea2
            // 
            panelLinea2.BackColor = Color.Lime;
            panelLinea2.Location = new Point(269, 227);
            panelLinea2.Name = "panelLinea2";
            panelLinea2.Size = new Size(265, 1);
            panelLinea2.TabIndex = 4;
            // 
            // lblClaveIncorrecta
            // 
            lblClaveIncorrecta.AutoSize = true;
            lblClaveIncorrecta.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClaveIncorrecta.ForeColor = Color.Red;
            lblClaveIncorrecta.Location = new Point(269, 231);
            lblClaveIncorrecta.Name = "lblClaveIncorrecta";
            lblClaveIncorrecta.Size = new Size(141, 28);
            lblClaveIncorrecta.TabIndex = 4;
            lblClaveIncorrecta.Text = "Clave Incorrecta";
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(319, 312);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(215, 46);
            btnSalir.TabIndex = 35;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 20, 16);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(889, 459);
            Controls.Add(grbLogin);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private PictureBox pictureBox2;
        private TextBox txtClave;
        private Label lblClave;
        private PictureBox pictureBox1;
        private Label lblUsuarioInvalido;
        private Panel panelLinea1;
        private TextBox txtUsuario;
        private Label llblUsuario;
        private Label lblLogin;
        private GroupBox grbLogin;
        private Panel panelLinea2;
        private Label lblLetrasNumeros;
        private Label lblClaveIncorrecta;
        private Button btnSalir;
    }
}
