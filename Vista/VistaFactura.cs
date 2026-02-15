using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class VistaFactura : Form
    {


        public VistaFactura(string textoFactura)
        {
            InitializeComponent();

            rtb_Contenido.Clear();

            rtb_Contenido.SelectionAlignment = HorizontalAlignment.Center;
            rtb_Contenido.SelectionFont = new Font("Consolas", 14, FontStyle.Bold);
            rtb_Contenido.AppendText("FACTURA DE VENTA\n\n");

            rtb_Contenido.SelectionAlignment = HorizontalAlignment.Left;
            rtb_Contenido.SelectionFont = new Font("Consolas", 11, FontStyle.Regular);
            rtb_Contenido.AppendText(textoFactura);

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
