
int[] Array3 = new int[] { 0, 0, 0, 0, 0 };

int[,] Queries = new int[,] { { 1, 2, 10 }, { 2, 3, 20 }, { 2, 4, 25 } };

for (int i = 0; i < Queries.GetLength(0); i++)
{
    int l = Queries[i, 0];
    int r = Queries[i, 1];
    int value = Queries[i, 2];

    Array3[l] = Array3[l] + value;

    if (r + 1 < Array3.Length)
    {
        Array3[r + 1] = Array3[r + 1] - value;
    }
}

for (int j = 1; j < Array3.Length; j++)
{
    Array3[j] = Array3[j - 1] + Array3[j];
}

foreach (int k in Array3)
{
    Console.Write(k + " ");
}
