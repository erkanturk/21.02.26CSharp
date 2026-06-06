using System;
using System.Collections.Generic;
using System.Text;

namespace _35_RestorantOtomasyon
{
    public class Yonetici
    {
        private static string Password = "1234";

        public static bool Giris()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Şifre:");
                string password = Console.ReadLine();
                if (password == Password)
                {
                    return true;
                }
                Console.WriteLine("Tekrar deneyin");
            }
            return false;
        }
    }
}
