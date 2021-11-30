using System;

namespace CapaDTO
{
    public class Producto
    {
        private string sku;
        private string num_captura;
        private int peso_captura;
        private DateTime fecha;
        private bool esAprobado;

        public string Sku { get => sku; set => sku = value; }
        public string Num_captura { get => num_captura; set => num_captura = value; }
        public int Peso_captura { get => peso_captura; set => peso_captura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public bool EsAprobado { get => esAprobado; set => esAprobado = value; }
    }
}
