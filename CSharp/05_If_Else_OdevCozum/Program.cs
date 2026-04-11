namespace _05_If_Else_OdevCozum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            //Kullanıcıdan 3 adet sayı alınız ve bu sayıları A şeklinde görüldüğü gibi büyükten küçüğe sıralayınız 
            //ve ekrana yazdırınız
            //A Şekli: 15>13>5 Console.WriteLine(15) Console.WriteLine(13) Console.WriteLine(5)

            //2. ödev
            //Kullanıcıdan şu anki hava sıcaklığını isteyip;
            //Hava sıcaklığı; 5 derece altındaysa "Hava soğuk,Kalın giysiler giyin" uyarısı yapsın.
            // 5 ile 15 arasında ise ; "Hava serin ceket giymeyi unutma" uyarısı.
            //15 ile 25 arasında ise ; "Hava ılık. Rahat şeyler giyebilirsin" uyarısı versin.
            //25 üzeri ise; Hava sıcaK uyarısı versin. 
            //3.Ödev

            //kullanıcıdan isim , yaş, maaş ve çocuk sayısı istenecek 
            //eğer kullanıcı 45 yaşının altında ise çocuk sayısına bakılacak
            //ve çocuk sayısı 3'ten az ise çocuk başına 2500₺ 3'ten fazla ise çocuk başına 2000₺ maaş eklemesi yapılacak
            //45 in üzerinde ise çocuk başına para verilmeyecek ancak 5000₺ ekleme yapılacak
            //Son olarak ekrana :Erkan Türk Maaşınız 40000₺ yazılacak.
            #endregion
            #region 3 Sayı ödevi
            //Console.WriteLine("1.Sayıyı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayıyı giriniz");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("3.Sayıyı giriniz");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());
            //if (sayi > sayi2 && sayi > sayi3)
            //{
            //    Console.WriteLine("En Büyük sayı:" + sayi);
            //    if (sayi2 > sayi3)
            //    {
            //        Console.WriteLine(sayi+"=>"+sayi2+"=>"+sayi3);
            //        Console.WriteLine("Ortanca Sayı: " + sayi2);
            //        Console.WriteLine("En küçük sayı: " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı: " + sayi3);
            //        Console.WriteLine("En küçük sayı: " + sayi2);
            //    }
            //}
            //else if (sayi2 > sayi && sayi2 > sayi3)
            //{
            //    Console.WriteLine("En Büyük sayı:" + sayi2);
            //    if (sayi > sayi3)
            //    {
            //        Console.WriteLine("Ortanca Sayı: " + sayi);
            //        Console.WriteLine("En küçük sayı: " + sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı: " + sayi3);
            //        Console.WriteLine("En küçük sayı: " + sayi);
            //    }
            //}
            //else if (sayi3 > sayi2 && sayi3 > sayi)
            //{
            //    Console.WriteLine("En Büyük sayı:" + sayi3);
            //    if (sayi > sayi2)
            //    {
            //        Console.WriteLine("Ortanca Sayı: " + sayi);
            //        Console.WriteLine("En küçük sayı: " + sayi2);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ortanca Sayı: " + sayi2);
            //        Console.WriteLine("En küçük sayı: " + sayi);
            //    }
            //}

            #endregion

            #region sıcaklık ödevi
            //Console.WriteLine("Lütfen hava durumunu belirtiniz.");
            //int sicaklik = Convert.ToInt32(Console.ReadLine());
            //if (sicaklik < 5)
            //{
            //    Console.WriteLine("Hava soğuk,Kalın giysiler giyin");
            //}
            //else if (sicaklik >= 5 && sicaklik < 15)
            //{
            //    Console.WriteLine("Hava serin ceket giymeyi unutma");
            //}
            //else if (sicaklik >= 15 && sicaklik < 25)
            //{
            //    Console.WriteLine("Hava ılık. Rahat şeyler giyebilirsin");
            //}
            //else
            //{
            //    Console.WriteLine("Hava sıcak");
            //}
            #endregion
            #region Maaş Hesaplama Ödev
            Console.WriteLine("Ad:");
            string isim = Console.ReadLine();
            Console.WriteLine("Yaş:");
            int yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Maaş");
            double maas = Convert.ToDouble(Console.ReadLine());
            if (yas > 45)
            {
                Console.WriteLine($"Ad:{isim} Yeni maaş: {maas+5000}");
            }
            else
            {
                Console.WriteLine("Çocuk sayısı");
                int cocuk = Convert.ToInt32(Console.ReadLine());
                if (cocuk < 3)
                {
                    Console.WriteLine($" Ad:{isim} Yeni maaş: {maas + (cocuk * 2500)}");
                }
                else
                {
                    Console.WriteLine($"Ad:{isim}  Yeni maaş: {maas + (cocuk * 2000)}");
                }
            }
            #endregion
        }
    }
}
