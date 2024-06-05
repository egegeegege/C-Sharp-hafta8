using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_2
{
    public class Kure : Sekil
    {
        public Kure(double r) : base(r,0)
        {
            
        }

        public override double Alan()
        {
            return 4 * PI * (x * x);
        }
    }
}
