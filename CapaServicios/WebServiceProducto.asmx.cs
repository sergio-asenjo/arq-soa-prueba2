using CapaDTO;
using CapaNegocio;

using System.Data;
using System.Web.Services;

namespace CapaServicios
{
    /// <summary>
    /// Summary description for WebServiceProducto
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class WebServiceProducto : WebService
    {

        [WebMethod]
        public DataSet webConsultarPeso(Producto producto)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            return auxNegocioProducto.consultarPeso(producto);
        }

        [WebMethod]
        public void webRegistraCaptura(Producto producto)
        {
            NegocioProducto auxNegocioProducto = new NegocioProducto();
            auxNegocioProducto.registraCaptura(producto);
        }
    }
}
