using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ShoppingSpree
{
    class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.money; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative");
                }
                this.money = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Money > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.Money -= product.Money;
            this.products.Add(product);
        }

        public override string ToString()
        {
            string products = string.Join(", ", this.products);
            if (string.IsNullOrWhiteSpace(products))
            {
                products = "Nothing bought";
            }

            string name = this.Name;

            string result = $"{name} - {products}";
            return result;
        }
    }

     class Product
    {
        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Money = cost;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{nameof(this.Name)} cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get { return this.cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException($"{nameof(this.Money)} cannot be negative");
                }
                this.cost = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    class Shoping
    {
        static void Main()
        {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string allPeople = Console.ReadLine();
            string[] peopleTokens = allPeople.Split(new char[] {';','='},StringSplitOptions.RemoveEmptyEntries);

           if ( !CreateEntity(peopleTokens, people))
            {
                return;
            }
           
            string allProducts = Console.ReadLine();
            string[] productsTokens = allProducts.Split(new char[] { ';','=' }, StringSplitOptions.RemoveEmptyEntries);

           if( ! CreateEntity(productsTokens, products))
            {
                return;
            }

            string line = Console.ReadLine();

            while(line != "END")
            {
                string[] tokens = line.Split(' ');
                string personName = tokens[0];
                string productName = tokens[1];

                Person person = people[personName];
                Product product = products[productName];

                try
                {
                    person.BuyProduct(product);
                    Console.WriteLine($"{personName} bought {productName}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                line = Console.ReadLine();
            }

            foreach (Person person in people.Values)
            {
                Console.WriteLine(person);
            }
        }

        static bool CreateEntity<T>(string[] tokens, Dictionary<string,T> collection)
        {
            for (int i = 0; i < tokens.Length; i += 2)
            {
                string name = tokens[i];
                decimal money = decimal.Parse(tokens[i + 1]);

                try
                {
                    T item = (T)Activator.CreateInstance(typeof(T),
                        new object[]
                        {
                            name,
                            money
                        }
                        );
                    collection.Add(name, item);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.InnerException.Message);
                    return false;
                }
            }
            return true;
        }
    }
}
