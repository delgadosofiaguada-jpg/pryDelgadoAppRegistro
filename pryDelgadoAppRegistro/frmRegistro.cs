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

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            lstbRegistros.Items.Add("Fecha:" +" "+dtpFecha);
            lstbRegistros.Items.Add("Producto:"+ " " + lstProductos.SelectedItem);
            lstbRegistros.Items.Add("Cantidad:" + " " +nudCantidad.Value);
            lstbRegistros.Items.Add("Precio:$" + " " + mtbPrecio.Text);

            LimpiarControles();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
