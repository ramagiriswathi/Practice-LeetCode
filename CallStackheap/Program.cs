

using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;
        int[] Arr = new int[3];
        int[] Arr1 = new int[2];
        int[] Arr2 = Arr;
        Console.WriteLine(x);
        Console.WriteLine(Arr);
        Console.WriteLine(Arr1);
        Console.WriteLine(Arr2);
    }
}