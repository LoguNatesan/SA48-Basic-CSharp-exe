using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day3Exer
    {
        public static void Main()
        {
            //Day 3:Quiz
            Console.WriteLine("Welcome to ISS Gadget Shop");
            Console.Write("Number of items to purchase:");
            int num = int.Parse(Console.ReadLine());
            double discount = 0;
            double pay = (num * 500);
            if (pay <= 2000)
            {
                discount = pay;
            }
            else if (pay > 2000 && pay <= 3000)
            {
                discount = pay - (pay * 0.03);
            }
            else if (pay > 3000 && pay <= 6000)
            {
                discount = pay - (pay * 0.05);
            }
            else if (pay > 6000)
            {
                discount = pay - (pay * 0.08);
            }
            Console.WriteLine();
            Console.WriteLine($"Please pay ${discount:#,###.00}");

            //Day 3:SecE1a
            Console.WriteLine("Enter an Integer:");
            int x = int.Parse(Console.ReadLine());
            int fac = 1;
            for (int i = 1; i <= x; i++)
            {
                fac = fac * i;
            }
            Console.WriteLine($"Factorial of {x} is {fac}");

            //Day 3:SecE1b
            Console.WriteLine("Enter an Integer:");
            int x1 = int.Parse(Console.ReadLine());
            int fac1 = 1;
            for (int i = x1; i >= 1; i--)
            {
                fac1 = fac1 * i;
            }
            Console.WriteLine($"Factorial of {x} is {fac1}");

            //Day 3:SecE2
            Console.WriteLine("No\tInverse\t\tSQUAREROOT\tSQUARE");
            Console.WriteLine("--------------------------------------------");
            for (double i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i:0.0##}\t{(1 / i):0.0##}\t\t{Math.Sqrt(i):0.0##}\t\t{(i * i):0.0##}");
            }

            //Day 3:SecE2
            Console.WriteLine("Enter an Integer:");

            //Day 3:SecF1a
            Console.WriteLine("Enter the phrase:");
            string s = Console.ReadLine();
            s = s.ToLower();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i, 1) == "a" || s.Substring(i, 1) == "e" || s.Substring(i, 1) == "i" || s.Substring(i, 1) == "o" || s.Substring(i, 1) == "u")
                {
                    count++;
                    //Console.WriteLine(s.Substring(i, 1));
                }
            }
            Console.WriteLine($"Number of vowels in the phrase{s} is {count}");

            //Day 3:SecF1b
            Console.WriteLine("Enter the phrase:");
            string s1 = Console.ReadLine();
            s1 = s1.ToLower();
            int a = 0, e = 0, j = 0, o = 0, u = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i, 1) == "a")
                {
                    a++;

                }
                else if (s1.Substring(i, 1) == "e")
                {
                    e++;

                }
                else if (s1.Substring(i, 1) == "i")
                {
                    j++;

                }
                if (s1.Substring(i, 1) == "o")
                {
                    o++;

                }
                if (s1.Substring(i, 1) == "u")
                {
                    u++;
                }

            }
            Console.WriteLine($"Number of a's:{a}");
            Console.WriteLine($"Number of e's:{e}");
            Console.WriteLine($"Number of i's:{j}");
            Console.WriteLine($"Number of o's:{o}");
            Console.WriteLine($"Number of u's:{u}");

            //Day 3:SecF2
            Console.WriteLine("Enter the word:");
            string input_str = Console.ReadLine();
            //string inputlower = input_str.ToLower();
            string reverse_str = "";

            for (int j1 = input_str.Length - 1; j1 >= 0; j1--)
            {

                string temp = input_str.Substring(j1, 1);
                reverse_str += temp;
            }

            if (input_str == reverse_str)
            {
                Console.WriteLine($"{input_str} is a palindrome.");
            }
            else
                Console.WriteLine($"{input_str} is not a palindrome.");

            //Day 3:SecF3
            Console.WriteLine("Enter the phrase:");
            string input_str1 = Console.ReadLine();
            string inputlower = input_str.ToLower();
            string reverse_str1 = "";

            for (int j2 = input_str1.Length - 1; j2 >= 0; j2--)
            {

                string temp = input_str1.Substring(j2, 1);
                reverse_str1 += temp;
            }

            if (input_str1 == reverse_str1)
            {
                Console.WriteLine($"{input_str1} is a palindrome.");
            }
            else
                Console.WriteLine($"{input_str1} is not a palindrome.");

            //To find given number is Prime Number
            var number = 0;

            Console.WriteLine("Accept number:");
            number = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(number))
            {
                Console.WriteLine("It is prime");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            //var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
