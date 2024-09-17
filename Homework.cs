using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Homework
    {
        static (double peri, double acre) Rectangle(double length, double width)
        {
            var r = (peri: 0.0, acre: 0.0);
            r.peri = (length + width) * 2;
            r.acre = length * width;
            return r;
        }
        static (double peri, double acre) Square(double side)
        {
            var r = (peri: 0.0, acre: 0.0);
            r.peri = side * 4;
            r.acre = side * side;
            return r;
        }
        static (double peri, double acre) Triangle(double a, double b, double c)
        {
            var r = (peri: 0.0, acre: 0.0);
            double p = (a+ b + c) / 2;
            r.peri = a + b + c;
            r.acre = Math.Sqrt(p * (p-a) * (p-b) * (p-c));
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Rectangle 's Perimeter and Acreage");
            Console.WriteLine("2.Square 's Perimeter and Acreage");
            Console.WriteLine("3.Triangle 's Perimeter and Acreage");
            Console.WriteLine("Enter your choice");
            int choice;
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:                    
                    Console.WriteLine("Enter length");
                    double length = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter width");
                    double width = double.Parse(Console.ReadLine());
                    var(peri1, acre1) = Rectangle(length, width);
                    Console.WriteLine($"Perimeter : {Math.Round(peri1,3)} ,Acreage : {Math.Round(acre1,3)}");
                    break;
                case 2:
                    Console.WriteLine("Enter side");
                    double side = double.Parse(Console.ReadLine());                   
                    var (peri2, acre2) = Square(side);
                    Console.WriteLine($"Perimeter : {Math.Round(peri2, 3)} ,Acreage : {Math.Round(acre2, 3)}");
                    break;
                case 3:
                    Console.WriteLine("Enter first side");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second side");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter third side");
                    double c = double.Parse(Console.ReadLine());
                    while (true)
                    {
                        if (a + b <= c || a + c <= b || b + c <= a)
                        {
                            Console.WriteLine("Enter again third side");
                            c = double.Parse(Console.ReadLine());
                        }
                        else break;
                    }
                    var (peri3, acre3) = Triangle(a, b, c);
                    Console.WriteLine($"Perimeter : {Math.Round(peri3, 3)} ,Acreage : {Math.Round(acre3, 3)}");
                    break;
            }
        }
    }
}
