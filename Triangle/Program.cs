using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Point
    {
        public int coordinateX;
        public int coordinateY;

        public Point(int coordinateX, int coordinateY)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }
    }

    class Edge
    {
        public Point pointA;
        public Point pointB;
        public double LenghtSegment; // длина отрезка
        public Edge(Point pointA, Point pointB, double LenghtSegment)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.LenghtSegment = LenghtSegment;
        }
        
        public double LenghtSegment (Point pointA, Point pointB)
        {
            return Math.Scrt
        }
    }
    class Program
    {
        public static void RandomCoordinate(Point [] points )
        {
            Random gen = new Random();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(gen.Next(1, 15), gen.Next(1, 15));
                Console.WriteLine("ваши точки x={0} и y={1}" , points[i].coordinateX, points[i].coordinateY);
            }
        }

        public static void RandomEdge(Point pointA, Point pointB, double LenghtSegment)//МЕТОД ПОССТРОЕНИЯ ребра
        {

        }
        static void Main(string[] args)
        {
            Point[] points = new Point[3];
            RandomCoordinate(points);

            Edge[] edges = new Edge[3];
            RandomEdge(points,edges); // рандомно строю ребра
            Console.ReadKey();
        }
        
    }

}
