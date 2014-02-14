using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDApplication
{
    class CanadianTax
    {
        internal static string getTax(string sIn, string sProv = "ON")
        {
            decimal nIn = Decimal.Parse(sIn);
            decimal nRc = 0;
            if (sProv == "ON" || sProv == "NB" || sProv == "NL" || sProv == "MB")
            {
                nRc = nIn * 1.13M;
            }
            else if (sProv == "PE")
            {
                nRc = nIn * 1.14M;
            }
            else if (sProv == "NS")
            {
                nRc = nIn * 1.15M;
            }
            else if (sProv == "QC")
            {
                nRc = nIn * 1.14975M;
            }
            else if (sProv == "SK")
            {
                nRc = nIn * 1.1M;
            }
            else if (sProv == "BC")
            {
                nRc = nIn * 1.12M;
            }
            else
            {
                nRc = nIn * 1.05M;
            }
            return nRc.ToString("0.00");
        }
    }
}
