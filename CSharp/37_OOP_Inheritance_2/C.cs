using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance_2
{
    internal class C:B
    {
        public int CClass { get; set; }
        public C()
        {
            Console.WriteLine("C Sınıfı Ctor");
        }
    }
}
