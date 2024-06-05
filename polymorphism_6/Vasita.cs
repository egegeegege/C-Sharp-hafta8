using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_6
{
    public class Vasita
    {
        public int Agirlik { get; set; }
        public string Renk { get; set; }
       
        public virtual void VasitaOzellikleri()
        {
            Console.WriteLine("Vasitanın ağırlığı: {0} , Vasitanin rengi: {1}",Agirlik,Renk);
        }
    }

   
}
