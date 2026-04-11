namespace _05_If_Else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 
            //Kullanıcının girdiği sayı deperinin öncelikle 0 dan büyük olup olmadığını kontrol edelim
            //Eğer 0 dan büyükse 100 den büyük mü küçük mü eşit mi kontrol edeceğiz.
            //Console.WriteLine("Lütfen bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi > 0)
            //{
            //    if (sayi > 100)
            //    {
            //        Console.WriteLine($"sayı Büyüktür 100 den sayınız: {sayi}");
            //    }
            //    else if (sayi < 100)
            //    {
            //        Console.WriteLine($"Sayı Küçüktür 100 den sayınız: {sayi}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sayı 100 e eşittir girilen sayı {sayi}");
            //    }
            //}
            //else if (sayi < 0)
            //{
            //    Console.WriteLine("Sayı Küçüktür 0 dan: " + sayi);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı 0 a eşittir: " + sayi);
            //}

            //if (sayi > 0)
            //{
            //    Console.WriteLine("Sayı sıfırdan büyük");
            //}
            //if (sayi > 100)
            //{
            //    Console.WriteLine("Sayı büyük yüzden");
            //}
            //if (sayi == 100)
            //{
            //    Console.WriteLine("Sayı Yüze eşit");
            //}
            //if (sayi > -100)
            //{
            //    Console.WriteLine("Sayı sıfırdan büyük");
            //}
            #endregion
            #region Scopesuz  if kullanımı
            //Console.WriteLine("Bir sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("İkinci sayı");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if(sayi>sayi2)
            //    Console.WriteLine($"{sayi}>{sayi2}");
            //else if(sayi2>sayi)
            //    Console.WriteLine($"{sayi2}>{sayi}");
            //else  Console.WriteLine($"{sayi}=={sayi2}");
            #endregion
            #region terenary if else
            //? if olarak kullanılır
            //: ise else ifadesidir.
            //string metin = "C#";
            //bool sonuc = metin == "c#" ? true : false;
            //Console.WriteLine(sonuc);
            //string sonuc2 = metin == "C#" ? "Değerler aynı" : "Değerler Aynı değil";
            //Console.WriteLine(sonuc2);
            //Kullanıcıdan sayı alıp teranary
            //if else yapısı ile gelen değerin 5 den büyük yada 5 den küçük olduğunu ekrana yazdırın
            //Console.WriteLine("Sayı giriniz");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string sonuc = sayi > 5 ? "Sayı 5den büyüktür" : sayi == 5 ? "Sayı 5 e eşittir" : "Sayı 5 den küçüktür";
            //Console.WriteLine(sonuc);
            #endregion
            #region Haftanın hangi günü
            //Kullanıcıya haftanın hangi günü olduğunu soracağız kullanıcıdan aldığımız değere göre 
            //1 ise pazartesi 2 salı 3 çarşamba gibi değerleri döndüreceğiz 
            //Eğer kullanıcı 1 ila 7 dışında bir değer girerse 1 ila 7 arasında değer girin diyeceğiz.
            Console.WriteLine("Haftanın hangi günü ");
            int gun=Convert.ToInt32(Console.ReadLine());
            if (gun < 0 || gun > 7)
            {
                Console.WriteLine("Lütfen 1 ila 7 arasında değer giriniz");
            }
            else if (gun == 1)
            {
                Console.WriteLine("Pazartesi");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi");
            }
            else
            {
                Console.WriteLine("Pazar");
            }

            #endregion

        }
    }
}
