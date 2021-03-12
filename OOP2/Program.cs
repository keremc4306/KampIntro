﻿using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kerem Candangil
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Kerem";
            musteri1.Soyadi = "Candangil";
            musteri1.TcNo = "15349246121";


            //Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234521652";

            //Gerçek Müşteri - Tüzel Müşteri


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
        }
    }
}
