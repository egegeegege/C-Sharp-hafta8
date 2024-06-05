using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Brand = "Asus";
            computer.Ram = 16;
            computer.CPU = "Intel";
            computer.GetOptions();

            Notebook notebook = new Notebook();
            notebook.Brand = "Macbook";
            notebook.Ram = 32;
            notebook.CPU = "M2";
            notebook.Wifi = true;
            notebook.Bluetooth = true;
            notebook.GetOptions();

            Console.ReadLine();
        }
    }
}
