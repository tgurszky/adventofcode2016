using System.Collections.Generic;
using System.Text;

namespace Day2
{
    public static class Part1
    {
        public static string Calculate(IEnumerable<string> input)
        {
            var resultBuilder = new StringBuilder();
            var number = 5;
            foreach (var line in input)
            {
                number = CalculateNumber(number, line);
                resultBuilder.Append(number);
            }
            return resultBuilder.ToString();
        }

        private static int CalculateNumber(int startNumber, string steps)
        {
            var currentNumber = startNumber;
            foreach (var step in steps)
            {
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (step)
                {
                    case 'U':
                        if (currentNumber != 1 && currentNumber != 2 && currentNumber != 3)
                        {
                            currentNumber -= 3;
                        }
                        break;
                    case 'D':
                        if (currentNumber != 7 && currentNumber != 8 && currentNumber != 9)
                        {
                            currentNumber += 3;
                        }
                        break;
                    case 'L':
                        if (currentNumber != 1 && currentNumber != 4 && currentNumber != 7)
                        {
                            currentNumber -= 1;
                        }
                        break;
                    case 'R':
                        if (currentNumber != 3 && currentNumber != 6 && currentNumber != 9)
                        {
                            currentNumber += 1;
                        }
                        break;
                }
            }
            return currentNumber;            
        }
    }
}
