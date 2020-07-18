using System;

class Solution
{
    public int[] solution(int[] N, int K)
    {
        if (N == null)
        {
            return null;
        }
        if (N.Length == 0)
        {
            return N;
        }
        if (K == 0 || K == N.Length)
        {
            // no rotation necessary.
            return N;
        }

        int shiftRight;
        if (K > N.Length)
        {
            shiftRight = K % N.Length;
        }
        else
        {
            shiftRight = K;
        }

        if (shiftRight == 0)
        {
            return N;
        }

        return ShiftArrayElementsToRight(N, shiftRight);
    }

    public int[] ShiftArrayElementsToRight(int[] array, int numberOfTimes)
    {
        var newArray = new int[array.Length];
        int lastElementIndex = (array.Length - numberOfTimes);

        Array.Copy(array, lastElementIndex, newArray, 0, numberOfTimes);
        Array.Copy(array, 0, newArray, numberOfTimes, lastElementIndex);

        return newArray;
    }
}