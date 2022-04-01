using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_tk_3_17th_March
{
    public class Membership : IMembership

    {
        public void SilverMembership()
        {
            Console.WriteLine("3 days accomodation at resort ");
        }

        public void GoldMembership()
        {
            Console.WriteLine("5 days accomodation at resort \n2 Dinners on the house");
        }

        public void PlatinumMembership()
        {
            Console.WriteLine("7 days accomodation at resort \n5 Dinners on the house");
        }
    }
}
