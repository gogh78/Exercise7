using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Два треугольника заданы длинами своих сторон.
            //Определить, площадь какого из них больше (создать метод для вычисления
            //площади  треугольника по длинам его сторон).
            //Для решения задачи можно использовать формулу Герона 
            //S = Sqrt(p*(p-x)*(p-y)*(p-z))
            //где x, y, z – стороны треугольника, p – полупериметр.

            int[] array = new int[2];
            int x = 0;
            int y = 0;
            int z = 0;
            int n = 0;
            double min = 0;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Введите длины сторон треугольника х, у, z");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                z = Convert.ToInt32(Console.ReadLine());
                double S = area(x, y, z);
                Console.WriteLine();
                Console.WriteLine("Площадь треугольника = {0:0.000}", S);
                {
                    if (S > min)
                    {
                        min = S;
                        n = i + 1;
                    }
                }

            }
            Console.WriteLine();
            Console.WriteLine("Максимальную площадь имеет треугольник №{0} с площадью = {1:0.000}", n, min);
            Console.ReadKey();
        }
        static double area(int x, int y, int z)
        {
            int p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }

    }
}
