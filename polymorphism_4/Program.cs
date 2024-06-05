using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Calis();

            Muhendis muhendis = new Muhendis();
            muhendis.Calis();

            Console.ReadLine();
        }
    }
}
