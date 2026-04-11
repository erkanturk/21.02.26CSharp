namespace _06_Switch_Case_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ödev
            /*
           kullanıcıdan alınan cinsiyet bilgisine göre
        ==> ERKEK ise
           yaşı 60 ve üstü ise maaşının 10 katı kadar ikramiye alaral emekli edilecek, yaş 60'ın altında 
          ise çalıştığı gün sayısına göre eğer 6000 ve üstü ise maaşının 11 katı kadar ikramiye alarak emekli edilecek,    
          6000 altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> KADIN ise
            yaşı 58 ve üstü ise maaşının 10 katı kadar ikramiye alarak emekli edilecek, 
          yaş 58'ın altında ise çalıştığı gün sayısına göre eğer 5600 ve üstü ise 
          maaşının 11 katı kadar ikramiye alarak emekli edilecek, 5600 
          altında ise emekli edilmeyecek bilgisi kullanıcıya gösterilecek
           ==> cinsiyet bilgisi switch-case ile sorgulanacak
            */
            #endregion
            Console.WriteLine("Cinsiyet belirtiniz");
            string cinsiyet = Console.ReadLine().ToUpper();
            switch (cinsiyet)
            {
                case "ERKEK":
                    Console.WriteLine("Yaşınız");
                    int yas = Convert.ToInt32(Console.ReadLine());
                    if (yas >= 60)
                    {
                        Console.WriteLine("Maaşınız");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Emekli ikramiyeniz: {maas * 10}");
                    }
                    else
                    {
                        Console.WriteLine("Prim gün sayınız");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 6000)
                        {
                            Console.WriteLine("Maaşınız");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Emekli ikramiyeniz:{maas * 11}");
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik yalan oldu");
                        }
                    }
                    break;
                case "KADIN":
                    Console.WriteLine("Yaşınız");
                    int kYas = Convert.ToInt32(Console.ReadLine());
                    if (kYas >= 58)
                    {
                        Console.WriteLine("Maaşınız");
                        double maas = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Emekli ikramiyeniz: {maas * 10}");
                    }
                    else
                    {
                        Console.WriteLine("Prim gün sayınız");
                        int prim = Convert.ToInt32(Console.ReadLine());
                        if (prim >= 5800)
                        {
                            Console.WriteLine("Maaşınız");
                            double maas = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine($"Emekli ikramiyeniz:{maas * 11}");
                        }
                        else
                        {
                            Console.WriteLine("Emeklilik yalan oldu");
                        }
                    }
                    break;
                default: Console.WriteLine("Hatalı işlem"); break;

            }
        }
    }
}
