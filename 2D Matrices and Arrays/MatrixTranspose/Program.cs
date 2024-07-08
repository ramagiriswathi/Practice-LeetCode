using System.Data;

int[,] Matrix2 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

Transpose.TransposeFinder(Matrix2);

for (int row = 0; row < Matrix2.GetLength(0); row++)
{
    for (int col = 0; col < Matrix2.GetLength(1); col++)
    {
        Console.Write(Matrix2[row, col]);
    }
    Console.WriteLine();
}

public class Transpose
{
    public static int[,] TransposeFinder(int[,] Matrix)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);

        for (int row = 0; row < rowlength; row++)
        {
            for (int col = row; col < collength; col++)
            {
                int temp = Matrix[row, col];
                Matrix[row, col] = Matrix[col, row];
                Matrix[col, row] = temp;
            }
        }
        return Matrix;
    }
}

