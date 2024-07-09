using System.Net.Cache;
using System.Runtime.InteropServices.Marshalling;

int[] Array2 = { 1, 1, 0, 1, 1, 0, 1, 1, 1 };

int result = Countof1s.Countof1sfinder(Array2);
Console.WriteLine(result);
public class Countof1s
{
    public static int Countof1sfinder(int[] Array)
    {
        int ans = 0; int totalcount = 0;
        int N = Array.Length;
        for (int i = 0; i < N; i++)
        {
            if (Array[i] == 1)
            {
                totalcount++;
            }
        }
        if (totalcount == N)
        {
            return totalcount;
        }
        for (int i = 0; i < N; i++)
        {
            int l = 0; int r = 0;
            if (Array[i] == 0)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (Array[j] == 1)
                    {
                        l++;
                    }
                    else
                    { break; }
                }
                for (int k = i + 1; k < N; k++)
                {
                    if (Array[k] == 1)
                    {
                        r++;
                    }
                    else
                    { break; }
                }
                if (l + r + 1 > ans)
                {
                    ans = l + r + 1;

                }

            }
        }
        return ans;
    }
}


