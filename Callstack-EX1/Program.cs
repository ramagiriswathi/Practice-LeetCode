using System;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;

        int y = 20;

        int t1 = Add(x, y);
        int t2 = Product(x, y);
        int t3 = Subtract(x, y);

        Console.WriteLine(t1);
        Console.WriteLine(t2);
        Console.WriteLine(t3);
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Product(int x, int y)
    {
        return x * y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }
}
