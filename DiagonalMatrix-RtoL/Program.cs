using System.Globalization;

int[,] Matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

DiagonalMatrix.DiagonalMatrixFinder(Matrix);
public class DiagonalMatrix
{
    public static void DiagonalMatrixFinder(int[,] Matrix)
    {
        int rowlength = Matrix.GetLength(0);
        int collength = Matrix.GetLength(1);

        
        for (int col = 0; col < collength; col++)
        {
            int i = 0;
            int j = col;
            while (i < rowlength && j >= 0)
            {
                System.Console.Write(Matrix[i,j]+ " ");
                
                i++;j--;
            }
            Console.WriteLine();

        }
        
        for(int row=1; row< rowlength; row++)
        {
            int i =row;
            int j=collength-1;
        while (i < rowlength && j >= 0)
            {
                System.Console.Write(Matrix[i,j]+ " ");
                
                i++;j--;
            }
            Console.WriteLine();
        }
    }
}
