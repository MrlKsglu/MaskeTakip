
using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workround
{
    class Program
    {
        static void Main(string[] args)
        {



            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };

            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;

            sehirler1[0] = "Adana";

            List<string> yeniSehiler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };

            yeniSehiler1.Add("Adana 1");

            foreach (var sehir in yeniSehiler1)
            {
                Console.WriteLine(sehir);
            }

            Person person1 = new Person();
            person1.FirstName = "Meral";
            person1.LastName = "K";
            person1.DateOfBirthYear = 1991;
            person1.NationalIdentity = 12345;


            Person person2 = new Person();
            person2.FirstName = "Cihat";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);





        }


        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba Meral " + isim);
        }



        static int Topla(int sayi1 = 9, int sayi2 = 8)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + sonuc);
            return sonuc;
        }
    }




}





