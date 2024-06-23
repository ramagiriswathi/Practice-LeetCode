using System.Diagnostics.CodeAnalysis;

int[] Array1 = { 2, 1, 4 };
Array.Sort(Array1, (x, y) => y.CompareTo(x));

int Ans = 0;

for (int
 i = 0; i < Array1.Length; i++)
{
    int sum = 0;
    for (int j = i; j < Array1.Length; j++)
    {
        sum += Array1[j];
    }
    Ans = Ans + sum;
}
Console.WriteLine(Ans);
