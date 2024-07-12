//Search K from the row and columwise sorted matrices.
using System.Runtime.InteropServices;

int[,] GivenMatrix = { { 5, 10, 15, 20 }, { 6, 12, 20, 23 }, { 7, 14, 21, 30 }, { 17, 26, 33, 48 } };

bool result = MatrixSearch.Ksearch(GivenMatrix, 49);

Console.WriteLine(result);
public class MatrixSearch
{
    public static bool Ksearch(int[,] Matrix, int K)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);
        int row = 0; int col = collength - 1;
        while (row <= rowlength - 1 && col >= 0)
        {
            if (Matrix[row, col] == K)
            {
                return true;
            }
            else if (Matrix[row, col] > K)
            {
                col--;
            }
            else
            {
                if (Matrix[row, col] < K)
                {
                    row++;
                }
            }
        }
        return false;
    }
}
