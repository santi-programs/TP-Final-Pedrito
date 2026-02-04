namespace Vista
{
    partial class VistaReportesConsultas
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
            cbo_Sucursal = new ComboBox();
            btn_Cerrar = new Button();
            panel2 = new Panel();
            btn_Historial = new Button();
            label8 = new Label();
            txt_precio = new TextBox();
            btn_Descuento = new Button();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            label7 = new Label();
            txt_ID = new TextBox();
            txt_Telefono = new TextBox();
            label6 = new Label();
            btn_VentasSucursal = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(cbo_Sucursal);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_Telefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_VentasSucursal);
            panel1.Location = new Point(32, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 432);
            panel1.TabIndex = 5;
            // 
            // cbo_Sucursal
            // 
            cbo_Sucursal.FormattingEnabled = true;
            cbo_Sucursal.Location = new Point(29, 31);
            cbo_Sucursal.Name = "cbo_Sucursal";
            cbo_Sucursal.Size = new Size(151, 28);
            cbo_Sucursal.TabIndex = 15;
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
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(btn_Historial);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_precio);
            panel2.Controls.Add(btn_Descuento);
            panel2.Controls.Add(btn_Eliminar);
            panel2.Controls.Add(btn_Modificar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_ID);
            panel2.Location = new Point(29, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 160);
            panel2.TabIndex = 13;
            // 
            // btn_Historial
            // 
            btn_Historial.BackColor = Color.FromArgb(0, 0, 20);
            btn_Historial.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Historial.ForeColor = SystemColors.ButtonHighlight;
            btn_Historial.Location = new Point(223, 15);
            btn_Historial.Name = "btn_Historial";
            btn_Historial.Size = new Size(161, 59);
            btn_Historial.TabIndex = 19;
            btn_Historial.Text = "Historial";
            btn_Historial.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.Cursor;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 20);
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(772, 108);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 18;
            label8.Text = "Precio";
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(632, 106);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(125, 27);
            txt_precio.TabIndex = 17;
            // 
            // btn_Descuento
            // 
            btn_Descuento.BackColor = Color.FromArgb(0, 0, 20);
            btn_Descuento.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Descuento.ForeColor = SystemColors.ButtonHighlight;
            btn_Descuento.Location = new Point(661, 25);
            btn_Descuento.Name = "btn_Descuento";
            btn_Descuento.Size = new Size(161, 59);
            btn_Descuento.TabIndex = 11;
            btn_Descuento.Text = "Descuento";
            btn_Descuento.UseVisualStyleBackColor = false;
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
            // txt_Telefono
            // 
            txt_Telefono.Location = new Point(29, 219);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(125, 27);
            txt_Telefono.TabIndex = 4;
            // 
            // label6
            // 
            label6.AccessibleRole = AccessibleRole.Cursor;
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(169, 221);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            // 
            // btn_VentasSucursal
            // 
            btn_VentasSucursal.BackColor = Color.FromArgb(0, 0, 20);
            btn_VentasSucursal.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VentasSucursal.ForeColor = SystemColors.ButtonHighlight;
            btn_VentasSucursal.Location = new Point(216, 14);
            btn_VentasSucursal.Name = "btn_VentasSucursal";
            btn_VentasSucursal.Size = new Size(161, 59);
            btn_VentasSucursal.TabIndex = 10;
            btn_VentasSucursal.Text = "Ventas Por Sucursal";
            btn_VentasSucursal.UseVisualStyleBackColor = false;
            btn_VentasSucursal.Click += btn_VentasSucursal_Click;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.Cursor;
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(370, 39);
            label2.Name = "label2";
            label2.Size = new Size(290, 28);
            label2.TabIndex = 4;
            label2.Text = "Reportes Y Consultas";
            // 
            // VistaReportesConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1021, 553);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "VistaReportesConsultas";
            Text = "VistaReportesConsultas";
            Load += VistaReportesConsultas_Load;
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
        private Button btn_Historial;
        private Label label8;
        private TextBox txt_precio;
        private Button btn_Descuento;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Label label7;
        private TextBox txt_ID;
        private TextBox txt_Telefono;
        private Label label6;
        private Button btn_VentasSucursal;
        private Label label2;
        private ComboBox cbo_Sucursal;
    }
}