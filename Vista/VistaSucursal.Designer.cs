namespace Vista
{
    partial class VistaSucursal
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
            txt_Stock = new TextBox();
            label3 = new Label();
            txt_Direccion = new TextBox();
            panel2 = new Panel();
            btn_Eliminar = new Button();
            btn_Modificar = new Button();
            label7 = new Label();
            txt_ID = new TextBox();
            btn_Cerrar = new Button();
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
            label2.Location = new Point(159, 52);
            label2.Name = "label2";
            label2.Size = new Size(301, 28);
            label2.TabIndex = 7;
            label2.Text = "Gestión De Sucursales";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(txt_Stock);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_Direccion);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 373);
            panel1.TabIndex = 6;
            // 
            // txt_Stock
            // 
            txt_Stock.Location = new Point(31, 77);
            txt_Stock.Name = "txt_Stock";
            txt_Stock.Size = new Size(125, 27);
            txt_Stock.TabIndex = 17;
            // 
            // label3
            // 
            label3.AccessibleRole = AccessibleRole.Cursor;
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(169, 79);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 16;
            label3.Text = "Stock Límite";
            // 
            // txt_Direccion
            // 
            txt_Direccion.Location = new Point(31, 31);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(125, 27);
            txt_Direccion.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(btn_Eliminar);
            panel2.Controls.Add(btn_Modificar);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_ID);
            panel2.Location = new Point(31, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(416, 160);
            panel2.TabIndex = 14;
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
            label7.Location = new Point(363, 76);
            label7.Name = "label7";
            label7.Size = new Size(31, 20);
            label7.TabIndex = 15;
            label7.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(218, 74);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(125, 27);
            txt_ID.TabIndex = 14;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(409, 14);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(161, 59);
            btn_Cerrar.TabIndex = 14;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Agregar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Agregar.ForeColor = SystemColors.ButtonHighlight;
            btn_Agregar.Location = new Point(286, 124);
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
            label1.Size = new Size(108, 20);
            label1.TabIndex = 1;
            label1.Text = "Dirección";
            // 
            // VistaSucursal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(626, 513);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "VistaSucursal";
            Text = "VistaSucursal";
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
        private Button btn_Agregar;
        private Label label1;
        private Panel panel2;
        private Button btn_Eliminar;
        private Button btn_Modificar;
        private Label label7;
        private TextBox txt_ID;
        private TextBox txt_Stock;
        private Label label3;
        private TextBox txt_Direccion;
    }
}