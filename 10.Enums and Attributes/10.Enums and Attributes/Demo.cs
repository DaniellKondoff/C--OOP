using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _10.Enums_and_Attributes
{
    [Author("Pesho")]
    class Demo
    {
        static void Main()
        {
            Cat cat = new Cat("Ivan");

            ChangeName(cat);
            Console.WriteLine(cat.Name);

            var dog = new Dog();
            dog.Name = "Pesho";

            ChangeNameDog(dog);
            Console.WriteLine(dog.Name);

            int someValue = 5;
            ChangeValue(someValue);
            Console.WriteLine(someValue);

            //Enumeration

            Color color = Color.Blue;
            if (color==Color.Blue)
            {
                Console.WriteLine(color);
            }

            Task task = new Task();
            task.State = TaskState.Pending;
            task.State = TaskState.Done;

            var values = Enum.
                GetValues(typeof(Color)).
                OfType<Color>()
                .ToList();

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            var valuess = EnumExtensions.ToStringValues<Color>();

            foreach (var val in valuess)
            {
                Console.WriteLine(val);
            }

            //Atributes
            var atributes = typeof(Demo).GetCustomAttributes(false);
            foreach (var attr in atributes)
            {
                Console.WriteLine(attr);
            }

            var types = Assembly.GetExecutingAssembly().GetTypes().Where(t=>t.GetCustomAttribute<AuthorAttribute>() != null);

            foreach (var type in types)
            {
                var name = type.Name;
                var attr = type.GetCustomAttribute<AuthorAttribute>();
                var author = attr.Name;

                Console.WriteLine(name + "-" + author);
            }

            var catt = new Cat();


        }

        public static void ChangeValue(int value)
        {
            value = 100;
        }

        public static void ChangeName(Cat cat)
        {
            cat.Name = "Changed!";
        }

        public static void ChangeNameDog(Dog dog)
        {
            dog.Name = "Change Dog Name";
        }

    }
}
