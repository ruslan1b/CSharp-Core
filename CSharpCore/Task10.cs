using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace CSharpCore
{
    class Task10
    {
        public void DemoTask10()
        {
            try 
            {
                Point p1, p2, p3;
                p1 = new Point(1, 5);
                p2 = new Point(4, 1);
                p3 = new Point(1, 1);
                Triangle tr1 = new Triangle(p1, p2, p3);

                Console.ReadKey();
            }
            catch (Exception e) { }
            
            
        }
        
    }

    public struct Point
    {
        public int X, Y;
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double Distance(Point p) 
        {
            return p.X - p.Y;
        }
    }

    public class Triangle
    {
        private Point p1, p2, p3;
        public Triangle(Point a, Point b, Point c)
        {
            p1 = a;
            p2 = b;
            p3 = c;
        }

        public void Perimeter() { }

        public void Square() { }

        public void Print() { }

    }

}
