using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode07
{
    public class DelegateFunctions
    {
        public static string Sum(int a, int b)
        {
            return "合計値:" +  (a + b).ToString();
        }

        public static string Multiply(int a, int b)
        {
            return "掛けた値:" + (a * b).ToString();
        }

        public static string Power(int a, int b)
        {
            int ret = 1;
            for (int i = 0; i < b; i++)
            {
                ret *= a;
            }

            return "aのb乗:" + ret.ToString();
        }
    }
}
