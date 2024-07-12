//Search max number of 1's from the sorted row Matrix and return minum indices.

int[,] Matrix2 = { { 0, 0, 0, 1 }, { 0, 1, 1, 1 }, { 1, 1, 1, 1 }, { 0, 1, 1, 1 } };

int result = MatrixSearch.Onesfinder(Matrix2);
System.Console.WriteLine(result);
public class MatrixSearch
{
    public static int Onesfinder(int[,] Matrix)
    {
        int Totalcount = 0;
        int index = 0;
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);

        int row = 0; int col = collength - 1;

        while (row <= rowlength - 1 && col >= 0)
        {
            if (Matrix[row, col] == 1)
            {
                Totalcount++;
                index = row;
                col--;
            }
            else if (Matrix[row, col] != 1)
            {
                row++;
            }
        }
        return index;
    }
}
