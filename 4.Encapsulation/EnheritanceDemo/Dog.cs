namespace EnheritanceDemo
{
   public class Dog : Animal
    {
        public Dog()
        {
            this.InitialColor = "Black";
        }

        public string Color => this.InitialColor;

        public string SayHello()
        {
            return "Bark!!!";
        }
    }
}
