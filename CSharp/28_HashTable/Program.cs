using System.Collections;

namespace _28_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*HashTable Düzensiz Sözlük  olarak adlandırılır
             * SortedList yapısına benzer key value ilişkisi vardır fakat key değerleri düzensizdir
             * ve key değerleri dinamik yapıdadır yani farklı veri tiplerinde key değerleri tanımlanabilir
             * aynı şekilde value değerleri de farklı veri tiplerinde tanımlanabilir
             * random erişim sağlar ve performansı SortedList yapısına göre daha yüksektir
             */
            /*SortedList sayısal olarak sıralama da 1 2 3 4 5  yada a b c  
             * Şekilde sıralama yaparken key değerlerini sıralar ve buna göre sıralama yapar
             * Hashtable yapısında düzensiz bir şekilde değerler gelir key değerleri benzersiz olmak zorundadır
             
             */
            Hashtable hashtable = new Hashtable();
            hashtable.Add("istanbul", 34);
            hashtable.Add("ankara", 06);
            hashtable.Add(10, "Balıkesir");
            hashtable.Add("izmir", 35);
            hashtable.Add(16, "Bursa");
            hashtable.Add(DateTime.Now, "Şu anki zaman");
            hashtable.Add("Şu anki zaman", DateTime.Now);
            hashtable.Add(true, false);
            hashtable.Add(false, true);
            hashtable.Add('A', 'B');
            hashtable.Add('C', 'D');
            hashtable.Add('E', 'F');
            hashtable.Add('G', 'H');
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine(de.Key + "=>" + de.Value);
            }
           
            hashtable["Antalya"]= 07;//Yoksa ekler var ise günceller
            hashtable[55]= "Samsun";
            hashtable[true] = true;
            Console.WriteLine("***********");
            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }
            
            /*
                16=>Bursa
3.05.2026 18:05:57=>Şu anki zaman
Şu anki zaman=>3.05.2026 18:05:57
A=>B
10=>Balıkesir
True=>False
ankara=>6
istanbul=>34
False=>True
            */
        }
    }
}
