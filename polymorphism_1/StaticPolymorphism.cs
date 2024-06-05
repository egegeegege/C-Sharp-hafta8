using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_1
{
    public class StaticPolymorphism
    {
        public void Yaz(int yas, string ad)
        {
            Console.WriteLine("{1} adlı kişinin yaşı: {0}",yas, ad);
        }

        public void Yaz(string ad)
        {
            Console.WriteLine("Merhaba: {0}", ad);
        }

        public void Yaz(string ad, string soyad)
        {
            Console.WriteLine("Merhaba: {0} {1}", ad,soyad);
        }
    }
}
