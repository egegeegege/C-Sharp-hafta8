using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev
            /* 
             Not adında bir sınıf oluşturulacak. Propertyleri Vize ve Final olacak.
             Methodları VizeFinalBelirle(int v, int f) , OrtalamaAl adlı geriye double döndürecek ve Öğrencinin Vize,Final ve Ortalaması ekrana yazdıracak methodlar olacak.

             */

            Not not = new Not();
            not.VizeFinalBelirle(100,50);
            Console.WriteLine(not.OrtalamaAl());

            Console.ReadLine();
        }
    }
}
