using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode07
{
    public class Average : IRepresentativeValue
    {
        public double GetRepresentativeValue(double[] values)
        {
            //平均値を出す
            double sum = 0.0;

            for (int i = 0; i < values.Length; i++)
            {
                sum += values[i];
            }

            return sum / values.Length;
        }
    }
}
