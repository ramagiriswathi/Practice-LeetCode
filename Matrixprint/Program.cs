//Printing Matrix boundary elements in clockwise direction

int[,] Matrix2 = { { 10, 11, 12, 13 }, { 20, 21, 22, 23 }, { 30, 31, 32, 33 }, { 40, 41, 42, 43 } };

List<int> Result = MatrixPrint.Matrixbondaryprint(Matrix2);
Console.WriteLine();
foreach (int i in Result)
{
    Console.Write(i + " ");
}
public class MatrixPrint
{
    public static List<int> Matrixbondaryprint(int[,] Matrix)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);
        List<int> Resultprint = new List<int>();

        for (int col = 0; col <= collength - 2; col++)
        {
            int row = 0;
            // Console.Write(Matrix[row, col] + " ");
            Resultprint.Add(Matrix[row, col]);
        }
        for (int row = 0; row <= rowlength - 2; row++)
        {
            int col = collength - 1;
            Resultprint.Add(Matrix[row, col]);
            //Console.Write(Matrix[row, col] + " ");
        }

        for (int col = collength - 1; col > 0; col--)
        {
            int row = rowlength - 1;
            // Console.Write(Matrix[row, col] + " ");
            Resultprint.Add(Matrix[row, col]);
        }
        for (int row = rowlength - 1; row > 0; row--)
        {
            int col = 0;
            // Console.Write(Matrix[row, col] + " ");
            Resultprint.Add(Matrix[row, col]);
        }
        return Resultprint;
    }
}
