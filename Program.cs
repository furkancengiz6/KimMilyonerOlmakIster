using System;

namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("KIM MILYONER OLMAK ISTER'E HOS GELDINIZ!");
            Console.WriteLine(" 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!");

            int correctAnswers = 0;

            Console.WriteLine("1. Soru  hangisi bla bla ");
            Console.WriteLine("a) asd");
            Console.WriteLine("b) asd");
            string answers1 = Console.ReadLine().ToLower();

            if (answers1 == "a")
            {
                Console.WriteLine("Dogru Cevap ");
                correctAnswers++;

            }
            else 
            {
                Console.WriteLine("Yanlıs Cevap ");
                
            }

            Console.WriteLine("2. Soru  hangisi bla bla ");
            Console.WriteLine("a) asd");
            Console.WriteLine("b) asd");
            string answers2 = Console.ReadLine().ToLower();
            if (answers2 == "b")
            {
                Console.WriteLine("Dogru Cevap ");
                correctAnswers++;

            }
            else
            {
                Console.WriteLine("Yanlıs Cevap ");
            }

            if (correctAnswers == 0)
            {
                Console.WriteLine($"Maalesef  sansınız kalmadı puan: {correctAnswers}");
            }
            else 
            {
                Console.WriteLine($"Son sansınız puan: {correctAnswers}");

            }

            Console.WriteLine("3. Soru  hangisi bla bla ");
            Console.WriteLine("a) asd");
            Console.WriteLine("b) asd");
            string answers3 = Console.ReadLine().ToLower();

            if (answers3 == "a")
            {
                Console.WriteLine("Dogru Cevap ");
                correctAnswers++;

            }
            else
            {
                Console.WriteLine("Yanlıs Cevap ");
            }
            if (correctAnswers >= 2)
            {
                Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
            }
            else
            {
                Console.WriteLine("Maalesef büyük ödülü kazanamadınız.");
            }
        }
    }
}
