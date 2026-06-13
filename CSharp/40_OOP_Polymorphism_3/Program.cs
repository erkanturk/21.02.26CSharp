namespace _40_OOP_Polymorphism_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Canli canli = new Canli();
            canli.HareketEt();
            canli = new Balik();
            canli.HareketEt();
            canli = new Kus();
            canli.HareketEt();
            canli = new Insan();
            canli.HareketEt();
            canli = new Yilan();
            canli.HareketEt();
        }
    }
}
