namespace _17_OptionalMethods_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string adSoyad = Yazdir("Erkan");
            //Console.WriteLine(adSoyad);
            //Console.WriteLine("Doğum tarihi");
            //DateTime time = Convert.ToDateTime(Console.ReadLine());
            //Insan("Erkan Türk", 32, time);
            //Insan("Erkan Türk", 32, time, "Yazılım");
            //Insan("Erkan Türk", 32, time, "Yazılım", "İngiltere", "Erkek");
            ////Ben Mesleğimi belirteceğim ülke belirtmeyeceğim ama cinsiyet belirteceğim.
            //Insan("Erkan Türk", 32, time, "Yazılım", "Erkek");//hatalı tanım
            //Methodun kendi parametresini kullanma yöntemi
            Console.WriteLine("Doğum Tarihi");
           // DateTime time = Convert.ToDateTime(Console.ReadLine());

            //Insan(adSoyad:"Erkan Türk",yas:32,dogumTarihi: time, meslek:"Yazılım",cinsiyet:"Erkek");
            //Insan(adSoyad:"Erkan Türk",yas:32,dogumTarihi: time, cinsiyet:"Erkek");
            Insan(adSoyad:"Erkan Türk",yas:32,dogumTarihi: Convert.ToDateTime(Console.ReadLine()), cinsiyet:"Erkek");

        }
        static string Yazdir(string ad, string soyad = "Türk")
        {
            return ad + " " + soyad;
        }
        static void Insan(string adSoyad,int yas,DateTime dogumTarihi,
            string meslek="Serbes Meslek",string ulke="Türkiye",string cinsiyet="Belirtmek istemiyor")
        {
            Console.WriteLine($"AdSoyad:{adSoyad} Yaş:{yas} Doğum Tarihi: {dogumTarihi} Meslek:{meslek} Ülke:{ulke} Cinsiyet:{cinsiyet}");
        }
    }
}
