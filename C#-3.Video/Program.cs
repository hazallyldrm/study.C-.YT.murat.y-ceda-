using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__3.Video
{
    class Program
    {
        static void Main(string[] args)
        {
            #region İf Else
            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "1234")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}
            //string capital, country;
            //Console.Write("başkenti giriniz:  ");
            //capital = Console.ReadLine();

            //Console.Write("ülkeyi giriniz:  ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("doğru");
            //}
            //else
            //{
            //    Console.WriteLine("yanlış");
            //}
            //int number;
            //Console.Write("Bir sayı giriniz: ");
            //number=int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Sayı doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Sayı yanlış");
            //}
            //double exam1, exam2, exam3, average;
            //string result;
            //Console.Write("1. sınavı giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. sınavı giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. sınavı giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;  
            //Console.WriteLine("Ortalama: " + average);
            //if (average >= 0 & average<=49)
            //{
            //    result = " Kötü";
            //}
            //if (average >= 50 & average <= 69)
            //{
            //    result = "Ortalama";
            //}
            //if (average >= 70 & average <=84)
            //{
            //    result = "İyi";
            //}
            //if (average>=85&average<100)
            //{
            //    result = "Çok İyi";
            //}

            //Console.WriteLine("Sonuç: " + result);

            //string city;
            //Console.Write("Bir şehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" || city == "ankara" || city == "trabzon")
            //{
            //    Console.WriteLine("Şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}
            //Console.WriteLine("Lütfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if(username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz!!");
            //}

            #endregion
            #region MOD işlemleri
            //int number;
            //number = 10;
            //int result=number%5;
            //Console.WriteLine(result);
            //Console.Write("Bir 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Bir 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine("1.sayının ikinci sayıya bölümünden kalan : " + result);
            //Console.Write("Bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion
            #region Char değişkeni ile karar yapıları
            //char team;
            //Console.Write("Bir takım sembolü giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'F' || team == 'f'  )
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            //if (team == 'G' || team == 'g'  )
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if (team == 'b' || team == 'B'  )
            //{
            //    Console.WriteLine("beşiktaş");
            //}


            #endregion
            #region örnek proje uygulaması
            //Console.WriteLine("*******************C# Eğitim Kampı Restorant************************* ");
            //Console.WriteLine();
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- İçecekler");
            //Console.WriteLine("3- Tatlılar");
            //Console.WriteLine("4- Çorbalar");
            //Console.WriteLine("5- Pizzalar");

            //string menuItem;
            //Console.Write("Lütfen menü numarasını giriniz: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1") 
            //{ 
            //    Console.WriteLine();
            //    Console.WriteLine("*************Ana Yemekler Menüsü************");
            //    Console.WriteLine("1- Kuru Fasulye");
            //    Console.WriteLine("2- İzmir Köfte");
            //    Console.WriteLine("3- Tavuklu Pilav");
            //    Console.WriteLine("4- Kuzu Tandır");
            //    Console.WriteLine("5- Kıymalı Pide");

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*************İçecekler Menüsü************");
            //    Console.WriteLine("1- kola");
            //    Console.WriteLine("2- ayran");
            //    Console.WriteLine("3- su");
            //    Console.WriteLine("4- limonata");
            //    Console.WriteLine("5- çay");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*************Tatlılar Menüsü************");
            //    Console.WriteLine("1- Sütlaç");
            //    Console.WriteLine("2- Kadayıf");
            //    Console.WriteLine("3- Baklava");
            //    Console.WriteLine("4- Profiterol");
            //    Console.WriteLine("5- Dondurma");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*************Çorbalar Menüsü************");
            //    Console.WriteLine("1- Mercimek Çorbası");
            //    Console.WriteLine("2- Tarhana Çorbası");
            //    Console.WriteLine("3- Tavuk Suyu Çorbası");
            //    Console.WriteLine("4- Domates Çorbası");
            //    Console.WriteLine("5- Sebze Çorbası");

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*************Pizzalar Menüsü************");
            //    Console.WriteLine("1- Sucuklu Pizza");
            //    Console.WriteLine("2- Kavurmalı Pizza");
            //    Console.WriteLine("3- Mantarlı Pizza");
            //    Console.WriteLine("4- Kıymalı Pizza");
            //    Console.WriteLine("5- Karışık Pizza");
            //}








            #endregion
            #region Switch Case

            //int monthNumber;
            //Console.Write("Bir ay numarası giriniz: ");
            //monthNumber = Convert.ToInt32(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("Aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş yaptınız");
            //        break;
            //}

            #endregion
            #region switch case örnek proje
            int number1, number2;
            int result;
            char symbol;
            Console.Write("1. sayıyı giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());


            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
                default:
                    Console.WriteLine("Hatalı giriş yaptınız");
                    break;
                    #endregion
                    Console.ReadKey();

            }
    }
}
