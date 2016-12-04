using System;

namespace Day1
{
    public class Part1
    {        
        private Compass Compass { get; }

        public Part1()
        {
            Compass = new Compass();
        }

        public int Calculate(string input)
        {
            Point p;
            p.X = 0;
            p.Y = 0;
            var steps = input.Split(',');
            foreach (var step in steps)
            {
                var s = step.Trim();
                Compass.SetDirection(s[0]);
                var blocks = Convert.ToInt32(s.Substring(1, s.Length - 1));
                // ReSharper disable once SwitchStatementMissingSomeCases
                switch (Compass.Direction)
                {
                    case Direction.North:
                        p.Y += blocks;
                        break;
                    case Direction.East:
                        p.X += blocks;
                        break;
                    case Direction.South:
                        p.Y -= blocks;
                        break;
                    case Direction.West:
                        p.X -= blocks;
                        break;
                }
            }
            return Math.Abs(p.X) + Math.Abs(p.Y);
        }
    }
}
