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

        }
        public double FindLenghtSegments(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointB.coordinateX-pointA.coordinateX,2) + Math.Pow(pointB.coordinateY - pointA.coordinateY, 2)); 
        }
    }
}
