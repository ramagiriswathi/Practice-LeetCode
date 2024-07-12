int[,] Matrixinput ={{1,2,3,4},
                     {5,6,7,8},
                     {9,10,11,12}
};

MatrixSum matrixsumprinter = new MatrixSum();
matrixsumprinter.MatrixRowSumPrinter(Matrixinput);

public class MatrixSum
{
    public void MatrixRowSumPrinter(int[,] Matrix)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);

        for (int i = 0; i < rowlength; i++)
        {
            int Sum = 0;
            for (int j = 0; j < collength; j++)
            {
                Sum += Matrix[i, j];
            }
            Console.WriteLine(Sum);
        }

    }
}
