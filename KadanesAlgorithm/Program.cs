using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

List<int> Array2 = new List<int> { 5, 6, 7, -3, 2, -10, -12, 8, 12, -4, 7, -2 };

int ans = int.MinValue;
int Sum = 0;
int i = 0;
int N = Array2.Count;

while (i < N)
{
    Sum = Sum + Array2[i];

    if (Sum > ans)
    {
        ans = Sum;
    }
    if (Sum < 0)
    {
        Sum = 0;
    }
    i++;
}

Console.WriteLine(ans);
