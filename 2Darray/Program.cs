int[] ArraySub = new int[] {2,7,6,4,5,1,2,6,4,1};

minmax MinMaxFinder = new minmax();
MinMaxFinder.FindMinMax(ArraySub,out int min, out int max);


int Maxindex = -1;
int Minindex = -1;
int Ans = 0;
int result = int.MaxValue;
for (int i = 0; i < ArraySub.Length; i++)
{
    if (ArraySub[i] == min)
    {
        Minindex = i;

        if(Maxindex !=-1)
        {
            int subArrayLength = (Minindex - Maxindex) + 1;
            result = Math.Min(result, subArrayLength);
        }
    }
    

    if (ArraySub[i] == max)
    {

        Maxindex = i;
        if (Minindex != -1)
        {
            int subArrayLength = (Maxindex - Minindex) + 1;
            result = Math.Min(result, subArrayLength);
        }
   
    }
}
Console.WriteLine(result);

public class minmax
{
    public void FindMinMax(int[] Array, out int min, out int max)
    {
        min = Array[0];
        max = Array[0];
        for(int i = 0; i < Array.Length; i++)
        {
            if (Array[i] < min)
                min = Array[i];

            if (Array[i] > max)
                max = Array[i];
        }
    }
}



