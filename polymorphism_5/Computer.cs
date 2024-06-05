using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_5
{
    public class Computer
    {
        public string Brand { get; set; }
        public string CPU { get; set; }
        public int Ram { get; set; }

        public virtual void GetOptions()
        {
            Console.WriteLine("Brand: {0} - CPU: {1} - Ram: {2}",Brand,CPU,Ram);
        }
    }
}
