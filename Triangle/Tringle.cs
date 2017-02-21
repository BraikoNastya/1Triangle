using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Triangle
    {
        public Point pointA;
        public Point pointB;
        public Point pointC;
        // List<Point> points;

        /*
        public double len1;
        public double len2;
        public double len3;
        */

        public Triangle(Point pointA, Point pointB, Point pointC)
        {
            this.pointA = pointA;
            this.pointB = pointB;
            this.pointC = pointC;

            /*
            this.len1 = len1;
            this.len2 = len2;
            this.len3 = len3;
            */
        }

        public Triangle()
        {
            // Создать точки рандомно
            Random gen = new Random();
            pointA = new Point(gen.Next(1, 15), gen.Next(1, 15));
            pointB = new Point(gen.Next(1, 15), gen.Next(1, 15));
            pointC = new Point(gen.Next(1, 15), gen.Next(1, 15));
        }

        public double Perimetr()
        {
            Edge e1 = new Edge(pointA, pointB);
            Edge e2 = new Edge(pointA, pointC);
            Edge e3 = new Edge(pointB, pointC);

            return e1.LenghtSegment + e2.LenghtSegment + e3.LenghtSegment;
        }

        public double Area()
        {
            double p_half = Perimetr() / 2;
            Edge e1 = new Edge(pointA, pointB);
            Edge e2 = new Edge(pointA, pointC);
            Edge e3 = new Edge(pointB, pointC);

            double a = e1.LenghtSegment;
            double b = e2.LenghtSegment;
            double c = e3.LenghtSegment;

            return 0;
        }

        public bool Right()
        {
            Edge e1 = new Edge(pointA, pointB);
            Edge e2 = new Edge(pointA, pointC);
            Edge e3 = new Edge(pointB, pointC);

            double a = e1.LenghtSegment;
            double b = e2.LenghtSegment;
            double c = e3.LenghtSegment;

            bool flag = false;
            if ( Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                return flag = true;
            if (Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2)) == Math.Pow(a, 2))
                return flag = true;
            if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) == Math.Pow(b, 2))
                return flag = true;

            return flag;
        }
    }

}
