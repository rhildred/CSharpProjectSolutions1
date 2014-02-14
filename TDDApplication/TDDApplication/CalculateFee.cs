using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDApplication
{
    public delegate decimal CalculateFee(decimal balance);

    public class FeeCalculator
    {
        static public decimal RipoffFee(decimal balance)
        {
            if (balance < 0)
            {
                return 100;
            }
            else
            {
                return 10;
            }
        }
        static public decimal FriendlyFee(decimal balance)
        {
            return 1;
        }
    }
}
