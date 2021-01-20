using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farkliTurlerdeUrunEkleme
{
    class Program
    {
        static void Main(string[] args)
        {
            islemler i = new islemler();
            string exit = "e";

            while (exit=="e")
            {
                Console.WriteLine("Lütfen tür seçiniz: \n1.Elektronik\n2.Gıda\n3.Multimedia");
                string secenek = Console.ReadLine();

                if (secenek=="1")
                {
                    elektronik dizi = new elektronik();

                    Console.WriteLine("Marka giriniz.");
                    dizi.marka = Console.ReadLine();
                    Console.WriteLine("Model giriniz.");
                    dizi.model = Console.ReadLine();
                    Console.WriteLine("Fiyat giriniz.");
                    dizi.fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Stok giriniz.");
                    dizi.stok = Convert.ToInt32(Console.ReadLine());
                    i.ekle(dizi);
                }
                else if (secenek == "2")
                {
                    gida dizi = new gida();

                    Console.WriteLine("Marka giriniz.");
                    dizi.marka = Console.ReadLine();
                    Console.WriteLine("Ürün adı giriniz.");
                    dizi.urunAdi = Console.ReadLine();
                    Console.WriteLine("SKT giriniz.");
                    dizi.sonKullanmaTarihi = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Fiyat giriniz.");
                    dizi.fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Stok giriniz.");
                    dizi.stok = Convert.ToInt32(Console.ReadLine());
                    i.ekle(dizi);
                }
                else if (secenek=="3")
                {
                    multimedia dizi = new multimedia();

                    Console.WriteLine("Ürün adı giriniz.");
                    dizi.urunAdi = Console.ReadLine();
                    Console.WriteLine("Yayımcı giriniz.");
                    dizi.yayimci = Console.ReadLine();
                    Console.WriteLine("Fiyat giriniz.");
                    dizi.fiyat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Stok giriniz.");
                    dizi.stok = Convert.ToInt32(Console.ReadLine());
                    i.ekle(dizi);
                }
                Console.WriteLine("Devam etmek istiyor musunuz? e/h");
                exit = Console.ReadLine();
            }
            i.yazdir();
        }
    }
}
