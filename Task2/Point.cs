using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
     public class IntersectionResult
            {
                public Point? Point1 { get; set; }
                public Point? Point2 { get; set; }
            }
    public static class Functions
    {
        public static IntersectionResult FindIntersection(Point center, double radius, Point linePoint1, Point linePoint2)
        {
            double dx = linePoint2.X - linePoint1.X;
            double dy = linePoint2.Y - linePoint1.Y;

            double a = dx * dx + dy * dy;
            double b = 2 * (dx * (linePoint1.X - center.X) + dy * (linePoint1.Y - center.Y));
            double c = center.X * center.X + center.Y * center.Y;
            c += linePoint1.X * linePoint1.X + linePoint1.Y * linePoint1.Y;
            c -= 2 * (center.X * linePoint1.X + center.Y * linePoint1.Y);
            c -= radius * radius;

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                
                return new IntersectionResult { Point1 = null, Point2 = null };
            }
            else if(discriminant > 0) { 
            discriminant = Math.Sqrt(discriminant);

            double t1 = (-b - discriminant) / (2 * a);
            double t2 = (-b + discriminant) / (2 * a);

            Point? intersectionPoint1 =null;
            Point? intersectionPoint2=null;

            if (t1 >= 0 && t1 <= 1)
            {
                intersectionPoint1 = new Point { X = linePoint1.X + t1 * dx, Y = linePoint1.Y + t1 * dy };
            }
            

            if (t2 >= 0 && t2 <= 1)
            {
                intersectionPoint2 = new Point { X = linePoint1.X + t2 * dx, Y = linePoint1.Y + t2 * dy };
            }
           

            return new IntersectionResult { Point1 = intersectionPoint1, Point2 = intersectionPoint2 };
            }
            else
            {
                discriminant = Math.Sqrt(discriminant);

                double t1 = (-b - discriminant) / (2 * a);
                Point? intersectionPoint1 = null;

                if (t1 >= 0 && t1 <= 1)
                {
                    intersectionPoint1 = new Point { X = linePoint1.X + t1 * dx, Y = linePoint1.Y + t1 * dy };
                }
                 return new IntersectionResult { Point1 = intersectionPoint1, Point2 = null };
            }
        }
    }

    public class Line
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
    }
}
