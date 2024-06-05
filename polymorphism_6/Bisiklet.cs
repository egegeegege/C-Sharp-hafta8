using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_6
{
    public class Bisiklet : Vasita
    {
        public int VitesSayisi { get; set; }
        public int JantBoyutu { get; set; }

        public override void VasitaOzellikleri()
        {
            Console.WriteLine("Vasitanın ağırlığı: {0} , Vasitanin rengi: {1}, Vasitanın Vites sayisi: {2}, Vasitanın jant boyutu: {3}", Agirlik, Renk, VitesSayisi, JantBoyutu);
        }
    }
}
