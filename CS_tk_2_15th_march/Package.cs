using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_tk_2_15th_march
{
    public class Package
    {
        char pack;
        public Package(char x)
        {
            pack = x;
        }
        public void ChannelPackage()
        {
            
            switch (pack)
            {
                case 'A':
                    Console.WriteLine("\nSouth Special\nChildern's Club\nMovies\nRate= 250");
                    break;
                case 'B':
                    Console.WriteLine("\nNew\nSports\nMovies\nRegional-2\nRate = 450");
                    break;
                case 'C':
                    Console.WriteLine("\nDiscovery\nHistory\nNational\nRate = 350");
                    break;
                default:
                    Console.WriteLine("\nInvalid Package");
                    break;
            }

        }
    }
}
