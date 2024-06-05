using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_2
{
    public class Siparis
    {
        public OdemeTipleri OdemeTipi { get; set; }
        public SiparisDurumu SiparisDurumu { get; set; }
    }

    public enum OdemeTipleri : byte
    {
        KrediKarti = 1,
        Havale,
        Eft
    }

    public enum SiparisDurumu : byte
    {
        Alindi,
        Hazirlaniyor,
        Kargoda,
        TeslimEdildi
    }
}
