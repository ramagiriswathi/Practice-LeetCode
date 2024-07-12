//Spiral Printing of the Matrix in clockwise direction

int[,] Matrix3 = { { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 }, { 30, 31, 32, 33, 34 }, { 40, 41, 42, 43, 44 } };

int rowstart = 0;
int colstart = 0;
int rowend = Matrix3.GetLength(0) - 1;
int colend = Matrix3.GetLength(1) - 1;
int count = (rowend + 1) * (colend + 1);

while (rowstart <= rowend && colstart <= colend && count > 0)
{
    for (int i = colstart; i <= colend; i++)
    {
        Console.Write(Matrix3[rowstart, i] + " ");
        count--;

    }
    rowstart++;
    for (int i = rowstart; i <= rowend; i++)
    {
        Console.Write(Matrix3[i, colend] + " ");
        count--;
    }
    colend--;
    if (rowstart <= rowend)
    {
        for (int i = colend; i >= colstart; i--)
        {
            Console.Write(Matrix3[rowend, i] + " ");
            count--;
        }
        rowend--;
    }

    if (colstart <= colend)
    {
        for (int i = rowend; i >= rowstart; i--)
        {
            Console.Write(Matrix3[i, colstart] + " ");
            count--;
        }
        colstart++;
    }
}

