namespace _11_RandomOdevCozum
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

            Random random = new Random();
            int rSayi = random.Next(1, 101);
            int hak = 5;

            while (true)
            {
                Console.WriteLine("Şanslı tahmininizi giriniz");
                int tahmin = Convert.ToInt32(Console.ReadLine());
                hak--;
                if (hak == 0)
                {
                    Console.WriteLine("Hakkınız kalmadı random sayı: " + rSayi);
                    break;
                }
                if (rSayi == tahmin)
                {
                    Console.WriteLine("Tebrikler doğru tahmin:" + tahmin);
                    break;
                }
                else if (rSayi > tahmin)
                {
                    Console.WriteLine("Lütfen daha büyük bir sayı giriniz");
                }
                else if (rSayi < tahmin)
                {
                    Console.WriteLine("Lütfen daha küçük bir sayı giriniz");
                }
            }
        }
    }
}
