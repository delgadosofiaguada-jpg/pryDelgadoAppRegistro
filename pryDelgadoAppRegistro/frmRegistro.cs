using System.Diagnostics.Eventing.Reader;

namespace pryDelgadoAppRegistro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        struct RegVentas
        {
            public DateTime Fecha;
            public string Producto;
            public int Cantidad;
            public int Precio;
        }
        RegVentas[] VectorVentas = new RegVentas[10];
        int i = 0;

        private void LimpiarControles()
        {
            lstProductos.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecio.Text = "";
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFecha.Text == "")
            {
                lstProductos.Enabled = false;
            }
            else
            {
                lstProductos.Enabled = true;
            }
        }

        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.Text == "")
            {
                nudCantidad.Enabled = false;
            }
            else
            {
                nudCantidad.Enabled = true;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value < 1)
            {
                mtbPrecio.Enabled = false;
            }
            else
            {
                mtbPrecio.Enabled = true;
            }
        }

        private void mtbPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbPrecio.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {


            VectorVentas[i].Fecha = dtpFecha.Value;
            VectorVentas[i].Producto = lstProductos.Text;
            VectorVentas[i].Cantidad = Convert.ToInt32(nudCantidad.Value);
            string precioText = mtbPrecio.Text.Replace("$", "").Trim();
            if (int.TryParse(precioText, out int precio))
            {
                VectorVentas[i].Precio = precio;
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
                return;
            }


            lblResultados.Text +=
                VectorVentas[i].Fecha.ToShortDateString() + " - " +
                VectorVentas[i].Producto + " | " +
                "Cantidad: " + VectorVentas[i].Cantidad + " | " +
                "Precio: $" + VectorVentas[i].Precio + "\n";


            i++;

            LimpiarControles();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

    }
}
