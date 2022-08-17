using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaApp1
{
    internal class Producto
    {
        private int nroProducto;
        private string nombreProducto;
        private float precio;
        private bool activo;

        public Producto()
        {
            nroProducto = 0;
            precio = 0;
            activo = false;
            nombreProducto = "";
        }
        public Producto(int nroProducto, string nombreProducto, float precio, bool activo)
        {
            this.nroProducto = nroProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.activo = activo;
        }
        public int pNroProducto
        {
            set { nroProducto = value; }
            get { return nroProducto; }
        }
        public float pPrecio
        {
            set { precio = value; }
            get { return precio; }
        }
        public string pNombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        public bool pActivo
        {
            get { return activo; }
            set { activo = value; }
        }
    }
}
