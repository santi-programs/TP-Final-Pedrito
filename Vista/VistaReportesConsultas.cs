using Controlador;
using Entidades;
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
    public partial class VistaReportesConsultas : Form
    {
        private ControladorReporte controlador;
        List<Sucursal> listaSucursales = new List<Sucursal>();
        public VistaReportesConsultas()
        {

            controlador = new ControladorReporte();
            InitializeComponent();
        }

        private void VistaReportesConsultas_Load(object sender, EventArgs e)
        {
            cbo_Sucursal.DataSource = listaSucursales;
            cbo_Sucursal.DisplayMember = "Direccion";
            cbo_Sucursal.ValueMember = "IDSucursal";

        }

        private void btn_VentasSucursal_Click(object sender, EventArgs e)
        {
            
            //Necesito acceder la base de datos para poder testear
        }
    }
}
