namespace Vista
{
    partial class VistaProducto
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
            panel1 = new Panel();
            txt_Stock = new TextBox();
            txt_Precio = new TextBox();
            txt_Sucursal = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            txt_IdCategoria = new TextBox();
            label4 = new Label();
            btn_Cerrar = new Button();
            panel2 = new Panel();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            label7 = new Label();
            txt_ID = new TextBox();
            btn_BuscarPorSucursal = new Button();
            btn_Agregar = new Button();
            txt_Descripcion = new TextBox();
            label3 = new Label();
            txt_Nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(txt_Stock);
            panel1.Controls.Add(txt_Precio);
            panel1.Controls.Add(txt_Sucursal);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_IdCategoria);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_BuscarPorSucursal);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(txt_Descripcion);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 456);
            panel1.TabIndex = 4;
            // 
            // txt_Stock
            // 
            txt_Stock.Location = new Point(24, 296);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(191, 27);
            txt_Stock.TabIndex = 29;
            // 
            // txt_Precio
            // 
            txt_Precio.Location = new Point(24, 245);
            txt_Precio.Name = "txt_Precio";
            txt_Precio.Size = new Size(191, 27);
            txt_Precio.TabIndex = 28;
            // 
            // txt_Sucursal
            // 
            txt_Sucursal.Location = new Point(24, 344);
            txt_Sucursal.Name = "txt_Sucursal";
            txt_Sucursal.Size = new Size(191, 27);
            txt_Sucursal.TabIndex = 27;
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.Cursor;
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(231, 344);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 26;
            label10.Text = "Sucursal";
            // 
            // label9
            // 
            label9.AccessibleRole = AccessibleRole.Cursor;
            label9.AutoSize = true;
            label9.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(231, 296);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 24;
            label9.Text = "Stock";
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.Cursor;
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(231, 247);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 22;
            label6.Text = "Precio";
            // 
            // txt_IdCategoria
            // 
            txt_IdCategoria.Location = new Point(24, 193);
            txt_IdCategoria.Name = "txt_IdCategoria";
            txt_IdCategoria.Size = new Size(191, 27);
            txt_IdCategoria.TabIndex = 21;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Cursor;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(231, 193);
            label4.Name = "label4";
            label4.Size = new Size(174, 20);
            label4.TabIndex = 20;
            label4.Text = "Id De Categoría";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(755, 14);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(161, 59);
            btn_Cerrar.TabIndex = 14;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(btn_Eliminar);
            panel2.Controls.Add(btn_Modificar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_ID);
            panel2.Location = new Point(462, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 160);
            panel2.TabIndex = 13;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Eliminar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Eliminar.ForeColor = SystemColors.ButtonHighlight;
            btn_Eliminar.Location = new Point(21, 89);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(161, 59);
            btn_Eliminar.TabIndex = 16;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.UseVisualStyleBackColor = false;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Modificar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Modificar.ForeColor = SystemColors.ButtonHighlight;
            btn_Modificar.Location = new Point(21, 15);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(161, 59);
            btn_Modificar.TabIndex = 13;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Cursor;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 20);
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(363, 108);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(223, 106);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(125, 27);
            txt_ID.TabIndex = 14;
            // 
            // btn_BuscarPorSucursal
            // 
            btn_BuscarPorSucursal.BackColor = Color.FromArgb(0, 0, 20);
            btn_BuscarPorSucursal.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_BuscarPorSucursal.ForeColor = SystemColors.ButtonHighlight;
            btn_BuscarPorSucursal.Location = new Point(695, 366);
            btn_BuscarPorSucursal.Name = "btn_BuscarPorSucursal";
            btn_BuscarPorSucursal.Size = new Size(161, 59);
            btn_BuscarPorSucursal.TabIndex = 11;
            btn_BuscarPorSucursal.Text = "Buscar Por Sucursal";
            btn_BuscarPorSucursal.UseVisualStyleBackColor = false;
            btn_BuscarPorSucursal.Click += btn_BuscarPorSucursal_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(471, 366);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(161, 59);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // txt_Descripcion
            // 
            txt_Descripcion.Location = new Point(24, 66);
            txt_Descripcion.Multiline = true;
            txt_Descripcion.Name = "txt_Descripcion";
            txt_Descripcion.Size = new Size(191, 109);
            txt_Descripcion.TabIndex = 4;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Cursor;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(231, 68);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(24, 20);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(191, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Cursor;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 22);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.Cursor;
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(371, 32);
            label2.Name = "label2";
            label2.Size = new Size(292, 28);
            label2.TabIndex = 5;
            label2.Text = "Gestión De Productos";
            // 
            // VistaProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1006, 553);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "VistaProducto";
            Text = "VistaProducto";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_Cerrar;
        private Panel panel2;
        private Label label8;
        private TextBox txt_precio;
        private Button btn_BuscarPorSucursal;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Label label7;
        private TextBox txt_ID;
        private Button btn_Agregar;
        private TextBox txt_Descripcion;
        private Label label3;
        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txt_IdCategoria;
        private TextBox textBox2;
        private Label label9;
        private TextBox txt_Precio;
        private Label label6;
        private TextBox txt_Sucursal;
        private Label label10;
        private TextBox txt_Stock;
    }
}