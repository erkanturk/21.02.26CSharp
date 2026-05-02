using System.Collections;

namespace _25_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Queue(Kuyruk) Yapısı
             * Fifo (First in First out) yapısına sahip bir koleksiyon yapısıdır.
             * Dinamik bir yapıya sahiptir ve içerisinde birden fazla yapıyı tutan koleksiyon yapısıdır.
             */
            //Queue kuyruk = new Queue();
            //kuyruk.Enqueue("Erkan");
            //kuyruk.Enqueue("Ahmet");
            //kuyruk.Enqueue(10);
            //kuyruk.Enqueue(3.14);
            //kuyruk.Enqueue(true);
            //kuyruk.Enqueue(false);

            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("************");
            //kuyruk.Dequeue();//İlk eklenen değeri siler
            //foreach (var item in kuyruk)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(kuyruk.Peek());//İlk eklenen değeri silmeden bize gösterir
            //Console.WriteLine("****************");
            //Console.WriteLine(kuyruk.Contains("Ahmet"));//true veya false döner varsa true yoksa false döner
            //                                            // Console.WriteLine(kuyruk[0]);//Hata verir Queue yapısı index yapısına sahip değildir

            #region Call Center Örneği
            Queue callCenter = new Queue();
            callCenter.Enqueue("Ahmet");
            callCenter.Enqueue("Mehmet");
            callCenter.Enqueue("Ayşe");
            callCenter.Enqueue("Fatma");
            callCenter.Enqueue("Ali");
            callCenter.Enqueue("Veli");
            callCenter.Enqueue("Erkan");

            //for (int i = 7; i >= callCenter.Count; i--)
            //{
            //    Thread.Sleep(1000);
            //    Console.WriteLine($"{i}.Sıradasınız");
            //    if (callCenter.Count == 1)
            //    {
            //        Console.WriteLine($"Sıra sizde {callCenter.Peek()}");

            //    }
            //    if (callCenter.Count == 1)
            //    {
            //        break;
            //    }

            //    callCenter.Dequeue();

            //}
            for (int i = 7; i >= callCenter.Count; i--)
            {
                Thread.Sleep(1000);


                Console.WriteLine($"Sıra sizde {callCenter.Peek()}");

                if (callCenter.Count == 1)
                {
                    break;
                }

                callCenter.Dequeue();

            }

            #endregion

        }
    }
}
