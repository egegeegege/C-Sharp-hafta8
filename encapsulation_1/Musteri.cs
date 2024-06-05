using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_1
{
    public class Musteri
    {
        public Guid MusteriID { get; set; } // unique (benzersiz) bir değer atar.
        public string Ad { get; set; }
        public string Soyad { get; set; }
        private string _TCKimlikNo { get; set; }  // Değerleri get yada set durumunda kontrol altına alacağım

        public string TCKimlikNo { // encapsulation (kapsülleme)
            get { 
                return _TCKimlikNo;
            }
            set
            {
                bool digitsOnly = value.All(char.IsDigit);

                if (digitsOnly)
                {
                    if(value.Length == 11)
                    {
                        _TCKimlikNo = value;
                    }
                    else
                    {
                        _TCKimlikNo = "11 hane olmalı";
                    }
                }
                else
                {
                    _TCKimlikNo = "Sayısal bir değer olmalı";
                }
            } 
        
        }  
        public Musteri()
        {
             MusteriID = Guid.NewGuid();
        }
    }
}
