using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar bilgisayar = new Bilgisayar();
            bilgisayar.Fiyat = 100;
            bilgisayar.KdvHesapla();

            Elbise elbise = new Elbise();
            elbise.Fiyat = 100;
            elbise.KdvHesapla();

            Kitap kitap = new Kitap();
            kitap.Fiyat = 100;
            kitap.KdvHesapla();

            Console.ReadLine();
        }
    }
}
