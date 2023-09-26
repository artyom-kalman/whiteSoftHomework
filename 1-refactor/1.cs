using System;

namespace Example1
{
    class Point {
        int x;
        int y;

        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public getDistanceFromOrigin() {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = newPointFromInput();

            Point pointB = newPointFromInput();

            comparePoints(pointA, pointB);
        }

        Point newPointFromInput() {
            Console.WriteLine("Введите координаты точки: ");
            string[] input = Console.ReadLine().split(' ');
            int x = int.Parse(input[0]);
            int y = int.Parse(input[1]);
            return new Point(xA, yA);
        }

        void comparePoints(Point A, Point B) {
            int distanceA = A.getDistanceFromOrigin();
            int distanceB = B.getDistanceFromOrigin();

            if (distanceA > distanceB) {
                Console.WriteLine("Точка А находиться дальше от начала координат");
                return;
            }
            if (distanceA < distanceB) {
                Console.WriteLine("Точка В находиться дальше от начала координат");
                return;
            }
            Console.WriteLine("Точки равноудалены от начала координат");
        }
    }
}
