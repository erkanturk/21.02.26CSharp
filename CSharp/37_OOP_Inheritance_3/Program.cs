namespace _37_OOP_Inheritance_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Araba araba = new Suv();//Araba sınıfından bir nesne oluşturduk ama
            //                        //Suv sınıfının özelliklerini kullanabileceğiz
            //                        //çünkü araba nesnesi Suv sınıfından oluşturuldu.
            //araba.DortCeker
            //new Suv();
            Araba araba = new Araba();
            Suv suv = new Suv();
            suv.ArabaMarka = "Volvo";
            suv.ArabaModel = "XC90";
            suv.YakitTuru = "Dizel";
            suv.Renk = "Siyah";
            suv.DortCeker = true;
            suv.ArabaID = 123;
            suv.Vites = "Yarı Otomatik";
            suv.ArabaBilgileri();

            Sport sport = new Sport();
            sport.ArabaMarka = "Ford";
            sport.ArabaModel = "Mustang";
            sport.YakitTuru = "Benzin";
            sport.Vites = "Otomatik";
            sport.ArabaID = 1231;
            sport.Cabrio = false;
            sport.Renk = "Alev Kırmızı";
            sport.ArabaBilgileri();


        }
    }
}
