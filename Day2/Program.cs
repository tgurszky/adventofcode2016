using System;

namespace Day2
{
    internal static class Program
    {
        private static void Main()
        {
            var input = System.IO.File.ReadAllLines("Input.txt");            
            Console.WriteLine($"Day 2 :: Part 1 - {Part1.Calculate(input)}");            
            Console.WriteLine($"Day 2 :: Part 2 - {Part2.Calculate(input)}");
        }
    }
}
