namespace _41_OOP_Abstraction_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Buzdolabi buzdolabi = new Buzdolabi();
            buzdolabi.AlisFiyati = 5000;
            buzdolabi.KarYuzdesi = 2;
            buzdolabi.renk = "Gri";
            buzdolabi.Amper = 5;
            buzdolabi.FiyatHesapla();
        }
    }
}
