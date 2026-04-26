namespace _08_Donguler_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Loops(Döngüler) 
             * Bir işin tekrar tekrar aynı işlemleri yapmasına döngü denilir 
             * Program içerisinde döngüler bir değerin birden fazla kez çalışmasını sağlar 
             * Döngü yapısı true olduğu sürece çalışır false durumunda döngü sonlanır
            */
            #region For örneği
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //Console.WriteLine("Erkan");
            //for (int i = 0 => veri yapısı ; i < 10 koşul; i++ artış veya azalış)
            //{

            //}
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("Erkan");
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i > 0; i--)//Koşul false olduğunda sonlanır.
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region kullanıcıdan alınan bir sayının faktöriyelini hesaplama
            //5=>1*2*3*4*5=>120
            //Console.WriteLine("faktoriyel hesaplanacak sayı");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //int deger = 1;
            //for (int i = 1; i <= sayi; i++)
            //{
            //    deger *= i;
            //}
            //Console.WriteLine(deger);
            #endregion
            #region Çarpım tablosu
            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} = {i * j}\t");//\t bir tab boşluk bırak
            //    }
            //    Console.WriteLine();
            //}

            // 2 den başlayarak 200 e kadar 2nin katlarını ekrana yazdıran döngü
            //for (int i = 2; i <= 200; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 0; i < 10;)//Sonsuz döngü
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //for (; ; )
            //{
            //    Console.WriteLine("Sonsuz döngü");
            //}


            #endregion

            #region Kullanıcıdan alınacak değer
            //Kullanıcıdan sayı alacağız kullanıcıdan aldığımız sayıları toplayacağız
            //kullanıcı 0 a basarsa döngü sonlanacak ve toplam miktar ekrana yazılacak.
            ////Kullanıcı ilk girdiği sayı 0 sa ilk sayı sıfır girilemez deyip tekrardan sayı girmesini isteyeceğiz.
            //int toplam = 0;
            //int sayac = 0;

            //for (; ; )
            //{
            //    Console.WriteLine("Bir sayı giriniz");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi == 0 && sayac == 0)
            //    {
            //        Console.WriteLine("İlk değer 0 girilemez");
            //        continue;//Yapıda atlama işlemi yapar adımı es geçer
            //    }
            //    if (sayi == 0)
            //    {
            //        break;//Döngüyü sonlandırır.
            //    }
            //    if (sayi < 0)
            //    {
            //        Console.WriteLine("Lütfen Pozitif Sayı Giriniz");
            //        continue;
            //    }
            //    toplam += sayi;
            //    sayac++;

            //}
            //Console.WriteLine("Toplam:" + toplam);
            //Console.WriteLine("Ortalama:" + (toplam / sayac));
            //Console.WriteLine("Sayac toplamı:" + sayac);

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i == 5 || i == 6)
            //    {
            //        continue;//5 ve 6 yı atla diğerlerini yazdır
            //    }
            //    if (i == 9)
            //    {
            //        break;//9 a gelince döngüyü sonlandır
            //    }
            //    Console.WriteLine(i);
            //}
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Erkan");
            }
            #endregion
        }
    }
}
