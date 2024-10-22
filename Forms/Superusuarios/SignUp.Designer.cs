namespace ProyectoFinal_1._0
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            grbLogin = new GroupBox();
            lblExiste = new Label();
            btnSingUp = new Button();
            pictureBox4 = new PictureBox();
            cmbTiposUsuarios = new ComboBox();
            panel1 = new Panel();
            panelLinea2 = new Panel();
            lblClavesNoCoinciden1 = new Label();
            panel2 = new Panel();
            panelLinea1 = new Panel();
            txtClave = new TextBox();
            lblClavesNoCoinciden2 = new Label();
            lblLetrasNumeros = new Label();
            txtClaveConfirmar = new TextBox();
            lblLogin = new Label();
            label3 = new Label();
            lklCrearCuenta = new LinkLabel();
            pictureBox3 = new PictureBox();
            txtUsuario = new TextBox();
            label4 = new Label();
            llblUsuario = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblClave = new Label();
            grbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grbLogin
            // 
            grbLogin.BackColor = Color.FromArgb(31, 20, 16);
            grbLogin.Controls.Add(lblExiste);
            grbLogin.Controls.Add(btnSingUp);
            grbLogin.Controls.Add(pictureBox4);
            grbLogin.Controls.Add(cmbTiposUsuarios);
            grbLogin.Controls.Add(panel1);
            grbLogin.Controls.Add(panelLinea2);
            grbLogin.Controls.Add(lblClavesNoCoinciden1);
            grbLogin.Controls.Add(panel2);
            grbLogin.Controls.Add(panelLinea1);
            grbLogin.Controls.Add(txtClave);
            grbLogin.Controls.Add(lblClavesNoCoinciden2);
            grbLogin.Controls.Add(lblLetrasNumeros);
            grbLogin.Controls.Add(txtClaveConfirmar);
            grbLogin.Controls.Add(lblLogin);
            grbLogin.Controls.Add(label3);
            grbLogin.Controls.Add(lklCrearCuenta);
            grbLogin.Controls.Add(pictureBox3);
            grbLogin.Controls.Add(txtUsuario);
            grbLogin.Controls.Add(label4);
            grbLogin.Controls.Add(llblUsuario);
            grbLogin.Controls.Add(pictureBox2);
            grbLogin.Controls.Add(pictureBox1);
            grbLogin.Controls.Add(lblClave);
            grbLogin.Location = new Point(161, 47);
            grbLogin.Margin = new Padding(3, 4, 3, 4);
            grbLogin.Name = "grbLogin";
            grbLogin.Padding = new Padding(3, 4, 3, 4);
            grbLogin.Size = new Size(752, 572);
            grbLogin.TabIndex = 21;
            grbLogin.TabStop = false;
            // 
            // lblExiste
            // 
            lblExiste.AutoSize = true;
            lblExiste.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExiste.ForeColor = Color.Red;
            lblExiste.Location = new Point(306, 128);
            lblExiste.Margin = new Padding(3, 4, 3, 4);
            lblExiste.Name = "lblExiste";
            lblExiste.Size = new Size(73, 35);
            lblExiste.TabIndex = 30;
            lblExiste.Text = "Existe";
            // 
            // btnSingUp
            // 
            btnSingUp.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            btnSingUp.FlatAppearance.BorderSize = 2;
            btnSingUp.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnSingUp.FlatStyle = FlatStyle.Flat;
            btnSingUp.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSingUp.ForeColor = Color.White;
            btnSingUp.Location = new Point(306, 439);
            btnSingUp.Margin = new Padding(3, 4, 3, 4);
            btnSingUp.Name = "btnSingUp";
            btnSingUp.Size = new Size(246, 61);
            btnSingUp.TabIndex = 18;
            btnSingUp.Text = "Sing Up";
            btnSingUp.UseVisualStyleBackColor = true;
            btnSingUp.Click += btnSingUp_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(40, 383);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(48, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // cmbTiposUsuarios
            // 
            cmbTiposUsuarios.BackColor = Color.FromArgb(86, 42, 20);
            cmbTiposUsuarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTiposUsuarios.FlatStyle = FlatStyle.Flat;
            cmbTiposUsuarios.FormattingEnabled = true;
            cmbTiposUsuarios.Items.AddRange(new object[] { "Superusuario", "Administrador", "Usuario Comun" });
            cmbTiposUsuarios.Location = new Point(306, 375);
            cmbTiposUsuarios.Margin = new Padding(3, 4, 3, 4);
            cmbTiposUsuarios.Name = "cmbTiposUsuarios";
            cmbTiposUsuarios.Size = new Size(302, 28);
            cmbTiposUsuarios.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Location = new Point(306, 413);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 1);
            panel1.TabIndex = 20;
            // 
            // panelLinea2
            // 
            panelLinea2.BackColor = Color.Lime;
            panelLinea2.Location = new Point(306, 213);
            panelLinea2.Margin = new Padding(3, 4, 3, 4);
            panelLinea2.Name = "panelLinea2";
            panelLinea2.Size = new Size(303, 1);
            panelLinea2.TabIndex = 4;
            // 
            // lblClavesNoCoinciden1
            // 
            lblClavesNoCoinciden1.AutoSize = true;
            lblClavesNoCoinciden1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClavesNoCoinciden1.ForeColor = Color.Red;
            lblClavesNoCoinciden1.Location = new Point(306, 219);
            lblClavesNoCoinciden1.Name = "lblClavesNoCoinciden1";
            lblClavesNoCoinciden1.Size = new Size(245, 35);
            lblClavesNoCoinciden1.TabIndex = 4;
            lblClavesNoCoinciden1.Text = "Las claves no coinciden";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Location = new Point(306, 304);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(303, 1);
            panel2.TabIndex = 22;
            // 
            // panelLinea1
            // 
            panelLinea1.BackColor = Color.Lime;
            panelLinea1.Location = new Point(306, 119);
            panelLinea1.Margin = new Padding(3, 4, 3, 4);
            panelLinea1.Name = "panelLinea1";
            panelLinea1.Size = new Size(303, 1);
            panelLinea1.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.FromArgb(31, 20, 16);
            txtClave.BorderStyle = BorderStyle.None;
            txtClave.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClave.ForeColor = Color.Silver;
            txtClave.Location = new Point(306, 173);
            txtClave.Margin = new Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(303, 36);
            txtClave.TabIndex = 2;
            // 
            // lblClavesNoCoinciden2
            // 
            lblClavesNoCoinciden2.AutoSize = true;
            lblClavesNoCoinciden2.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClavesNoCoinciden2.ForeColor = Color.Red;
            lblClavesNoCoinciden2.Location = new Point(306, 313);
            lblClavesNoCoinciden2.Margin = new Padding(3, 4, 3, 4);
            lblClavesNoCoinciden2.Name = "lblClavesNoCoinciden2";
            lblClavesNoCoinciden2.Size = new Size(245, 35);
            lblClavesNoCoinciden2.TabIndex = 23;
            lblClavesNoCoinciden2.Text = "Las claves no coinciden";
            // 
            // lblLetrasNumeros
            // 
            lblLetrasNumeros.AutoSize = true;
            lblLetrasNumeros.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetrasNumeros.ForeColor = Color.Red;
            lblLetrasNumeros.Location = new Point(306, 128);
            lblLetrasNumeros.Margin = new Padding(3, 4, 3, 4);
            lblLetrasNumeros.Name = "lblLetrasNumeros";
            lblLetrasNumeros.Size = new Size(231, 35);
            lblLetrasNumeros.TabIndex = 4;
            lblLetrasNumeros.Text = "Solo letras y numeros";
            // 
            // txtClaveConfirmar
            // 
            txtClaveConfirmar.BackColor = Color.FromArgb(31, 20, 16);
            txtClaveConfirmar.BorderStyle = BorderStyle.None;
            txtClaveConfirmar.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClaveConfirmar.ForeColor = Color.Silver;
            txtClaveConfirmar.Location = new Point(306, 265);
            txtClaveConfirmar.Margin = new Padding(3, 4, 3, 4);
            txtClaveConfirmar.Name = "txtClaveConfirmar";
            txtClaveConfirmar.Size = new Size(303, 36);
            txtClaveConfirmar.TabIndex = 19;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe Print", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = Color.White;
            lblLogin.Location = new Point(256, 13);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(237, 44);
            lblLogin.TabIndex = 11;
            lblLogin.Text = "Sing Up Barberia";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(91, 268);
            label3.Name = "label3";
            label3.Size = new Size(181, 35);
            label3.TabIndex = 24;
            label3.Text = "Confirmar clave:";
            // 
            // lklCrearCuenta
            // 
            lklCrearCuenta.AutoSize = true;
            lklCrearCuenta.LinkColor = Color.White;
            lklCrearCuenta.Location = new Point(398, 524);
            lklCrearCuenta.Name = "lklCrearCuenta";
            lklCrearCuenta.Size = new Size(50, 20);
            lklCrearCuenta.TabIndex = 19;
            lklCrearCuenta.TabStop = true;
            lklCrearCuenta.Text = "Volver";
            lklCrearCuenta.Click += lklCrearCuenta_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(37, 268);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(31, 20, 16);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Silver;
            txtUsuario.Location = new Point(306, 80);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(303, 36);
            txtUsuario.TabIndex = 2;
            txtUsuario.KeyPress += txtUsuario_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(91, 383);
            label4.Name = "label4";
            label4.Size = new Size(168, 35);
            label4.TabIndex = 26;
            label4.Text = "Tipo de usuario";
            // 
            // llblUsuario
            // 
            llblUsuario.AutoSize = true;
            llblUsuario.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llblUsuario.ForeColor = Color.White;
            llblUsuario.Location = new Point(95, 83);
            llblUsuario.Name = "llblUsuario";
            llblUsuario.Size = new Size(95, 35);
            llblUsuario.TabIndex = 12;
            llblUsuario.Text = "Usuario:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(37, 180);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 87);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClave.ForeColor = Color.White;
            lblClave.Location = new Point(95, 180);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(74, 35);
            lblClave.TabIndex = 15;
            lblClave.Text = "Clave:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1088, 651);
            Controls.Add(grbLogin);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            grbLogin.ResumeLayout(false);
            grbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbLogin;
        private Panel panelLinea2;
        private Label lblClavesNoCoinciden1;
        private Panel panelLinea1;
        private TextBox txtClave;
        private Label lblLetrasNumeros;
        private Label lblLogin;
        private LinkLabel lklCrearCuenta;
        private TextBox txtUsuario;
        private Label llblUsuario;
        private Button btnSingUp;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblClave;
        private Panel panel1;
        private Panel panel2;
        private Label lblClavesNoCoinciden2;
        private TextBox txtClaveConfirmar;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label4;
        private ComboBox cmbTiposUsuarios;
        private PictureBox pictureBox4;
        private Label lblExiste;
    }
}