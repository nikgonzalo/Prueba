using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Botta
{
    abstract class Producto : Interface1
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }

        public Producto(int cod, string nombre, double precio)
        {
            this.Codigo = cod;
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public abstract double CalcularPrecio();


        public override string ToString()
        {
            return Codigo + " - " + Nombre + " $ " + CalcularPrecio();
        }
    }
}
