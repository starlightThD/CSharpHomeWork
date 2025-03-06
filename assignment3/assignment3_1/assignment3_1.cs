using System;


namespace assignment3_1
{
    public abstract class Shape
    {
        protected const double MINDOUBLE = 0.0000001;
        protected string ShapeName;
        protected List<double> Edge = new List<double>(0);
        abstract public bool IsIllegal();
        abstract public double GetArea();

        public string GetName()
        {
            return ShapeName;
        }
    }
    public class Rectangle : Shape
    {
        
        public Rectangle() { }
        public Rectangle(double height,double width) 
        {
            ShapeName = "Rectangle";
            Edge?.Add(height);
            Edge?.Add(width);
        }
        override public bool IsIllegal()
        {
            if (Edge == null) return true;
            if (Edge?.Count() == 0) return true;
            foreach(double edge in Edge)
            {
                if (MINDOUBLE > edge - 0 )
                {
                    return true;
                }
            }
            return false;
        }
        public override double GetArea()
        {

            if (!IsIllegal())
            {
                return Edge[0] * Edge[1];
            }
            else
            {
                Console.WriteLine("ERROR!:Illegal Rectangle!");
                return 0;
            }
        }
    }
    public class Square : Shape
    {
        public Square() { }
        public Square(double edge)
        {
            ShapeName = "Square";
            Edge?.Add(edge);
        }
        override public bool IsIllegal()
        {
            if (Edge == null) return true;
            if (Edge?.Count() == 0) return true;
            if (MINDOUBLE > Edge[0] - 0) return true;
            return false;
        }
        public override double GetArea()
        {
            if (!IsIllegal())
            {
                return Edge[0] * Edge[0];
            }
            else
            {
                Console.WriteLine("ERROR!:Illegal Square!");
                return 0;
            }
        }
    }
    public class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(double a,double b,double c)
        {
            ShapeName = "Triangle";
            Edge?.Add(a);
            Edge?.Add(b);
            Edge?.Add(c);
        }
        public override bool IsIllegal()
        {
            if (Edge == null) return true;
            if (Edge?.Count() == 0) return true;
            foreach (double edge in Edge)
            {
                if (MINDOUBLE > edge - 0) return true;
            }
            if (Edge[0] + Edge[1] < Edge[2] || Edge[0] + Edge[2] < Edge[1] || Edge[1] + Edge[2] < Edge[0]) return true;
            return false;
        }
        public override double GetArea()
        {
            if (!IsIllegal())
            {
                double p = (Edge[0] + Edge[1] + Edge[2]) / 2;
                return Math.Sqrt(p * (p - Edge[0]) * (p - Edge[1]) * (p - Edge[2]));
            }
            else
            {
                Console.WriteLine("ERROR!:Illegal Square!");
                return 0;
            }

        }
    }
    class assignment
    {
        public static void Main(string[] argv)
        {
            Console.WriteLine("You can create three shape, sqare with one double,rectangle with two double, triangle with three double: ");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}