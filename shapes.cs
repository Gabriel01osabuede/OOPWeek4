using System;

namespace week4class
{
    public class Shapes
    {
        public void shape()
        {
            Console.WriteLine("This is a shape");
        }
    }

    class Rectangle : Shapes
    {
        public void rectangle()
        {
            Console.WriteLine("This is a Rectangle");
        }
    }

    class Circle : Shapes
    {
        public void circle()
        {
            Console.WriteLine("This is a circle Shape");
        }
    }

    class square : Rectangle
        
        {
            public void squares()
            {
                Console.WriteLine("Square is a rectangle shape.");
            }
        }
}