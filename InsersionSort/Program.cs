int[] Array3 = { 5, 6, 4, 2, 3, 1 };

InsertionSort.Insertionsortfinder(Array3);

foreach (int i in Array3)
{
    Console.Write(i + " ");
}
public class InsertionSort
{
    public static void Insertionsortfinder(int[] Array)
    {
        int n = Array.Length;

        for (int i = 1; i < n; i++)
        {
            int current = Array[i];

            int j = i - 1;

            while (j >= 0 && Array[j] > current)
            {
                Array[j + 1] = Array[j];
                j--;
            }
            Array[j + 1] = current;

        }

    }
}

