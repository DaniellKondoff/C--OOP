using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FoodStorage.Models
{
    public class Citizen : Human
    {
        private string id;
        private string birthdate;
        public Citizen(string name, int age,string id,string birthdate) 
            : base(name, age)
        {
            this.Id = id;
            this.BirthDate = birthdate;
        }

        public string Id { get; set; }

        public string BirthDate { get; set; }

        public override void BuyFood()
        {
            base.Food += 10;
        }
    }
}
