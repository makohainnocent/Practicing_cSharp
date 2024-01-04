using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.types.structs
{
    internal class Structs
    {

        public static void comparing_struct_instances()
        {
            var p1 = new Point(40, 2);
            Point p2 = p1;
            var p3 = new Point(40, 2);
            Console.WriteLine($"{p1.X}, {p1.Y}");
            Console.WriteLine($"{p2.X}, {p2.Y}");
            Console.WriteLine($"{p3.X}, {p3.Y}");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p2 == p3);
            Console.WriteLine(ReferenceEquals(p1, p2));
            Console.WriteLine(ReferenceEquals(p1, p3));
            Console.WriteLine(ReferenceEquals(p2, p3));
            Console.WriteLine(ReferenceEquals(p1, p1));
        }

        public static void deconstructing() 
        {
            Size size = new Size(50,20);

            (double w, double h)=size;
            Console.WriteLine(w);
            Console.WriteLine(h);
        }

        public static void passing_in_parameter()
        {
            var r = new Rect(10, 20, 100, 100);
            double area = GetArea(in r);
            double area2 = GetArea(r);

            Console.WriteLine(area);
            Console.WriteLine(area2);

        }

        public static double GetArea(in Rect r) => r.Width * r.Height;
    }

    public struct Point
    {
        private double _x;
        private double _y;
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        public double X => _x;
        public double Y => _y;

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is Point p2 && X == p2.X && Y == p2.Y;
        }
        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }


    }

    public readonly struct Point2
    {
        public Point2(double x, double y)
        {
            X = x;
            Y = y;

        }

        public double X { get; }
        public double Y { get; }
        public double DistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }


    public readonly struct Size
    {
        public Size(double w, double h)
        {
            W = w;
            H = h;
        }
        public void Deconstruct(out double w, out double h)
        {
            w = W;
            h = H;
        }
        public double W { get; }
        public double H { get; }
    }

    // passing a vaariable and spacific is an in means its passed by ref
    public readonly struct Rect
    {
        public Rect(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }



        public double X { get; }
        public double Y { get; }
        public double Width { get; }
        public double Height { get; }
    }


}



