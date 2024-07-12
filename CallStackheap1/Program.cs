using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] Arr = new int[3];
        Console.WriteLine(Arr);
        Arr[1] = 9;
        Arr[2] = 5;
        Arr[0] = 8;
        Arr[0] = 7;
        Console.WriteLine(Arr[0]);
        Arr = new int[5];
        Console.WriteLine(Arr);
        Console.WriteLine(Arr[2]);
    }
}