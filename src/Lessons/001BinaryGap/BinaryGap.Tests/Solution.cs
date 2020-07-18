using System;

class Solution
{
    public int solution(int N)
    {
        var binary = Convert.ToString(N, 2);
        if (binary == null)
        {
            return 0;
        }
        return GetLongestBinaryGap(binary);
    }

    public int GetLongestBinaryGap(string binary)
    {
        bool isGapStarted = false;
        int longestGap = 0;
        int currentGap = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            var currentChar = binary[i];

            if (isGapStarted)
            {
                if (currentChar == '0')
                {
                    currentGap = currentGap + 1;
                }
                else
                {
                    // isGapStarted = false;
                    if (currentGap > longestGap)
                    {
                        longestGap = currentGap;
                    }
                    currentGap = 0;
                }
            }
            else
            {
                if (currentChar == '1')
                {
                    isGapStarted = true;
                }
            }
        }

        return longestGap;
    }
}