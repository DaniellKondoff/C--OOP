using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneInput = Console.ReadLine().Split(' ');
            string[] siteInput = Console.ReadLine().Split(' ');

            Smartphone smartphone = new Smartphone();
            foreach (var number in phoneInput)
            {
                smartphone.Calling(number);
            }

            foreach (var site in siteInput)
            {
                smartphone.Browsing(site);
            }
        }
    }
}
