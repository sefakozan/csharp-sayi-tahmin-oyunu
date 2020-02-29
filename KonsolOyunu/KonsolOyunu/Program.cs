using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsolOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sıra Sende, Aklımdan 0-100 arası bir sayı tuttum!..");
            Console.WriteLine("Tahmin et!..\n");

            Random randomsayi = new Random();
            int rastgeleSayi = randomsayi.Next(0, 100);
            int saymaSayisi = 01;

            for (; saymaSayisi <= int.MaxValue; saymaSayisi++)
            {
                Console.Write("({0})> ", saymaSayisi);
                int tutulanSayi;
                string metin = Console.ReadLine();
                tutulanSayi = Convert.ToInt32(metin);

                if (rastgeleSayi > tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı tuttum!..\n");
                }
                else if (rastgeleSayi < tutulanSayi)
                {
                    Console.WriteLine("Daha küçük bir sayı tuttum!..\n");
                }
                else
                {
                    Console.WriteLine("Doğru, tuttugum sayı {0} !..", rastgeleSayi);
                    Console.WriteLine("Dogru cevabı {0} hamlede buldun.", saymaSayisi);
                    Console.WriteLine("Eger ben daha az hamlede senin tuttugun sayıyı bulursam kazanırım.\n");
                    Console.WriteLine("Şimdi Aklından 0-100 arasından bir sayı tut.");
                    Console.WriteLine("Tuttuysan devam etmek için herhangi bir tuşa bas!..");
                    break;
                }

            }
            // Burdan sonra ikinci aşama.
            Console.ReadKey();
            Console.WriteLine("\n");

            // İkinci Aşamaya Geçildi.
            Random randomSayi = new Random();
            int pcTahmini=0, enKucuk = 0, enBuyuk = 100;
            string cevap;

            for (int saymaSayisi2 = 1; saymaSayisi2 < int.MaxValue; saymaSayisi2++)
            {
                if (saymaSayisi2 == 1)
                {
                    pcTahmini = randomSayi.Next(enKucuk, enBuyuk);
                }
                else 
                {
                    pcTahmini = (enBuyuk + enKucuk) / 2;
                }
                

                Console.WriteLine("{0}. tuttuğun sayı = {1}", saymaSayisi2, pcTahmini);
                Console.WriteLine("'küçük|kucuk', 'büyük|buyuk' yada 'eşit|esit' yazınız!..");
                Console.Write("> ");
                cevap = Console.ReadLine();

                if (cevap == "büyük" || cevap == "buyuk")
                {
                    enKucuk = pcTahmini;
                }
                else if (cevap == "küçük" || cevap == "kucuk")
                {
                    enBuyuk = pcTahmini;
                }
                else if (cevap == "eşit" || cevap == "esit")
                {
                    Console.WriteLine("Doğru bildim!..");
                    Console.WriteLine("Senin tahmin sayın = {0}", saymaSayisi);
                    Console.WriteLine("Benim tahmin sayım = {0}", saymaSayisi2);

                    if (saymaSayisi < saymaSayisi2)
                    {
                        Console.WriteLine("Kullanıcı Kazandı!..");
                    }
                    else if (saymaSayisi2 < saymaSayisi)
                    {
                        Console.WriteLine("Bilgisayar Kazandı!..");
                    }
                    else if (saymaSayisi == saymaSayisi2)
                    {
                        Console.WriteLine("Berabere Kaldık :(");
                    }
                    Console.WriteLine("Program sonlandı, Çıkmak için herhangi bir tuşa basınızı!..");
                    break;
                }

      

            }
            // program sonlandı
            Console.ReadKey();

        }
    }
}
