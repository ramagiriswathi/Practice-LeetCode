using System.Globalization;

int[] Array2 = { 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 0 };

int result = Consecutiveones.ConsecutiveonesCounter(Array2);
Console.WriteLine(result);
public class Consecutiveones
{
    public static int ConsecutiveonesCounter(int[] Array)
    {
        int count = 0;
        int totalones = 0;
        int N = Array.Length;

        for (int i = 0; i < N; i++)
        {
            if (Array[i] == 1)
            {
                totalones++;
            }
        }
        if (totalones == N)
        {
            return totalones;
        }

        int l = 0;
        int r = 0;
        for (int j = 0; j < N; j++)
        {
            if (Array[j] == 0)
            {
                l = 0;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (Array[k] == 1)
                    {
                        l++;
                    }
                    else
                    {
                        break;
                    }
                }

                r = 0;
                for (int m = j + 1; m < N; m++)
                {
                    if (Array[m] == 1)
                    {
                        r++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (l + r == totalones)
                {
                    return l + r;
                }
                if (l + r > count)
                {
                    count = l + r + 1;
                }
            }

        }
        return count;
    }

}
