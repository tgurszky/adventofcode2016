using System.Text.RegularExpressions;

namespace Day3
{
    public class Triangle
    {
        private int A { get; }
        private int B { get; }
        private int C { get; }

        public Triangle(string input)
        {
            var values = Regex.Split(input, @"\D+");
            A = int.Parse(values[1]);
            B = int.Parse(values[2]);
            C = int.Parse(values[3]);
        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsValid()
        {
            return A + B > C &&
                   C + B > A &&
                   A + C > B;
        }
    }
}
