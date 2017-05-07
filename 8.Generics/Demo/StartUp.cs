using System.Collections;

namespace Demo
{
    class StartUp
    {
        static void Main(string[] args)
        {
            MyCustomData<int> data = new MyCustomData<int>();
            data.Add(5);
            data.Add(15);
            //System.Console.WriteLine(data.Count);

            var result = data[0];

            Cat cat = new Cat();
            cat.Eat<int>(1);
            
        }
    }
}
