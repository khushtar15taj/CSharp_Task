using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_task3_16_march
{
    public class TaxCalculators
    {
        public double income;
        public TaxCalculators(double x)
        {
            income = x;
        }
        public void TaxCalculator()
        {
            Console.WriteLine("The total Tax is withh Vat is {0}", (double)(20 * income) / 100);

        }
    }

    public class TaxCalculatorGST : TaxCalculators
    {
        public double income;
        public TaxCalculatorGST(double y)  : base(y)
        {
            income = y;
        }
        public void TaxCalculator(int z)
        {
            Console.WriteLine("The total Tax is withh gst is {0}", (double)(12 * income) / 100);

        }
    }
}
