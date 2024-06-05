using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    public class Not
    {
        public int Vize { get; set; }
        public int Final { get; set; }

        public void VizeFinalBelirle(int v, int f)
        {
            Vize = v;
            Final = f;
        }

        public double OrtalamaAl()
        {
            double ortalama = (Vize * 0.4) + (Final * 0.6);
            return ortalama;
        }
    }
}
