using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_3
{
    public class Elbise : Urun
    {

        public override void KdvHesapla()
        {
            Console.WriteLine(Fiyat * 1.17);
        }
    }
}
