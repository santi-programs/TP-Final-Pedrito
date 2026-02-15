namespace Vista
{
    partial class VistaReporteVentas
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
            dgv_Reporte = new DataGridView();
            btn_Cerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Reporte).BeginInit();
            SuspendLayout();
            // 
            // dgv_Reporte
            // 
            dgv_Reporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Reporte.Location = new Point(-2, -2);
            dgv_Reporte.Name = "dgv_Reporte";
            dgv_Reporte.RowHeadersWidth = 51;
            dgv_Reporte.Size = new Size(806, 384);
            dgv_Reporte.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(326, 386);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(161, 59);
            btn_Cerrar.TabIndex = 15;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // VistaReporteVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Cerrar);
            Controls.Add(dgv_Reporte);
            Name = "VistaReporteVentas";
            Text = "VistaReporteVentas";
            ((System.ComponentModel.ISupportInitialize)dgv_Reporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_Reporte;
        private Button btn_Cerrar;
    }
}