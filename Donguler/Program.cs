using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "Python" , "C#"};
            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("sayfasonu - footer");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
