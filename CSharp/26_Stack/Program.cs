using System.Collections;

namespace _26_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Yığın(Stack) Yapısı
             * Queue yapısının tam tersi olarak Lifo(Last in First out) yapısına sahip bir koleksiyon yapısıdır.
             */
            Stack stack = new Stack();
            stack.Push("Erkan");
            stack.Push("Ahmet");
            stack.Push(10);
            stack.Push(3.14);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            stack.Pop();//Son eklenen değeri siler
            Console.WriteLine("***********");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("***********");
            Console.WriteLine(stack.Peek());
            stack.Clear();//Tüm değerleri siler

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
