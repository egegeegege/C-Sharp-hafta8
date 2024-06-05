using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_6
{
    public class Otomobil : Vasita
    {
        public int MotorHacmi { get; set; }
        public VitesTurleri VitesTipi { get; set; }

        public override void VasitaOzellikleri()
        {
            Console.WriteLine("Vasitanın ağırlığı: {0} , Vasitanin rengi: {1}, Vasitanın Motor Hacmi: {2}, Vasitanın Vites tipi: {3}", Agirlik, Renk,MotorHacmi,VitesTipi);
        }

    }
    
   

}
