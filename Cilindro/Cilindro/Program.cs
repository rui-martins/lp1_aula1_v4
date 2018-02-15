using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            float pi = 3.1415f;
            double height;
            double radius;
            double area;
            double volume;

            Console.WriteLine("\nInsert Height:\n");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nInsert Radius:\n");
            radius = Convert.ToDouble(Console.ReadLine());

            area = (2 * pi * (radius *(radius + height)));
            volume = pi * (radius * radius) * height;

            Console.WriteLine("\nArea:\n" + area);
            Console.WriteLine("\nVolume:\n" + volume);



        }
    }
}
