using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint3.Task7.V29.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task7.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Кайдалов И. Г. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич | СМАРТб-23-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Значения занести в массив.                                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага :" + startValue);
            Console.WriteLine("Конец шага :" + stopValue);

            int len = (stopValue - startValue) + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];
            valueWaitArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+---------+---------+");
            Console.WriteLine("|    X    |   f(x)  |");
            Console.WriteLine("+---------+---------+");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}    | {1, 6:f2}  |", startValue, valueWaitArray[i]);
                startValue++;
            }

            Console.WriteLine("+---------+---------+");

            Console.ReadKey();
        }
    }
}
