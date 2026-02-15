namespace Vista
{
    partial class VistaListaCategorias
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
            dgv_Categorias = new DataGridView();
            btn_Cerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).BeginInit();
            SuspendLayout();
            // 
            // dgv_Categorias
            // 
            dgv_Categorias.AllowUserToAddRows = false;
            dgv_Categorias.AllowUserToDeleteRows = false;
            dgv_Categorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Categorias.Location = new Point(-3, -2);
            dgv_Categorias.Name = "dgv_Categorias";
            dgv_Categorias.ReadOnly = true;
            dgv_Categorias.RowHeadersWidth = 51;
            dgv_Categorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categorias.Size = new Size(699, 470);
            dgv_Categorias.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(262, 474);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(161, 59);
            btn_Cerrar.TabIndex = 16;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // VistaListaCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(695, 541);
            Controls.Add(btn_Cerrar);
            Controls.Add(dgv_Categorias);
            Name = "VistaListaCategorias";
            Text = "VistaListaCategorias";
            ((System.ComponentModel.ISupportInitialize)dgv_Categorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Categorias;
        private Button btn_Cerrar;
    }
}