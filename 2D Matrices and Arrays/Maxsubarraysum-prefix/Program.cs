List<int> Array2 = new List<int> { -3, 4, -2, 5, 3, -2, 8, 2, -1, 4 };

PrefixSum prefix = new PrefixSum();
List<int> Sumarray = prefix.Prefixsumfinder(Array2);

foreach (int i in Sumarray)
{
    Console.Write(i + " ");

}
Console.WriteLine();
int Result = prefix.SubarraySumfinder(Array2);
Console.WriteLine(Result);

public class PrefixSum
{
    public List<int> Prefixsumfinder(List<int> Array)
    {
        int Sum = 0;
        List<int> Sumarray = new List<int>();

        for (int i = 0; i < Array.Count; i++)
        {
            Sum += Array[i];
            Sumarray.Add(Sum);
        }
        return Sumarray;
    }

    public int SubarraySumfinder(List<int> Array)
    {
        Console.WriteLine("Please enter the length of subarray");
        int K = Convert.ToInt16(Console.ReadLine());
        int Max = int.MinValue;
        int PrefixSum = 0;

        for (int i = 0; i <= Array.Count - K; i++)
        {
            if (i == 0)
            {
                for (int j = 0; j < K; j++)
                {
                    PrefixSum += Array[j];
                }
            }
            else
            {

                PrefixSum = PrefixSum + Array[i + K - 1] - Array[i - 1];
            }

            if (PrefixSum > Max)
            {
                Max = PrefixSum;
            }
        }

        return Max;
    }

}


