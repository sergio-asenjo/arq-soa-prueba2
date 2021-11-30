using CapaDTO;
using CapaConexion;

using System.Data;

namespace CapaNegocio
{
    public class NegocioProducto
    {
        private Conexion auxConexion;

        public Conexion AuxConexion { get => auxConexion; set => auxConexion = value; }

        public void configurarConexion(string nombreTabla)
        {
            this.AuxConexion = new Conexion();
            this.AuxConexion.NombreBaseDeDatos = "prueba";
            this.AuxConexion.NombreTabla = nombreTabla;
            this.AuxConexion.CadenaConexion = $"Data Source = localhost; Initial Catalog = {this.AuxConexion.NombreBaseDeDatos}; Integrated Security = True";
        }

        public DataSet consultarPeso(Producto producto)
        {
            this.configurarConexion("producto");
            this.AuxConexion.CadenaSQL = $@"SELECT peso_minimo, peso_maximo 
                                        FROM {AuxConexion.NombreTabla}
                                        WHERE sku = '{producto.Sku}';";
            this.AuxConexion.EsSelect = true;
            this.AuxConexion.conectar();
            return this.AuxConexion.DbDataSet;
        }

        public void registraCaptura(Producto producto)
        {
            if (producto.EsAprobado)
            {
                this.configurarConexion("captura");
                this.AuxConexion.CadenaSQL = $@"INSERT INTO {AuxConexion.NombreTabla} (num_captura, fecha, sku, peso_captura) 
                                                VALUES ('{producto.Num_captura}','{producto.Fecha}','{producto.Sku}',{producto.Peso_captura});";
                this.AuxConexion.EsSelect = false;
                this.AuxConexion.conectar();
            }
            else
            {
                this.configurarConexion("rechazo");
                this.AuxConexion.CadenaSQL = $@"INSERT INTO {AuxConexion.NombreTabla} (sku, fecha, num_captura, peso_captura) 
                                                VALUES ('{producto.Sku}','{producto.Fecha}','{producto.Num_captura}',{producto.Peso_captura});";
                this.AuxConexion.EsSelect = false;
                this.AuxConexion.conectar();
            }
        }
    }
}
