using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Day3
{
    public static class Part2
    {
        public static int Calculate(IEnumerable<string> input)
        {
            var validCount = 0;

            var l1 = new List<int>();
            var l2 = new List<int>();
            var l3 = new List<int>();

            foreach (var line in input)
            {
                var values = Regex.Split(line, @"\D+");
                l1.Add(int.Parse(values[1]));
                l2.Add(int.Parse(values[2]));
                l3.Add(int.Parse(values[3]));
            }

            l1.AddRange(l2);
            l1.AddRange(l3);

            var num = l1.Count / 3;

            for (var i = 0; i < num; i++)
            {
                var t = new Triangle(l1[i * 3], l1[i * 3 + 1], l1[i * 3 + 2]);
                if (t.IsValid())
                {
                    validCount++;
                }
            }

            return validCount;
        }
    }
}