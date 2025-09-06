using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tas_kagıt_makas_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] secenekler = { "taş", "kağıt", "makas" };
            Random random = new Random();
            bool oyunDevam = true;
            while (oyunDevam)
            {
                int oyuncuSkor = 0;
                int bilgisayarSkor = 0;
                Console.WriteLine("******* TAŞ-KAĞIT-MAKAS OYUNU *******");
                while (oyuncuSkor < 3 && bilgisayarSkor < 3)
                {
                    Console.Write("Seçiminizi yapın (taş, kağıt, makas): ");
                    string oyuncuSecim = Console.ReadLine().ToLower();
                    if (Array.IndexOf(secenekler, oyuncuSecim) == -1)

                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen tekrar deneyin.");
                        continue;
                    }
                    int bilgisayarIndex = random.Next(secenekler.Length);
                    string bilgisayarSecim = secenekler[bilgisayarIndex];
                    Console.WriteLine($"Bilgisayarın seçimi: {bilgisayarSecim}");
                    if (oyuncuSecim == bilgisayarSecim)
                    {
                        Console.WriteLine("Berabere!");
                    }
                    else if ((oyuncuSecim == "taş" && bilgisayarSecim == "makas") ||
                            (oyuncuSecim == "kağıt" && bilgisayarSecim == "taş") ||
                            (oyuncuSecim == "makas" && bilgisayarSecim == "kağıt"))
                    {
                        Console.WriteLine("Tebrikler! Bir puan kazandınız.");
                        oyuncuSkor++;
                    }
                    else
                    {
                        Console.WriteLine("Bilgisayar bir puan kazandı.");
                        bilgisayarSkor++;
                    }
                    if (oyuncuSkor == 3)
                    {
                        Console.WriteLine("Tebrikler! Oyunu kazandınız!");
                    }
                    else if (bilgisayarSkor == 3)
                    {
                        Console.WriteLine("Bilgisayar oyunu kazandı. Tekrar deneyin!");
                    }
                    Console.WriteLine($"Skor - Siz: {oyuncuSkor}, Bilgisayar: {bilgisayarSkor}");
                }
                if (oyuncuSkor == 3)
                {
                    Console.WriteLine("Tebrikler! Oyunu kazandınız!");
                }
                else
                {
                    Console.WriteLine("Bilgisayar oyunu kazandı.");
                }
                Console.WriteLine("Tekrar oynamak ister misiniz?(e/h)");
                String cevap = Console.ReadLine().ToLower();
                if (cevap != "e")
                {
                    oyunDevam = false;
                    Console.WriteLine("Oyun sona erdi.Teşekkürler!");
                    Console.WriteLine();
                }

            }

        }
    }
}