using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.PizzaTime
{
    public class Pizza
    {
        public static SortedDictionary<double, List<string>> pizzasByGroup = new SortedDictionary<double, List<string>>();

        public double group;
        public string name;

        public Pizza(double group, string name)
        {
            this.group = group;
            this.name = name;
        }

        public static SortedDictionary<double, List<string>> GetPizzas(params double[] groups)
        {
            if (groups.Length == 0)
            {
                return Pizza.pizzasByGroup;
            }
            SortedDictionary<double, List<string>> selectedGroups = new SortedDictionary<double, List<string>>();
            foreach (var @group in groups)
            {
                List<string> pizzas = Pizza.pizzasByGroup[@group];
                selectedGroups.Add(@group, pizzas);
            }
            return selectedGroups;
        }

        public static void PrdoublePizzas()
        {
            foreach (var pizzaGroup in pizzasByGroup)
            {
                Console.WriteLine("{0}-{1}", pizzaGroup.Key , string.Join(", ", pizzaGroup.Value));
            }
        }
    }
    public class PizzaTime
    {
      public static void Main()
        {
            string[] rawPizzas = Console.ReadLine().Split();
            string pattern = "@(d+)(w+)";
            Regex mather = new Regex(pattern);
            List<Pizza> pizzas = new List<Pizza>();

            for (double i = 0; i < rawPizzas.Length; i++)
            {
                Match match = mather.Match(rawPizzas[i]);
                var pizza = new Pizza(double.Parse(match.Groups[1].Value), match.Groups[2].Value);

                if (!Pizza.pizzasByGroup.ContainsKey(double.Parse(match.Groups[1].Value)))
                {
                    Pizza.pizzasByGroup.Add(double.Parse(match.Groups[1].Value), new List<string>());
                }
                Pizza.pizzasByGroup[double.Parse(match.Groups[1].Value)].Add(match.Groups[2].Value);
            }
            Pizza.PrdoublePizzas();
        }
    }
}
