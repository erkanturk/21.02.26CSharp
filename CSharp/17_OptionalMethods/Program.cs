namespace _17_OptionalMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Optional Methods
            //Normal method yapısında bir parametre varsa bu parametre değeri verilmesi zorunludur
            //Fakat bu parametredeğerinin verilmeme durumu olması için isteğe bağlı parametreler 
            //Tanımlanabilir
            //Örneğin bir sitede cinsiyet değeri belirtmek istemiyorsunuz ama bu değerin tutulması lazım
            //sizin belirtmek istemediğinizi tutmamız gerekiyor bu durumda 
            //optional method yapısı devreye girecektir
            //İsteğe bağlı parametre daima son parametreler olarak kullanılır 
            //Öncesinde mutlaka zorunlu olan parametreler tanımlanır son değerler optional olarak tanımlanır.
            UrunKaydet("Klavye","Logitec",10);//son değer isteğe bağlı parametre olduğu için vermezsek methodda
           // tanımlanan default değeri alır.
           UrunKaydet("Mouse","Logitec",20,"Bilgisayar malzemeleri");
            //son değeri verirsek methodda tanımlanan default değeri değil verdiğimiz değeri alır.
            //Eğer isteğe bağlı parametre yapısına bir değer gönderirsek gönderdiğimiz değeri alır
            //Değer göndermezsek varsayılan değeri alır.
            UrunKaydet2("Klavye", "Logitec", 10,"Bilgisayar");//Optional method yapısında olmadığı için tüm parametreler verilmelidir.
        }
        static void UrunKaydet(string urunAdi, string marka, int stok, string kategori = "Elektronik")
        {
            Console.WriteLine($"Ürün Adı:{urunAdi} Markası:{marka} Stok Miktarı: {stok} Kategorisi:{kategori}");
        }
        static void UrunKaydet2(string urunAdi, string marka, int stok, string kategori)
        {
            Console.WriteLine($"Ürün Adı:{urunAdi} Markası:{marka} Stok Miktarı: {stok} Kategorisi:{kategori}");
        }

    }
}
