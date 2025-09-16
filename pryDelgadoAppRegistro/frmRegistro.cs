namespace pryDelgadoAppRegistro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
        DateTime vFecha = DateTime.Now;
        String vProducto = "";
        int vCantidad = 0;
        int vPrecioU = 0;



        private void lstProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProductos.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
            {
                nudCantidad.Enabled = false;
            }
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (nudCantidad.Value > 0)
            {
                mtbPrecio.Enabled = true;
            }
            else
            {
                mtbPrecio.Enabled = false;
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
            vFecha = dtpFecha.Value;
            vProducto = lstProductos.Text;
            vCantidad = Convert.ToInt32(nudCantidad.Value);
            vPrecioU = Convert.ToInt32(mtbPrecio.Text);


            lblResultados.Text += (vFecha + " " + vProducto + " " + vCantidad + " " + vPrecioU);

            LimpiarControles();

        }

        private void LimpiarControles()
        {
            dtpFecha.Value = DateTime.Now;
            lstProductos.SelectedIndex = -1;
            nudCantidad.Value = 0;
            mtbPrecio.Text = "";
            lstProductos.Focus();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
              if (MessageBox.Show("¿Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
          this.Close();
      }
        }
    }
}
