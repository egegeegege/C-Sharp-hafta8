using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Siparis siparis = new Siparis();
            siparis.OdemeTipi = OdemeTipleri.Havale;
            siparis.SiparisDurumu = SiparisDurumu.Kargoda;

        }
    }
}
