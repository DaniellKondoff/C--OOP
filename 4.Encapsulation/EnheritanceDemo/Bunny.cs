namespace EnheritanceDemo
{
   public class Bunny : Animal
    {
        public string SayHello()
        {
            return $"{this.Name} : What's up doc?!";
        }

        public Bunny()
        {
            this.InitialColor = "White";
        }

        
    }
}
