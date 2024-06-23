int[] Array2 = { 2, 4, 1 };
Array.Sort(Array2, (x, y) => y.CompareTo(x));

int Sum = 0;
for (int i = 0; i < Array2.Length; i++)
{
    Sum += Array2[i] * (i + 1);
}
Console.WriteLine(Sum);
