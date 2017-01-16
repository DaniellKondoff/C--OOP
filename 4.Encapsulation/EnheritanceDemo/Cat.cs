namespace EnheritanceDemo
{
   public class Cat : Animal
    {
        public string SayHello()
        {
            return $"{this.Name} : Myey!!";
        }

        public Cat()
        {
            this.InitialColor = "Red";
        }
    }
}
