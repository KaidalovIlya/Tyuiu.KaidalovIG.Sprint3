using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaidalovIG.Sprint3.Task3.V5.Lib;

namespace Tyuiu.KaidalovIG.Sprint3.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Кайдалов И. Г. | СМАРТ-б-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант 5                                                               *");
            Console.WriteLine("* Выполнил: Кайдалов Илья Григорьевич | СМАРТ-б-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая используя цикл foreach заменит буквы a  на  *");
            Console.WriteLine("*  * в строке: fifa al fall                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            string art = "fifa al fall";
            char andr = 'a';
            char tim = '*';
            Console.WriteLine("Исходная строка = " + art);
            Console.WriteLine("Заменяемый символ = " + andr);
            Console.WriteLine("Заменительный символ = " + tim);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Итоговая строка = " + ds.ReplaceCharInString(art, andr, tim));

            Console.ReadKey();

        }
    }
}
