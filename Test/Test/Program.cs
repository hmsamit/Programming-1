using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Click number 1 or 2\n");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Hello World!");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Hello Saturn!");
            }
            else
            {
                Console.WriteLine("ERROR"); 
            }
            Console.ReadKey();
        }
    }
}
