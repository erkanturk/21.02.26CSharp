namespace _34_Constructor_3_ReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstTest constTest = new ConstTest();
            double pi = ConstTest.Pi;
            Console.WriteLine(pi);
            Console.WriteLine(ConstTest.Pi);
            ReadOnlyTest readOnlyTest = new ReadOnlyTest();
            //readOnlyTest.ReadOnlyVal = 10;//Değer ataması yapılamaz.
            Console.WriteLine(readOnlyTest.ReadOnlyVal);

            Test test = new Test(readOnlyTest);
            test.Yaz();
        }
    }
}
