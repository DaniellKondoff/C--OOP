namespace EnheritanceDemo
{
   public class Program
    {
      public static void Main()
        {
            Cat cat = new Cat
            {
                Name = "Silverster",
                Age = 50,
            };

            Bunny bunny = new Bunny
            {
                Name = "Bugs",
                Age = 15
            };

            System.Console.WriteLine(cat.SayHello());
            System.Console.WriteLine(bunny.SayHello());
      
            System.Console.WriteLine(bunny.InitialColor);

        }
    }
}
