using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public abstract class Shape
    {
        public double Perimeter {get; protected set;}
        public double Area { get; protected set; }

        protected abstract  double FindPerimeter();
        protected abstract double FindArea();
    }

    public class Rectangle : Shape
    {
        public double A { get; protected set; }
        public double B { get; set; }
        public Rectangle(double a,double b)
        {
            if(a<=0||b<=0)
                throw new ArgumentOutOfRangeException();
            A = a;
            B = b;
            Perimeter = FindPerimeter();
            Area = FindArea();
        }
        protected override double FindPerimeter() => 2*(A+B);
        protected override double FindArea() => A*B;

    }
    public sealed class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            if (radius<=0)
                throw new ArgumentOutOfRangeException();
            Radius = radius;
            Perimeter = FindPerimeter();
            Area = FindArea();
        }
        protected override double FindPerimeter() => 2*Math.PI*Radius;
        protected override double FindArea() => Math.PI*Math.Pow(Radius,2);

    }
    public sealed class Triangle : Shape
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
    
        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <=0)
                throw new ArgumentOutOfRangeException();
            A = a;
            B = b;
            C = c;
            Perimeter = FindPerimeter();
            Area = FindArea();
        }
        protected override double FindPerimeter() => A+B+C;
        protected override double FindArea() => Math.Sqrt(Perimeter*(Perimeter-A)*(Perimeter-B)*(Perimeter-C));

    }

    public sealed class Square : Rectangle
    {
        public Square(double a):base(a,a)
        {
            if (a <= 0)
                throw new ArgumentOutOfRangeException();
            A = B = a;
            Perimeter = FindPerimeter();
            Area = FindArea();
        }
        protected override double FindPerimeter() => 4*A;
        protected override double FindArea() => A*A;
    }
}
