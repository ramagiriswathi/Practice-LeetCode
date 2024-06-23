using System;

class Program
{
    static void Main()
    {
        int[] Array3 = { -10, 1, 1, 3, 100 };
        Nobleinteger.Nobleintegerfinder(Array3);
    }
}

public class Nobleinteger
{
    public static void Nobleintegerfinder(int[] array)
    {
        int nobleCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < array.Length; j++)
            {
                if ((array[i] > array[j]))
                {
                    count++;
                }
            }

            if (count == array[i])
            {
                nobleCount++;
            }
        }

        Console.WriteLine(nobleCount);
    }
}
