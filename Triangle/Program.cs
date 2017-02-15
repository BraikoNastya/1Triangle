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
        static void Main(string[] args)
        {
            Point[] points = new Point[3];
            RandomCoordinate(points);

            Console.ReadKey();
        }
        
    }

}
