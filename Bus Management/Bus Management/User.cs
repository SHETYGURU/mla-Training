using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Bus_Management
{
    internal class User
    {
        public void bus()
        {

            Console.WriteLine("--- USER REGISTARTION ---");
            Thread.Sleep(2000);
            Console.WriteLine("Enter User ID :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);


            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);


        prev: Console.WriteLine("Enter User Email : ");
            string email = Console.ReadLine();
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            if (IsValidEmail(email))
            {
                goto next;
            }
            else
            {
                Console.SetCursorPosition(Console.CursorLeft - 18, Console.CursorTop - 1);
                goto prev;
            }
        next: Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);


            Console.WriteLine("Enter GPA : ");
            double gpa = Convert.ToDouble(Console.ReadLine());
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);
            Console.WriteLine("---- Thank You for ur Time ----");
            Thread.Sleep(2000);
            Console.Clear();
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        //unsafe(for pointers)
        unsafe public void Main()
        {

            int num = 10;
            int* ptr = &num; // Pointer to num

            Console.WriteLine("Value: " + num);
            Console.WriteLine("Pointer Address: " + (int)ptr); // Display memory address
            Console.WriteLine("Pointer Value: " + *ptr); // Dereferencing pointer

            *ptr = 20; // Modifying value through pointer
            Console.WriteLine("Modified Value: " + num);
        }
        //ref and out
        void m(int s, out int x, out int y)
        {
            x = 10 + s;
            y = 20 + s;
        }

        public void refrence()
        {
            int num1;
            int num2;
            m(2, out num1, out num2);
            Console.WriteLine(num1 + num2);

        }
        //arrays
       public void array()
        {   //1d
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] n = new int[2];
            n[0] = 1;
            n[1] = 2;
            //2d
            int[,] numbers2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = 4; // Define number of rows
            int cols = 4; // Define number of columns
            int[,] multiArray = new int[rows, cols]; // Declare a 2D array

            // Assign values dynamically
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    multiArray[i, j] = j + 1; // Populate values
                }
            }

            // Display the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(multiArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            //jagged
            int[][] jag = {new int[]{ 1, 2, 3 },new int[]{ 1,2} };

            int[][] jag1= new int[2][];
            jag1[0] =new int[]{ 1};
            jag1[1] = new int [4];  //only declaring size
           //run time error (IndexOutofRangeExection)=  jag1[3]=new int [5];
            
            
            int[][] jaggedArray = new int[6][];
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i+1]; // Each row has increasing length
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = j + 1; // Assign values dynamically
                }
            }
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]);  // Assign values dynamically
                }
                Console.WriteLine();
            }
            }
    }
}
