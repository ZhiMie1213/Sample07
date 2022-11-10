using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode07
{
    public class RepresentativeValueCalculator
    {
        private IRepresentativeValue RValue { get; set; }

        public RepresentativeValueCalculator(IRepresentativeValue value)
        {
            RValue = value;
        }

        public double GetRepresentativeValue(double[] array)
        {
            return RValue.GetRepresentativeValue(array);
        }
    }
}
