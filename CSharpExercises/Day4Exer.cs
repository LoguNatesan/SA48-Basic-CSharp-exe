using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day4Exer
    {
        public static void Main()
        {
            //Day4Quiz
            int count = 0;
            int pin = 0;
            Console.WriteLine("Welcome to ISS");
            do
            {
                if (count >= 1)
                {
                    Console.WriteLine("Incorrect PIN. Please try again. ");
                }
                Console.Write("Enter your PIN:");
                pin = Convert.ToInt32(Console.ReadLine());
                count++;
                Console.WriteLine();
            } while (count < 3 && pin != 123456);


            if (pin == 123456)
            {
                Console.WriteLine("PIN accepted.You can access your account now.");
            }
            else
            {
                Console.WriteLine("Too many wrong PIN entries. Your account is now locked.");
            }

            //Day4SecGExer4
            int[] num = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int a = 0; a < 10; a++)
            {
                Console.WriteLine($"[{num[a]},{num[a + 1]},{num[a + 2]},{num[a + 3]},{num[a + 4]},{num[a + 5]},{num[a + 6]},{num[a + 7]},{num[a + 8]},{num[a + 9]}]");
                break;
            }

            // Day4SecGExer5
            int[] num1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Enter a number:");
            int _num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i1 = 0; i1 < num1.Length; i1++)
            {
                if (num1[i1] == _num)
                {
                    temp = i1;
                    break;
                }
            }
            if (temp != 0)
            {
                Console.WriteLine($"Number {_num} is found in the array at the element no{temp + 1}");
            }
            else
            {
                Console.WriteLine($"Number {_num} is found in the array at the element no -1");
            }

            //Day4SecGExer6 - Ascending order
            int[] num2 = new int[10] { 3, 5, 9, 1, 4, 7, 6, 2, 8, 10 };
            int temp1 = 0;
            for (int i2 = 0; i2 < num2.Length; i2++)
            {
                for (int j2 = i2; j2 < num2.Length; j2++)
                {
                    if (num2[i2] > num2[j2])
                    {
                        temp = num2[i2];
                        num2[i2] = num2[j2];
                        num2[j2] = temp1;
                    }
                }
            }
            foreach (var d in num2)
            {
                Console.Write($"{d},");
            }

            //Day4SecGExer6 Descending order
            int[] num3 = new int[10] { 3, 5, 9, 1, 4, 7, 6, 2, 8, 10 };
            int temp3 = 0;
            for (int i3 = 0; i3 < num3.Length; i3++)
            {
                for (int j3 = i3; j3 < num3.Length; j3++)
                {
                    if (num3[i3] < num3[j3])
                    {
                        temp3 = num3[i3];
                        num3[i3] = num3[j3];
                        num3[j3] = temp3;
                    }
                }
            }
            foreach (var d in num3)
            {
                Console.Write($"{d},");
            }

            //Day4SecGExer7
            string[] name = new string[] { "Frank", "Charlie", "Alice", "Gina", "Bob", "Eli", "Dennis" };
            int[] score = new int[] { 66, 120, 100, 88, 90, 76, 80 };
            string temp4 = null;
            int temp5 = 0;
            for (int i5 = 0; i5 < name.Length; i5++)
            {
                for (int j5 = i5; j5 < name.Length; j5++)
                {
                    int val = name[i5].CompareTo(name[j5]);
                    if (val == 1)
                    {
                        temp4 = name[i5];
                        temp5 = score[i5];
                        name[i5] = name[j5];
                        score[i5] = score[j5];
                        name[j5] = temp4;
                        score[j5] = temp5;
                    }
                }
            }
            Console.WriteLine("Name\tScore");
            for (int i6 = 0; i6 < name.Length; i6++)
            {
                Console.WriteLine($"{name[i6]}\t{score[i6]}");
            }

            //Day4SecGExer8
            int[,] num7 = new int[,] { { 5, 6, 7 }, { 8, 9, 10 }, { 11, 15, 22 } };
            Console.WriteLine("Enter a number:");
            int _num7 = Convert.ToInt32(Console.ReadLine());
            int tempi = 0;
            int tempj = 0;
            bool flag = false;
            for (int i7 = 0; i7 < 3; i7++)
            {
                for (int j7 = 0; j7 < 3; j7++)
                {
                    if (num7[i7, j7] == _num)
                    {
                        tempi = i7;
                        tempj = j7;
                        flag = true;
                        break;
                    }
                }
            }

            if (flag == true)
                Console.WriteLine($"Number {_num} is found in the array at [{tempi},{tempj}]");
            else
                Console.WriteLine($"Number {_num} is not found in the array.");

            //Day4SecGExer1
            Console.WriteLine("Enter the sales for 12 months:");
            int[] sales = new int[12];
            string[] month = new string[12] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int temp8 = 0;
            int avg = 0;
            string tempS = null;
            for (int i8 = 0; i8 < sales.Length; i8++)
            {
                sales[i8] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i9 = 0; i9 < sales.Length; i9++)
            {
                for (int j9 = i9; j9 < sales.Length; j9++)
                {
                    if (sales[i9] > sales[j9])
                    {
                        temp8 = sales[i9];
                        tempS = month[i9];
                        sales[i9] = sales[j9];
                        month[i9] = month[j9];
                        sales[j9] = temp8;
                        month[j9] = tempS;
                    }
                }
            }

            for (int i10 = 0; i10 < sales.Length; i10++)
            {
                avg += sales[i10];
            }

            Console.WriteLine($"Maximum sales recorded in the month {month[11]} and sales is {sales[11]}");
            Console.WriteLine($"Minimum sales recorded in the month {month[0]} and sales is {sales[0]}");
            Console.WriteLine($"Average Monthly sales is {avg / 12}");

            //Day4SecGExer2

            //Day4SecGExer3
            int[,] marks = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 96 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 }, { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 }, { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };
            int total = 0;
            double avg1 = 0;
            int i, j = 0;
            int count1 = 0;
            int[] totalArr = new int[marks.GetLength(0)];
            double[] avgArr = new double[marks.GetLength(0)];
            //a&b:
            for (i = 0; i < marks.GetLength(0); i++)
            {
                total = 0;
                for (j = 0; j < marks.GetLength(1); j++)
                {
                    total += marks[i, j];
                    count1++;
                    if (count1 <= 4)
                        Console.Write($"{marks[i, j]}\t");
                    else
                        Console.WriteLine();
                    count1 = 0;
                }
                totalArr[i] = total;
                avgArr[i] = total / 4.0;
                //Console.Write($"Student  obtained total marks {total}");
            }
            Console.WriteLine("Subject1   Subject2   Subject3   Subject4   Total   Avg");
            for (i = 0; i < marks.GetLength(0); i++)
            {
                for (j = 0; j < marks.GetLength(1); j++)
                {
                    Console.Write($"   {marks[i, j]:#00}      ");
                }
                Console.Write($" { totalArr[i]}    { avgArr[i]:##.00}");
                Console.Write("\n");
            }
            // c:
            int total1 = 0;

            for (i = 0; i < marks.GetLength(1); i++)
            {
                total1 = 0;
                for (j = 0; j < marks.GetLength(0); j++)
                {
                    total1 += marks[j, i];
                    avg1 = total1 / 12.0;
                    avgArr[i] = avg1;
                }
            }
            Console.WriteLine("Average per subject:");
            Console.WriteLine($"{avgArr[0]:##.##}  {avgArr[1]:##.##}  {avgArr[2]:##.##}  {avgArr[3]:##.##}");
        }
    }
}
