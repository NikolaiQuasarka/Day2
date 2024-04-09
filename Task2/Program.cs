namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки P1:");
            Point P1 = new Point();
            P1.X = Convert.ToDouble(Console.ReadLine());
            P1.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки P2:");
            Point P2 = new Point();
            P2.X = Convert.ToDouble(Console.ReadLine());
            P2.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты точки P3:");
            Point C = new Point();
            C.X = Convert.ToDouble(Console.ReadLine());
            C.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите радиус круга:");
            double r = Convert.ToDouble(Console.ReadLine());

                Point P3 = new Point() {X=P1.X , Y=P2.Y};
                Point P4 = new Point() { X=P2.X, Y=P1.Y};
               
                Line S1 = new Line() { P1= P1, P2=P3};
                Line S2 = new Line() { P1 = P1, P2=P4};
                Line S3 = new Line() { P1=P2,P2=P3};
                Line S4 = new Line() { P1=P2, P2=P4};

                List<Line> lines = new List<Line>() { S1, S2, S3, S4 }; 
                List<Point> Intersections = new List<Point>();

                foreach (Line line in lines)
                {
                    Point? p1 = Functions.FindIntersection(C, r, line.P1, line.P2).Point1;
                    if (p1 !=null)
                        Intersections.Add(p1);
                    Point? p2 = Functions.FindIntersection(C, r, line.P1, line.P2).Point2;
                    if(p2 != null)
                        Intersections.Add(p2);
                }
            if (Intersections.Count > 0)
            {
                Console.WriteLine("Точки пересечения окружности и прямоугольника:");
                Console.WriteLine(Intersections.Count);
                foreach (Point p in Intersections)
                {
                    Console.WriteLine($"X:{p.X}; Y:{p.Y}");
                }
            }
            else Console.WriteLine("Точек пересечения нет");
        }
    }
}
