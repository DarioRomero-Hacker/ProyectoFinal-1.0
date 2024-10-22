namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class Registrar_Cliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            btnInsertar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            txtTelefono = new TextBox();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(177, 71);
            label1.Name = "label1";
            label1.Size = new Size(72, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(170, 132);
            label2.Name = "label2";
            label2.Size = new Size(89, 28);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(170, 187);
            label3.Name = "label3";
            label3.Size = new Size(82, 26);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(31, 20, 16);
            txtNombre.BorderStyle = BorderStyle.None;
            txtNombre.ForeColor = Color.Silver;
            txtNombre.Location = new Point(295, 74);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 20);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.FromArgb(31, 20, 16);
            txtApellido.BorderStyle = BorderStyle.None;
            txtApellido.ForeColor = Color.Silver;
            txtApellido.Location = new Point(301, 129);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 20);
            txtApellido.TabIndex = 4;
            txtApellido.KeyPress += txtNombre_KeyPress;
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.FromArgb(31, 20, 16);
            txtDireccion.BorderStyle = BorderStyle.None;
            txtDireccion.ForeColor = Color.Silver;
            txtDireccion.Location = new Point(301, 190);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(119, 20);
            txtDireccion.TabIndex = 5;
            txtDireccion.TextChanged += txtStock_TextChanged;
            txtDireccion.KeyPress += txtNombre_KeyPress;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(31, 20, 16);
            btnInsertar.ForeColor = SystemColors.ControlLight;
            btnInsertar.Location = new Point(289, 307);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(125, 41);
            btnInsertar.TabIndex = 6;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(301, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 3);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(301, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(125, 3);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(301, 91);
            panel3.Name = "panel3";
            panel3.Size = new Size(119, 3);
            panel3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(170, 250);
            label4.Name = "label4";
            label4.Size = new Size(74, 26);
            label4.TabIndex = 10;
            label4.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(31, 20, 16);
            txtTelefono.BorderStyle = BorderStyle.None;
            txtTelefono.ForeColor = Color.Silver;
            txtTelefono.Location = new Point(295, 253);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(119, 20);
            txtTelefono.TabIndex = 11;
            txtTelefono.KeyPress += txtDireccion_KeyPress;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Location = new Point(295, 270);
            panel4.Name = "panel4";
            panel4.Size = new Size(125, 3);
            panel4.TabIndex = 12;
            // 
            // Registrar_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(641, 421);
            Controls.Add(panel4);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrar_Cliente";
            Text = "AgregarPorductos";
            KeyPress += txtNombre_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private Button btnInsertar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox txtTelefono;
        private Panel panel4;
    }
}