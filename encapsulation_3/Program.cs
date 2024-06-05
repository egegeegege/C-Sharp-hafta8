using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emlak emlak = new Emlak();
            Console.WriteLine("Daire no giriniz");
            emlak.DaireNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Oda Sayısını giriniz");
            emlak.OdaSayisi = int.Parse(Console.ReadLine());
            Console.WriteLine("Semti giriniz");
            emlak.Semt = Console.ReadLine();

            Console.WriteLine("*******************");
            Console.WriteLine(emlak.Semt);
            Console.WriteLine(emlak.DaireNo);
            Console.WriteLine(emlak.OdaSayisi);

            Console.ReadLine();
        }
    }
}
