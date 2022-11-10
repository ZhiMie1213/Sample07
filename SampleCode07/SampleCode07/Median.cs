using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode07
{
    public class Median : IRepresentativeValue
    {
        public double GetRepresentativeValue(double[] values)
        {
            //中央値を出す
            //引数をソートして変更したくないので一旦コピーする
            double[] clone = (double[])values.Clone();
            Array.Sort(clone);

            if(clone.Length %2 == 0)
            {
                //偶数の場合
                int targetIndex = clone.Length / 2;
                double medianSum = clone[targetIndex] + clone[targetIndex - 1];
                return medianSum / 2.0;
            }
            else
            {
                //奇数の場合
                int targetIndex = (clone.Length - 1) / 2;
                return clone[targetIndex];
            }
        }
    }
}
