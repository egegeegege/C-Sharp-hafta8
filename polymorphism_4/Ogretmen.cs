using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_4
{
    public class Ogretmen : Personel
    {
        public override void Calis()
        {
            Console.WriteLine("Ben öğretmenim öğretirim.");
        }
    }
}
