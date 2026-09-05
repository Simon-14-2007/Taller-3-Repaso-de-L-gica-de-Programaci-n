namespace HorseHarvest;

public static class KnightMove
{
    private static readonly Dictionary<string, (int DeltaColumn, int DeltaRow)> Deltas = new()
    {
        { "UL", (-1, 2) },
        { "UR", (1, 2) },
        { "LU", (-2, 1) },
        { "LD", (-2, -1) },
        { "RU", (2, 1) },
        { "RD", (2, -1) },
        { "DL", (-1, -2) },
        { "DR", (1, -2) },
    };

    public static Position Apply(Position current, string moveCode)
    {
        string code = moveCode.Trim().ToUpper();

        if (!Deltas.TryGetValue(code, out var delta))
            throw new ArgumentException($"Movimiento no reconocido: '{moveCode}'.", nameof(moveCode));

        return current.Move(delta.DeltaColumn, delta.DeltaRow);
    }
}