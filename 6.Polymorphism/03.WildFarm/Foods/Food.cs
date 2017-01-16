using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WildFarm.Foods
{
   public abstract class Food
    {
        private int foodQuantity;

        public Food(int foodQuantity)
        {
            this.FoodQuantity = foodQuantity;
        }

        public int FoodQuantity
        {
            get
            {
                return this.foodQuantity;
            }
            set
            {
                this.foodQuantity = value;
            }
        }
    }
}
