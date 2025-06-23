using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bus_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            Console.WriteLine("--- Bus Booking management ---");
            Thread.Sleep(1000);
            Console.WriteLine("LOGIN");
            Console.Write("Enter your name : ");
            string name=Console.ReadLine();
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);

        A: Console.WriteLine("Enter your  email:");
            string email=Console.ReadLine();
            Console.Write("Verifying");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 12, Console.CursorTop);

            if (!user.IsValidEmail(email) )
            {
                Console.WriteLine("Please enter valid emai (xxxx@aaa.bbb) :");
                Thread.Sleep(1000);
                goto A;
            }
            Console.WriteLine("Thank You");
            Thread.Sleep(1000);

           // user.array();

        }
    }
}
