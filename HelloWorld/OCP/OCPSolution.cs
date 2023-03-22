using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Now if we have to calculate another type of object, 
/// we don’t have to alter logic (in getArea()), 
/// we just have to add another class like Rectangle or Circle.
/// </summary>
namespace HelloWorld.OCP1
{
    public abstract class shape
    {
        public abstract double Area();
    }

    public class Rectangle : shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area()
        {
            return Width * Height;
        }
    }

    public class Circle : shape
    {
        public double Radious { get; set; }

        public override double Area()
        {
            return Radious * Radious * Math.PI;
        }
    }

    public class Main
    {
        public double GetArea(shape[] shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }

            return totalArea;
        }
    }

    // ---------------------------------------------------------------------------------------------------------------
    public class Water : shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Width1 { get; set; }
        public double Height1 { get; set; }
        public override double Area()
        {
            throw new Exception();
        }

    }

}
