using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите координату x точки A : ");
            int xA = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите координату y точки A : ");
            int yA = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите координату x точки B : ");
            int xB = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Введите координату y точки B : ");
            int yB = Convert.ToInt32(Console.ReadLine());
            double lA = Math.Sqrt(Math.Pow(xA,2) + Math.Pow(yA, 2));
            double lB = Math.Sqrt(Math.Pow(xB, 2) + Math.Pow(yB, 2));
            if (lA > lB) System.Console.WriteLine("Точка А находиться дальше от начала координат");
            if (lA < lB) System.Console.WriteLine("Точка В находиться дальше от начала координат");
            if (lA == lB) System.Console.WriteLine("Точки А и В одинаково отдалены от начала координат");
            System.Console.ReadLine();
        }
    }
}
