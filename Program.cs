using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bn1._1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите длину ");
            int a = int.Parse(Console.ReadLine()); // длина
            Console.Write("Введите ширину ");
            int b = int.Parse(Console.ReadLine()); // ширина
            Console.Write("Введите высоту ");
            int c = int.Parse(Console.ReadLine()); // высота
            double S;
            S = 2 * (a * b + b * c + a * c); //формула площади
            Console.WriteLine("Площадь поверхности параллелепипеда {0}", S);
            Console.ReadKey();
        }
    }
}
