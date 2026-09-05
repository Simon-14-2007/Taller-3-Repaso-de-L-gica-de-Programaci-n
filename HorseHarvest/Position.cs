namespace HorseHarvest;

public class Position
{
    private const string Columns = "ABCDEFGH";

    public int Column { get; }
    public int Row { get; }

    public Position(int column, int row)
    {
        Column = column;
        Row = row;
    }

    public static Position Parse(string notation)
    {
        char columnLetter = char.ToUpper(notation[0]);
        int column = Columns.IndexOf(columnLetter) + 1;
        int row = int.Parse(notation.Substring(1));
        return new Position(column, row);
    }

    public bool IsInsideBoard()
    {
        return Column >= 1 && Column <= 8 && Row >= 1 && Row <= 8;
    }

    public Position Move(int deltaColumn, int deltaRow)
    {
        return new Position(Column + deltaColumn, Row + deltaRow);
    }

    public override string ToString()
    {
        return $"{Columns[Column - 1]}{Row}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Position other && Column == other.Column && Row == other.Row;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Column, Row);
    }
}