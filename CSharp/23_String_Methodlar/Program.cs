namespace _23_String_Methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin = "C# Dersleri";
            string[] metinler = { "Merhaba", "String", "Methodlar" };
            string ad = "Erkan";
            string soyad = "Türk";
            string text = "    String Methodlar    ";
            Console.WriteLine($"String uzunluğu: {metin.Length}");
            Console.WriteLine($"String Büyültme: {metin.ToUpper()}");
            Console.WriteLine($"String Küçültme: {metin.ToLower()}");
            bool buldum = metin.Contains("C#");//Metin değişkeninin içerisinde C# var ise true dönderir yok ise false
            Console.WriteLine(buldum);
            string degistirilmisMetin = metin.Replace("C#", "CSharp");
            Console.WriteLine("Değiştirilmiş metin: " + degistirilmisMetin);
            string birlestirilmisMetin = string.Join("=>", metinler);
            Console.WriteLine("Birleştirilmiş dizi: " + birlestirilmisMetin);

            string adSoyad = string.Concat(ad, " ", soyad);
            Console.WriteLine($"Concat ile birleştirilmiş değer: {adSoyad}");
            Console.WriteLine($"Boşluklarından arındırılmamış: {text} vs Arındırılmış: {text.Trim()}");

            string[] diziyeDonusum = metin.Split(' ');
            foreach (string deger in diziyeDonusum)
            {
                Console.WriteLine(deger);
            }

            string lang = "C# String Hazır Methodlar";
            string alinanMetin = lang.Substring(0, 6);//başlangıç index bitiş uzunluğu verilerek o değere kadar al deriz.
            Console.WriteLine(alinanMetin);
            bool dogru = metin.StartsWith("C");
            Console.WriteLine(dogru);
            string metinsel = null;//Null
            string metinsel2 = "";//Empty
            bool deger2 = string.IsNullOrEmpty(metinsel2);//True veya false değer döndürür.
            Console.WriteLine(deger2);
            Console.WriteLine(string.Equals(metinsel, metinsel2));//True veya false olarak karşılaştırma yapar. 
            

        }
    }
}
