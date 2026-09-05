namespace MadisonBridges;

public class Bridge
{
    private readonly string _sequence;

    public string Sequence => _sequence;
    public int Length => _sequence.Length;

    public Bridge(string sequence)
    {
        _sequence = sequence;
    }

    public char CharAt(int index) => _sequence[index];
}