using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism (Çok Biçimcilik)
            // Bir nesnenin farklı amaçlar içinde kullanılabileceği anlamına gelir.
            // Statik ve Dinamik olmak üzere 2 ye ayrılır.
            // Static polymorphism: method yada operatörlerin aşırı yüklenmesi (overload) olarak belirtilir.
            // Dinamic polymorphism: soyut sınıflardan miras yoluyla işlemlerin gerçekleşmesi durumdur.
            // virtual keyword
            // Temel sınıfa ait bir method bazen türemiş sınıfta farklı şekilde kullanılabilir.
            // Temel sınıftaki bu methodun türemiş sınıfta yeniden düzenlenebilmesi için temel sınıftaki methodun düzenlenebilir veya değiştirilebilir olduğunu belirtmemiz gerekir. Bu durumda "virtual" anahtar kelimesini kullanırız. Virtual o methodun miras alınan türemiş sınıfta düzenlenebilir veya değiştirilebilir (override) olduğunu gösterir.

            // Methodu override etmek nedir ve methodun ezilmesi durumu nedir ?
            // Temel sınıfta "virtual" anahtar kelimesi ile tanımlanmış bir method türemiş sınıfta yeniden yazılmas için (geçersiz kılma) "override" anahtar kelimesi kullanılır. Temel sınıfta "virtual" anahtar kelimesi kullanılmadıysa yada method static olarak işaretlendiyse alt sınıfta ben bu methodu override edemem.
            
            // Overload
            StaticPolymorphism staticPolymorphism = new StaticPolymorphism();
            staticPolymorphism.Yaz(30, "Ali");
            staticPolymorphism.Yaz("Ali");
            staticPolymorphism.Yaz("Ali","Demir");

            Console.ReadLine();
        }
    }
}
