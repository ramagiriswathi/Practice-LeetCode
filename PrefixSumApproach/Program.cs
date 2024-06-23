using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> SubarraySum = new List<int> { 2, 5, 3 };

        SubarraySumCalculator subarraySumCalculator = new SubarraySumCalculator();
        int count = subarraySumCalculator.FunctionSubarraySum(SubarraySum);
        Console.WriteLine(count);
    }
}

public class SubarraySumCalculator
{
    public int FunctionSubarraySum(List<int> array)
    {
        int sum = 0;
        for (int i = 0; i < array.Count; i++)
        {
            for (int j = i; j < array.Count; j++)
            {
                for (int k = i; k <= j; k++)
                {
                    sum += array[k];
                }
            }
        }
        return sum;
    }
}
