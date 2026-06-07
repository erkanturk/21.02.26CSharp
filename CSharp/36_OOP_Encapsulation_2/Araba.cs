using System;
using System.Collections.Generic;
using System.Text;

namespace _36_OOP_Encapsulation_2
{
    internal class Araba
    {
        private double Hiz;

        private const double MaxHiz = 250;

        public double _Hiz
        {
            get
            {
                return Hiz;
            }
            set
            {
                if (value > 0 && value <= MaxHiz)
                {
                    Hiz = value;
                    Console.WriteLine(Hiz);
                }
                else if (value > MaxHiz)
                {
                    Console.WriteLine($"Hız {MaxHiz} km/saat'i geçemez.");
                }
                else
                {
                    Console.WriteLine("Hız negatif olamaz.");
                }
            }
        }
        public void Hizlan(double artis)
        {
            if (artis > 0 && artis <= MaxHiz)
            {
                Hiz += artis;
            }
            else
            {
                Console.WriteLine("Hızlanma miktarı negatif olamaz.");
            }
            if (artis > MaxHiz)
            {
                Console.WriteLine($"Hızlanma miktarı {MaxHiz} km/saat'i geçemez.");
            }
            if (Hiz > MaxHiz)
            {
                Console.WriteLine($"Hızlanma miktarı {MaxHiz} km/saat'i geçemez.");
                Hiz = MaxHiz;
                Console.WriteLine($"Şu anki hızınız {Hiz} km/saat.");
            }

        }
        public void Yavasla(double azalis)
        {
            if (azalis > 0 && azalis <= MaxHiz)
            {
                Hiz -= azalis;
            }
            if (Hiz <=0)
            {
                Console.WriteLine($"Araç stop etti");
            }
            
        }
    }
}
