using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.SoyAdi = "Demiroğ";
            musteri1.TcNo = "121323454540";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "456521;";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "5412564";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerMenager customerMenager = new CustomerMenager();
            customerMenager.Add(musteri1);
            customerMenager.Add(musteri2);






        }
    }
}
