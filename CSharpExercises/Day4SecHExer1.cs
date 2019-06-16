using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePaperSlip
{
    class Day4SecHExer1
    {
        static bool flag = false;
        public static void Main()
        {
            //SecH1
            //int num = 0;
            //do
            //{
            //    num = ReadInteger("Enter the Input:");
            //}
            //while (flag == false);
            //Console.WriteLine(num);

            //SecH2
            //int[] arr = new int[10] { 1,4,3,6,8,5,2,10,11,14};
            //PrintArray(arr);

            //SecH-3
            //while(true)
            //{ 
            //Console.WriteLine("Enter the string s1:");
            //string s1 = Console.ReadLine();
            //Console.WriteLine("Enter the string s2:");
            //string s2 = Console.ReadLine();
            //bool flag = InString(s1,s2);
            //Console.WriteLine("S1      S2      Output");
            //Console.WriteLine($"{s1}      {s2}      {flag}");
            //}

            //SecH-4
            //while (true)
            //{
            //    Console.WriteLine("Enter the string s1:");
            //    string s1 = Console.ReadLine();
            //    Console.WriteLine("Enter the string s2:");
            //    string s2 = Console.ReadLine();
            //    int value = FindWord(s1, s2);
            //    Console.WriteLine("S1      S2      Output");
            //    Console.WriteLine($"{s1}      {s2}      {value}");
            //}

            //SecH-6
            //string str = Substitute("hdneymddn", 'd', 'o');
            //Console.WriteLine(str);

            //SecH-7
            //int[] arr = new int[5];
            //SetArray(arr, 1200);
            //foreach(var d in arr)
            //Console.WriteLine(d);

            //SecH-8
            // int[] arr = new int[5] { 3,10,5,8,13};
            //int[] newArr= ResizeArray(arr, 10);
            // foreach (var d in newArr)
            // Console.WriteLine(d);
            // Console.WriteLine(newArr.Length);

            //SecH-10
            int[,] A = new int[,] { { 1,0,1},{ 2,3,4},{ 2,4,6} };
            int[,] B = new int[,] { { 2,1,0,6},{ 3,0,2,0},{ 1,4,3,1} };
            int[,] multiply = MatrixMultiply(A, B);
           for(int i=0; i<A.GetLength(0);i++)
            {
                Console.WriteLine("\n");
                for(int j=0;j<B.GetLength(1);j++)
                {
                    Console.Write($"{multiply[i,j]}\t");
                }
            }

        }

        public static int ReadInteger(string message)
        {
            int num = 0;
            try
            {
                flag = true;
                Console.WriteLine(message);
                num= Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                flag = false;
                Console.WriteLine("Please enter input in integer!!!");
            }
            return num;
        }

        //SecH-2
        public static void PrintArray(int[]arr)
        {
            foreach (var d in arr)
            {
                Console.WriteLine(d);
            }
        }

        //SecH-3

        public static bool InString(string s1,string s2)
        {
            if((s1.ToLower()).Contains(s2.ToLower()))
            return true;
            else 
            return false;
        }

        //SecH-4
        public static int FindWord(string s1,string s2)
        {
            int position = 0;
            string s1Lower = s1.ToLower();
            string[] arr = s1Lower.Split(' ');
            string s2Lower = s2.ToLower();

            if(s2Lower.Length == 1)
            {
                for (int i = 0; i < s1Lower.Length; i++)
                {
                    if (s1Lower[i] == s2Lower[0])
                    {
                        position = i;
                        flag = true;
                        break;
                    }
                }
            } else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == s2Lower)
                    {
                        position += arr[i].Length + 1;
                        flag = true;
                        break;
                    }
                }
            }

            return flag ? position : -1;
            //if (flag)
            //{
            //    flag = false;
            //}
            //else
            //{
            //    position = -1;

            //}
            //return position;
        }

       //SecH-5

        //SecH-6

        public static string Substitute(string s,char c1,char c2)
        {
            char[] sArr = s.ToArray();

            for (int i=0;i<s.Length;i++)
            {
                if(sArr[i] == c1)
                {
                    sArr[i] = c2;
                }
            }
            string str = new string (sArr);
            return str;
        }

        //SecH-7

        public static void SetArray(int[]arr,int value)
        {
            //string val = value.ToString();
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = value;
            }

        }

        //SecH-8

        public static int[] ResizeArray(int[] arr,int newSize)
        {
            int[] newArr = new int[newSize];
            for(int i=0;i<arr.Length;i++)
            {
                newArr[i] = arr[i];
            }
            return newArr;
        }

        //SecH-10

        public static int[,] MatrixMultiply(int[,]A , int[,]B)
        {
            int[,] multiply = new int[A.GetLength(0), B.GetLength(1)];
            int i=0, j = 0;
            if (A.GetLength(1)==B.GetLength(0))
            {
                for(i=0;i<A.GetLength(0);i++)
                {
                    for(j=0;j<B.GetLength(1);j++)
                    {
                        multiply[i, j] = 0;
                        for(int k=0;k<A.GetLength(1);k++)
                        {
                            multiply[i, j] += (A[i, k] * B[k, j]);
                        }
                    }
                }
            }

            return multiply;
        }
    }
}
