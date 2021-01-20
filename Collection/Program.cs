using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");

            List<string> isimler3 = new List<string>()
            {"Engin", "Murat", "Kerem" };
            Console.WriteLine(isimler3[0]);
            Console.WriteLine(isimler3[1]);
            Console.WriteLine(isimler3[2]);
            isimler3.Add("İlker");
            Console.WriteLine(isimler3[3]);
            Console.WriteLine(isimler3[0]);
            


        }
    }
}
