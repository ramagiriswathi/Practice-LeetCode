List<int> Array2 = new List<int> {-3,4,-2,5,3,-2,8,2,-1,4};
MaxSubarraySumfinder maxsum = new MaxSubarraySumfinder();
int Result = maxsum.MaxSubArraySumLenK(Array2,5);

Console.WriteLine(Result);

public class MaxSubarraySumfinder
{
public int MaxSubArraySumLenK(List<int> Array, int K)
{
    int Sum =0;
    int Ans = int.MinValue;
    for(int i=0; i<K; i++)
    {
        Sum+= Array[i];

    }
    Ans = Math.Max(Ans,Sum);
        int startIndex = 1; 
        int endIndex = startIndex + K - 1; 

    while(endIndex < Array.Count)
    {
        Sum = Sum - Array[startIndex - 1] + Array[endIndex];
        Ans = Math.Max(Ans,Sum);
            startIndex++; 
            endIndex++; 
    }
    return Ans;
}
}


