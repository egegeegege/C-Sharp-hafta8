using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_1
{
    enum GUNLER : byte
    {
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GUNLER.Pazartesi);

            Console.ReadLine(); 
        }
    }

}
