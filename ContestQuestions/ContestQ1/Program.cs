using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;


List<int> numbers = new List<int> { 4, 3, 1, 2 };

List<List<int>> result = SubArray.Subarrayfinder(numbers);

foreach (var sub in result)
{
    foreach (var num in sub)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Max Decreasing Subaaray");
List<int> result2 = SubArray.Finddecreasingsubaaray(result);
foreach (var num in result2)
{
    Console.Write(num + " ");
}
Console.WriteLine();



public class SubArray
{
    public static List<List<int>> Subarrayfinder(List<int> Array)
    {
        List<List<int>> subarraylist = new List<List<int>>();

        for (int i = 0; i < Array.Count; i++)
        {
            for (int j = i; j < Array.Count; j++)
            {
                List<int> subarrays = new List<int>();

                for (int k = i; k <= j; k++)
                {
                    subarrays.Add(Array[k]);
                }
                subarraylist.Add(subarrays);
            }
        }
        return subarraylist;
    }

    public static bool ISdecreasing(List<int> subarrays)
    {
        for (int i = 1; i < subarrays.Count; i++)
        {
            if (subarrays[i] >= subarrays[i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public static List<int> Finddecreasingsubaaray(List<List<int>> subarrays)
    {
        List<int> decsubarray = new List<int>();
        foreach (var sub in subarrays)
        {
            if (ISdecreasing(sub) && sub.Count > decsubarray.Count)
            {
                decsubarray = sub;
            }
        }
        return decsubarray;

    }

}

