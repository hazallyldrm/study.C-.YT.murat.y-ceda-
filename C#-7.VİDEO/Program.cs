using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__7.VİDEO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region foreach döngüsü
            //FOREACH(1;2;3;4)
            //1:DEĞİŞKEN TÜRÜ
            //2:DEĞİŞKEN ADI
            //3:IN
            //4:LİSTE , KOLEKSİYON,DİZİ

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6587, 1094 };

            //foreach (int number in numbers)
            //{ 
            //Console.WriteLine(number);
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6587, 1094 };

            //foreach (int i in numbers)
            //{
            //    if (i % 2 == 0)
            //    { 
            //    Console.WriteLine(i);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6587, 1094 };

            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //List<int> list = new List<int>()//liste oluşturma
            //{
            //    1,2,3,4,5,8
            //};
            //foreach (int i in list)//foreach listelerlede çalışır
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";//kelimenin harflerini alt alta sırala

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region örnek sınav sistemi,
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //sınıftaki öğrenci sayısının kullanıcıdan alma
            Console.WriteLine("---------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------------------");

            //öğrenci isimlerini ve not ort saklayacak diziler
            string[]studentNames=new string[studentCount];
            double[] studentExamAvg=new double[studentCount];
                
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                //her öğrenci için 2 sınav notu girişi
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = Convert.ToDouble(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz
                }
                studentExamAvg[i]= totalExamResult /2;
            }
            //sınav ort
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------------");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrenci ort ve geçip kalma durumalrı
                if (studentExamAvg[i] >= 50)
                {
                    Console.Write($"{studentNames[i]} adlı öğrenci dersi geçti! ");
                }
                else
                {
                    Console.Write($"{studentNames[i]} adlı öğrenci dersi geçti! ");
                }
                Console.WriteLine("---------------------------------");
            }
                    #endregion
                    Console.ReadKey();
        }
    }
}
