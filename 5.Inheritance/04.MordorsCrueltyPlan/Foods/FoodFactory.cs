using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class FoodFactory
    {
        public Food createFood(string name)
        {
            string foodName = name;
            Food food = null;

            switch (foodName)
            {
                case "cram":
                    food = new Cram();
                    break;
                case "lembas":
                    food = new Lembas();
                    break;
                case "apple":
                    food = new Apple();
                    break;
                case "melon":
                    food = new Melon();
                    break;
                case "honeycake":
                    food = new HoneyCake();
                    break;
                case "mushrooms":
                    food = new Mushrooms();
                    break;
                default:
                    food = new EverythingElse();
                    break;
            }

            return food;
        }
    }

