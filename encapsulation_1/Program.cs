using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Encapsulation (Kapsülleme)
            // Sınıf bazında propertylerin get, set durumu kontrol altına almamızı ve verinin istenilen şarta uygunluğunu kontrol eder.

            Musteri musteri = new Musteri();
            Console.WriteLine(musteri.TCKimlikNo); // get
            musteri.TCKimlikNo = "AAAAAAAA"; // set
            Console.WriteLine(musteri.TCKimlikNo);
            musteri.TCKimlikNo = "23423424422"; // set
            Console.WriteLine(musteri.TCKimlikNo);

            Console.ReadLine();
        }
    }
}
