using System.Collections.Generic;
using System.Text;

namespace Day2
{
    public class Part2
    {
        public static string Calculate(IEnumerable<string> input)
        {
            var resultBuilder = new StringBuilder();
            var number = 5;
            foreach (var line in input)
            {
                number = CalculateNumber(number, line);
                resultBuilder.Append($"{number:x}");
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
                        if (currentNumber == 3)
                        {
                            currentNumber -= 2;
                        }
                        else if (currentNumber >= 6 && currentNumber <= 12 && currentNumber != 9)
                        {
                            currentNumber -= 4;
                        }
                        else if (currentNumber == 13)
                        {
                            currentNumber -= 2;
                        }
                        break;
                    case 'D':
                        if (currentNumber == 1)
                        {
                            currentNumber += 2;
                        }
                        else if (currentNumber >= 2 && currentNumber <= 8 && currentNumber != 5)
                        {
                            currentNumber += 4;
                        }
                        else if (currentNumber == 11)
                        {
                            currentNumber += 2;
                        }
                        break;
                    case 'L':
                        if ((currentNumber >= 3 && currentNumber <= 4) ||
                            (currentNumber >= 6 && currentNumber <= 9) ||
                            (currentNumber >= 11 && currentNumber <= 12))
                        {
                            currentNumber -= 1;
                        }
                        break;
                    case 'R':
                        if ((currentNumber >= 2 && currentNumber <= 3) ||
                            (currentNumber >= 5 && currentNumber <= 8) ||
                            (currentNumber >= 10 && currentNumber <= 11))
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