using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_2
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen(double r, double y) : base(r, y)
        {
            
        }

        public override double Alan()
        {
            return x * y;
        }
    }
}
