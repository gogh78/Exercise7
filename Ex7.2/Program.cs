using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
            Console.WriteLine("Введите длину ребра куба");
            double x = Convert.ToInt32(Console.ReadLine());
            double P, S;
            GetParam(ref x, out P, out S);
            Console.WriteLine();
            Console.WriteLine("Площадь поверхности куба = {0}; Объем куба = {1}", P, S);
            Console.ReadKey();
        }
        static void GetParam(ref double x, out double P, out double S)
        {
            P = Math.Pow(x, 2) * 6;
            S = Math.Pow(x, 3);
        }

    }
}
