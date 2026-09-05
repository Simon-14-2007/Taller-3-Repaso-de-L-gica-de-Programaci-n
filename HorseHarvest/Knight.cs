namespace HorseHarvest;

public class Knight
{
    public Position CurrentPosition { get; private set; }

    public Knight(Position startingPosition)
    {
        CurrentPosition = startingPosition;
    }

    public void MoveTo(Position newPosition)
    {
        CurrentPosition = newPosition;
    }
}