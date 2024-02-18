using Businesss.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new Vatandas();

            SelamVer("Özlem");
            SelamVer("Atlas");
            SelamVer("Melek");
            SelamVer();


            int sonuc = Topla(3, 5);

            //Diziler / Array
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Özlem";
            ogrenciler[1] = "Atlas";
            ogrenciler[2] = "Melek";

            Console.WriteLine(ogrenciler[0]);

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); //adana

            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            Console.WriteLine(sayi2);

            Person person1 = new Person();
            person1.FirstName = "ÖZLEM";
            person1.LastName = "KOCAHARZEN";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 12345;

            Person person2 = new Person();
            person2.FirstName = "Melek";

            List<string> yeniSehirler = new List<string> { "Ankara 1", "Istanbul 1", "Izmir 1" };
            yeniSehirler.Add("Adana 1");

            foreach (string sehir in sehirler1)//dizi formatini donuyoruz
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            

            Console.ReadLine();
        }


        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }



        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc.ToString());
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000;
            bool girisyapmismi = false;

            string ad = "Özlem";
            string soyad = "Kocaharzen";
            int dogumyili = 2000;
            long tcNo = 1234567890;

            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing -> Ilk harf buyuk

    public class Vatandas
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

    //SOLID
}
