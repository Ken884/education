using System;

namespace quiz026
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point();
            a.X = 0;
            a.Y = 0;
            Point b = new Point();
            b.X = 0;
            b.Y = 4;
            Point c = new Point();
            c.X = 3;
            c.Y = 0;

            Console.WriteLine(CalculateDistance(a, b));
            Console.WriteLine(CalculateDistance(a, c));
            Console.WriteLine(CalculateDistance(b, c));
            Console.WriteLine(CalclateTriangleArea(a, b, c));
        }

        public static double CalculateDistance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
        }

        public static double CalclateTriangleArea(Point a, Point b, Point c)
        {
            double AB = CalculateDistance(a, b);
            double AC = CalculateDistance(a, c);
            double BC = CalculateDistance(b, c);

            double s = (AB + AC + BC) / 2;

            double area = Math.Sqrt(s * (s-AB) * (s-AC)  * (s-BC));

            return area;
        }

        
    }

    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
