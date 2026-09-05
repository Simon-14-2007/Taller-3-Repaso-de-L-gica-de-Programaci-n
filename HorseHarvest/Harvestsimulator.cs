namespace HorseHarvest;

public class HarvestSimulator
{
    private readonly Board _board;
    private readonly Knight _knight;

    public HarvestSimulator(Board board, Knight knight)
    {
        _board = board;
        _knight = knight;
    }

    public List<char> Harvest(IEnumerable<string> moveCodes)
    {
        var collectedFruits = new List<char>();

        foreach (string moveCode in moveCodes)
        {
            Position nextPosition = KnightMove.Apply(_knight.CurrentPosition, moveCode);

            if (!_board.IsInside(nextPosition))
                throw new InvalidOperationException(
                    $"El movimiento '{moveCode}' saca al caballo fuera del tablero (llegaría a {nextPosition}).");

            _knight.MoveTo(nextPosition);

            if (_board.TryHarvest(nextPosition, out char fruit))
                collectedFruits.Add(fruit);
        }

        return collectedFruits;
    }
}