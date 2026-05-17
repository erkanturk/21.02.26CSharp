namespace _34_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Garbage Collector:Bütün kodlar,değişkenler,methodlar,her yapı Ram bellekte tutulur.Ram belli bir doluluğa 
            //ulaştığında en eski en az kullanılan veya en kolay tanımlanan yapıyı siler.

            /* Constructor method (Yapıcı method)
             * Class ile aynı isme sahiptir.
             * Herhangi bir dönüş terimi almaz Void int return vb 
             * Default olarak sınıf yapısının arka planında boş şekilde gizli çalışır
             * Classtan instance alındığında otomatik olarak çalışır.
             */
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Ad="Erkan",Soyad="Türk",Yas=32},
                new Customer(){Ad="Altan",Soyad="Emre",Yas=33},
                new Customer(){Ad="Tahsin",Soyad="Canpolat",Yas=33},
            };
            Customer customer = new Customer();
            Customer customer2 = new Customer("Erkan", "Türk", 32);
            customer.Kaydet(customers);
            //Customer customer = new Customer();
            //customer.Kaydet();


        }
    }
    class Customer
    {
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        //ctor Constructor
        public void Kaydet(List<Customer> list)
        {
            //Console.WriteLine("Ad");
            //Ad = Console.ReadLine();
            //Console.WriteLine("Soyad");
            //Soyad = Console.ReadLine();
            //Console.WriteLine("Yaş");
            //Yas = Convert.ToInt32(Console.ReadLine());
            foreach (var item in list)
            {
                Console.WriteLine(item.Ad + " " + item.Soyad + " " + item.Yas);
            }
        }
        public Customer(string ad, string soyad, int yas)//varsayılan constructor
        {
            Ad = ad;
            Soyad = soyad;
            Yas = yas;
            Console.WriteLine(Ad);
            Console.WriteLine(Soyad);
            Console.WriteLine(Yas);
        }
        public Customer()
        {
            
        }
       

    }
}
