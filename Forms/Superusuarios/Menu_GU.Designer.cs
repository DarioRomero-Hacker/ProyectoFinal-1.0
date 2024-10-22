namespace ProyectoFinal_1._0.Forms.Superusuarios
{
    partial class Menu_GU
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btn_IngresarUsuario = new Button();
            btnShowUsers = new Button();
            dgvUsuarios = new DataGridView();
            Actualizar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            grp_filtro = new GroupBox();
            cmb_tipoUser = new ComboBox();
            label3 = new Label();
            bnt_AplicarFiltro = new Button();
            txtFiltro = new TextBox();
            lbl_filtro = new Label();
            label2 = new Label();
            cmb_Filtros = new ComboBox();
            groupBox1 = new GroupBox();
            btn_GuardarCambios = new Button();
            txt_clave = new TextBox();
            lbl_Clave = new Label();
            txt_Usuario = new TextBox();
            lbl_Usuario = new Label();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
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
            btn_IngresarUsuario.Text = "Registrar usuario";
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
            btnShowUsers.Text = "Mostrar Usuarios";
            btnShowUsers.UseVisualStyleBackColor = false;
            btnShowUsers.Click += btn_btnShowUsers_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { Actualizar, Eliminar });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.MenuText;
            dataGridViewCellStyle4.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle4;
            dgvUsuarios.Location = new Point(10, 79);
            dgvUsuarios.Margin = new Padding(3, 2, 3, 2);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(917, 359);
            dgvUsuarios.TabIndex = 5;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
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
            grp_filtro.Controls.Add(cmb_tipoUser);
            grp_filtro.Controls.Add(label3);
            grp_filtro.Controls.Add(bnt_AplicarFiltro);
            grp_filtro.Controls.Add(txtFiltro);
            grp_filtro.Controls.Add(lbl_filtro);
            grp_filtro.Controls.Add(label2);
            grp_filtro.Controls.Add(cmb_Filtros);
            grp_filtro.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            grp_filtro.ForeColor = SystemColors.ButtonHighlight;
            grp_filtro.Location = new Point(954, 230);
            grp_filtro.Margin = new Padding(3, 2, 3, 2);
            grp_filtro.Name = "grp_filtro";
            grp_filtro.Padding = new Padding(3, 2, 3, 2);
            grp_filtro.Size = new Size(331, 208);
            grp_filtro.TabIndex = 6;
            grp_filtro.TabStop = false;
            grp_filtro.Text = "Filtros";
            grp_filtro.Visible = false;
            // 
            // cmb_tipoUser
            // 
            cmb_tipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipoUser.FormattingEnabled = true;
            cmb_tipoUser.Items.AddRange(new object[] { "Superusuario", "Administrador", "Usuario Comun" });
            cmb_tipoUser.Location = new Point(168, 110);
            cmb_tipoUser.Margin = new Padding(3, 2, 3, 2);
            cmb_tipoUser.Name = "cmb_tipoUser";
            cmb_tipoUser.Size = new Size(133, 29);
            cmb_tipoUser.TabIndex = 6;
            cmb_tipoUser.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 116);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 5;
            label3.Text = "Tipo de usuario";
            // 
            // bnt_AplicarFiltro
            // 
            bnt_AplicarFiltro.BackColor = Color.FromArgb(31, 20, 16);
            bnt_AplicarFiltro.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_AplicarFiltro.ForeColor = Color.Silver;
            bnt_AplicarFiltro.Location = new Point(93, 164);
            bnt_AplicarFiltro.Margin = new Padding(3, 2, 3, 2);
            bnt_AplicarFiltro.Name = "bnt_AplicarFiltro";
            bnt_AplicarFiltro.Size = new Size(135, 29);
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
            cmb_Filtros.Items.AddRange(new object[] { "Por nombre de usuario", "Por tipo de usuario", "Por ID", "Sin filtro(Todos)" });
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
            groupBox1.Controls.Add(btn_GuardarCambios);
            groupBox1.Controls.Add(txt_clave);
            groupBox1.Controls.Add(lbl_Clave);
            groupBox1.Controls.Add(txt_Usuario);
            groupBox1.Controls.Add(lbl_Usuario);
            groupBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(954, 79);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(331, 146);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // btn_GuardarCambios
            // 
            btn_GuardarCambios.BackColor = Color.FromArgb(31, 20, 16);
            btn_GuardarCambios.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GuardarCambios.ForeColor = Color.Silver;
            btn_GuardarCambios.Location = new Point(93, 101);
            btn_GuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btn_GuardarCambios.Name = "btn_GuardarCambios";
            btn_GuardarCambios.Size = new Size(132, 32);
            btn_GuardarCambios.TabIndex = 9;
            btn_GuardarCambios.Text = "Guardar Cambios";
            btn_GuardarCambios.UseVisualStyleBackColor = false;
            btn_GuardarCambios.Click += btn_GuardarCambios_Click;
            // 
            // txt_clave
            // 
            txt_clave.BackColor = Color.FromArgb(31, 20, 16);
            txt_clave.BorderStyle = BorderStyle.FixedSingle;
            txt_clave.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_clave.ForeColor = Color.Silver;
            txt_clave.Location = new Point(145, 59);
            txt_clave.Margin = new Padding(3, 2, 3, 2);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(110, 29);
            txt_clave.TabIndex = 8;
            // 
            // lbl_Clave
            // 
            lbl_Clave.AutoSize = true;
            lbl_Clave.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_Clave.ForeColor = Color.Silver;
            lbl_Clave.Location = new Point(26, 64);
            lbl_Clave.Name = "lbl_Clave";
            lbl_Clave.Size = new Size(41, 21);
            lbl_Clave.TabIndex = 6;
            lbl_Clave.Text = "Clave";
            // 
            // txt_Usuario
            // 
            txt_Usuario.BackColor = Color.FromArgb(31, 20, 16);
            txt_Usuario.BorderStyle = BorderStyle.FixedSingle;
            txt_Usuario.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_Usuario.ForeColor = Color.Silver;
            txt_Usuario.Location = new Point(145, 20);
            txt_Usuario.Margin = new Padding(3, 2, 3, 2);
            txt_Usuario.Name = "txt_Usuario";
            txt_Usuario.Size = new Size(110, 29);
            txt_Usuario.TabIndex = 1;
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_Usuario.ForeColor = Color.Silver;
            lbl_Usuario.Location = new Point(26, 26);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(54, 21);
            lbl_Usuario.TabIndex = 0;
            lbl_Usuario.Text = "Usuario";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(408, 9);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(219, 43);
            lblMensaje.TabIndex = 11;
            lblMensaje.Text = "Gestion Usuarios";
            // 
            // Menu_GU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(1289, 476);
            Controls.Add(lblMensaje);
            Controls.Add(groupBox1);
            Controls.Add(grp_filtro);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnShowUsers);
            Controls.Add(btn_IngresarUsuario);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu_GU";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
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
        private DataGridView dgvUsuarios;
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
        private TextBox txt_Usuario;
        private Label label6;
        private Label lbl_Clave;
        private TextBox txt_clave;
        private Button btn_GuardarCambios;
        private ComboBox cmb_tipoUser;
        private Label label3;
        private Label lblMensaje;
    }
}