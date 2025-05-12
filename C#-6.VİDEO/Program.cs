using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__6.VİDEO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örn
            // değişken türü [] diziadı = new değişkentürü[eleman sayısı]
            //string[] colors = new string[4];
            //colors[0] = "kırmızı" ;
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);

            //string [] cities= new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[2]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers);

            //string[] cities = { "ankara", "elazığ", "malatya");

            //Console.WriteLine(cities[2]);


            #endregion

            #region dizideki tüm elemanları listeleme
            //string[] colors = { "kırmızı", "sarı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{ 
            //Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 782, 389, 554, 85,96 ,546,7925,546};

            //for (int i = 0; i < numbers.Length; i++)
            //{   
            //if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}  


            //char[] symbols = { 'A', 'B', 'C' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myarry = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };

            //int maxNumber=myarry[0];

            //for (int i = 0; i < myarry.Length; i++)
            //{
            //    if (myarry[i] > maxNumber)
            //    { 
            //        maxNumber = myarry[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] name = { "ali", "ayşe", "ahmet" };
            //Console.WriteLine(name.Length);

            //int[] numbers = { 45, 85, 41, 86, 10, 22, 35 };

            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region dizi metotları

            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve")  ;


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max()+"\n"+"dizinin en küçük elemanı: " + numbers.Min());


            #endregion

            #region kullanıcıdan değer alma 
            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehrini giriniz: ");
            //    //$sembolu "" içinde parametreler kullanmaya izin veren semboldur
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------");

            //for (int i = 0; i <cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {  
            //        Console.WriteLine(numbers[i]);
            //    }               
            //}

            #endregion

            Console.ReadKey();
        }
    }
}
