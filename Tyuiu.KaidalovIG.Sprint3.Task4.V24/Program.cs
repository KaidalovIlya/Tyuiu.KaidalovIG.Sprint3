using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint3.Task4.V24.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task4.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #3 | Выполнил: Кайдалов И. Г. | ИИПб-23-3";

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* Спринт #3                                                          *");
            Console.WriteLine("* Задание #4                                                         *");
            Console.WriteLine("* Вариант #24                                                        *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                           *");
            Console.WriteLine("* На отрезке, где x принимает значения от -5 до 5, вычислить значение*");
            Console.WriteLine("* функции y=(sin(x)/x)+2. При х = 0 прервать цикл.                   *");
            Console.WriteLine("* Полученные значения перемножать.                                   *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                   *");
            Console.WriteLine("**********************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт = " + startValue);
            Console.WriteLine("конец шага = " + stopValue);

            Console.WriteLine("**********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                          *");
            Console.WriteLine("**********************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(startValue, stopValue));

            Console.ReadKey();
        }
    }
}
