using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction_2
{
    internal abstract class Elektirikli:Elektronik
    {
        public double Voltaj {  get; set; }
        public abstract int Amper{get; set;}
        protected Elektirikli()
        {
            Console.WriteLine("Elektirikli constructor");
        }
    }
}
