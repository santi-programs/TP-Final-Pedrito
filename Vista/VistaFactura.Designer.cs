namespace Vista
{
    partial class VistaFactura
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
            rtb_Contenido = new RichTextBox();
            btn_Cerrar = new Button();
            SuspendLayout();
            // 
            // rtb_Contenido
            // 
            rtb_Contenido.Location = new Point(21, 21);
            rtb_Contenido.Name = "rtb_Contenido";
            rtb_Contenido.Size = new Size(762, 478);
            rtb_Contenido.TabIndex = 0;
            rtb_Contenido.Text = "";
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.BackColor = Color.FromArgb(0, 0, 20);
            btn_Cerrar.Font = new Font("Lucida Bright", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cerrar.ForeColor = SystemColors.ButtonHighlight;
            btn_Cerrar.Location = new Point(304, 522);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(161, 59);
            btn_Cerrar.TabIndex = 15;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.UseVisualStyleBackColor = false;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // VistaFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(805, 593);
            Controls.Add(btn_Cerrar);
            Controls.Add(rtb_Contenido);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "VistaFactura";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VistaFactura";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtb_Contenido;
        private Button btn_Cerrar;
    }
}