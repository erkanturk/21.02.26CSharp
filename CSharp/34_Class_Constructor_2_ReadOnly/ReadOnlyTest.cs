using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Constructor_3_ReadOnly
{
    internal class ReadOnlyTest
    {
        public readonly int ReadOnlyVal = 10;
        //Readonly yapısı ilk tanımlandığı yerde veya
        //constructor yapısında değer ataması yapılabilir.
        //Sonrasında değeri değiştirilemez.
        //public int NormalVal = 10;
        public ReadOnlyTest()
        {
            ReadOnlyVal = 20;
        }
        //public void DegerDegistir()
        //{
        //    //ReadOnlyVal = 30;//Hata verir. Çünkü ReadOnlyVal değeri sadece tanımlandığı yerde veya constructor yapısında değiştirilebilir.
        //    NormalVal = 50;//NormalVal değeri her yerden değiştirilebilir.
        //    int sayi = ReadOnlyVal;
        //}

    }
}
