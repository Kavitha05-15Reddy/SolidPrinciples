using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    //Without OSP
    public class AreaCalculator
    {
        public void AreaRectangle(double height,double width)
        {
            double area = height * width;
            Console.WriteLine("Area of Rectangle :" + area);
        }
        public void AreaCicle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle:" + area);
        }
    }
    //With OSP
    public abstract class Shape
    {
        public abstract void CalculateArea();
    }
    public class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Rectangle:"+(height * width));
        }
    }
    public class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Circle:" + (Math.PI * radius * radius));
        }
    }

    //DRY
    public class Square : Shape
    {
        private double sideLength;

        public Square(double sideLength)
        {
            this.sideLength = sideLength;
        }

        public override void CalculateArea()
        {
            Console.WriteLine("Area of Square:"+sideLength * sideLength);
        }
    }
    public class Triangle : Shape
    {
        private double baseLength;
        private double height;
        public Triangle(double baseLength,double height)
        {
            this.baseLength = baseLength;
            this.height = height;
        }
        public override void CalculateArea()
        {
            Console.WriteLine("Area of Triangle:" +(baseLength*height)/2);
        }
    }
}


