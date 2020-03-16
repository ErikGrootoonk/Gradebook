using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {   
            var numbers = new [] {21.7, 34.6, 35.4 };

            var result = 0.0;
            foreach(double number in numbers)

            {
               result += number; 
            }

            Console.WriteLine(result);
            
            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]} !");
            } 
            else 
            {
                Console.WriteLine("Hello World!");
            }
            
        }
    }
}
