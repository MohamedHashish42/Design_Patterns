using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.FlyweightDP
{
    public class Circle : Shape
    {
        public void Draw(ConsoleColor Color)
        {
            Console.WriteLine
            (Color + " Circle was drawn ",
            Console.ForegroundColor = Color);
        }
    }

    public class Triangle : Shape
    {
        public void Draw(ConsoleColor Color)
        {
            Console.WriteLine
            (Color + " Triangle was drawn",
            Console.ForegroundColor = Color);
        }
    }


    public class Rectangle : Shape
    {
        private ConsoleColor Color;
        public void Draw(ConsoleColor Color)
        {
            this.Color = Color;
            Console.WriteLine
            (Color + " Rectangle with was drawn",
            Console.ForegroundColor = Color);
        }
    }
}
