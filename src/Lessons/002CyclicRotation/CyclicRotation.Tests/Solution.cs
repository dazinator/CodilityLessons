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

        for (int i = 0; i < numberOfTimes; i++)
        {
            var currentOffset = lastElementIndex + i;
            newArray[i] = array[currentOffset];
        }

        // now add remainder  
        for (int i = 0; i < lastElementIndex; i++)
        {
            newArray[i + numberOfTimes] = array[i];
        }

        return newArray;
    }
}