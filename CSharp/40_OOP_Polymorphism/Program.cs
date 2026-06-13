namespace _40_OOP_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Polymorphism (Çok Biçimlilik)
            /*Polymorphism nedir ?
            * Çok biçimcilik (Polymorphism) bir nesnenin farklı amaçlar için de kullanılabileceği 
            * anlamına gelir ve statik dinamik olmak üzere ikiye ayrılır 
               *Static çok biçimcilik method ve operatörlerin aşırı yüklenmesi (Overload) olarak belirtilir.
               *Dinamik çok biçimcilik:Sınıfların miras alma yoluyla parrent sınıftaki işaretlenmiş(virtual) yapıyı
               *kendi dinamiklerine uygun bir biçimde kullanmasıdır.
               *Virtual ile işaretlenmiş yapıyı sınıf kendi dinamiklerine göre restore etmek isterse
               *bu yapıya override(ezme işlemi) işlemi yapması gerekir.
               *
           *Virtual() Methodu
           *Temel sınıfa ait bir methodun bazen türetilmiş sınıfta farklı şekilde kullanılması gerekebilir.
           *Bu durumda temel sınıfın söz konusu methodun türemiş sınıfın değiştirip kullanabileceği 
           *yönünde izin vermesi gerekir biz bu izni methodun temel sınıfta 'Virtual' olarak tanımlanması 
           *sonucu vermekteyiz.
           *Diğer bir ifadeyle temel sınıfta virtual keywordu verilmiş bir method
           *türetilmiş sınıfta yeniden yararlanabilir ve ana sınıftaki yapılarla birlikte de kullanılabilinir.
           *
           *Bu yapıyı kullanabilmemiz için ezme işlemi uygulamamız gerekir 
           *Bu ezme işleminede türemiş sınıflarda override diyerek temel sınıftaki methodu yeniden biçimlendiririz
           *Abstract yada virtual olarak tanımlanan değerleri override edilebilmektedir.
           *Temel sınıfta virtual olarak belirtilen yapının erişim belirleyicisi eğer public ise override yapısıda
           *public olur protected ise protected kalmalıdır.

           */
            #endregion

            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Kaydet();
            Console.WriteLine(ogrenci.Ad+" "+ogrenci.Soyad+" "+ogrenci.Yas+" "+ogrenci.Numara+" "+ogrenci.Vize+" "+ogrenci.Final);
            LiseOgrenci lise = new LiseOgrenci();
            lise.Kaydet();
            Console.WriteLine(lise.Ad + " " + lise.Soyad + " " + lise.Yas + " " + lise.Numara + " " + lise.Vize + " " + lise.Final);
            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Kaydet();
            Console.WriteLine(ogretmen.Ad + " " + ogretmen.Soyad + " " + ogretmen.Yas + " " + ogretmen.Brans );
        }
    }
}
