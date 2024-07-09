using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

/*List<int> Arraynumbers = new List<int> { 3, 2, 4, -1, 3, 4, 3 };
List<int> resultprefixsum = Subarray.PrefixSumFinder(Arraynumbers);
Console.WriteLine("PrefixSumArray:");
foreach (int i in resultprefixsum)
{
    Console.Write(i + " ");
}
Console.WriteLine();

Console.WriteLine("Max Subarray Sum:");
int result2 = Subarray.Sumofsubarray(resultprefixsum);
Console.Write(result2 + " ");*/

//Find the sum of each subarray
/*using System.Diagnostics.CodeAnalysis;

List<int> Arraynumbers = new List<int> { 3, 2, 4, -1, 3, 4, 3 };

int result = Sumofsubarray.SumofsubarrayFinder(Arraynumbers);
Console.WriteLine(result);

public class Sumofsubarray
{
    public static int SumofsubarrayFinder(List<int> Array)
    {
        int overallsum = 0;
        for (int i = 0; i < Array.Count; i++)
        {
            for (int j = i; j < Array.Count; j++)
            {
                int sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum = sum + Array[k];
                }
                if (sum > overallsum)
                {
                    overallsum = sum;
                }
            }
        }
        return overallsum;
    }
}*/

// PrefixSum
/*
public class Subarray
{
    public static List<int> PrefixSumFinder(List<int> Array)
    {
        List<int> Prefixsum = new List<int>();
        int PFsum = 0;

        for (int i = 0; i < Array.Count; i++)
        {
            PFsum += Array[i];
            Prefixsum.Add(PFsum);
        }
        return Prefixsum;

    }
    public static int Sumofsubarray(List<int> Prefixsum)
    {
        int OverAllSum = 0;

        for (int j = 0; j < Prefixsum.Count; j++)
        {
            int SUM = 0;
            for (int k = j; k < Prefixsum.Count; k++)
            {
                SUM = Prefixsum[k];

                if (SUM > OverAllSum)
                {
                    OverAllSum = SUM;
                }
            }

        }
        return OverAllSum;

    }
}*/

//Carry forward technique
/*List<int> Arraynumbers = new List<int> { 3, 2, 4, -1, 3, 4, 3 };

int resultSum = Carryforward.SubarrayFinder(Arraynumbers);
Console.WriteLine(resultSum);
public class Carryforward
{
    public static int SubarrayFinder(List<int> Array)
    {
        int TotalMaxSum = 0;

        for (int i = 0; i < Array.Count; i++)
        {
            int Sum = 0;
            for (int j = i; j < Array.Count; j++)
            {
                Sum = Sum + Array[j];
            }
            if (Sum > TotalMaxSum)
            {
                TotalMaxSum = Sum;
            }
        }
        return TotalMaxSum;
    }
}*/

//Kadane's Algorithm

List<int> Arraynumbers = new List<int> { 3, 6, 6, -1, 3, 4, 3 };

int resultSum = Carryforward.SubarrayFinder(Arraynumbers);
Console.WriteLine(resultSum);
public class Carryforward
{
    public static int SubarrayFinder(List<int> Array)
    {
        int TotalMaxSum = 0;
        int Sum = 0;

        for (int i = 0; i < Array.Count; i++)
        {
            Sum = Math.Max(Array[i], Sum + Array[i]);


            if (Sum > TotalMaxSum)
            {
                TotalMaxSum = Sum;
            }
        }
        return TotalMaxSum;
    }
}



