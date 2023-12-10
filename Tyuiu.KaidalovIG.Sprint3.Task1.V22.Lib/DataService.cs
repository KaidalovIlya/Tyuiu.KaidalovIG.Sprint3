using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.KaidalovIG.Sprint3.Task1.V22.Lib
{
    public class DataService : ISprint3Task1V22
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            {
                int i = 1;
                double res = 0;
                while (i <= stopValue)
                {
                    res += (Math.Pow(value, i) + 0.5) * Math.Cos(i);
                    i++;
                }
                return Math.Round(res, 3);
            }
        }
    }
}
