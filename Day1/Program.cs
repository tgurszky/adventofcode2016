using System;

namespace Day1
{
    internal static class Program
    {
        private static void Main()
        {
            var input = System.IO.File.ReadAllText("Input.txt");
            var part1 = new Part1();
            Console.WriteLine($"Day 1 :: Part 1 - {part1.Calculate(input)}");

            var part2 = new Part2();
            Console.WriteLine($"Day 1 :: Part 2 - {part2.Calculate(input)}");
        }
    }
}
