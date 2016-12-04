using System;
using System.Collections.Generic;

namespace Day1
{
    public class Part2
    {
        private Dictionary<Point, bool> Map { get; }        

        private Compass Compass { get; }

        public Part2()
        {
            Map = new Dictionary<Point, bool>();
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
                for (var i = 1; i <= blocks; i++)
                {
                    // ReSharper disable once SwitchStatementMissingSomeCases
                    switch (Compass.Direction)
                    {
                        case Direction.North:
                            p.Y += 1;
                            break;
                        case Direction.East:
                            p.X += 1;
                            break;
                        case Direction.South:
                            p.Y -= 1;
                            break;
                        case Direction.West:
                            p.X -= 1;
                            break;
                    }
                    if (Map.ContainsKey(p))
                    {
                        return Math.Abs(p.X) + Math.Abs(p.Y);
                    }
                    Map.Add(p, true);
                }                
            }
            return Math.Abs(p.X) + Math.Abs(p.Y);
        }
    }
}
