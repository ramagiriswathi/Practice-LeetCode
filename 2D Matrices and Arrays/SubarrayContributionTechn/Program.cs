using System;
using System.Collections.Generic;

class Program
{
    //Test
    static void Main(string[] args)
    {
        List<int> Array = new List<int> { 2, 5, 3 };

        SubarrayContribution subarray = new SubarrayContribution();
        int Count = subarray.FindSumOfSubarrays(Array);
        Console.WriteLine(Count);
    }
}

public class SubarrayContribution
{
    public int FindSumOfSubarrays(List<int> Array2)
    {
        int Sum = 0;
        for (int i = 0; i < Array2.Count; i++)
        {
            Sum += Array2[i] * (i + 1) * (Array2.Count - i);
        }
        return Sum;
    }
}

