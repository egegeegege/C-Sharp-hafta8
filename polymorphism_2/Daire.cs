﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_2
{
    public class Daire : Sekil
    {
        public Daire(double r):base(r,0)
        {
            
        }

        public override double Alan()
        {
            return PI * (x * x);
        }

    }
}
