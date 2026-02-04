namespace Vista
{
    partial class VistaVenta
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
            btn_Factura = new Button();
            label10 = new Label();
            btn_Descuento = new Button();
            dtp_Fecha = new DateTimePicker();
            cbo_MetodoPago = new ComboBox();
            btn_Cerrar = new Button();
            panel2 = new Panel();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            label7 = new Label();
            txt_ID = new TextBox();
            txt_Cantidad = new TextBox();
            label6 = new Label();
            btn_Agregar = new Button();
            label5 = new Label();
            label4 = new Label();
            txt_Monto = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(dtp_Fecha);
            panel1.Controls.Add(cbo_MetodoPago);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_Cantidad);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Monto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 432);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // btn_Factura
            // 
            btn_Factura.BackColor = Color.FromArgb(0, 0, 20);
            btn_Factura.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Factura.ForeColor = SystemColors.ButtonHighlight;
            btn_Factura.Location = new Point(401, 89);
            btn_Factura.Name = "btn_Factura";
            btn_Factura.Size = new Size(161, 59);
            btn_Factura.TabIndex = 19;
            btn_Factura.Text = "Crear Factura";
            btn_Factura.UseVisualStyleBackColor = false;
            btn_Factura.Click += btn_Factura_Click;
            // 
            // label10
            // 
            label10.AccessibleRole = AccessibleRole.Cursor;
            label10.AutoSize = true;
            label10.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(171, 182);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 18;
            label10.Text = "Cantidad";
            // 
            // btn_Descuento
            // 
            btn_Descuento.BackColor = Color.FromArgb(0, 0, 20);
            btn_Descuento.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Descuento.ForeColor = SystemColors.ButtonHighlight;
            btn_Descuento.Location = new Point(401, 15);
            btn_Descuento.Name = "btn_Descuento";
            btn_Descuento.Size = new Size(161, 59);
            btn_Descuento.TabIndex = 11;
            btn_Descuento.Text = "Descuento";
            btn_Descuento.UseVisualStyleBackColor = false;
            btn_Descuento.Click += btn_Descuento_Click;
            // 
            // dtp_Fecha
            // 
            dtp_Fecha.Location = new Point(29, 128);
            dtp_Fecha.Name = "dtp_Fecha";
            dtp_Fecha.Size = new Size(125, 27);
            dtp_Fecha.TabIndex = 16;
            // 
            // cbo_MetodoPago
            // 
            cbo_MetodoPago.FormattingEnabled = true;
            cbo_MetodoPago.Location = new Point(29, 31);
            cbo_MetodoPago.Name = "cbo_MetodoPago";
            cbo_MetodoPago.Size = new Size(125, 28);
            cbo_MetodoPago.TabIndex = 15;
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
            panel2.Controls.Add(btn_Factura);
            panel2.Controls.Add(btn_Eliminar);
            panel2.Controls.Add(btn_Modificar);
            panel2.Controls.Add(btn_Descuento);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_ID);
            panel2.Location = new Point(29, 264);
            panel2.Name = "panel2";
            panel2.Size = new Size(579, 160);
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
            label7.Location = new Point(346, 68);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(206, 66);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(125, 27);
            txt_ID.TabIndex = 14;
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(29, 182);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(125, 27);
            txt_Cantidad.TabIndex = 4;
            // 
            // label6
            // 
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 17;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(700, 330);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(161, 59);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 12;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Cursor;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(171, 135);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 5;
            label4.Text = "Fecha";
            // 
            // txt_Monto
            // 
            txt_Monto.Location = new Point(29, 77);
            txt_Monto.Name = "txt_Monto";
            txt_Monto.Size = new Size(125, 27);
            txt_Monto.TabIndex = 4;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Cursor;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(169, 79);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Monto";
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Cursor;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 33);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 1;
            label1.Text = "Metodo De Pago";
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            // 
            // label9
            // 
            label9.AccessibleRole = AccessibleRole.Cursor;
            label9.AutoSize = true;
            label9.BackColor = Color.SteelBlue;
            label9.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(357, 26);
            label9.Name = "label9";
            label9.Size = new Size(251, 28);
            label9.TabIndex = 7;
            label9.Text = "Gestión De Ventas";
            // 
            // VistaVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1006, 553);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "VistaVenta";
            Text = "VistaVenta";
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
        private Button btn_Factura;
        private Button btn_Descuento;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Label label7;
        private TextBox txt_ID;
        private TextBox txt_Cantidad;
        private Label label6;
        private Button btn_Agregar;
        private Label label5;
        private Label label4;
        private TextBox txt_Monto;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label9;
        private DateTimePicker dtp_Fecha;
        private ComboBox cbo_MetodoPago;
        private Label label10;
    }
}