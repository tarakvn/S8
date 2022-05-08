using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            double Area = radius * radius * Math.PI;
            double peri = radius * 2 * Math.PI;
            Console.WriteLine("The area of the circle is " + Area);
            Console.WriteLine("the perimeter of circle is " + peri);
            Console.ReadKey();
        }
    }
}
