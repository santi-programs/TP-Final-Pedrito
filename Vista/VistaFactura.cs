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
        // Constructor modificado para recibir el texto

        public VistaFactura(string textoFactura)
        {
            InitializeComponent();

            rtb_Contenido.Text = textoFactura;
            // Ponemos el fondo blanco para que parezca papel
            this.BackColor = Color.White;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
