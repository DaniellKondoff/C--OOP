using _07.FoodStorage.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodStorage.Models
{
    public abstract class Human : IByuer
    {
        private string name;
        private int age;

        public Human(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            this.Food = 0;
        }

        public string Name { get; set; }

        public int Age { get; set; }
        public int Food { get; set; }

        public abstract void BuyFood();
    }
}
