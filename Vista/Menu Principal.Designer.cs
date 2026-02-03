namespace Vista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_VistaCliente = new Button();
            btn_VistaProducto = new Button();
            btn_VistaCategorias = new Button();
            btn_VistaReportesConsultas = new Button();
            SuspendLayout();
            // 
            // btn_VistaCliente
            // 
            btn_VistaCliente.Location = new Point(502, 326);
            btn_VistaCliente.Name = "btn_VistaCliente";
            btn_VistaCliente.Size = new Size(135, 41);
            btn_VistaCliente.TabIndex = 0;
            btn_VistaCliente.Text = "Clientes";
            btn_VistaCliente.UseVisualStyleBackColor = true;
            btn_VistaCliente.Click += btn_VistaCliente_Click;
            // 
            // btn_VistaProducto
            // 
            btn_VistaProducto.Location = new Point(468, 211);
            btn_VistaProducto.Name = "btn_VistaProducto";
            btn_VistaProducto.Size = new Size(135, 41);
            btn_VistaProducto.TabIndex = 1;
            btn_VistaProducto.Text = "Productos";
            btn_VistaProducto.UseVisualStyleBackColor = true;
            btn_VistaProducto.Click += btn_VistaProducto_Click;
            // 
            // btn_VistaCategorias
            // 
            btn_VistaCategorias.Location = new Point(456, 100);
            btn_VistaCategorias.Name = "btn_VistaCategorias";
            btn_VistaCategorias.Size = new Size(135, 41);
            btn_VistaCategorias.TabIndex = 2;
            btn_VistaCategorias.Text = "Categorias";
            btn_VistaCategorias.UseVisualStyleBackColor = true;
            btn_VistaCategorias.Click += btn_VistaCategorias_Click;
            // 
            // btn_VistaReportesConsultas
            // 
            btn_VistaReportesConsultas.Location = new Point(123, 100);
            btn_VistaReportesConsultas.Name = "btn_VistaReportesConsultas";
            btn_VistaReportesConsultas.Size = new Size(135, 41);
            btn_VistaReportesConsultas.TabIndex = 3;
            btn_VistaReportesConsultas.Text = "Reportes Y Consultas";
            btn_VistaReportesConsultas.UseVisualStyleBackColor = true;
            btn_VistaReportesConsultas.Click += btn_VistaReportesConsultas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_VistaReportesConsultas);
            Controls.Add(btn_VistaCategorias);
            Controls.Add(btn_VistaProducto);
            Controls.Add(btn_VistaCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_VistaCliente;
        private Button btn_VistaProducto;
        private Button btn_VistaCategorias;
        private Button btn_VistaReportesConsultas;
    }
}
