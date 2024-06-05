using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ödev
            // Product adlı bir sınıf olacak. Bu sınıfının özellikleri ProductId, ProductName, Price, Discount, Category olacak. Bir döngüde bu ürün 10 defa oluşturulacak. ve ürünün özellikleri yazılacak. Ve generici Product olan bir List e atılacak. Daha sonra List in içindeki tüm ürünler özellikleri ile beraber ekrana yazılacak.

            Console.WriteLine("Ürün sayısı giriniz");
            int urunSayisi = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();

            for (int i = 1; i <= urunSayisi; i++)
            {
                Product product = new Product();
                Console.WriteLine("Ürün adı:");
                product.ProductName = Console.ReadLine();
                Console.WriteLine("Ürün fiyatı:");
                product.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Ürün indirim:");
                product.Discount = double.Parse(Console.ReadLine());
                Console.WriteLine("Kategori:");
                product.Category = Console.ReadLine();

                products.Add(product);

            }

            foreach (var p in products)
            {
                Console.WriteLine(p.ProductId);
                Console.WriteLine(p.ProductName);
                Console.WriteLine(p.Price);
                Console.WriteLine(p.Discount);
                Console.WriteLine(p.Category);
            }

            Console.ReadLine();

        }
    }
}
