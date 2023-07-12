using System;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input--> ");
            var input = Console.ReadLine();
            Console.WriteLine($"result= {input}");
        }
    }
}