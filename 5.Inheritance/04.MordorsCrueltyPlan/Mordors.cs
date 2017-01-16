
using _04.MordorsCrueltyPlan.Mood;
using System;


    public class Mordors
    {
        static void Main()
        {
            string[] foodTokens = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);

            FoodFactory foodFactory = new FoodFactory();
            MoodFactory moodFactory = new MoodFactory();

            int point = 0;

            for (int i = 0; i < foodTokens.Length; i++)
            {
                string food = foodTokens[i];

                Food currentFood = foodFactory.createFood(food.ToLower());
                point += currentFood.givePointsOfHappines();
            }
            Console.WriteLine(point);
            Console.WriteLine(moodFactory.createMood(point).GetMoodName);
        }
    }

