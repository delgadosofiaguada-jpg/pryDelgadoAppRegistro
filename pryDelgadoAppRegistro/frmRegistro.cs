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

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            lstbRegistros.Items.Add("Fecha:" + " " + dtpFecha.Text);
            lstbRegistros.Items.Add("Producto:" + " " + lstProductos.SelectedItem);
            lstbRegistros.Items.Add("Cantidad:" + " " + nudCantidad.Value);
            lstbRegistros.Items.Add("Precio:$" + " " + mtbPrecio.Text + "\n");

            LimpiarControles();
        }
        //declaración de variables
        string[] vecDatos = new string[3];
        int indice = 0;
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            while(vecDatos.Length < indice)
            {
                lblResultado.Text += vecDatos[indice] + "\n";
                indice++;
            }
            indice = 0;
            lstbRegistros.Items.Add("Gabinete");
            lstbRegistros.Items.Add("cpu");
            lstbRegistros.Items.Add("ram");
            nudCantidad.Enabled=false;

            //No mayor a 3 registros
            if (indice == 3)
            {
                MessageBox.Show("Se registró el máximo de productos",
                    "Registro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

            }
            else
            {
                indice++;
            }
            LimpiarControles();
        }
    }
}
