using System;

internal class Program
{
    private static void Main()
    {
        int[] a = { 10 };
        Change(a);
        Console.WriteLine(a[0]);
    }
    public static void Change(int[] a)
    {
        a[0] = 50;
    }
}
