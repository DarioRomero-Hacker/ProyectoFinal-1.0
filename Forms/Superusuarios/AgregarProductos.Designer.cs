namespace ProyectoFinal_1._0.Gestion_Productos
{
    partial class AgregarProductos
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
            txtProducto = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            btnInsertar = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
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
            label1.Size = new Size(81, 26);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(177, 142);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(177, 205);
            label3.Name = "label3";
            label3.Size = new Size(54, 26);
            label3.TabIndex = 2;
            label3.Text = "Stock";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(31, 20, 16);
            txtProducto.BorderStyle = BorderStyle.None;
            txtProducto.ForeColor = Color.Silver;
            txtProducto.Location = new Point(295, 74);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(125, 20);
            txtProducto.TabIndex = 3;
            txtProducto.KeyPress += txt_Producto_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.FromArgb(31, 20, 16);
            txtPrecio.BorderStyle = BorderStyle.None;
            txtPrecio.ForeColor = Color.Silver;
            txtPrecio.Location = new Point(295, 146);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 20);
            txtPrecio.TabIndex = 4;
            txtPrecio.KeyPress += txt_Producto_KeyPress_decimales;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.FromArgb(31, 20, 16);
            txtStock.BorderStyle = BorderStyle.None;
            txtStock.ForeColor = Color.Silver;
            txtStock.Location = new Point(295, 208);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(119, 20);
            txtStock.TabIndex = 5;
            txtStock.TextChanged += txtStock_TextChanged;
            txtStock.KeyPress += txtEntero_KeyPress;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(31, 20, 16);
            btnInsertar.ForeColor = SystemColors.ControlLight;
            btnInsertar.Location = new Point(295, 282);
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
            panel1.Location = new Point(295, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(119, 3);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(295, 163);
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
            // AgregarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            ClientSize = new Size(641, 421);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnInsertar);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtProducto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgregarProductos";
            Text = "AgregarPorductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtProducto;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Button btnInsertar;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}