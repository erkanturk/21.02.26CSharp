namespace _32_Class_Object_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Static NonStatic
            /* Static sınıflar static öğeler barındırır new keywordü ile birlikte kullanılamazlar 
             * Nesnesi oluşturulamaz doğrudan sınıf öğelerine erişim sağlamamıza olanak tanır
             * NonStatic yapı ise new keywordü olmadan kullanılamaz bir nesne üzerinden sınıfın içerisinde 
             * bulunan yapılara erişilir.
             * Static yapılar genellikle sık kullanılan yapılar değildir yardımcı yapılarda kullanılırlar
             * Random rand=new Random(); rand.Next(10,100);
             * Console.WriteLine();
             */

            #endregion
            // List<Araba> araclar = new List<Araba>();
            //Araba2.Kaydet();//Static bir yapıda olduğu için sadece static öğeleri kullanır ve nesne üzerinden işlem yapamayız

            //Araba araba = new Araba();
            //araba.Kaydet(araclar);

            Araba2.Kaydet();
            Araba2.Marka = "Deneme";
            
            Console.WriteLine(Araba2.Marka);//Bellekten aynı değeri getirir.
            //foreach (var item in araclar)
            //{
            //    Console.WriteLine(item.Marka+" "+item.Model+" "+item.Fiyat);
            //}
            Araba araba1 = new Araba();
            araba1.Marka = "test";
            Console.WriteLine(araba1.Marka);
            Araba araba2 = new Araba();
            Console.WriteLine(araba2.Marka);//Yeni sayfa açar ve değer bekler.
            //Console.WriteLine();
            //Random random = new();
            //random.Next();
        }
    }
}
