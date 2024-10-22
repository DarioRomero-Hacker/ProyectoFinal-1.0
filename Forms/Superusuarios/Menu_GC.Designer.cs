namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class Menu_GC
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_IngresarUsuario = new Button();
            btnShowUsers = new Button();
            dgvClientes = new DataGridView();
            Actualizar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            grp_filtro = new GroupBox();
            bnt_AplicarFiltro = new Button();
            txtFiltro = new TextBox();
            lbl_filtro = new Label();
            label2 = new Label();
            cmb_Filtros = new ComboBox();
            groupBox1 = new GroupBox();
            txt_telefono = new TextBox();
            txt_direccion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btn_GuardarCambios = new Button();
            txt_apellido = new TextBox();
            lbl_Clave = new Label();
            txt_Nombre = new TextBox();
            lbl_Usuario = new Label();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            grp_filtro.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_IngresarUsuario
            // 
            btn_IngresarUsuario.BackColor = Color.FromArgb(31, 20, 16);
            btn_IngresarUsuario.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btn_IngresarUsuario.ForeColor = Color.Silver;
            btn_IngresarUsuario.Location = new Point(177, 45);
            btn_IngresarUsuario.Margin = new Padding(3, 2, 3, 2);
            btn_IngresarUsuario.Name = "btn_IngresarUsuario";
            btn_IngresarUsuario.Size = new Size(162, 28);
            btn_IngresarUsuario.TabIndex = 1;
            btn_IngresarUsuario.Text = "Registrar cliente";
            btn_IngresarUsuario.UseVisualStyleBackColor = false;
            btn_IngresarUsuario.Click += btn_IngresarUsuario_Click;
            // 
            // btnShowUsers
            // 
            btnShowUsers.BackColor = Color.FromArgb(31, 20, 16);
            btnShowUsers.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btnShowUsers.ForeColor = Color.Silver;
            btnShowUsers.Location = new Point(10, 44);
            btnShowUsers.Margin = new Padding(3, 2, 3, 2);
            btnShowUsers.Name = "btnShowUsers";
            btnShowUsers.Size = new Size(161, 29);
            btnShowUsers.TabIndex = 3;
            btnShowUsers.Text = "Mostrar Clientes";
            btnShowUsers.UseVisualStyleBackColor = false;
            btnShowUsers.Click += btn_showClientes_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Actualizar, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.Location = new Point(10, 79);
            dgvClientes.Margin = new Padding(3, 2, 3, 2);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(917, 359);
            dgvClientes.TabIndex = 5;
            dgvClientes.CellClick += dgvClientes_CellClick;
            // 
            // Actualizar
            // 
            Actualizar.HeaderText = "Actualizar";
            Actualizar.MinimumWidth = 6;
            Actualizar.Name = "Actualizar";
            Actualizar.ReadOnly = true;
            Actualizar.Text = "Actualizar/Editar";
            Actualizar.UseColumnTextForButtonValue = true;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Text = "Eliminar";
            Eliminar.UseColumnTextForButtonValue = true;
            // 
            // grp_filtro
            // 
            grp_filtro.BackColor = Color.FromArgb(31, 20, 16);
            grp_filtro.Controls.Add(bnt_AplicarFiltro);
            grp_filtro.Controls.Add(txtFiltro);
            grp_filtro.Controls.Add(lbl_filtro);
            grp_filtro.Controls.Add(label2);
            grp_filtro.Controls.Add(cmb_Filtros);
            grp_filtro.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            grp_filtro.ForeColor = SystemColors.ButtonHighlight;
            grp_filtro.Location = new Point(954, 301);
            grp_filtro.Margin = new Padding(3, 2, 3, 2);
            grp_filtro.Name = "grp_filtro";
            grp_filtro.Padding = new Padding(3, 2, 3, 2);
            grp_filtro.Size = new Size(331, 164);
            grp_filtro.TabIndex = 6;
            grp_filtro.TabStop = false;
            grp_filtro.Text = "Filtros";
            grp_filtro.Visible = false;
            // 
            // bnt_AplicarFiltro
            // 
            bnt_AplicarFiltro.BackColor = Color.FromArgb(31, 20, 16);
            bnt_AplicarFiltro.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_AplicarFiltro.ForeColor = Color.Silver;
            bnt_AplicarFiltro.Location = new Point(93, 108);
            bnt_AplicarFiltro.Margin = new Padding(3, 2, 3, 2);
            bnt_AplicarFiltro.Name = "bnt_AplicarFiltro";
            bnt_AplicarFiltro.Size = new Size(135, 36);
            bnt_AplicarFiltro.TabIndex = 4;
            bnt_AplicarFiltro.Text = "Aplicar Filtro";
            bnt_AplicarFiltro.UseVisualStyleBackColor = false;
            bnt_AplicarFiltro.Click += bnt_AplicarFiltro_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(31, 20, 16);
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtFiltro.ForeColor = Color.Silver;
            txtFiltro.Location = new Point(168, 66);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(132, 29);
            txtFiltro.TabIndex = 3;
            txtFiltro.Visible = false;
            // 
            // lbl_filtro
            // 
            lbl_filtro.AutoSize = true;
            lbl_filtro.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_filtro.ForeColor = Color.Silver;
            lbl_filtro.Location = new Point(16, 72);
            lbl_filtro.Name = "lbl_filtro";
            lbl_filtro.Size = new Size(22, 21);
            lbl_filtro.TabIndex = 2;
            lbl_filtro.Text = "....";
            lbl_filtro.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(16, 32);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Tipo de filtro";
            // 
            // cmb_Filtros
            // 
            cmb_Filtros.BackColor = SystemColors.ButtonHighlight;
            cmb_Filtros.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Filtros.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmb_Filtros.ForeColor = Color.Silver;
            cmb_Filtros.FormattingEnabled = true;
            cmb_Filtros.Items.AddRange(new object[] { "Por nombre(A-Z)", "Por nombre(Z-A)", "Por apellido(A-Z)", "Por apellido(Z-A)", "Por direccion", "Por Id", "Por telefono" });
            cmb_Filtros.Location = new Point(168, 25);
            cmb_Filtros.Margin = new Padding(3, 2, 3, 2);
            cmb_Filtros.Name = "cmb_Filtros";
            cmb_Filtros.Size = new Size(133, 29);
            cmb_Filtros.TabIndex = 0;
            cmb_Filtros.TextChanged += cmb_Filtros_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(31, 20, 16);
            groupBox1.Controls.Add(txt_telefono);
            groupBox1.Controls.Add(txt_direccion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btn_GuardarCambios);
            groupBox1.Controls.Add(txt_apellido);
            groupBox1.Controls.Add(lbl_Clave);
            groupBox1.Controls.Add(txt_Nombre);
            groupBox1.Controls.Add(lbl_Usuario);
            groupBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(954, 79);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(331, 218);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // txt_telefono
            // 
            txt_telefono.BackColor = Color.FromArgb(31, 20, 16);
            txt_telefono.BorderStyle = BorderStyle.FixedSingle;
            txt_telefono.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_telefono.ForeColor = Color.Silver;
            txt_telefono.Location = new Point(145, 138);
            txt_telefono.Margin = new Padding(3, 2, 3, 2);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(110, 29);
            txt_telefono.TabIndex = 13;
            // 
            // txt_direccion
            // 
            txt_direccion.BackColor = Color.FromArgb(31, 20, 16);
            txt_direccion.BorderStyle = BorderStyle.FixedSingle;
            txt_direccion.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_direccion.ForeColor = Color.Silver;
            txt_direccion.Location = new Point(145, 98);
            txt_direccion.Margin = new Padding(3, 2, 3, 2);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(110, 29);
            txt_direccion.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(26, 138);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 11;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(26, 104);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 10;
            label3.Text = "Direccion";
            // 
            // btn_GuardarCambios
            // 
            btn_GuardarCambios.BackColor = Color.FromArgb(31, 20, 16);
            btn_GuardarCambios.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GuardarCambios.ForeColor = Color.Silver;
            btn_GuardarCambios.Location = new Point(93, 173);
            btn_GuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btn_GuardarCambios.Name = "btn_GuardarCambios";
            btn_GuardarCambios.Size = new Size(132, 41);
            btn_GuardarCambios.TabIndex = 9;
            btn_GuardarCambios.Text = "Guardar Cambios";
            btn_GuardarCambios.UseVisualStyleBackColor = false;
            btn_GuardarCambios.Click += btn_GuardarCambios_Click;
            // 
            // txt_apellido
            // 
            txt_apellido.BackColor = Color.FromArgb(31, 20, 16);
            txt_apellido.BorderStyle = BorderStyle.FixedSingle;
            txt_apellido.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_apellido.ForeColor = Color.Silver;
            txt_apellido.Location = new Point(145, 59);
            txt_apellido.Margin = new Padding(3, 2, 3, 2);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(110, 29);
            txt_apellido.TabIndex = 8;
            // 
            // lbl_Clave
            // 
            lbl_Clave.AutoSize = true;
            lbl_Clave.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_Clave.ForeColor = Color.Silver;
            lbl_Clave.Location = new Point(26, 64);
            lbl_Clave.Name = "lbl_Clave";
            lbl_Clave.Size = new Size(57, 21);
            lbl_Clave.TabIndex = 6;
            lbl_Clave.Text = "Apellido";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.FromArgb(31, 20, 16);
            txt_Nombre.BorderStyle = BorderStyle.FixedSingle;
            txt_Nombre.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_Nombre.ForeColor = Color.Silver;
            txt_Nombre.Location = new Point(145, 20);
            txt_Nombre.Margin = new Padding(3, 2, 3, 2);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(110, 29);
            txt_Nombre.TabIndex = 1;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_Usuario.ForeColor = Color.Silver;
            lbl_Usuario.Location = new Point(26, 26);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(58, 21);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "Nombre";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(465, 9);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(210, 43);
            lblMensaje.TabIndex = 14;
            lblMensaje.Text = "Gestion Clientes";
            // 
            // Menu_GC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1199, 476);
            Controls.Add(lblMensaje);
            Controls.Add(groupBox1);
            Controls.Add(grp_filtro);
            Controls.Add(dgvClientes);
            Controls.Add(btnShowUsers);
            Controls.Add(btn_IngresarUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu_GC";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            grp_filtro.ResumeLayout(false);
            grp_filtro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_IngresarUsuario;
        private Button btnShowUsers;
        private DataGridView dgvClientes;
        private GroupBox grp_filtro;
        private ComboBox cmb_Filtros;
        private Label label2;
        private Button bnt_AplicarFiltro;
        private TextBox txtFiltro;
        private Label lbl_filtro;
        private DataGridViewButtonColumn Actualizar;
        private DataGridViewButtonColumn Eliminar;
        private GroupBox groupBox1;
        private Label lbl_Usuario;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_Nombre;
        private Label label6;
        private Label lbl_Clave;
        private TextBox txt_apellido;
        private Button btn_GuardarCambios;
        private TextBox txt_direccion;
        private Label label4;
        private Label label3;
        private TextBox txt_telefono;
        private Label lblMensaje;
    }
}