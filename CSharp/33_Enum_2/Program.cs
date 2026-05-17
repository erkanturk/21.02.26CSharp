namespace _33_Enum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Renk ara");
            string ara = Console.ReadLine().ToLower();
            KitapKategori kategori = (KitapKategori)Enum.Parse(typeof(KitapKategori), ara);

            //KitapKategori adında  enum oluşturarak içerisine,
            //BilimKurgu=0, DunyaKlasikleri=1, Psikoloji=2 olmak üzere 3 kategori ekleyelim.
            //Kullanıcıdan string olarak kategori girmesini isteyelim, girilen değeri
            //KitapKategori enum'ına çevirerek switch case ile kontrol edip
            //aşağıda belirtilen şekilde mesajı yazdıran programı yazalım.
            //BilimKurgu ise: "Bilim Kurgu kategorisindeki kitaplar A reyonundadır."
            //DunyaKlasikleri ise:  "Dünya Klasikleri kategorisindeki kitaplar B reyonundadır."
            //Psikoloji ise:  "Psikoloji kategorisindeki kitaplar C reyonundadır."
            switch (kategori)
            {
                case KitapKategori.aksiyon: Console.WriteLine("Aksiyon A reyonundadır."); break;
                case KitapKategori.bilimkurgu: Console.WriteLine("bilimkurgu b reyonundadır."); break;
                case KitapKategori.macera: Console.WriteLine("macera c reyonundadır."); break;
                case KitapKategori.fantastik: Console.WriteLine("fantastik d reyonundadır."); break;
                case KitapKategori.dünyaklasikleri: Console.WriteLine("dünyaklasikleri kasa arkasında"); break;
                default: Console.WriteLine("Aradığınız ürün mağzamızda mevcut değildir."); break;
            }

        }
    }
    enum KitapKategori { aksiyon, bilimkurgu, macera, fantastik, dünyaklasikleri }
}
