using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otomobil otomobil = new Otomobil();
            otomobil.MotorHacmi = 2000;
            otomobil.Renk = "Kırmızı";
            otomobil.Agirlik = 3000;
            otomobil.VitesTipi = VitesTurleri.Otomatik;
            otomobil.VasitaOzellikleri();

            Bisiklet bisiklet = new Bisiklet();
            bisiklet.VitesSayisi = 18;
            bisiklet.JantBoyutu = 20;
            bisiklet.Agirlik = 15;
            bisiklet.Renk = "Yeşil";
            bisiklet.VasitaOzellikleri();

            Console.ReadLine();
        }
    }
}
