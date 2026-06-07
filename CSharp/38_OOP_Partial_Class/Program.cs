namespace _38_OOP_Partial_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Parçalı sınıf fiziksel olarak Personel ve Personel 1 adında oluşturulan 2 farklı classın adını personel olarak verip
             * Partial keywordü kullanarak tek bir class gibi davranmasını sağladık
             * Her ikisininde içerisinde bulunan üyeler derleyici tarafından tek bir sınıf olarak algılanır ve kullanılır
             * Genellikle büyük projelerde tek bir sınıfın
             * çok fazla kod içermesi durumunda kodun daha 
             * düzenli ve okunabilir olması için parçalayarak yazmak istediğimizde kullanılır.
             * Partial sınıflar aynı namespace içerisinde ve aynı erişim belirleyiciye sahip olmalıdır
             
             */

            Personel personel = new Personel();
            personel.Ad = "Ahmet";
            personel.Soyad = "Yılmaz";
            personel.Yas = 30;
            personel.Adres = "İstanbul";
            personel.OzellikleriGoster();

            Personel personel1 = new Personel("Test");
            personel1.Ad = "Mehmet";
            personel1.Soyad = "Kaya";
            personel1.Yas = 25;
            personel1.Adres = "Ankara";
            personel1.OzellikleriGoster();

        }
    }
}
