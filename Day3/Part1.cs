using System.Collections.Generic;
using System.Linq;

namespace Day3
{
    public static class Part1
    {
        public static int Calculate(IEnumerable<string> input)
        {
            return input.Select(line => new Triangle(line)).Count(t => t.IsValid());
        }        
    }
}
