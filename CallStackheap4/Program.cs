using System;
using System.Reflection;
internal class Program
{
    private static void Main()
    {

        int[,] Mat = new int[2, 3];
        Mat[0, 0] = 15;
        Mat[1, 0] = 25;
        Sum(Mat);
    }
    static void Sum(int[,] Mat)
    {
        Console.WriteLine(Mat);
        Console.WriteLine(Mat[0, 0] + Mat[1, 0]);
    }
}
