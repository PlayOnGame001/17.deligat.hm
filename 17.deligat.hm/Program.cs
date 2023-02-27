using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _17.deligat.hm
{
    delegate void Deligate(int[] mas);
    delegate void Time();
    delegate void Area();
    class Massive
    {
        public static void Chet(int[] mas)
        {
            foreach (int i in mas)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public static void Nechet(int[] mas)
        {
            foreach (int i in mas)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        public static void Prost(int[] mas)
        {

        }
        public static void Fibon(int[] mas)
        {
            int d = 0, num1 = 0, num2 = 1, result = 0;
            Console.WriteLine("Enter 1 to...");
            string diapason = Console.ReadLine();
            d = Convert.ToInt32(diapason);

            while (result < d)
            {
                result = num1 + num2;
                if (result > d)
                {
                    break;
                }
                num1 = num2;
                num2 = result;
                Console.WriteLine($"Result = {result}");
            }
        }
        public static void Time()
        {
            Console.WriteLine(DateTime.Now.TimeOfDay.ToString());
        }
        public static void Date()
        {
            Console.WriteLine(DateTime.Now.Date.ToString());
        }
        public static void DayOfWeek()
        {
            Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
        }
        public static void AreaTriangle()
        {
            int Side1;
            int Side2;
            int Side3;
            Console.Write("Enter 1: ");
            Side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2: ");
            Side2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3: ");
            Side3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(1 / 2 * ((Side1 * Side2) * Math.Sin(Side3)));
        }
        public static void AreaRectangle()
        {
            int L;
            int W;
            Console.Write("Enter Lenth: ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Width: ");
            W = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(L * W);
        }
        static void Main(string[] args)
        {
            int[] mas = { 1, 2, 3, 4, 5 };

            Deligate Task1 = new Deligate(Chet);
            Task1 += Nechet;
            Task1 += Fibon;
            Task1 += Prost;

            Time Task2 = new Time(Time);
            Task2 += Date;
            Task2 += DayOfWeek;

            Area Task3 = new Area(AreaTriangle);
            Task3 += AreaRectangle;
        }
    }
}