namespace _09_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /* Sistem tarafından random sayı üreteceğiz 1 ila 100 arasında olacak 100 de dahil olacak
             * kullanıcıdan bu sayıyı tahmin etmesini isteyeceğiz
             * toplamta 5 tahmin hakkı olacak
             * kullanıcının girdiği sayı random sayıdan büyük ise ekrana "Daha küçük bir sayı giriniz" yazacak
             * kullanıcının girdiği sayı random sayıdan küçük ise ekrana "Daha büyük bir sayı giriniz" yazacak
             * doğru tahmin yaparsa ekrana "Tebrikler doğru tahmin" yazacak ve döngü sonlanacak
             * kullanıcı 5 tahmin hakkını da kullanırsa ekrana "Tahmin hakkınız bitti. Doğru sayı
            */
            #endregion
            /* Do while 
             * C# a özgü bir döngüdür
             * Diğer programlama dillerinde do while döngüsü bulunmaz
             * Koşul false olsa dahi en az bir kez çalışır
             * Koşul true ise döngü devam eder false ise döngü sonlanır
            */
            #region Do-while örneği
            //int sayac = 1;
            //do
            //{
            //    Console.WriteLine(sayac);
            //    sayac++;
            //}
            //while (sayac >= 10);//Koşul false olsa dahi en az bir kez çalışır

            #endregion
            #region Örnek 2
            //do
            //{
            //    Console.WriteLine("Do while çalıştı");
            //}
            //while (false);

            //do
            //{
            //    Console.WriteLine("Sonsuz döngü");
            //}
            //while (true);

            //Kullanıcı 0 girene kadar sayıları toplasın 0 girdiğinde döngü sonlansın ve sayıların toplamını ekrana yazdırsın
            //int sayi = 0;
            //int toplam = 0;
            //do
            //{
            //    Console.WriteLine("Sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;

            //}
            //while (sayi != 0);//Kullanıcı 0 girdiğinde döngü sonlanır
            //Console.WriteLine("Sayıların toplamı:"+toplam);
            #endregion

            #region 300 den başlayarak 7 ye tam bölünenleri ekrana yazdıran do while yapısı
            //int sayi = 300;
            //do
            //{
            //    if (sayi % 7 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //    }
            //    sayi--;
            //}
            //while (sayi != 0);
            //Console.WriteLine("Döngü bitti");
            //7 ye tam bölünenlerden çift olan sayıların toplamı ve tek olan sayıların toplamı kaçtır.
            //int sayi = 300;
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //do
            //{
            //    if (sayi % 7 == 0)
            //    {
            //        Console.WriteLine(sayi);
            //        if (sayi % 2 == 0)
            //        {
            //            ciftToplam += sayi;
            //        }
            //        else
            //        {
            //            tekToplam += sayi;
            //        }
            //    }
            //    sayi--;
            //}
            //while (sayi != 0);
            //Console.WriteLine("************");
            //Console.WriteLine("Tek toplam:" + tekToplam);
            //Console.WriteLine("Çift toplam:" + ciftToplam);

            //300 den başlayarak 7 ye tam bölünenlerden çift olanları ekrana yazdıran do while yapısı

            int sayi = 300;
            do
            {
                if (sayi % 7 == 0 && sayi % 2 == 0)
                {
                    Console.WriteLine(sayi);
                }
                sayi--;
            }
            while (sayi!=0);

            #endregion
        }
    }
}
