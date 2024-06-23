using System;
using System.Reflection;
internal class Program
{
    private static void Main()
    {
        float y = 7.84f;
        int[,] Mat = new int[3, 4];
        Console.WriteLine(y);
        Console.WriteLine(Mat);
        Console.WriteLine(Mat[1, 3]);
    }
}
