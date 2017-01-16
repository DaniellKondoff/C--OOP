using System;

namespace _04.BeerCounter
{
    public class BeerCounter
    {
        public static int beerInStock;
        public static int beersDrankCount;

      public static int BuyBeer(int bottlesCount)
        {
            beerInStock += bottlesCount;
            return beerInStock;
        }

       public static void DrinkBeer(int bottlesCount)
        {
            beersDrankCount += bottlesCount;
            beerInStock -= bottlesCount;
        }
    }
    public class Beer
    {
       public  static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            while(input[0] != "End")
            {
                BeerCounter.BuyBeer(int.Parse(input[0]));
                BeerCounter.DrinkBeer(int.Parse(input[1]));
                input = Console.ReadLine().Split();
            }

            Console.WriteLine(BeerCounter.beerInStock+ " " +BeerCounter.beersDrankCount);
        }
    }
}
