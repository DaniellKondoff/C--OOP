using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    public class Smartphone : ICallable,IBrowsable
    {
        public void Browsing(string site)
        {
            bool isValidSite = Validator.IsConsistDigitstOnly(site);
            if (!isValidSite)
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {site}!");
            }
        }

        public void Calling(string phoneNumber)
        {
            bool IsValid = Validator.IsConsistDigitstOnly(phoneNumber);
            if (IsValid)
            {
                Console.WriteLine("Invalid number!");
            }
            else
            {
                Console.WriteLine("Calling... " +phoneNumber);
            }
        }
    }
}
