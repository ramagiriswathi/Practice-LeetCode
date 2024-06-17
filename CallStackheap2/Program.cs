using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] Arr = new int[3];
        Console.WriteLine(Arr);
        Arr[0] = 90;
        Arr[1] = 50;
        Console.WriteLine(Arr[1]);
        Func(Arr);
        Console.WriteLine(Arr[1]);
    }

    static void Func(int[] a)
    {
        Console.WriteLine(a);
        a[1] = 5;
    }
}