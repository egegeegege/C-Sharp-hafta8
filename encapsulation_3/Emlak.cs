using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_3
{
    public class Emlak
    {
        private string _Semt;

        public string Semt // value = kayışdağı => KAYIŞDAĞI
        {
            get { return _Semt; }
            set { 
                _Semt = value.ToUpper();
            }
        }

        private int _DaireNo;

        public int DaireNo
        {
            get { return _DaireNo; }
            set
            {
                _DaireNo = Math.Abs(value);
            }
        }

        private int _OdaSayisi;

        public int OdaSayisi
        {
            get { return _OdaSayisi; }
            set
            {
                _OdaSayisi = Math.Abs(value);
            }
        }
    }
}
