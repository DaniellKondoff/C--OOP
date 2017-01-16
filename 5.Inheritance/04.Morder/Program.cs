using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morder
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]tokens = Console.ReadLine().Split(' ');
            int totalPoints = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                string currFood = tokens[i].ToLower();

                int currPoints;
                switch (currFood)
                {
                    case "cram":
                        currPoints = 2;
                        break;
                    case "lembas":
                        currPoints = 3;
                        break;
                    case "apple":
                        currPoints = 1;
                        break;
                    case "melon":
                        currPoints = 1;
                        break;
                    case "honeycake":
                        currPoints = 5;
                        break;
                    case "mushrooms":
                        currPoints = -10;
                        break;
                    default:
                        currPoints = -1;
                        break;
                }

                totalPoints += currPoints;
            }

            Console.WriteLine(totalPoints);
            if (totalPoints < -5)
            {
                Console.WriteLine("Angry");
            }
            else if (totalPoints >= -5 && totalPoints < 0)
            {
                Console.WriteLine("Sad");
            }
            else if (totalPoints >= 0 && totalPoints < 15)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("JavaScript ");
            }
        }
    }
}
