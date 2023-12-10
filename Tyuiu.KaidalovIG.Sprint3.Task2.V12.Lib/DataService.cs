using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaidalovIG.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double res = 1;
            do
            {
                res = res * (Math.Pow(300 / (startValue + Math.Pow(value, startValue)), startValue));
                startValue++;
            }
            while (startValue <= stopValue);

            return Math.Round(res, 3);
        }
    }
}
