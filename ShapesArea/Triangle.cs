using System;

namespace ShapesArea
{
    public class Triangle : IShape
    {
        // стороны
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            if(a == b && b == c)
            {
                Console.WriteLine("This is isosceles triangle");
            }
            A = a;
            B = b;
            C = c;
        }

        public double A
        {
            get => a;
            set
            {
                if(value <=0)
                {
                    Console.WriteLine("The value should be > 0");
                }
                else
                {
                    a = value;
                }
            }
        }
        public double B
        {
            get => b;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The value should be > 0");
                }
                else
                {
                    b = value;
                }
            }
        }
        public double C
        {
            get => c;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("The value should be > 0");
                }
                else
                {
                    c = value;
                }
            }
        }
        public double GetArea()
        {
            try
            {
                if(a == 0 || b == 0 || c ==0)
                {
                    return -1;
                }
                else
                {
                    double p = (a + b + c) / 2;
                    return Math.Round(Math.Sqrt(p * ((p - a) * (p - b) * (p - c))), 5, MidpointRounding.ToZero);
                }                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }            
        }
    }
}
