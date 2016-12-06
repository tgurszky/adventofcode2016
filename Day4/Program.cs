using System;

namespace Day4
{
    internal static class Program
    {
        private static void Main()
        {
            var input = System.IO.File.ReadAllLines("Input.txt");
            Console.WriteLine($"Day 4 :: Part 1 - {Part1.Calculate(input)}");
            //Console.WriteLine($"Day 4 :: Part 2 - {Part2.Calculate(input)}");
        }
    }
}
