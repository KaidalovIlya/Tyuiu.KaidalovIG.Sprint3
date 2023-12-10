using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint3.Task1.V22.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task1.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Кайдалов И. Г. | СМАРТб-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет              *");
            Console.WriteLine("* произведение ряда по формуле, при a = 1,5.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*      20                                                                 *");
            Console.WriteLine("*      --                                                                 *");
            Console.WriteLine("*      \\     k                                                           *");
            Console.WriteLine("* S =  /   (a  + 1/2) * cos(k)                                            *");
            Console.WriteLine("*      --                                                                 *");
            Console.WriteLine("*     k=1                                                                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");

            double a = 1.5;
            int startValue = 1;
            int stopValue = 20;


            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"a = {a}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(a, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
