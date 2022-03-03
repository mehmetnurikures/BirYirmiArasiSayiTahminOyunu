using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirYirmiArasiSayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)

        {
            int i = 1;
            Random rdn = new Random();
            int rastgele = rdn.Next(0, 20);
            while (true)
            {
                Console.Write("Bir sayı giriniz.");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi==rastgele)
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i+ " 'nci tahmininizde bilgisayarın atadığı sayıyı buldunuz. Tebrikler!");

            Console.ReadKey();
        }
    }
}
