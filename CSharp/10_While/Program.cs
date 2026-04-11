namespace _10_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While koşul true olduğu sürece çalışır false olduğunda sonlanır

            #region While örneği
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            #endregion
            #region sonsuz döngü
            //bool durum = true;
            //while (durum)
            //{
            //    Console.WriteLine("Devam etmek ister misin ?");
            //    string cevap = Console.ReadLine().ToUpper();
            //    if (cevap == "E")
            //    {

            //        Console.WriteLine("Devam ediliyor");
            //    }
            //    else if (cevap == "H")
            //    {
            //        //break;//break döngüyü sonlandırır
            //        durum = false;//durum false olduğunda döngü sonlanır
            //    }
            //}
            //Console.WriteLine("Döngü bitti");


            #endregion

            #region Harfleri ekrana yazdırma
            //for (char i = 'A'; i <= 'z'; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //char harf = 'A';
            //char harf2 = 'z';
            //while (harf < harf2)
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}
            //harf = 'A';
            //Console.WriteLine("********************");
            //do
            //{
            //    Console.WriteLine(harf);
            //    harf++;
            //}
            //while (harf<harf2);
            #endregion
            #region  Modem sistemi 
            //kullanıcı 5 defa yanlış kullanıcı adı şifre girerse sistem 10 saniye kitlenecek sonra tekrar  giriş yapacak 

            //string kullaniciAdi = "admin";
            //string sifre = "admin";
            //int hak = 5;

            //while (true)
            //{
            //    Console.WriteLine("Kullanıcı Adınız");
            //    string kullanici = Console.ReadLine();
            //    Console.WriteLine("Şifreniz");
            //    string password = Console.ReadLine();
            //    hak--;
            //    if (kullanici == kullaniciAdi && password == sifre)
            //    {
            //        Console.WriteLine("Sisteme giriş başarılı");
            //        break;
            //    }
            //    else if (hak == 0)
            //    {

            //        Console.WriteLine("Hakkınız kalmadı");
            //        Console.WriteLine("Sistem kitlendi");
            //        Thread.Sleep(10000);
            //        Console.WriteLine("Sistem açıldı");
            //        Console.Clear();
            //        hak = 5;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Giriş başarısız");
            //        Console.WriteLine("Tekrar deneyiniz");
            //        Thread.Sleep(2000);
            //        Console.Clear();
            //    }


            //}
            #endregion
            #region Kullanıcıdan gelen her harfi ekrana yazdırma
            //Console.WriteLine("Bir kelime giriniz");
            //string kelime = "M=>0,e=>1,r=>2,h=>3,a=>4,b=>5,a=6";
            //string metin = Console.ReadLine();
            //int index = 0;
            //while (index <= metin.Length)
            //{
            //    Console.WriteLine(metin[index]);
            //    index++;
            //}
            //Console.WriteLine(metin[5].ToString().ToUpper());
            #endregion
        }
    }
}
