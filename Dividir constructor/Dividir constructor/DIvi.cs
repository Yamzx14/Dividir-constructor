using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividir_constructor
{
  
    internal class Divicionclass
    {
        //campo propiedades, como es
        private double n1;
        private double n2;

        //constructor
        public Divicionclass(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

  
        public double Dividir()
        {
            return (n1 / n2);
        }
    }
}
