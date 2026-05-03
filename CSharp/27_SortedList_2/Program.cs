namespace _27_SortedList_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Sözlük uygulaması TR-EN
             * sozluk.Add("kitap", "book");
             * 1-Arama
             * 2-Çıkarma
             * 3-Listeleme
             * 4-Çıkış
             * Kullanıcıya bu seçimlerden birini yönlendirelim
             * ve seçimine göre işlemler yapalım
             * Eğer arama derse kullanıcı türkçe olarak girdiği 
             * kelimenin ingilizce karşılığını görecek
             * Eğer bu kelime sözlükte yoksa kullanıcıya bu 
             * kelimenin sözlükte bulunmadığını söyleyelim ve 
             * Sözlüğe eklemek isteyip istemediğini soralım 
             * eğer kullanıcı eklemek isterse bu kelimeyi sözlüğe ekleyelim
             * Çıkarmak isterse türkçe olarak girdiği kelimenin
             * ingilizce karşılığını sözlükten çıkaralım
             * 
             * 
             */
            //Key değeride string value değeridi string
            SortedList<string, string> sozluk = new SortedList<string, string>();
            sozluk.Add("kitap", "book");
            sozluk.Add("defter", "notebook");
            sozluk.Add("kalem", "pen");
            sozluk.Add("bulutlu", "cloudy");
            sozluk.Add("gunesli", "sunny");
            sozluk.Add("mavi", "blue");
            sozluk.Add("sari", "yellow");
            sozluk.Add("gokyuzu", "sky");

            while (true)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("İngilizce türkçe sözlüğe hoş geldiniz");
                Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:\n1-Arama\n2-Sözlükten Sil\n3-Listele\n4-Çıkış");
                string secim = Console.ReadLine();
                if (secim == "1")
                {
                    Console.WriteLine("Aranacak kelime:");
                    string aranacakKelime = Console.ReadLine().ToLower().Trim();
                    if (sozluk.ContainsKey(aranacakKelime))
                    {
                        Console.WriteLine(sozluk[aranacakKelime]);
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte aranan kelime yok eklemek ister misiniz (E/H)?");
                        string cevap = Console.ReadLine().ToLower().Trim();
                        if (cevap == "e")
                        {
                            Console.WriteLine($"{aranacakKelime} nin ingilizcesini giriniz");
                            sozluk[aranacakKelime] = Console.ReadLine().ToLower().Trim();
                            Console.WriteLine("Başarı ile eklendi");
                        }
                        else
                        {
                            Console.WriteLine("Anasayfaya yönlendiriliyorsunuz");
                            Thread.Sleep(2000);
                            Console.Clear();
                        }
                            
                    }


                }
                else if (secim == "2")
                {
                    Console.WriteLine("Silmek istediğiniz kelime:");
                    string kelime= Console.ReadLine().ToLower().Trim();
                    if (sozluk.ContainsKey(kelime))
                    {
                        sozluk.Remove(kelime);
                        Console.WriteLine("Silme işlemi başarılı");
                    }
                    else
                    {
                        Console.WriteLine("Sözlükte silmek istediğiniz kelime bulunamadı");
                    }
                }
                else if(secim=="3")
                {
                    foreach (KeyValuePair<string,string> item in sozluk)
                    {
                        Console.WriteLine(item.Key+" => "+item.Value);
                    }
                    Thread.Sleep(5000);
                }
                else if (secim == "4")
                {
                    Console.WriteLine("iyi günler");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama");
                    Thread.Sleep(3000);
                }
            }

        }
    }
}
