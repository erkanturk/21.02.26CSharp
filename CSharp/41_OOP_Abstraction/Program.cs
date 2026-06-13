namespace _41_OOP_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Abstract nedir ?
            * Abstract class'lar oluşturulması istenen class'ların sadece base class olarak davranması
            * ve üzerinden bir insatance(örneklem/nesne oluşturma) oluşturulmamasını istediğimiz durumlarda kullanılır
            * C# da bu fonksiyonaliteyi sağlamak için abstract keywordü kullanmamız yeterlidir.
            * Abstract sınıflar içerisinde gövdesiz methodlar tanımlayabiliriz.
            * bu methodlar base class dan miras alan sınıfların içerisinde mutlaka gövdeleri doldurulmalıdır
            * Abstract sınıflar alt sınıflara abstrac olan yapıları kullanmaya zorlar.
            * Bu işleme biz implementasyon deriz.
            * Abstrac olarak işaretlenen yapılar override edilebilinir.
            * Sadece methodlar değil propertyler de abstrac olarak işaretlenir ve override edilir.
            * 
            
            */
           //Insan ınsan = new Insan();
           Ogrenci ogrenci = new Ogrenci();
            ogrenci.Create(123456789789);

        }
    }
}
