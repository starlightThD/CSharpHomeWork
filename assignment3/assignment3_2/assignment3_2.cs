using System;
using assignment3_1;

class assignment3_2
{
    public class ShapeFactory
    {
        private static readonly Random _random = new Random();
        public  Shape CreateRandomShape()
        {
            int type = _random.Next(0, 3);
            switch (type)
            {
                case 0:
                    return CreateRandomRectangle();
                case 1:
                    return CreateRandomSquare();
                case 2:
                    return CreateRandomTriangle();
                default:
                    throw new InvalidOperationException("invalid shape");
            }
        }
        private Rectangle CreateRandomRectangle()
        {
            double height = _random.NextDouble() * 10;
            double width = _random.NextDouble() * 10;
            return new Rectangle(height, width);
        }
        private Square CreateRandomSquare()
        {
            double edge = _random.NextDouble() * 10;
            return new Square(edge);
        }

        private Triangle CreateRandomTriangle()
        {
            double a, b, c;
                a = _random.NextDouble() * 10; 
                b = _random.NextDouble() * 10;
                c = _random.NextDouble() * 10;
            return new Triangle(a, b, c);
        }
    }
   
    class assignment
    {
        
        public static void Main(string[] argv)
        {
            Console.WriteLine("Create 10 Shapes:");
            ShapeFactory factory = new ShapeFactory();

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Shape shape = factory.CreateRandomShape();
                    Console.WriteLine("ShapeName: " + shape.GetName());
                    if (shape.IsIllegal())
                    {
                        Console.WriteLine("The shape is illegal");
                    }
                    else 
                    {
                        Console.WriteLine("The area is " + shape.GetArea());
                     }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"生成形状失败: {ex.Message}");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}