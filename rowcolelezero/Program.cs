using System;

int[,] Matrix1 = { { 1, 2, 3, 4 }, { 5, 6, 7, 0 }, { 9, 2, 0, 4 } };

int[,] Result = MatrixZero.MatrixZeroFinder(Matrix1);

for (int i = 0; i < Result.GetLength(0); i++)
{
    for (int j = 0; j < Result.GetLength(1); j++)
    {
        Console.Write(Result[i, j] + " ");
    }
    Console.WriteLine();
}

public class MatrixZero
{
    public static int[,] MatrixZeroFinder(int[,] Matrix)
    {
        int row = Matrix.GetLength(0);
        int col = Matrix.GetLength(1);


        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                if (Matrix[i, j] == 0)
                {

                    for (int k = 0; k < col; k++)
                    {
                        if (Matrix[i, k] != 0)
                        {
                            Matrix[i, k] = '*';
                        }
                    }

                    for (int l = 0; l < row; l++)
                    {
                        if (Matrix[l, j] != 0)
                        {
                            Matrix[l, j] = '*';
                        }
                    }
                }
            }
        }


        for (int m = 0; m < row; m++)
        {
            for (int n = 0; n < col; n++)
            {
                if (Matrix[m, n] == '*')
                {
                    Matrix[m, n] = 0;
                }
            }
        }

        return Matrix;
    }
}
