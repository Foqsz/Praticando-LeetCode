public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> romanToInt = new Dictionary<char, int>()
        {
            {'M', 1000},
            {'D', 500},
            {'C', 100},
            {'L', 50},
            {'X', 10},
            {'V', 5},
            {'I', 1}
        };

        int result = 0;
        int prevValue = 0;

        foreach (char c in s)
        {
            int currentValue = romanToInt[c];

            if (currentValue > prevValue)
            {
                result += currentValue - 2 * prevValue;
            }
            else
            {
                result += currentValue;
            }

            prevValue = currentValue;
        }

        return result;
    }
}
