namespace _34_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci(1,"Erkan","Türk",1995);
            Ogrenci ogrenci2 = new Ogrenci(1,"Ali","Türk",1995);
            Ogrenci ogrenci3 = new Ogrenci(1,"test","Türk",1995);
            Ogrenci ogrenci4 = new Ogrenci(1,"veli","Türk",1995);
            Ogrenci ogrenci5 = new Ogrenci(1,"deneme","Türk",1995);
            Ogrenci ogrenci6 = new Ogrenci(1, "1234", "Türk", 1995);
            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(ogrenci);
            ogrencis.Add(ogrenci2);
            ogrencis.Add(ogrenci3);
            ogrencis.Add(ogrenci4);
            ogrencis.Add(ogrenci5);
            ogrencis.Add(ogrenci6);
            //foreach (var x in ogrenci.Ogrenciler())
            //{
            //    Console.WriteLine(x.Adi + " " + x.Soyadi + " " + x.OgrNo + " " + x.DogumTarihi);
            //}
            //ogrenci.Ogrenciler = ogrenci.Ogrenciles();
            //foreach (var item in ogrenci.Ogrenciler)
            //{
            //    Console.WriteLine(item.Adi+" "+item.Soyadi+" "+item.DogumTarihi);
            //}
            //ogrenci.Ogrenciler.ForEach(x => Console.WriteLine(x.Adi + " " + x.Soyadi + " " + x.OgrNo + " " + x.DogumTarihi));
            foreach (var i in ogrencis)
            {
                Console.WriteLine(i.Adi+" "+i.Soyadi+" "+i.OgrNo+" "+i.DogumTarihi);
            }
        }
    }
}
