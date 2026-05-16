using System;
using System.Collections.Generic;
using System.Text;

namespace _32_Class_Object_2
{
    internal static class Araba2
    {
        public static int Id { get; set; }
        public static string Marka { get; set; }
        public static string Model { get; set; }
        public static double Fiyat { get; set; }

        public static void Kaydet()
        {
            Console.WriteLine("Marka:");
            Marka = Console.ReadLine();
            Console.WriteLine("Model:");
            Model = Console.ReadLine();
            Console.WriteLine("Fiyat");
            Fiyat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Araba:{Marka} Model:{Model} Fiyat:{Fiyat}");
        }
    }
}
