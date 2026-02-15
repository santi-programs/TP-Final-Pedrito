namespace Vista
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private int letraActual = 0;
        private double progreso = 0;
        private bool esperando = false;
        private int contadorEspera = 0;

        private string texto = "Tech Store S.A.";
        private Font fuente = new Font("Yu Gothic", 25.8f, FontStyle.Regular);
        private int xBase = 275;
        private int yBase = 97;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

        }


        private void btn_VistaCliente_Click(object sender, EventArgs e) { }




        private void btn_VistaReportesConsultas_Click(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 20;
            timer.Tick += Animar;
            timer.Start();


        }

        private void btn_Venta_Click(object sender, EventArgs e) { }

        private void btn_VistaProductos_Click(object sender, EventArgs e)
        {
            VistaProducto formProducto = new VistaProducto();
            formProducto.Show();
        }


        private void Animar(object sender, EventArgs e)
        {
            if (esperando)
            {
                contadorEspera++;
                if (contadorEspera > 60)
                {
                    esperando = false;
                    contadorEspera = 0;
                    letraActual = 0;
                }
                Invalidate();
                return;
            }

            if (letraActual < texto.Length)
            {
                progreso += 0.08;

                if (progreso > 1)
                {
                    progreso = 0;
                    letraActual++;
                }
            }
            else
            {
                esperando = true;
            }

            Invalidate(); // Redibuja
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            float x = xBase;

            for (int i = 0; i < texto.Length; i++)
            {
                float y = yBase;

                if (i == letraActual && !esperando)
                {
                    float altura = (float)(30 * 4 * progreso * (1 - progreso));
                    y -= altura;
                }

                e.Graphics.DrawString(
                    texto[i].ToString(),
                    fuente,
                    Brushes.White,
                    x,
                    y
                );

                SizeF size = e.Graphics.MeasureString(texto[i].ToString(), fuente);
                x += size.Width;
            }
        }

        private void btn_Venta_Click_1(object sender, EventArgs e)
        {
            VistaVenta formVenta = new VistaVenta();
            formVenta.Show();
        }

        private void btn_VistaCliente_Click_1(object sender, EventArgs e)
        {
            VistaCliente formCliente = new VistaCliente();
            formCliente.Show();
        }

        private void btn_VistaReportesConsultas_Click_1(object sender, EventArgs e)
        {
            VistaReportesConsultas formReportes = new VistaReportesConsultas();
            formReportes.Show();
        }
    }
}

