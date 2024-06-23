using System;

int[] Array3 = { 5, 6, 4, 2, 3, 1 };

int[] result = SelectionSort.SelectionSortFinder(Array3);

foreach (int i in result)
{
    Console.Write(i + " ");
}

public class SelectionSort
{
    public static int[] SelectionSortFinder(int[] Array)
    {
        ;

        for (int i = 0; i < Array.Length - 1; i++)
        {
            int mi = i;
            for (int j = i + 1; j < Array.Length; j++)
            {
                if (Array[j] < Array[mi])
                {
                    mi = j;
                }
            }
            Swap(Array, mi, i);
        }
        return Array;
    }

    public static void Swap(int[] Array, int i, int j)
    {
        int temp = Array[i];
        Array[i] = Array[j];
        Array[j] = temp;
    }
}
