using System;

namespace KimMilyonerOlmakIster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bu tür bir uygulama yazarken if-else blokları mantıklı bir seçimdir. Kullanıcının girdiği cevapları kontrol etmek ve duruma göre farklı işlemler yapmak için gayet uygundur.
            Console.WriteLine("KIM MILYONER OLMAK ISTER'E HOS GELDINIZ!");
            Console.WriteLine(" 3 sorudan 2'sini doğru cevaplar  ise 1 Milyon TL'lik büyük ödülü kazanacak!");

            int correctAnswers = 0;

            Console.WriteLine("1.  Kızınca tüküren hayvan hangisidir ? ");
            Console.WriteLine("a) Lama ");
            Console.WriteLine("b) Deve");
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

            Console.WriteLine("2. Dünya'ya en yakın gezegen hangisidir ? ");
            Console.WriteLine("a) Venüs");
            Console.WriteLine("b) Mars ");
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

            Console.WriteLine("3. 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır ? ");
            Console.WriteLine("a) 12 ");
            Console.WriteLine("b) 7 ");
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
