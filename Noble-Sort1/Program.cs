int[] Array3 = { 1, -5, 3, 5, -10, 4 };

Array.Sort(Array3, (x, y) => x.CompareTo(y));
NobleElementSort.NobleElementFinder(Array3);

public class NobleElementSort
{
    public static void NobleElementFinder(int[] Array)
    {
        int count = 0;
        for (int i = 0; i < Array.Length; i++)
        {

            if (Array[i] == i)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}

