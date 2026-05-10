namespace _30_List_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /*
            Ödev Sorusu: E-Ticaret Sipariş Analiz Algoritması
            Senaryo: Bir e-ticaret sistemindeki siparişleri yönetecek bir
            program yazmanız isteniyor. Sistemde siparişlerin numarasını, müşterinin adını, 
            sipariş tutarını ve sipariş durumunu tutan bir yapı kurulmalıdır.

Sınıf Yapısı:

İçerisinde SiparisNo (int), MusteriAdi (string),
            Tutar (int) ve Durum (string) özelliklerini (property) barındıran bir Siparis sınıfı oluşturun. 
            (Durum alanı sadece "Teslim Edildi", "Kargoda", "Hazırlanıyor" veya "İptal" değerlerini alabilir.)

İstenen Görevler:

Ana programda bir List<Siparis> oluşturun ve içine rastgele değerlere sahip en az 8 farklı sipariş ekleyin.

Ciro Hesaplama: Sadece "Teslim Edildi" durumundaki siparişlerin toplam tutarını
            tek bir LINQ sorgusu ile bularak ekrana yazdırın.

VIP Müşteriler: Tutarı 3000 TL'nin üzerinde olan siparişleri bulun. 
            Bu siparişleri veren müşterilerin sadece adlarını,
            alfabetik sıraya (A'dan Z'ye) dizilmiş olarak ekrana yazdırın 
            (Bu işlemde listeyi tamamen dönüştürmeniz gerekecektir).

Sorunlu Sipariş Kontrolü: 
            Listede "İptal" durumunda olan bir sipariş olup olmadığını kontrol edin. 
            Eğer varsa, iptal edilen ilk siparişin numarasını (SiparisNo) ekrana yazdırın. 
            Yoksa "İptal edilen sipariş bulunmamaktadır" uyarısı verin.

Durum Özeti: Sistemde o an bulunan tüm siparişlerin durumlarını, 
            tekrar etmeyecek (benzersiz) şekilde listeleyerek ekrana yazdırın 
            (Örn: Sadece "Teslim Edildi, Kargoda, İptal" yazmalı, aynı durumlar defalarca yazılmamalı).
             */
            #endregion
            //Kişi diye bir yapımız olacak bu kişinin içindeki ad soyad yaş değerleri olacak ve her seferinde bu değerler 
            //bir  listede tutulacak
            Kisi kisi = new Kisi();
            kisi.Ad = "Ahmet";
            kisi.Soyad = "Yılmaz";
            kisi.Yas = 30;

            Kisi kisi2 = new Kisi();
            kisi2.Ad = "Mehmet";
            kisi2.Soyad = "Demir";
            kisi2.Yas = 25;

            Kisi kisi3 = new Kisi();
            kisi3.Ad = "Ayşe";
            kisi3.Soyad = "Kara";
            kisi3.Yas = 28;

            //List<string> kisiler = new List<string>();//Gereksiz kullanım
            ////Eğer kişi sınıfını alacaksak o zaman List<Kisi> kisiler = new List<Kisi>(); şeklinde tanımlama yapmamız gerekir
            ////kisiler.Add($"{kisi.Ad} {kisi.Soyad} {kisi.Yas}");
            ////kisiler.Add($"{kisi2.Ad} {kisi2.Soyad} {kisi2.Yas}");
            ////kisiler.Add($"{kisi3.Ad} {kisi3.Soyad} {kisi3.Yas}");
            //kisiler.Add(kisi.Ad);
            //kisiler.Add(kisi.Soyad);
            //kisiler.Add(kisi2.Yas.ToString());
            ////kisiler.Add(kisi.Yas);
            //kisiler.Add(kisi2.Ad);
            //kisiler.Add(kisi2.Soyad);
            //kisiler.Add(kisi2.Yas.ToString());
            //kisiler.Add(kisi3.Ad);
            //kisiler.Add(kisi3.Soyad);
            //kisiler.Add(kisi3.Yas.ToString());

            //foreach (string item in kisiler)
            //{
            //    Console.WriteLine(item);
            //}
            List<Kisi> k = new List<Kisi>();//Kisi sınıfından bir liste oluşturduk> kisiler 
            k.Add(kisi);
            k.Add(kisi2);
            k.Add(kisi3);
            foreach (Kisi item in k)
            {
                Console.WriteLine($"Ad: {item.Ad} Soyad: {item.Soyad} Yaş: {item.Yas}");
            }
            Console.WriteLine(k.Sum(x => x.Yas));//Yaşların toplamını verir

        }
        class Kisi//Kişi sınıfı oluşturduk
        {
            //Ad Soyad Ve Yaş yapıları Property Field Yapılarıdır 
            //Nitelik veya Özellik olarak da adlandırılırlar
            //Get ve Set işlemleri Get getirmek Set var olan
            //değeri yada olmayan değeri oluşturmak güncellemek için kullanılırlar
            public string Ad { get; set; }//ad, soyad ve yaş özelliklerini tanımladık 
            public string Soyad { get; set; }
            public int Yas { get; set; }
        }
    }
}
