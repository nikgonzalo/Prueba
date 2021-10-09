using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Botta
{
    class Suelto : Producto
    {

        public double Medida { get; set; }

        public Suelto(int cod, string nombre, double precio, double med) : base(cod,nombre,precio)
        {
            this.Medida = med;
        }

        public override double CalcularPrecio()
        {
            return this.Precio * this.Medida;
        }

        public override string ToString()
        {
            return "Suelto: " + base.ToString();
        }
    }
}
