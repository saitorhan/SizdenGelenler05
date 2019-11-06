using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizdenGelenler05
{
    class Program
    {
        static void Main(string[] args)
        {
            double urunFiyati, komisyonToplami = 0;
            string okunan;
            double[] komisyonlar = new double[5];

            for (int i = 0; i < 5;)
            {
                Console.WriteLine("{0}. Ürün Fiyatını Giriniz:", i+1);
                okunan = Console.ReadLine();

                // string sayi dönüşüm işlemleri için https://youtu.be/IjuDU5AMTOI linkinden ilgili videomu izleyebilirsiniz. 
                if (!Double.TryParse(okunan, out urunFiyati) || urunFiyati < 0)
                {
                    Console.WriteLine("Girilen değer doğru formatta değil.");
                    continue;
                }

                komisyonlar[i] = urunFiyati > 50 ? urunFiyati * 0.025 : urunFiyati * 0.03;
                komisyonToplami += komisyonlar[i];
                i++;
            }

            Console.WriteLine("Alınan Toplam Komisyon: {0:F2}", komisyonToplami);
            Console.WriteLine("Sırayla Ürün Komisyonları");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. Ürün Komisyonu: {1:F2}", i+1, komisyonlar[i]);
            }

            Console.ReadLine();
        }
    }
}
