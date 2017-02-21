using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Edge
    {
        public Point pointA;
        public Point pointB;
        public double LenghtSegment; // длина отрезка

        public Edge(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;

            LenghtSegment = FindLenghtSegments();
        }
        public Edge()
        {
            Random gen = new Random();
            pointA = new Point(gen.Next(1, 15), gen.Next(1, 15));
            pointB = new Point(gen.Next(1, 15), gen.Next(1, 15));

            LenghtSegment = FindLenghtSegments();
        }
        public double FindLenghtSegments()
        {
            return Math.Sqrt(Math.Pow(pointB.coordinateX-pointA.coordinateX,2) + Math.Pow(pointB.coordinateY - pointA.coordinateY, 2)); 
        }
    }
}
