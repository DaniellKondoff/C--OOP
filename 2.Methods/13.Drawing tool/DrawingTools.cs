using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Drawing_tool
{
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Square : Shape
    {
        public double side;

        public Square(double side)
        {
            this.side = side;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}",'|',new string('-', this.side));
            for (double i = 0; i < this.side-2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', this.side));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.side));
        }
    }

    public class Rectangle : Shape
    {
        public double lenght;
        public double width;

        public Rectangle(double width, double lenght)
        {
           
            this.width = width;
            this.lenght = lenght;
        }
        public override void Draw()
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.width));
            for (double i = 0; i < this.lenght - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", '|', new string(' ', this.width));
            }
            Console.WriteLine("{0}{1}{0}", '|', new string('-', this.width));
        }
    }

    public class CorDraw
    {
        public CorDraw(Shape shape)
        {
            this.Draw(shape);
        }

        public void Draw(Shape shape)
        {
            shape.Draw();
        }
    }
    public class DrawingTools
    {
        public static void Main()
        {
            string typeOfShape = Console.ReadLine();
            Shape shape = null;
            if(typeOfShape== "Square")
            {
                double side = double.Parse(Console.ReadLine());
                Square square = new Square(side);
                shape = square;
            }
            else
            {
                double width = double.Parse(Console.ReadLine());
                double lenght = double.Parse(Console.ReadLine());
                Rectangle rect = new Rectangle(width, lenght);
                shape = rect;
            }

            CorDraw drawe = new CorDraw(shape);
        }
    }
}
