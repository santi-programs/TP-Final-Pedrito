namespace Vista
{
    partial class VistaCliente
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
            txt_Nombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
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
            btn_Agregar = new Button();
            label5 = new Label();
            rb_Mayorista = new RadioButton();
            rb_Minorista = new RadioButton();
            txt_DNI = new TextBox();
            label4 = new Label();
            txt_Apellido = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(29, 31);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(125, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.Cursor;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(169, 33);
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
            label2.Location = new Point(366, 31);
            label2.Name = "label2";
            label2.Size = new Size(267, 28);
            label2.TabIndex = 2;
            label2.Text = "Gestión De Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txt_Telefono);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rb_Mayorista);
            panel1.Controls.Add(rb_Minorista);
            panel1.Controls.Add(txt_DNI);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_Apellido);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(942, 432);
            panel1.TabIndex = 3;
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
            btn_Historial.Click += btn_Historial_Click;
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
            btn_Descuento.Click += btn_Descuento_Click;
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
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(325, 182);
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
            // rb_Mayorista
            // 
            rb_Mayorista.AutoSize = true;
            rb_Mayorista.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Mayorista.ForeColor = SystemColors.ButtonFace;
            rb_Mayorista.Location = new Point(171, 175);
            rb_Mayorista.Name = "rb_Mayorista";
            rb_Mayorista.Size = new Size(129, 24);
            rb_Mayorista.TabIndex = 7;
            rb_Mayorista.TabStop = true;
            rb_Mayorista.Text = "Mayorista";
            rb_Mayorista.UseVisualStyleBackColor = true;
            // 
            // rb_Minorista
            // 
            rb_Minorista.AutoSize = true;
            rb_Minorista.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb_Minorista.ForeColor = SystemColors.ButtonFace;
            rb_Minorista.Location = new Point(36, 175);
            rb_Minorista.Name = "rb_Minorista";
            rb_Minorista.Size = new Size(129, 24);
            rb_Minorista.TabIndex = 6;
            rb_Minorista.TabStop = true;
            rb_Minorista.Text = "Minorista";
            rb_Minorista.UseVisualStyleBackColor = true;
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(29, 122);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(125, 27);
            txt_DNI.TabIndex = 4;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.Cursor;
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(169, 124);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "DNI";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(29, 77);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(125, 27);
            txt_Apellido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Cursor;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(169, 79);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 5;
            label3.Text = "Apellido";
            // 
            // VistaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1006, 553);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "VistaCliente";
            Text = "VistaCliente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private TextBox txt_Apellido;
        private Label label3;
        private TextBox txt_DNI;
        private Label label4;
        private RadioButton rb_Mayorista;
        private RadioButton rb_Minorista;
        private Label label5;
        private Button btn_Agregar;
        private TextBox txt_Telefono;
        private Label label6;
        private Button btn_Modificar;
        private TextBox txt_ID;
        private Label label7;
        private Panel panel2;
        private Button btn_Eliminar;
        private Label label8;
        private TextBox txt_precio;
        private Button btn_Descuento;
        private Button btn_Historial;
        private Button btn_Cerrar;
    }
}