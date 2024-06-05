using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_5
{
    public class Notebook : Computer
    {
        public bool Wifi { get; set; }
        public bool Bluetooth { get; set; }

        public override void GetOptions()
        {
            Console.WriteLine("Brand: {0} - CPU: {1} - Ram: {2} - Wifi: {3} - Bluetooth: {4}", Brand, CPU, Ram,Wifi, Bluetooth);
        }
    }
}
