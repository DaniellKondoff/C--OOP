using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public static class Validator
    {
        internal static bool IsConsistDigitstOnly(string phoneNumber)
        {
            if (phoneNumber.Any(n=>Char.IsDigit(n)))
            {
                return false;
            }
            return true;
        }
    }
}
