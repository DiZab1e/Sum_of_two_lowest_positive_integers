using System;
public static class Kata
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        //Code here...
        int temp = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - i - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    temp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = temp;
                }
            }
        }
        int min1 = numbers[0];
        int min2 = numbers[1];
        int result = (min1 + min2);
        return result;
    }
}