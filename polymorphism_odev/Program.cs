﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Projemiz sanal market olacak.
             Yani hem gıda hemde elektronik ürünleri satabilecek.
             Satın almak istediğimiz ürünü sepete ekleyebilecek.
             Siparişi vermeden önce, sepetteki tüm ürünlerin fiyatlarının toplamı alınarak müşteriye ödemesi gereken fiyat gösterilecek bu ürünlerin her bir kategoride kdv
            oranları farklı olacak ve fiyat bu kdv oranlarına göre hesaplanacak.

            // Yapılacaklar
            Bir adet temel Urun sınıfı oluşuturulacak. (Property => UrunAdi, Fiyat)
            Elektronik ve Gida adında 2 adet türeyene sınıf oluşturulacak ve Urun sınıfından miras alacak. (Urun sınıfında tanımlanmış KdvHesapla adlı method virtual olarak işaretlenip Elektronik ve Gida sınıfında bu method override edilecek.)
            Sepet adında bir sınıf oluşturulacak ve bu sınıfta 1 adet List<Urun> tipinde bir property olcak bununla beraber sepet sınıfında SepeteEkle ve ToplamTutar adlı 2 adet method olacak.         
             
             */
        }
    }
}