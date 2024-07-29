using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    class Producto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Producto(string nombre, float precio)
        {
            Nombre = nombre;
            Precio = precio;
        }
    }

    class CarritoDeCompras
    {
        private List<Producto> productos;
        privatefloat umbralDescuento;
        private float porcentajeDescuento;

        public CarritoDeCompras(float umbral, float porcentaje)
        {
            productos = new List<Producto>();
            umbralDescuento = umbral;
            porcentajeDescuento = porcentaje;
        }
    }
}
