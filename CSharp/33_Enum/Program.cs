namespace _33_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Enum
            /* Enum
             * Enumlar Sabitler olarak adlandırılan Sabit sayısal küme yapısıdır 
             * Bir veri yapısının hem metinsel hem sayısal karşılığı bulunur 
             * Örneğin İstanbul dediğimizde metinseldir 34 plakası ise sayısaldır ama bu plakanın
             * İstanbula ait olduğunu biliriz.
             * Enum yapıları da metinsel veri veritabanında tutulurken sayısal olarak tutulup kullanıcıya metinsel olarak 
             * cevap vermemizi sağlayan değiştirilemeyen yapılardır.
             * Enum varsayılan olarak 0 dan başlar 1+1 olarak artarak devam eder aynı değeri almazlar hata verirler
             * Değerler benzersiz olmalıdır eğer bir değere elle 10 değeri verirsek devam eden veri yapısı otomatik 11 olur
             * Enum yapıları genellikle int byte long gibi veri tipleri ile çalışırlar.
             * Enum yapısı varsayılan olarak int yapısını destekler.
             */
            #endregion
            //Otomobil otomobil = new Otomobil();//instance örneklem nesneleme
            //otomobil.Marka = Markalar.Nissan;
            //otomobil.Model = "GTR35";
            //otomobil.Renk = Renkler.Siyah;
            //otomobil.YakitTipi = "Benzin";
            //otomobil.UretimYili = 2025;
            //otomobil.Vites = Vitestler.Otomatik;
            //otomobil.OzellikYaz();
            #region Enum yapıları kullanma prensipleri
            //Console.WriteLine(Markalar.Bmw);
            //Console.WriteLine((int)Markalar.Bmw);
            //string[] markalar = Enum.GetNames(typeof(Markalar));
            //foreach (string item in markalar)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("************");
            //byte[] degerler = (byte[])Enum.GetValues(typeof(Markalar));
            //foreach (int item in degerler)
            //{
            //    Console.WriteLine(item);
            //}
            //bool sonuc = Enum.IsDefined(typeof(Renkler), 5);//True false olarak cevap verir;
            //Console.WriteLine(sonuc);
            //bool sonuc2 = Enum.IsDefined(typeof(Renkler), "Siyah");
            //Console.WriteLine(sonuc2);

            //int sayi = 15;
            //for (int i = 0; i <= sayi; i++)
            //{
            //    string backColor = i.ToString();
            //    string foreColor = i.ToString();
            //    Console.BackgroundColor=(ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //    Console.ForegroundColor=(ConsoleColor)Enum.Parse (typeof(ConsoleColor), foreColor);
            //    Console.Clear();
            //    Thread.Sleep(100);
            //    if (i == 15)
            //    {
            //        i = 0;
            //        continue;
            //    }
            //}
            //Console.WriteLine("BC");
            //string backColor = Console.ReadLine();
            //Console.WriteLine("FC");
            //string foreColor = Console.ReadLine();
            //Console.BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), backColor);
            //Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), foreColor);
            //Console.WriteLine("Renk ayarlandı");
            //int renk = ((int)Renkler.Turuncu);
            //Console.WriteLine(renk);
            Console.WriteLine("Renk ara");
            string ara = Console.ReadLine();
            Renkler renks = (Renkler)Enum.Parse(typeof(Renkler), ara);
            Console.WriteLine(renks);
            //while (true)
            //{
            //    Console.WriteLine("0 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 1 0 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 10 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 10 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 10 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 10 1 0 1 0 1 0 1 0 1 1 1 0 0 1 1 1");
            //}

            #endregion


        }
    }
    enum Markalar:byte { Honda=2,Mercedes,Bmw,Ford=7,Renault,Nissan}
    enum Vitestler { Manuel,Otomatik, YarıOtomatik }
  

    class Otomobil
    {
        public Markalar Marka { get; set; }
        public Vitestler Vites { get; set; }
        public Renkler Renk { get; set; }
        public int UretimYili { get; set; }
        public string Model { get; set; }
        public string YakitTipi { get; set; }

        public void OzellikYaz()
        {
            Console.WriteLine($"Marka:{Marka} Vites:{Vites} Renk:{Renk} Model:{Model} Yakıt:{YakitTipi} Üretim Yılı:{UretimYili}");
        }
    }
}
