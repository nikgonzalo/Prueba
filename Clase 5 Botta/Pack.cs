using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Botta
{
    class Pack : Producto
    {
        public int Cantidad { get; set; }

        public Pack(int cod, string nombre, double precio, int can) : base(cod, nombre, precio)
        {
            this.Cantidad = can;
        }

        public override double CalcularPrecio()
        {
            return this.Precio * this.Cantidad;
        }

        public override string ToString()
        {
            return "Pack: " + base.ToString();
        }


    }
}
