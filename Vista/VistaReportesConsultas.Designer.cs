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
            btn_MasVendido = new Button();
            btn_VentasFecha = new Button();
            btn_VentasProducto = new Button();
            btn_VentasVendedor = new Button();
            btn_Cerrar = new Button();
            panel2 = new Panel();
            btn_EstadoCuenta = new Button();
            label7 = new Label();
            txt_ID = new TextBox();
            btn_VentasSucursal = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(btn_MasVendido);
            panel1.Controls.Add(btn_VentasFecha);
            panel1.Controls.Add(btn_VentasProducto);
            panel1.Controls.Add(btn_VentasVendedor);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_VentasSucursal);
            panel1.Location = new Point(32, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(718, 360);
            panel1.TabIndex = 5;
            // 
            // btn_MasVendido
            // 
            btn_MasVendido.BackColor = Color.FromArgb(0, 0, 20);
            btn_MasVendido.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_MasVendido.ForeColor = SystemColors.ButtonHighlight;
            btn_MasVendido.Location = new Point(533, 235);
            btn_MasVendido.Name = "btn_MasVendido";
            btn_MasVendido.Size = new Size(161, 59);
            btn_MasVendido.TabIndex = 18;
            btn_MasVendido.Text = "Producto Más Vendido";
            btn_MasVendido.UseVisualStyleBackColor = false;
            btn_MasVendido.Click += btn_MasVendido_Click;
            // 
            // btn_VentasFecha
            // 
            btn_VentasFecha.BackColor = Color.FromArgb(0, 0, 20);
            btn_VentasFecha.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VentasFecha.ForeColor = SystemColors.ButtonHighlight;
            btn_VentasFecha.Location = new Point(233, 107);
            btn_VentasFecha.Name = "btn_VentasFecha";
            btn_VentasFecha.Size = new Size(161, 59);
            btn_VentasFecha.TabIndex = 17;
            btn_VentasFecha.Text = "Ventas Por Fecha";
            btn_VentasFecha.UseVisualStyleBackColor = false;
            btn_VentasFecha.Click += btn_VentasFecha_Click;
            // 
            // btn_VentasProducto
            // 
            btn_VentasProducto.BackColor = Color.FromArgb(0, 0, 20);
            btn_VentasProducto.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VentasProducto.ForeColor = SystemColors.ButtonHighlight;
            btn_VentasProducto.Location = new Point(29, 107);
            btn_VentasProducto.Name = "btn_VentasProducto";
            btn_VentasProducto.Size = new Size(161, 59);
            btn_VentasProducto.TabIndex = 16;
            btn_VentasProducto.Text = "Ventas Por Producto";
            btn_VentasProducto.UseVisualStyleBackColor = false;
            btn_VentasProducto.Click += btn_VentasProducto_Click;
            // 
            // btn_VentasVendedor
            // 
            btn_VentasVendedor.BackColor = Color.FromArgb(0, 0, 20);
            btn_VentasVendedor.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VentasVendedor.ForeColor = SystemColors.ButtonHighlight;
            btn_VentasVendedor.Location = new Point(233, 14);
            btn_VentasVendedor.Name = "btn_VentasVendedor";
            btn_VentasVendedor.Size = new Size(161, 59);
            btn_VentasVendedor.TabIndex = 15;
            btn_VentasVendedor.Text = "Ventas Por Vendedor";
            btn_VentasVendedor.UseVisualStyleBackColor = false;
            btn_VentasVendedor.Click += btn_VentasVendedor_Click;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(533, 14);
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
            panel2.Controls.Add(btn_EstadoCuenta);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_ID);
            panel2.Location = new Point(29, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(435, 96);
            panel2.TabIndex = 13;
            // 
            // btn_EstadoCuenta
            // 
            btn_EstadoCuenta.BackColor = Color.FromArgb(0, 0, 20);
            btn_EstadoCuenta.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_EstadoCuenta.ForeColor = SystemColors.ButtonHighlight;
            btn_EstadoCuenta.Location = new Point(21, 15);
            btn_EstadoCuenta.Name = "btn_EstadoCuenta";
            btn_EstadoCuenta.Size = new Size(161, 59);
            btn_EstadoCuenta.TabIndex = 13;
            btn_EstadoCuenta.Text = "Estado de cuenta";
            btn_EstadoCuenta.UseVisualStyleBackColor = false;
            btn_EstadoCuenta.Click += btn_EstadoCuenta_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.Cursor;
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 20);
            label7.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(368, 34);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(222, 32);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(125, 27);
            txt_ID.TabIndex = 14;
            // 
            // btn_VentasSucursal
            // 
            btn_VentasSucursal.BackColor = Color.FromArgb(0, 0, 20);
            btn_VentasSucursal.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_VentasSucursal.ForeColor = SystemColors.ButtonHighlight;
            btn_VentasSucursal.Location = new Point(29, 14);
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
            label2.Location = new Point(236, 35);
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
            ClientSize = new Size(782, 497);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "VistaReportesConsultas";
            Text = "VistaReportesConsultas";
            Load += VistaReportesConsultas_Load;
            panel1.ResumeLayout(false);
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
        private Button btn_EstadoCuenta;
        private Label label7;
        private TextBox txt_ID;
        private TextBox txt_Telefono;
        private Label label6;
        private Button btn_VentasSucursal;
        private Label label2;
        private Button btn_VentasVendedor;
        private Button btn_VentasFecha;
        private Button btn_VentasProducto;
        private Button btn_MasVendido;
    }
}