namespace _37_OOP_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Inheritance(Kalıtım Miras alma)
             * Bir sınıf Ortak özellikleri barındırır.
             * Bu sınıf yapısı Parrent sınıf olarak oluşturulur ve bu sınıftan miras alan child sınıflar,
             * Parrent sınıfın özelliklerini kullanabilirler.
             * Bu yapıyı kullanmak için ':' iki nokta işlemi ile sınıfın kalıtım alması gerekmektedir
             * fakat bu yapı sealed olarak işaretlenmiş ise kalıtım almaya uygun olamaz 
             * !!!!Önemli not 
             * Parrent sınıf child sınıftan miras alamaz veya child sınıfın özelliklerini kullanamaz.
             * 
             */
            IK ik = new IK();
            Pazarlama pazarlama = new Pazarlama();
            Muhasebe muhasebe = new Muhasebe();

            ik.TC = "12345678910";
            ik.AdSoyad = "Ahmet Yılmaz";
            ik.Adres = "İstanbul";
            ik.PersonelSayisi = 10;
            ik.IseGirisTarihi = new DateTime(2020, 1, 1);
            ik.SigortaNo = "12345";
            ik.Yas = 30;
            ik.PersonelBilgileri();
            Console.WriteLine("***********");
            pazarlama.TC = "12345678910";
            pazarlama.AdSoyad = "Ahmet Yılmaz";
            pazarlama.Adres = "İstanbul";
            pazarlama.MusteriSayisi = 100;
            pazarlama.IseGirisTarihi = new DateTime(2020, 1, 1);
            pazarlama.SigortaNo = "12345";
            pazarlama.Yas = 30;
            pazarlama.PersonelBilgileri();
            Console.WriteLine("**************");
            muhasebe.TC = "12345678910";
            muhasebe.AdSoyad = "Ahmet Yılmaz";
            muhasebe.Adres = "İstanbul";
            muhasebe.HesapSayisi = "5";
            muhasebe.IseGirisTarihi = new DateTime(2020, 1, 1);
            muhasebe.SigortaNo = "12345";
            muhasebe.Yas = 30;
            muhasebe.PersonelBilgileri();

        }
    }
}
