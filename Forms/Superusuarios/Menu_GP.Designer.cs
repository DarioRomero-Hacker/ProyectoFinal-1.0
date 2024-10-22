namespace ProyectoFinal_1._0.Gestion_Productos
{
    partial class Menu_GP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_GP));
            btn_IngresarProducts = new Button();
            btn_ShowProducts = new Button();
            dgvProductos = new DataGridView();
            Actualizar = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            grp_filtro = new GroupBox();
            bnt_AplicarFiltro = new Button();
            txtFiltro = new TextBox();
            lbl_filtro = new Label();
            label2 = new Label();
            cmb_Filtros = new ComboBox();
            groupBox1 = new GroupBox();
            btn_GuardarCambios = new Button();
            txt_precio = new TextBox();
            txt_stock = new TextBox();
            lbl_Precio = new Label();
            lbl_stock = new Label();
            txt_Producto = new TextBox();
            lbl_producto = new Label();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            grp_filtro.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_IngresarProducts
            // 
            btn_IngresarProducts.BackColor = Color.FromArgb(31, 20, 16);
            btn_IngresarProducts.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btn_IngresarProducts.ForeColor = Color.Silver;
            btn_IngresarProducts.Location = new Point(178, 64);
            btn_IngresarProducts.Margin = new Padding(3, 2, 3, 2);
            btn_IngresarProducts.Name = "btn_IngresarProducts";
            btn_IngresarProducts.Size = new Size(162, 39);
            btn_IngresarProducts.TabIndex = 1;
            btn_IngresarProducts.Text = "Ingresar Producto";
            btn_IngresarProducts.UseVisualStyleBackColor = false;
            btn_IngresarProducts.Click += btn_IngresarProducts_Click;
            // 
            // btn_ShowProducts
            // 
            btn_ShowProducts.BackColor = Color.FromArgb(31, 20, 16);
            btn_ShowProducts.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            btn_ShowProducts.ForeColor = Color.Silver;
            btn_ShowProducts.Location = new Point(11, 64);
            btn_ShowProducts.Margin = new Padding(3, 2, 3, 2);
            btn_ShowProducts.Name = "btn_ShowProducts";
            btn_ShowProducts.Size = new Size(161, 39);
            btn_ShowProducts.TabIndex = 3;
            btn_ShowProducts.Text = "Mostrar Productos";
            btn_ShowProducts.UseVisualStyleBackColor = false;
            btn_ShowProducts.Click += btn_ShowProducts_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 20, 16);
            dataGridViewCellStyle1.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkSalmon;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Actualizar, Eliminar });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.Location = new Point(11, 109);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(917, 369);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellClick += dgvProductos_CellClick;
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
            grp_filtro.Location = new Point(955, 319);
            grp_filtro.Margin = new Padding(3, 2, 3, 2);
            grp_filtro.Name = "grp_filtro";
            grp_filtro.Padding = new Padding(3, 2, 3, 2);
            grp_filtro.Size = new Size(331, 159);
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
            bnt_AplicarFiltro.Location = new Point(102, 110);
            bnt_AplicarFiltro.Margin = new Padding(3, 2, 3, 2);
            bnt_AplicarFiltro.Name = "bnt_AplicarFiltro";
            bnt_AplicarFiltro.Size = new Size(135, 39);
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
            txtFiltro.Location = new Point(168, 67);
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
            cmb_Filtros.Items.AddRange(new object[] { "Por nombre", "Por ID", "Menor precio", "Mayor precio", "Sin filtro(Todos)" });
            cmb_Filtros.Location = new Point(168, 26);
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
            groupBox1.Controls.Add(txt_precio);
            groupBox1.Controls.Add(txt_stock);
            groupBox1.Controls.Add(lbl_Precio);
            groupBox1.Controls.Add(lbl_stock);
            groupBox1.Controls.Add(txt_Producto);
            groupBox1.Controls.Add(lbl_producto);
            groupBox1.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(955, 109);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(331, 206);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // btn_GuardarCambios
            // 
            btn_GuardarCambios.BackColor = Color.FromArgb(31, 20, 16);
            btn_GuardarCambios.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GuardarCambios.ForeColor = Color.Silver;
            btn_GuardarCambios.Location = new Point(102, 146);
            btn_GuardarCambios.Margin = new Padding(3, 2, 3, 2);
            btn_GuardarCambios.Name = "btn_GuardarCambios";
            btn_GuardarCambios.Size = new Size(132, 43);
            btn_GuardarCambios.TabIndex = 9;
            btn_GuardarCambios.Text = "Guardar Cambios";
            btn_GuardarCambios.UseVisualStyleBackColor = false;
            btn_GuardarCambios.Click += btn_GuardarCambios_Click;
            // 
            // txt_precio
            // 
            txt_precio.BackColor = Color.FromArgb(31, 20, 16);
            txt_precio.BorderStyle = BorderStyle.FixedSingle;
            txt_precio.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_precio.ForeColor = Color.Silver;
            txt_precio.Location = new Point(145, 59);
            txt_precio.Margin = new Padding(3, 2, 3, 2);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(110, 29);
            txt_precio.TabIndex = 8;
            txt_precio.KeyPress += txt_Producto_KeyPress_decimales;
            // 
            // txt_stock
            // 
            txt_stock.BackColor = Color.FromArgb(31, 20, 16);
            txt_stock.BorderStyle = BorderStyle.FixedSingle;
            txt_stock.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_stock.ForeColor = Color.Silver;
            txt_stock.Location = new Point(145, 101);
            txt_stock.Margin = new Padding(3, 2, 3, 2);
            txt_stock.Name = "txt_stock";
            txt_stock.Size = new Size(110, 29);
            txt_stock.TabIndex = 7;
            txt_stock.KeyPress += txtEntero_KeyPress;
            // 
            // lbl_Precio
            // 
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_Precio.ForeColor = Color.Silver;
            lbl_Precio.Location = new Point(26, 64);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(46, 21);
            lbl_Precio.TabIndex = 6;
            lbl_Precio.Text = "Precio";
            // 
            // lbl_stock
            // 
            lbl_stock.AutoSize = true;
            lbl_stock.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_stock.ForeColor = Color.Silver;
            lbl_stock.Location = new Point(26, 104);
            lbl_stock.Name = "lbl_stock";
            lbl_stock.Size = new Size(44, 21);
            lbl_stock.TabIndex = 5;
            lbl_stock.Text = "Stock";
            // 
            // txt_Producto
            // 
            txt_Producto.BackColor = Color.FromArgb(31, 20, 16);
            txt_Producto.BorderStyle = BorderStyle.FixedSingle;
            txt_Producto.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            txt_Producto.ForeColor = Color.Silver;
            txt_Producto.Location = new Point(145, 20);
            txt_Producto.Margin = new Padding(3, 2, 3, 2);
            txt_Producto.Name = "txt_Producto";
            txt_Producto.Size = new Size(110, 29);
            txt_Producto.TabIndex = 1;
            txt_Producto.KeyPress += txt_Producto_KeyPress;
            // 
            // lbl_producto
            // 
            lbl_producto.AutoSize = true;
            lbl_producto.Font = new Font("Segoe Print", 9F, FontStyle.Bold);
            lbl_producto.ForeColor = Color.Silver;
            lbl_producto.Location = new Point(26, 26);
            lbl_producto.Name = "lbl_producto";
            lbl_producto.Size = new Size(65, 21);
            lbl_producto.TabIndex = 0;
            lbl_producto.Text = "Producto";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.BackColor = Color.FromArgb(86, 42, 20);
            lblMensaje.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(495, 21);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(239, 43);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Gestion Productos";
            // 
            // Menu_GP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1306, 504);
            Controls.Add(lblMensaje);
            Controls.Add(groupBox1);
            Controls.Add(grp_filtro);
            Controls.Add(dgvProductos);
            Controls.Add(btn_ShowProducts);
            Controls.Add(btn_IngresarProducts);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu_GP";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            grp_filtro.ResumeLayout(false);
            grp_filtro.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_IngresarProducts;
        private Button btn_ShowProducts;
        private DataGridView dgvProductos;
        private GroupBox grp_filtro;
        private ComboBox cmb_Filtros;
        private Label label2;
        private Button bnt_AplicarFiltro;
        private TextBox txtFiltro;
        private Label lbl_filtro;
        private DataGridViewButtonColumn Actualizar;
        private DataGridViewButtonColumn Eliminar;
        private GroupBox groupBox1;
        private Label lbl_producto;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox txt_Producto;
        private Label label6;
        private Label lbl_Precio;
        private Label lbl_stock;
        private TextBox txt_precio;
        private TextBox txt_stock;
        private Button btn_GuardarCambios;
        private Label lblMensaje;
    }
}