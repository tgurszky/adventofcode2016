using System.Collections.Generic;
using System.Linq;

namespace Day4
{
    public static class Part1
    {
        public static int Calculate(IEnumerable<string> input)
        {
            return input.Sum(Room.Decode);
        }
    }
}
