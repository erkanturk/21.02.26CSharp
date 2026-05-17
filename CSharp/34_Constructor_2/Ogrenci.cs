using System;
using System.Collections.Generic;
using System.Text;

namespace _34_Constructor_2
{
    internal class Ogrenci
    {
        public int OgrNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int DogumTarihi { get; set; }

        public List<Ogrenci> Ogrenciler { get; set; }=new List<Ogrenci>();

        public Ogrenci(int ogrNo,string ad,string soyad,int dogumTarihi)
        {
            OgrNo = ogrNo;
            Adi = ad;
            Soyadi = soyad;
            DogumTarihi = dogumTarihi;
            Ogrenciler.Add(this);
        }

        //public List<Ogrenci> Ogrenciles()
        //{
        //    List<Ogrenci> ogrencis = new List<Ogrenci>()
        //    {
        //        new Ogrenci(){ Adi="Erkan",Soyadi="Türk",DogumTarihi=1995,OgrNo=1},
        //        new Ogrenci(){ Adi="Altan",Soyadi="Demirci",DogumTarihi=1986,OgrNo=2},
        //        new Ogrenci(){ Adi="Tahsin",Soyadi="Canpolat",DogumTarihi=1992,OgrNo=3},
        //        new Ogrenci(){ Adi="Onur",Soyadi="Yağız",DogumTarihi=1993,OgrNo=4},
        //        new Ogrenci(){ Adi="Furkan",Soyadi="Uçan",DogumTarihi=2000,OgrNo=5},
        //        new Ogrenci(){ Adi="Bedirhan",Soyadi="Giden",DogumTarihi=2000,OgrNo=6},
        //        new Ogrenci(){ Adi="Enes",Soyadi="Aslan",DogumTarihi=1995,OgrNo=7},
        //        new Ogrenci(){ Adi="Aslı",Soyadi="Ör",DogumTarihi=1995,OgrNo=8},
        //        new Ogrenci(){ Adi="Ebru",Soyadi="Türk",DogumTarihi=1995,OgrNo=9}
        //    };
        //    return ogrencis;
        //}
    }
}
