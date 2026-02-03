namespace Vista
{
    partial class VistaCategoria
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
            btn_Cerrar = new Button();
            panel2 = new Panel();
            label8 = new Label();
            txt_IDCategoria = new TextBox();
            btn_Asignar = new Button();
            label7 = new Label();
            txt_IDProducto = new TextBox();
            btn_Agregar = new Button();
            label5 = new Label();
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
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(32, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 373);
            panel1.TabIndex = 4;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(444, 14);
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
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txt_IDCategoria);
            panel2.Controls.Add(btn_Asignar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_IDProducto);
            panel2.Location = new Point(29, 195);
            panel2.Name = "panel2";
            panel2.Size = new Size(552, 160);
            panel2.TabIndex = 13;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.Cursor;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 20);
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(363, 49);
            label8.Name = "label8";
            label8.Size = new Size(141, 20);
            label8.TabIndex = 17;
            label8.Text = "ID Categoría";
            // 
            // txt_IDCategoria
            // 
            txt_IDCategoria.Location = new Point(223, 47);
            txt_IDCategoria.Name = "txt_IDCategoria";
            txt_IDCategoria.Size = new Size(125, 27);
            txt_IDCategoria.TabIndex = 16;
            // 
            // btn_Asignar
            // 
            btn_Asignar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Asignar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Asignar.ForeColor = SystemColors.ButtonHighlight;
            btn_Asignar.Location = new Point(21, 59);
            btn_Asignar.Name = "btn_Asignar";
            btn_Asignar.Size = new Size(161, 59);
            btn_Asignar.TabIndex = 13;
            btn_Asignar.Text = "Asignar";
            btn_Asignar.UseVisualStyleBackColor = false;
            btn_Asignar.Click += btn_Asignar_Click;
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
            label7.Size = new Size(130, 20);
            label7.TabIndex = 15;
            label7.Text = "ID Producto";
            // 
            // txt_IDProducto
            // 
            txt_IDProducto.Location = new Point(223, 106);
            txt_IDProducto.Name = "txt_IDProducto";
            txt_IDProducto.Size = new Size(125, 27);
            txt_IDProducto.TabIndex = 14;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(27, 85);
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
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(31, 31);
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
            label2.Location = new Point(201, 18);
            label2.Name = "label2";
            label2.Size = new Size(300, 28);
            label2.TabIndex = 5;
            label2.Text = "Gestión De Categorías";
            // 
            // VistaCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(699, 451);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "VistaCategoria";
            Text = "VistaCategoria";
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
        private TextBox txt_precio;
        private Button btn_Descuento;
        private Button btn_Eliminar;
        private Button btn_Asignar;
        private Label label7;
        private TextBox txt_IDProducto;
        private Button btn_Agregar;
        private Label label5;
        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private Label label8;
        private TextBox txt_IDCategoria;
    }
}