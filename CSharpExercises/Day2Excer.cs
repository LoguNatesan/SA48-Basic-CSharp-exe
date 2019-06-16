using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day2Excer
    {
        public static void Main()
        {
            //Day2: Quiz
            Console.WriteLine("Enter the Length in cm:");
            double x = double.Parse(Console.ReadLine());
            double len = x / 2.54;
            Console.WriteLine($"Lenght in inch:{len:0.000}");

            //Day2: secC: 1
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Gender either 'M' or 'F':");
            char Gender = char.Parse(Console.ReadLine());
            if (Gender == 'M')
                Console.WriteLine($"Good Morning Mr.{name}");
            else if (Gender == 'F')
                Console.WriteLine($"Good Morning Mrs.{name}");

            //Day2: secC: 2
            Console.WriteLine("Enter your Name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter your Gender either 'M' or 'F':");
            char Gender1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Age:");
            int age = int.Parse(Console.ReadLine());
            if (Gender1 == 'M' && age < 40)
                Console.WriteLine($"Good Morning Mr.{name1}");
            else if (Gender1 == 'F' && age < 40)
                Console.WriteLine($"Good Morning Mrs.{name1}");
            else if (Gender1 == 'M' && age >= 40)
                Console.WriteLine($"Good Morning Uncle {name1}");
            else if (Gender1 == 'F' && age >= 40)
                Console.WriteLine($"Good Morning Aunty {name1}");

            //Day2: secC: 3
            Console.WriteLine("Enter the Mark between 0 and 100:");
            int Mark = int.Parse(Console.ReadLine());
            if (Mark <= 100 && Mark >= 80)
                Console.WriteLine($"You scored {Mark} marks which is A grade.");
            else if (Mark <= 79 && Mark >= 60)
                Console.WriteLine($"You scored {Mark} marks which is B grade.");
            else if (Mark <= 59 && Mark >= 40)
                Console.WriteLine($"You scored {Mark} marks which is C grade.");
            else if (Mark <= 40 && Mark >= 0)
                Console.WriteLine($"You scored {Mark} marks which is F grade.");
            else if (Mark < 0 || Mark > 100)
                Console.WriteLine("**Error**");

            //Day2: secC: 4
            Console.WriteLine("Enter the distance travelled in Km:");
            double distance = double.Parse(Console.ReadLine());
            distance = distance * 10;
            double totalfare = 0;
            distance = Math.Ceiling(distance) / 10;
            if (distance <= 0.5)
            {
                totalfare = 2.40;
            }
            else if (distance > 0.5 && distance <= 8.5)
            {
                totalfare = 2.40 + ((distance * 10) - 0.5) * 0.04;
            }
            else if (distance > 8.5)
            {
                totalfare = 2.40 + (85 * 0.04) + ((distance * 10) - 90) * 0.05;
            }
            Console.WriteLine($"Total distance is {distance} and Total Fare is ${totalfare}");

            //Day2 :secC:5
            Console.WriteLine("Enter a 3-Digit number:");
            int num = int.Parse(Console.ReadLine());
            if (num < 100 && num > 999) { 
                Console.WriteLine("Please enter a valid 3-Digit Number");
            }
            else {
                int d1 = num / 100;
                Console.WriteLine(d1);
                int d2 =( num % 100)/10;
                Console.WriteLine(d2);
                int d3 = (num % 100) % 10;
                Console.WriteLine(d3);
                double sum = Math.Pow(d1, 3)+ Math.Pow(d2, 3)+ Math.Pow(d3, 3);
                Console.WriteLine(sum);
                if(sum == num)
                {
                    Console.WriteLine($"{num} is a Palindrome number");
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine($"{num} is not a Palindrome number");
                    Console.WriteLine("False");
                }
           }
        }
    }
}
