using System;

namespace CS_task3_16_march
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MulDiv ad = new MulDiv(2, 4);
            ad.AddSubtract();
            ad.MulDivision();

            TaxCalculatorGST gst = new TaxCalculatorGST(78660);
            gst.TaxCalculator();
            gst.TaxCalculator(2);

            UserLogin login = new UserLogin();
            login.ValidatePin(12347);
            login.ValidateEmail("5464@gmail.com");
            login.ValidatePhone(43534);
        }
    }
}
