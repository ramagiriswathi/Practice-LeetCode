internal class Program
{
    public static void Main(string[] args)
    {
        int[,] Matrix = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };

        ColumWiseSumFinder(Matrix);
    }

    public static void ColumWiseSumFinder(int[,] MatrixValue)
    {
        int rowlength = MatrixValue.GetLength(0);
        int collength = MatrixValue.GetLength(1);

        for (int i = 0; i < collength; i++)
        {
            int Sum = 0;
            for (int j = 0; j < rowlength; j++)
            {
                Sum += MatrixValue[j, i];
            }
            Console.WriteLine(Sum);
        }
    }
}
