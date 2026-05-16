using System;
using System.Collections.Generic;
using System.Text;

namespace _32_Class_Object
{
    internal class Ogrenci
    {
        //=0 varsayılan değer ataması yapar. yani OgrenciNo değeri tanımlanmazsa otomatik olarak 0 atanır.
        private int OgrenciNo { get; set; }=0;//Get getirmek için kullanılır
                                           //Set var olan değeri güncellemek yada olmayan değeri oluşturmak için kullanılır
        private string OgrenciAd { get; set; }=string.Empty;
        //string.Empty string tipinin boş değerini temsil eder. yani OgrenciAd değeri tanımlanmazsa otomatik olarak boş string atanır.
        private string OgrenciSoyad { get; set; }=string.Empty;
        private string Bolumu { get; set; }=string.Empty;


        private void Test()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine($"Öğrenci Ad: {OgrenciAd}");
            Console.WriteLine($"Öğrenci Soyad: {OgrenciSoyad}");
            Console.WriteLine($"Bölüm: {Bolumu}");
        }

    }
}
