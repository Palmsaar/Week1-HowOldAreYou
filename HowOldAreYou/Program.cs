using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            //ReadLine() to read the user input from the console
            string UserName = Console.ReadLine();
            //Console.WriteLine("Hello, " + UserName + "!");
            //string interpoltaion
            Console.WriteLine($"Hello, {UserName}!");

            Console.WriteLine("How old are you? Only digits:");
            int Userage = Int32.Parse(Console.ReadLine());
            int Yearofbirth = 2021 - Userage;
            
            Console.WriteLine($"You were born in {Yearofbirth}.");


            Console.Read();
        }
    }
}
