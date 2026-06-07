namespace _37_OOP_Inheritance_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Çoklu kalıtım*/
            C c = new C();/*İlk hangi ctor çalışacak ?*/
            c.AClass = 1;//Aziza => A Can=>A Melek => A Yakup => A Efe=> A Yunus => A 
            c.BClass= 2;
            c.CClass= 3;

        }
    }
}
