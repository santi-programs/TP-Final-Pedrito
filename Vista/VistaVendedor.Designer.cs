namespace Vista
{
    partial class VistaVendedor
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
            label2 = new Label();
            panel1 = new Panel();
            txt_Apellido = new TextBox();
            txt_Nombre = new TextBox();
            label3 = new Label();
            btn_Cerrar = new Button();
            panel2 = new Panel();
            btn_Despedir = new Button();
            txt_IdVendedor = new TextBox();
            txt_IdSucursal = new TextBox();
            label8 = new Label();
            btn_Asignar = new Button();
            label7 = new Label();
            btn_Agregar = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.Cursor;
            label2.AutoSize = true;
            label2.BackColor = Color.SteelBlue;
            label2.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(254, 21);
            label2.Name = "label2";
            label2.Size = new Size(312, 28);
            label2.TabIndex = 7;
            label2.Text = "Gestión De Vendedores";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(txt_Apellido);
            panel1.Controls.Add(txt_Nombre);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(28, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 373);
            panel1.TabIndex = 6;
            // 
            // txt_Apellido
            // 
            txt_Apellido.Location = new Point(31, 79);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(125, 27);
            txt_Apellido.TabIndex = 17;
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(31, 33);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(125, 27);
            txt_Nombre.TabIndex = 16;
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
            label3.TabIndex = 15;
            label3.Text = "Apellido";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(582, 16);
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
            panel2.Controls.Add(btn_Despedir);
            panel2.Controls.Add(txt_IdVendedor);
            panel2.Controls.Add(txt_IdSucursal);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btn_Asignar);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(31, 194);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 160);
            panel2.TabIndex = 13;
            // 
            // btn_Despedir
            // 
            btn_Despedir.BackColor = Color.FromArgb(0, 0, 20);
            btn_Despedir.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Despedir.ForeColor = SystemColors.ButtonHighlight;
            btn_Despedir.Location = new Point(530, 55);
            btn_Despedir.Name = "btn_Despedir";
            btn_Despedir.Size = new Size(161, 59);
            btn_Despedir.TabIndex = 20;
            btn_Despedir.Text = "Despedir";
            btn_Despedir.UseVisualStyleBackColor = false;
            btn_Despedir.Click += btn_Despedir_Click;
            // 
            // txt_IdVendedor
            // 
            txt_IdVendedor.Location = new Point(206, 101);
            txt_IdVendedor.Name = "txt_IdVendedor";
            txt_IdVendedor.Size = new Size(125, 27);
            txt_IdVendedor.TabIndex = 19;
            // 
            // txt_IdSucursal
            // 
            txt_IdSucursal.Location = new Point(206, 42);
            txt_IdSucursal.Name = "txt_IdSucursal";
            txt_IdSucursal.Size = new Size(125, 27);
            txt_IdSucursal.TabIndex = 18;
            // 
            // label8
            // 
            label8.AccessibleRole = AccessibleRole.Cursor;
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 20);
            label8.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(366, 42);
            label8.Name = "label8";
            label8.Size = new Size(130, 20);
            label8.TabIndex = 17;
            label8.Text = "ID Sucursal";
            // 
            // btn_Asignar
            // 
            btn_Asignar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Asignar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Asignar.ForeColor = SystemColors.ButtonHighlight;
            btn_Asignar.Location = new Point(16, 55);
            btn_Asignar.Name = "btn_Asignar";
            btn_Asignar.Size = new Size(161, 59);
            btn_Asignar.TabIndex = 13;
            btn_Asignar.Text = "Asignar A Sucursal";
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
            label7.Location = new Point(366, 101);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 15;
            label7.Text = "ID Vendedor";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(307, 119);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(161, 59);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
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
            // VistaVendedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(820, 453);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "VistaVendedor";
            Text = "VistaVendedor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button btn_Cerrar;
        private Panel panel2;
        private Label label8;
        private Button btn_Asignar;
        private Label label7;
        private Button btn_Agregar;
        private Label label1;
        private TextBox txt_Nombre;
        private Label label3;
        private TextBox txt_Apellido;
        private Button btn_Despedir;
        private TextBox txt_IdVendedor;
        private TextBox txt_IdSucursal;
    }
}