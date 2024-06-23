int[] Array3 = { 1, -5, 3, 5, -10, 4 };
Nobleinteger.Nobleintegerfinder(Array3);

public class Nobleinteger
{
    public static void Nobleintegerfinder(int[] Array)
    {
        int Ans = 0;
        for (int i = 0; i < Array.Length; i++)
        {
            int Count = 0;
            for (int j = 0; j < Array.Length; j++)
            {
                if (Array[i] < Array[j])
                {
                    Count++;
                }
            }
            if (Count == Array[i])
            {
                Ans++;
            }

        }
        Console.WriteLine(Ans);
    }
}
