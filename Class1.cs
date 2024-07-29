using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1
{
    internal class Class1
    {
        public class Cllientes
        {
            public string Nombre { get; set; }
            public int Precio { get; set; }

            public Cllientes(int precio, string nombre)
            {
                Nombre = nombre;
                Precio = precio;
            }
        }
    }
}
