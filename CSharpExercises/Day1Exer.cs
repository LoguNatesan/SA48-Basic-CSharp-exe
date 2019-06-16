using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day1Exer
    {
        static void Main(string[] args)
        {
            //Day 1:1
            Console.WriteLine("Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Email:");
            string Email = Console.ReadLine();

            Console.WriteLine(Name + "\n" + Email);

            //Day 1:2
            Console.WriteLine("Name:");
            string Name_1 = Console.ReadLine();
            Console.WriteLine($"\tGood Morning {Name_1} \n where {Name_1} is the name you had input.");

            //Day 1:3
            Console.WriteLine("Enter an Integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            x = x * x;
            Console.WriteLine($"Square of the number is:{x}");

            //Day 1:4 & 5
            //Day 1:SecB: 1
            
            Console.WriteLine("Enter an Integer:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            x1 = Math.Sqrt(x1);
            Console.WriteLine($"Square of the number is:{x1:0.00}");
            Console.WriteLine($"Square of the number is:{x1:0.###}");


            //Day 1:SecB: 2
           
            Console.WriteLine("Enter an Integer:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            x2 = Math.Sqrt(x2);
            Console.WriteLine($"Square of the number is:{x2:0.000}");


            //Day 1:SecB: 3
            Console.WriteLine("Enter the salary:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            x3 = x3 + (0.1 * x3) + (0.03 * x3);
            Console.WriteLine($"Output is:${x3:#,##0.00}");


            //Day 1:SecB: 4
            Console.WriteLine("Enter the temperature in centigrade:");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = 1.8 * c + 32;
            Console.WriteLine($"Temp in Fahrenheit is:{f}");


            //Day 1:Sec B:5
            Console.WriteLine("Enter the Value of X:");
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y = 5 * (x4 * x4) - (4 * x4) + 3;
            Console.WriteLine($"Value of Y is:{y}");

            //Day 1:Sec B:6
            Console.WriteLine("Enter the Value of X1:");
            int x5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of X2:");
            int x6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Value of Y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double Distance = Math.Sqrt(Math.Pow((x6 - x5), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine($"Distance is:{Distance}");


            //Day 1:Sec B:7
            Console.WriteLine("Enter the distance travelled:");
            double x7 = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + x7 * 0.4;


            Console.WriteLine($"Total fare is:{totalfare}");


            //Day 1:Sec B:9
            Console.WriteLine("Enter the distance travelled:");
            double x8 = Convert.ToDouble(Console.ReadLine());
            double totalfare1 = (2.40 + x8 * 0.4) * 10;
            totalfare = Math.Ceiling(totalfare1);
            totalfare = Math.Floor(totalfare1) / 10;

            Console.WriteLine($"Total fare is:{totalfare1:0.00}");

            //Day 1:Sec B:10
            Console.WriteLine("Enter the length of side a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side c:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            int s = (a + b + c1) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c1));
            Console.WriteLine($"Area of Triangle is:{area}");
        }
   }
}
