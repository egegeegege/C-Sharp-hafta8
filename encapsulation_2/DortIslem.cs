using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_2
{
    public class DortIslem
    {
        private static int a, b;

        public int OzellikA  // encapsulation
        {
            get { return a; }
            set { a = value; }
        }
        public int OzellikB  // encapsulation
        {
            get { return b; }
            set { b = value; }
        }

        public int Topla()
        {
            return a + b;
        }
    }
}
