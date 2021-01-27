using System;

namespace ShapesArea
{
    public class Circle : IShape
    {
        double radius;
        public double Radius
        {
            get => radius;
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Radius should be > 0");
                }
                else
                {
                    radius = value;
                }
            }
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public double GetArea()
        {
            try
            {                
                return radius == 0 ? -1 : Math.Round((Math.PI * Math.Pow(radius, 2)), 5, MidpointRounding.ToZero);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
    }
    
}
