namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            /*
                         using (var context = new Context())
            {
                bool conexion = context.Database.CanConnect(); // Devuelve true si conecta

                if (conexion == true) { MessageBox.Show("Conecta"); } else { MessageBox.Show("no Conecta"); }
                
            }
             */
        }




        private void btn_VistaCliente_Click(object sender, EventArgs e)
        {

            VistaCliente formCliente = new VistaCliente();
            formCliente.Show();

        }

        private void btn_VistaProducto_Click(object sender, EventArgs e)
        {
            VistaProducto formProducto = new VistaProducto();
            formProducto.Show();
        }



        private void btn_VistaReportesConsultas_Click(object sender, EventArgs e)
        {
            VistaReportesConsultas formReportes = new VistaReportesConsultas();
            formReportes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            VistaVenta formVenta = new VistaVenta();
            formVenta.Show();
        }
    }
}

