using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dinamic polymorphism

            Daire daire = new Daire(10);
            Console.WriteLine(daire.Alan());
            Kure kure = new Kure(10);
            Console.WriteLine(kure.Alan());
            Dikdortgen dikdortgen = new Dikdortgen(10,20);
            Console.WriteLine(dikdortgen.Alan());
            Console.ReadLine();
        }
    }
}
