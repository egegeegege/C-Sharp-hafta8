using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortIslem = new DortIslem();
            dortIslem.OzellikA = 10;
            dortIslem.OzellikB = 20;
            Console.WriteLine(dortIslem.Topla());

            Console.ReadLine();
        }
    }
}
