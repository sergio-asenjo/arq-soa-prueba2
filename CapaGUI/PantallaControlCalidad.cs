using System.Data;
using System.Windows.Forms;

namespace CapaGUI
{
    public partial class PantallaControlCalidad : Form
    {
        public PantallaControlCalidad()
        {
            InitializeComponent();
        }

        private void btoMostrarPeso_Click(object sender, System.EventArgs e)
        {
            if (this.verificarDatos())
            {
                ServiceProducto.WebServiceProductoSoapClient auxServiceProducto = new ServiceProducto.WebServiceProductoSoapClient();
                ServiceProducto.Producto auxProducto = new ServiceProducto.Producto();

                auxProducto.Sku = txtSku.Text;

                DataSet pesos = auxServiceProducto.webConsultarPeso(auxProducto);

                if (pesos.Tables[0].Rows.Count != 0)
                {
                    this.txtPesoMinimo.Text = pesos.Tables[0].Rows[0]["peso_minimo"].ToString();
                    this.txtPesoMaximo.Text = pesos.Tables[0].Rows[0]["peso_maximo"].ToString();
                }
                else
                {
                    MessageBox.Show("¡No hay producto con dicho SKU!", "Error del Sistema.");
                }
            }
            else
            {
                MessageBox.Show("¡Complete todos los campos de manera correcta!", "Error del Sistema.");
            }
        }

        private void btoGuardar_Click(object sender, System.EventArgs e)
        {
            if (this.verificarDatos())
            {
                ServiceProducto.WebServiceProductoSoapClient auxServiceProducto = new ServiceProducto.WebServiceProductoSoapClient();
                ServiceProducto.Producto auxProducto = new ServiceProducto.Producto();

                auxProducto.Num_captura = txtNumeroCaptura.Text;
                auxProducto.Peso_captura = int.Parse(txtPesoCaptura.Text);
                auxProducto.Sku = txtSku.Text;
                auxProducto.Fecha = dteFecha.Value;

                if (int.Parse(txtPesoCaptura.Text) >= int.Parse(txtPesoMinimo.Text)
                    && int.Parse(txtPesoCaptura.Text) <= int.Parse(txtPesoMaximo.Text))
                {
                    auxProducto.EsAprobado = true;
                    auxServiceProducto.webRegistraCaptura(auxProducto);
                    MessageBox.Show("¡Producto ACEPTADO!\nGuardado en tabla Captura.", "Mensaje del Sistema.");
                }
                else
                {
                    auxProducto.EsAprobado = false;
                    auxServiceProducto.webRegistraCaptura(auxProducto);
                    MessageBox.Show("¡Producto RECHAZADO!\nGuardado en tabla Rechazo.", "Mensaje del Sistema.");
                }
            }
            else
            {
                MessageBox.Show("¡Debe rellenar todos los datos antes de guardar!", "Error del Sistema.");
            }
        }

        public bool verificarDatos()
        {
            if (string.IsNullOrEmpty(txtNumeroCaptura.Text)
                || string.IsNullOrEmpty(txtSku.Text)
                || string.IsNullOrEmpty(txtPesoCaptura.Text)
                || !int.TryParse(txtPesoCaptura.Text, out _))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
