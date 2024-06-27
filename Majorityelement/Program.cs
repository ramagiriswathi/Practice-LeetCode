int[] ArrayMaj = { 3, 3, 4, 3, 5, 7, 3 };
int[] ArrayMaj1 = { 1, 1, 2, 3, 4, 5, 6 };

int result = MajorityElement.MajorityElementFinder(ArrayMaj1);
Console.WriteLine(result);
public class MajorityElement
{
    public static int MajorityElementFinder(int[] Array)
    {
        int MajEle = -1;
        int Count = 0;
        int N = Array.Length;

        for (int i = 0; i < N; i++)
        {
            if (Count == 0)
            {
                MajEle = Array[i];
                Count = 1;
            }
            else if (Array[i] == MajEle)
            {
                Count++;
            }
            else
            {
                Count--;
            }

        }

        int CountMajEle = 0;
        for (int i = 0; i < N; i++)
        {
            if (Array[i] == MajEle)
            {
                CountMajEle++;
            }
        }
        if (CountMajEle > N / 2)
        {
            return MajEle;
        }
        else
        {
            return -1;
        }
    }
}


