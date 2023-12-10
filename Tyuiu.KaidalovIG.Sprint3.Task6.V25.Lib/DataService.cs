using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KaidalovIG.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int num = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= (int)Math.Pow(i, 0.5); j++)
                {
                    if (i % j == 0)
                    {
                        if (Math.Pow(j, 2) != i)
                        {
                            if (j < 10) num += j;
                            if ((i / j) < 10) num += i / j;
                        }
                        else num += j;
                    }
                }

            }
            return num;
        }
    }
}
