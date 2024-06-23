int[] Array3 = { -10, 1, 1, 3, 100 };

Array.Sort(Array3, (x, y) => x.CompareTo(y));

int ans = NonDistinctNobleelement.Nobleelementfinder(Array3);
Console.WriteLine(ans);

public class NonDistinctNobleelement
{
    public static int Nobleelementfinder(int[] Array)
    {
        int count = 0;
        int Ans = 0;

        if (Array[0] == 0)
        {
            Ans++;
        }

        for (int i = 1; i < Array.Length; i++)
        {
            if (Array[i] != Array[i - 1])
            {
                count = i;
            }
            if (count == Array[i])
            {
                Ans++;
            }
        }
        return Ans;

    }
}


