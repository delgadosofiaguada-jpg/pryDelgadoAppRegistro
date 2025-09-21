using System.Diagnostics.Eventing.Reader;

namespace pryDelgadoAppRegistro
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }
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
            lstbRegistros.Items.Add("Fecha:" + " " + dtpFecha.Text);
            lstbRegistros.Items.Add("Producto:" + " " + lstProductos.SelectedItem);
            lstbRegistros.Items.Add("Cantidad:" + " " + nudCantidad.Value);
            lstbRegistros.Items.Add("Precio:$" + " " + mtbPrecio.Text + "\n");

            LimpiarControles();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

      
    }
}
