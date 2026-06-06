using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Constructor_3_ReadOnly
{
    internal class ConstTest
    {
        public const double Pi = 3.14;

        public ConstTest()
        {
            //Pi= 3.14159; // Hata: const değişkenler sadece tanımlandıkları
                         // yerde atanabilir ve değiştirilemezler.
        }
    }
}
