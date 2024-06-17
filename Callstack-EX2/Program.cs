using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int x = 10;
        int y = 20;

        int z = Func(x, y);
        Console.WriteLine(z);
        Extra(z);
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Func(int a, int b)
    {
        int Sum = Add(a, b);
        int Ans = Sum * 10;
        return Ans;
    }

    public static void Extra(int w)
    {
        Console.WriteLine("Hello");
        Console.WriteLine(w);
    }
}
