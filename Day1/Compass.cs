namespace Day1
{
    public class Compass
    {
        public Direction Direction { get; set; }

        public Compass()
        {
            Direction = Direction.North;
        }

        public void SetDirection(char input)
        {
            if (input.Equals('L'))
            {
                if (Direction == Direction.North)
                {
                    Direction = Direction.West;
                }
                else
                {
                    // Az enum sorrendben való fölvétele miatt lehet így trükközni.
                    Direction = (Direction) ((int) Direction - 1);
                }
            }
            // 'R'
            else
            {
                if (Direction == Direction.West)
                {
                    Direction = Direction.North;
                }
                else
                {
                    Direction = (Direction)((int)Direction + 1);
                }
            }
            // Tudjuk, hogy csak 'L' és 'R' lehet, normális esetben föl kéne készülni hibás input ellen..
        }
    }
}
