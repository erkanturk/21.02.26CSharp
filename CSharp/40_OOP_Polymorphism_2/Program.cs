namespace _40_OOP_Polymorphism_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Havale havale = new Havale();
            havale.ParaGonder(1000);
            Eft eft = new Eft();
            eft.ParaGonder(1000);
            Swift swift = new Swift();
            swift.ParaGonder(1000);
        }
    }
}
