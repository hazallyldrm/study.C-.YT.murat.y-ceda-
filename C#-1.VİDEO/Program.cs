using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__1.VİDEO
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");
            //Console.WriteLine("*********Yemek Listesi*********");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Salatalar");
            //Console.WriteLine("3-Ara Yemekler");
            //Console.WriteLine("4-Ana Yemekler");
            //Console.WriteLine();
            //Console.WriteLine("*********Yemek Listesi*********");
            #endregion
            #region Değişkenler STRİNG
            //string name;
            //name = "Hazal";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;


            //customerName = "Hazal";
            //customerSurname = "Yıldırım";
            //customerPhone = "+90 550 555 555";
            //customerEmail = "deneme@gmail.com";
            //district = "Merkez";
            //city = "Elazığ";

            //Console.WriteLine("****Rezervasyon Kartı****");
            //Console.WriteLine("");
            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");
            //customerName = "Eylül";
            //customerSurname = "Alptekin";
            //customerPhone = "+90 550 555 555";
            //customerEmail = "deneme@gmail.com";
            //district = "Çarşamba";
            //city = "Samsun";

            //Console.WriteLine("---------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("---------------------------");
            #endregion
            #region Değişkenler İNT
            //int number;
            //number = 12;
            //Console.WriteLine(number);

            int hamburgerPrice = 300, cokePrice = 35, waterPrice = 10, friesPrice = 50, pizzaPrice = 250, lemonadePrice = 30;
            Console.WriteLine("*****Restoran Menü Fiyatı*******");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("------Kola:" + cokePrice + "TL");
            Console.WriteLine("------Limonata:" + lemonadePrice + "TL");
            Console.WriteLine("------Kızartma: " + friesPrice + "TL");
            Console.WriteLine("------Su: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("*****Restoran Menü Fiyatı*******");

            Console.WriteLine();
            int hamburgerCount, waterCount, cokeCount, friesCount, pizzaCount, lemonadeCount;
            int hamburgerTotal, waterTotal, cokeTotal, friesTotal, pizzaTotal, lemonadeTotal;
            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;
            Console.WriteLine("-----------------------------------");
            hamburgerTotal = hamburgerPrice * hamburgerCount;
            Console.WriteLine("Hambuger Tutarı: " + hamburgerTotal + "TL");

           cokeTotal = cokePrice*cokeCount;
            Console.WriteLine("Kola Tutarı: " +cokeTotal + "TL");

            waterTotal = waterPrice * waterCount;
            Console.WriteLine("Su Tutarı: " + waterTotal + "TL");

            friesTotal = friesPrice*friesCount;
            Console.WriteLine("Kızartma Tutarı: " + friesTotal + "TL");

            pizzaTotal =pizzaPrice*pizzaCount;
            Console.WriteLine("Pizza Tutarı: " + pizzaTotal + "TL");

            lemonadeTotal = lemonadePrice * lemonadeCount;
            Console.WriteLine("Limonata Tutarı: " + lemonadeTotal + "TL");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine();
            int totalPrice = cokeTotal + waterTotal + lemonadeTotal + friesTotal + pizzaTotal + hamburgerTotal;
            Console.WriteLine("Toplam Ödenecek Toplam Tutar: " + totalPrice + "TL");




            


            #endregion

            Console.Read();
        }
    }
}
