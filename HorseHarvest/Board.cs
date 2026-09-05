namespace HorseHarvest;

public class Board
{
    private readonly Dictionary<Position, char> _fruits = new();

    public void PlantFruit(Position position, char fruit)
    {
        _fruits[position] = fruit;
    }

    public bool IsInside(Position position)
    {
        return position.IsInsideBoard();
    }

    public bool TryHarvest(Position position, out char fruit)
    {
        return _fruits.TryGetValue(position, out fruit);
    }

    public static Board FromNotation(string fruitsNotation)
    {
        var board = new Board();
        string[] entries = fruitsNotation.Split(',', StringSplitOptions.RemoveEmptyEntries);

        foreach (string entry in entries)
        {
            string trimmedEntry = entry.Trim();
            string positionPart = trimmedEntry.Substring(0, trimmedEntry.Length - 1);
            char fruitSymbol = trimmedEntry[^1];

            var position = Position.Parse(positionPart);
            board.PlantFruit(position, fruitSymbol);
        }

        return board;
    }
}