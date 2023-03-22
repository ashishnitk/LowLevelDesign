using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// If we have to calculate another type of object (say, Trapezium) then we’ve to add another condition.
/// </summary>
namespace HelloWorld.OCP
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radious { get; set; }
    }

    public class Trapizuim
    {
        public int length { get; set; }
        public int width { get; set; }
        public int width1 { get; set; }
        public int length1 { get; set; }
    }


    public class Main
    {
        public double GetArea(object[] shapes)
        {
            double totalArea = 0;

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    Rectangle rectangle = (Rectangle)shape;
                    totalArea += rectangle.Width * rectangle.Height;
                }
                else if (shape is Trapizuim)
                {
                    Trapizuim t = new Trapizuim();
                    totalArea = 456456456;
                }
                else
                {
                    Circle circle = (Circle)shape;
                    totalArea += circle.Radious * circle.Radious * Math.PI;
                }

            }
            return totalArea;
        }
    }
}
