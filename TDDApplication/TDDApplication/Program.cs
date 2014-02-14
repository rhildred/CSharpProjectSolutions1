using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDApplication
{
    class Program
    {
        static int sayFavouriteNumber(int nFavourite)
        {
            Console.WriteLine(nFavourite + " is my favourite number");
            return nFavourite;
        }
        static void sayItsWednesdayNow()
        {
            Console.WriteLine("Ooops its Wednesday now");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Tuesday!");
            sayItsWednesdayNow();
            sayFavouriteNumber(6);
        }
    }
}
