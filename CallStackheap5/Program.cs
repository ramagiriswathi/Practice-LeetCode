using System;
using System.Reflection;
internal class Program
{
    private static void Main()
    {

        int[,] Mat = new int[2, 3];
        Mat[0, 0] = 9;
        Mat[1, 0] = 5;
        Mat[0, 2] = 1;
        int Ans = SumRow(Mat, 1);
        Console.WriteLine(Ans);
    }
    static int SumRow(int[,] A, int rowIndex)
    {
        Console.WriteLine(A);
        int Sum = 0;
        for (int i = 0; i < A.GetLength(1); i++)
        {
            Sum += A[rowIndex, i];
        }
        return Sum; ;
    }
}