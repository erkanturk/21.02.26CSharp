namespace _41_OOP_Abstraction_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Odev
            /* 
                Urun sınıfından miras alacak ürün sınıdında  ad fiyat KdvUygula methodu olacak.
               Tekstil:Ad,Fiyat,KumasTuru,Beden,UreticiFirma = KDVUygular(%20)
               CepTelefonu:Ad,Fiyat,Özellik,Marka = KDVUygular(%120)
               Ekmek:Ad,Fiyat,Gramaj = KDVUygular(%10)

           Nesne özelliklerini constructor methodu ile alın.
           Sepet: Alınan ürünleri bir listeye kaydetsin toplam tutarı söylesin

           */
            #endregion
            #region Ödev 2
            //Örnek: Bir tane Tasit sınıfı oluşturalım ancak bu sınıftan nesne üretilemesin.
            //İçerisinde Marka, Model, TabanFiyat property'leri  bir de türeyen her sınıfa
            //özel hesaplanacak abstract Fiyat property'si ekleyelim.
            //Tasit'dan türeyen Araba, Ucak, Tren ve Gemi class'larımız olsun.
            //Araba'ya özel fiyat hesabı YakitTuru, VitesTuru bilgilerine göre yapılsın
            //(Dizel'se +5000, Otomatikse'se +10000)
            //Uçak'a özel fiyat hesabı kapasite bilgisine göre yapılsın.
            //(Kapasite başına +100)
            //Trene özel fiyat hesabı vagon sayısı ve sınıf bilgisine göre yapılsın
            //(sınıf A ise + 5000, B ise +10000 vagon sayısı başına + 30000)
            //Gemi'ye özel fiyat hesabı kamara sayısına göre yapılsın
            //(kamara başına +40000)
            #endregion
            UcanNesne ucanNesne = new Kus();
            ucanNesne.Uc();
            YuzenNesne yuzenNesne = new Balik();
            yuzenNesne.Yuz();
            Insan insan =new Insan();
            insan.Yuru();
            SurunenNesne surunenNesne = new Yilan();
            surunenNesne.Surun();
            YuruyenNesne yuruyenNesne = new Kus();//Yürüyen nesne kuş olamaz bu senaryoda 
            //Kanıtlanması gerekiyor.

        }
    }
}
