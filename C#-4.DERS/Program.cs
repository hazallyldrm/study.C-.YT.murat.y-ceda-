using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__4.DERS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FOR DÖNGÜSÜ
            //for (x;y;z)
            //x: Başlangıç değeri
            //y: Koşul
            //z: Artış miktarı
            //int i;
            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("HAZAL");
            //}
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 3; i <= 50; i+=3 )
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılması istediğiniz adedi giriniz:");
            //int finishValue;
            //finishValue=Convert.ToInt32(Console.ReadLine());

            //for (int i  = 1; i  <= finishValue; i ++)
            //{
            //    Console.WriteLine("Yaşasın CUMHURİYET");
            //}



            #endregion
            #region FOR DÖNGÜSÜ İLE KARAR YAPILARI
            //for (int i = 0; i < = 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{ 
            //totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //    }
            //}
            //Console.WriteLine(totalValue);

            //int count = 0;
            //for (int i = 1; i <=50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);





            #endregion
            #region bakteri örn
            //int bakterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{ 
            // bakterium*=2;
            //    Console.WriteLine(i+".saat sonunda: "+bakterium);

            //}   
            #endregion

            #region WHİLE DÖNGÜSÜ
            //while(şart)
            //{
            //    işelm
            //}
            //int i = 1;

            //while (i <= 10) 
            //{
            //    Console.WriteLine("merhaba");
            //    i++;

            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i %3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i ++;

            //}

            //int i = 1;
            //int sum = 0;


            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);
            #endregion
            #region örn sınav sorusu
            //klavyeden girilen 3 basamaklı sayının basamakalrı toplamını hesaplayan kod
            int num,ones,tens,hunders,sum;

            Console.Write("3 Basamaklı sayı giriniz: ");
            num=Convert.ToInt32(Console.ReadLine());

            ones = num % 10;
            tens =( num % 100)/10;
            hunders = num / 100;

            Console.WriteLine(ones + "-" + tens + "-" + hunders);
            sum =ones+tens+hunders;
            Console.WriteLine(sum);


            #endregion


            Console.ReadKey();
        }
    }
}
