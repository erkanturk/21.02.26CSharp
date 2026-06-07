using System;
using System.Collections.Generic;
using System.Text;

namespace _37_OOP_Inheritance_2
{
    internal class B:A
    {
        public int BClass { get; set; }
        public B()
        {
            Console.WriteLine("B sınıfı ctor oluşturuldu");
        }
    }
}
