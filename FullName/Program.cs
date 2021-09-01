using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First name?");
            String UserFirstname = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            String UserLastname = Console.ReadLine();
            Console.WriteLine($"Hello, {UserFirstname} {UserLastname}!");

            Console.ReadLine();


        }
    }
}
