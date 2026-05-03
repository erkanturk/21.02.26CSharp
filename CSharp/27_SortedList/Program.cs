using System.Collections;

namespace _27_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region SortedList
            /* SortedList 
             * Sıralı liste olarak adlandırılır ve anahtar-değer çiftlerini saklayan bir koleksiyon yapısıdır.
             * Key değerleri daima sabit veri tipi olmalıdır ve benzersiz olmalıdır
             * eğer bir key değeri string ise string olarak diğer key değerleride verilmelidir
             * Fakat value değerleri bu kısıtlamaya tabi değildir ve herhangi bir veri tipi olabilir
             * Dictonary Entry yapısına sahip bir koleksiyon yapısıdır (sözlük yapısı)
             * Generic bir yapısıda mevcuttur ve bu yapısında key ve value değerleri aynı veri tipinde kullanılabilir
             */
            //Add ifadesinden sonra ilk tanımlanan değer key değeri ikincisi ise value değeridir
            //SortedList sortedList = new SortedList();
            //sortedList.Add("istanbul", 34);
            //sortedList.Add("ankara", 06);
            //sortedList.Add("izmir", 35);
            //sortedList.Add("adana", 01);
            //sortedList.Add("antalya", 07);
            //sortedList.Add("bursa", "16");
            //sortedList.Add(16, "Bursa");//Hata verir çünkü key değerleri farklı veri tiplerinde tanımlanamaz
            //sortedList.Add("istanbul", 22);//Hata verir çünkü key değerleri benzersiz olmalıdır

            //foreach (var item in sortedList)//Tüm yapıyı Array gibi döndürür
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in sortedList.Keys)//Sadece key değerlerini getirir
            //{
            //    Console.WriteLine(item);
            //}
            //foreach(var item in sortedList.Values)//Sadece value değerlerini getirir
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (DictionaryEntry de in sortedList)//Key ve value değerlerini birlikte getirir
            //{
            //    Console.WriteLine(de.Key + "=>" + de.Value);
            //}
            //foreach (DictionaryEntry item in sortedList)
            //{
            //    Console.WriteLine(item);//DictionaryEntry ile kullanılınca key ve value değerleri kullanılabilinir.
            //}
            SortedList sortedList = new SortedList();
            sortedList.Add("istanbul", 34);
            sortedList.Add("ankara", 06);
            sortedList.Add("izmir", 35);
            sortedList.Add("adana", 01);
            sortedList.Add("antalya", 07);
            sortedList.Add("bursa", "16");
            Console.WriteLine(sortedList.ContainsValue("16"));//true
            Console.WriteLine(sortedList.ContainsKey("Adana"));//false büyük küçük harf duyarlıdır
            sortedList["Adana"] = 01;//Yoksa ekler var ise günceller
            foreach (DictionaryEntry de in sortedList)//Key ve value değerlerini birlikte getirir
            {
                Console.WriteLine(de.Key + "=>" + de.Value);
            }
            sortedList["Adana"] = 33;//Adana key değerine sahip value değerini günceller
            foreach (DictionaryEntry de in sortedList)//Key ve value değerlerini birlikte getirir
            {
                Console.WriteLine(de.Key + "=>" + de.Value);
            }
            sortedList.Remove("Adana");//Adana key değerine sahip olan değeri siler
            foreach (DictionaryEntry de in sortedList)//Key ve value değerlerini birlikte getirir
            {
                Console.WriteLine(de.Key + "=>" + de.Value);
            }
            #endregion
        }
    }
}
