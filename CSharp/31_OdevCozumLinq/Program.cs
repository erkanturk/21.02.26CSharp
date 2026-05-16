namespace _31_OdevCozumLinq
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
            List<Siparis>siparisler = new List<Siparis>()
            {
                new Siparis(){SiparisNo=1,MusteriAdi="Ahmet Yılmaz",Tutar=2500,Durum="Teslim Edildi"},
                new Siparis(){SiparisNo=2,MusteriAdi="Mehmet Demir",Tutar=3500,Durum="Kargoda"},
                new Siparis(){SiparisNo=3,MusteriAdi="Ayşe Kara",Tutar=1500,Durum="Hazırlanıyor"},
                new Siparis(){SiparisNo=4,MusteriAdi="Fatma Çelik",Tutar=4000,Durum="Teslim Edildi"},
                new Siparis(){SiparisNo=5,MusteriAdi="Ali Veli",Tutar=2000,Durum="İptal"},
                new Siparis(){SiparisNo=6,MusteriAdi="Zeynep Kaya",Tutar=4500,Durum="Teslim Edildi"},
                new Siparis(){SiparisNo=7,MusteriAdi="Emre Yıldız",Tutar=3000,Durum="Kargoda"},
                new Siparis(){SiparisNo=8,MusteriAdi="Veli Can",Tutar=500,Durum="Hazırlanıyor"}
            };
            //Normalde int 100 olarak değeri getirir fakar N2 formatı ile 100,00 olarak getirir.
            int toplamCiro = siparisler.Where(s=>s.Durum=="Teslim Edildi").Sum(s=>s.Tutar);//Ciro hesaplama
      
            
            Console.WriteLine($"Teslim edilen siparişlerin toplamı:{toplamCiro.ToString("N2")} TL\n");

            Console.WriteLine("3000 TL üzeri sipariş veren müşteriler (A-Z)");
            siparisler.Where(s=>s.Tutar>3000)
                .OrderByDescending(s=>s.MusteriAdi)
                .Select(s=>s.MusteriAdi)//Objeden listeye dönüştürme işlemi
                .ToList()
                .ForEach(m=>Console.WriteLine(m));
            Console.WriteLine("************");
            Siparis iptalSiparis = siparisler.FirstOrDefault(s=>s.Durum=="İptal");
            if (iptalSiparis != null)
            {
                Console.WriteLine($"Sistemde ilk sipariş iptali numarası: {iptalSiparis.SiparisNo}");
            }
            else
            {
                Console.WriteLine("iptal edilen sipariş bulunmamaktadır.");
            }

            Console.WriteLine("Sistemdeki Mevcut Sipariş Durumları:");
            siparisler.Select(s => s.Durum)
                .Distinct()
                .ToList()
                .ForEach(d=> Console.WriteLine(d));
            int durumlar = siparisler.Count(s => s.Durum == "Teslim Edildi");
            Console.WriteLine(durumlar);
        }
    }
    class Siparis
    {
        public int SiparisNo { get; set; }
        public string MusteriAdi { get; set; }
        public int Tutar { get; set; }
        public string Durum { get; set; }
    }
}
