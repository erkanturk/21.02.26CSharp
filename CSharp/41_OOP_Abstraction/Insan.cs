using System;
using System.Collections.Generic;
using System.Text;

namespace _41_OOP_Abstraction
{
    public abstract class Insan//Parrent class
    {
        public abstract long TC { get; set; }//Soyut olarak işaretlediğimiz property
        //Child yani miras alan sınıflar mutlaka kullanmak zorundadır.
        public abstract string Ad {  get; set; }
        public string Soyad { get; set; }

        public abstract void Create(long tc);//Gövdesiz method.
        public abstract void Update();//Mutlaka kullanılmalıdır.
        public abstract void Delete();
        public abstract void List();
        public void Find(int id)
        {
            Console.WriteLine(id);
        }
    }
}
