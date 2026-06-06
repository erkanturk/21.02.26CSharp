
using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Constructor_3_ReadOnly
{
    internal class Test
    {
        public readonly ReadOnlyTest _test;
        public Test(ReadOnlyTest readOnly)
        {
            _test=readOnly;//DI Dependency Injection Dışa bağımlılık.
            //Readonly yapısını dışa bağımlılığı güvenli
            //bir şekilde kullanmak için kullanırız.
            //Readonly yapısı sadece constructor içerisinde
            //set edilebilir ve o set edilen değer değiştirilemez.
            //Bu sayede dışarıdan gelen bir değerin değiştirilmesi engellenmiş olur.
        }
        public void Yaz()
        {
           var deger= _test.ReadOnlyVal.ToString();
            Console.WriteLine(deger);
        }
    }
}
