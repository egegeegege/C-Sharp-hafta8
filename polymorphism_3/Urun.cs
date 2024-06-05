using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_3
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public virtual void KdvHesapla()
        {
            Console.WriteLine(Fiyat * 1.18);
        }
    }
}
