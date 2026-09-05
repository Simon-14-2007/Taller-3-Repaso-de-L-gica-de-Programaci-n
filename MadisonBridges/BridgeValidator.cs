namespace MadisonBridges;

public class BridgeValidator
{
    private const char Base = '*';
    private const char Platform = '=';
    private const char Reinforcement = '+';

    public bool IsValid(Bridge bridge)
    {
        return ValidateBasesOnlyAtExtremes(bridge)
            && ValidateSymmetry(bridge)
            && ValidatePlatformGroups(bridge);
    }

    private bool ValidateBasesOnlyAtExtremes(Bridge bridge)
    {
        for (int i = 0; i < bridge.Length; i++)
        {
            bool isExtreme = i == 0 || i == bridge.Length - 1;
            if (bridge.CharAt(i) == Base && !isExtreme)
                return false;
        }
        return true;
    }

    private bool ValidateSymmetry(Bridge bridge)
    {
        int left = 0;
        int right = bridge.Length - 1;

        while (left < right)
        {
            if (bridge.CharAt(left) != bridge.CharAt(right))
                return false;

            left++;
            right--;
        }
        return true;
    }

    private bool ValidatePlatformGroups(Bridge bridge)
    {
        int i = 0;
        while (i < bridge.Length)
        {
            if (bridge.CharAt(i) != Platform)
            {
                i++;
                continue;
            }

            int start = i;
            while (i < bridge.Length && bridge.CharAt(i) == Platform)
                i++;
            int end = i - 1;

            if (!IsGroupLengthValid(start, end, bridge.Length))
                return false;

            if (!IsGroupBounded(bridge, start, end))
                return false;
        }
        return true;
    }

    private bool IsGroupLengthValid(int start, int end, int bridgeLength)
    {
        int groupLength = end - start + 1;

        if (groupLength == 2)
            return true;

        if (groupLength == 3)
            return IsCentered(start, end, bridgeLength);

        return false;
    }

    private bool IsCentered(int start, int end, int bridgeLength)
    {
        return start + end == bridgeLength - 1;
    }

    private bool IsGroupBounded(Bridge bridge, int start, int end)
    {
        bool leftBounded = start > 0 &&
            (bridge.CharAt(start - 1) == Base || bridge.CharAt(start - 1) == Reinforcement);

        bool rightBounded = end < bridge.Length - 1 &&
            (bridge.CharAt(end + 1) == Base || bridge.CharAt(end + 1) == Reinforcement);

        return leftBounded && rightBounded;
    }
}