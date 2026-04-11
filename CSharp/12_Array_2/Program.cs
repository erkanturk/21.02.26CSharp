namespace _12_Array_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array Örnek
            //Kullanıcıdan kelime girmesini isteyelim 
            //Kullanıcının girdiği her kelimenin harflerini tek tek diziye aktaralım 
            //Ve aktarılan her harfi tersten yazdıralım

            //Console.WriteLine("Bir metin giriniz");
            //string metin = Console.ReadLine();
            //char[] harfler = new char[metin.Length];
            //int i = 0;
            //foreach (char harf in metin)
            //{
            //    harfler[i] = metin[i];

            //    Console.WriteLine(harf);
            //    i++;

            //}
            //Console.WriteLine("************");
            //Console.WriteLine();
            //Array.Reverse(harfler);
            //for (int j = 0; j < harfler.Length; j++)
            //{
            //    Console.WriteLine(harfler[j]);
            //}
            #endregion
            #region Array Örnek 2
            //Kullanıcıdan 10 sayı girmesini isteyelim
            //Kullanıcının girdiği sayılardan 3 ün katı  olan sayıları  bir diziye  atalım ve bu diziyi yazdıralım 

            //int[] sayilar = new int[10];
            //for (int i = 0; i < sayilar.Length;)
            //{
            //    Console.WriteLine($"3 ün katlarını girin {i + 1}.Sayi");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi % 3 == 0)
            //    {
            //        sayilar[i] = sayi;
            //        i++;
            //    }

            //}
            //foreach (int sayi in sayilar)
            //{
            //    Console.WriteLine(sayi);
            //}


            //Kullanıcıdan minimum 10 sayı girmesini isteyelim dizinin miktarını kullanıcı belirlesin
            //örneğin kullanıcı 15 sayı girecek ve bu sayılar diziye aktarılacak
            //Dizideki çiftleri ve tekleri ayrı ayrı toplanacak ekrana yazdırılacak 
            //Console.WriteLine("10 veya daha büyük bir sayı giriniz");
            //int miktar = Convert.ToInt32(Console.ReadLine());
            //int[] dizi = new int[miktar];
            //int tekToplam = 0;
            //int ciftToplam = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}.sayı");
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());

            //}
            //foreach (int sayi in dizi)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    else
            //    {
            //        tekToplam += sayi;
            //    }

            //}
            //Console.WriteLine("Tek sayılar: " + tekToplam);
            //Console.WriteLine("Çift sayılar: "+ciftToplam);



            #endregion
            #region Random Dizi
            //Random random = new Random();
            //int randomSayi = random.Next(1, 21);//dizinin uzunluğu
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //int[] randomSayilar = new int[randomSayi];
            //for (int i = 0; i < randomSayilar.Length; i++)
            //{
            //    randomSayilar[i] = random.Next(1, 50);//eleman değerleri 

            //}
            //Console.WriteLine("*************");
            //for (int i = 0; i < randomSayilar.Length; i++)
            //{
            //    Console.WriteLine(randomSayilar[i]);
            //}
            //Console.WriteLine("*************");
            //foreach (int sayi in randomSayilar)
            //{
            //    if (sayi % 2 == 0)
            //    {
            //        ciftToplam += sayi;
            //    }
            //    else
            //    {
            //        tekToplam += sayi;
            //    }
            //}

            //Console.WriteLine("Tek toplam: " + tekToplam);
            //Console.WriteLine("Çift toplam: " + ciftToplam);


            #endregion
            #region Try Parse
            string[] meyveler = { "elma", "armut", "muz", "çilek", "karpuz" };
            Console.WriteLine("Bir ürün seçin");
            int i =0;
            foreach (string meyve in meyveler)
            {
                Console.WriteLine(meyve + " => " + i);
                i++;
            }
            string secim = Console.ReadLine();
            if (int.TryParse(secim, out int index))//tryparse yapısı true false değer döndürür eğer kullanıcı sayı girmişse
                                                   //sayısal olarak index değerini arar metinsel ise metinsel olarak devam eder.
            {
                if (index == 0)
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
                else if (index == 1)
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
                else if (index == 2)
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
                else if (index == 3)
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
                else if (index == 4)
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
                else
                {
                    Console.WriteLine($"{meyveler[index]} alındı");
                }
            }
            else
            {
                int index2=Array.IndexOf(meyveler, secim);//kullanıcının girdiği metinsel değerin meyveler dizisinde olup olmadığını kontrol eder

                if (secim == "elma")
                {
                    Console.WriteLine($"{meyveler[index2]} alındı");
                }
                else if (secim == "armut")
                {
                    Console.WriteLine($"{meyveler[index2]} alındı");
                }
                else if (secim == "muz")
                {
                    Console.WriteLine($"{meyveler[index2]} alındı");
                }
                else if (secim == "çilek")
                {
                    Console.WriteLine($"{meyveler[index2]} alındı");
                }
                else if (secim == "karpuz")
                {
                    Console.WriteLine($"{meyveler[index2]} alındı");
                }
                else
                {
                    Console.WriteLine("Geçersiz meyve");
                }
            }

            #endregion
        }
    }
}
