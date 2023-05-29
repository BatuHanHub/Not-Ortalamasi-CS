using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan veriler alınıyor...
            int not1 = Convert.ToInt32(Console.ReadLine());
            int not2 = Convert.ToInt32(Console.ReadLine());
            int not3 = Convert.ToInt32(Console.ReadLine());
            int devamsizlik = Convert.ToInt32(Console.ReadLine());

            // Minik hesaplamalar yapılıyor...
            int notOrt = (not1 + not2 + not3) / 3;
            Convert.ToString(notOrt);

            if (devamsizlik > 20)
            {
                Console.WriteLine("Devamsızlıktan kaldınız");
            }
            else
            {
                if (notOrt >= 50)
                {
                    Console.WriteLine("Not Ortalamanız: " + notOrt);
                    Console.WriteLine("Geçtiniz");
                }
                else
                {
                    Console.WriteLine("Not Ortalamanız: " + notOrt);
                    Console.WriteLine("Not ortalamasından kaldınız");
                }
            }
        }
    }
}