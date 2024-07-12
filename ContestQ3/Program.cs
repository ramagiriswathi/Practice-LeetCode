int[] Array = { 0, 0, 0, 0, 0, 0, 0 };
int[,] Query = { { 3, 4 }, { 1, 3 }, { 4, -2 } };

for (int i = 0; i < Query.GetLength(0); i++)
{
    int index = Query[i, 0];
    int value = Query[i, 1];

    Array[index] = Array[index] + value;
}

for (int j = 1; j < Array.Length; j++)
{
    Array[j] = Array[j - 1] + Array[j];
}

for (int k = 0; k < Array.Length; k++)
{
    Console.Write(Array[k] + " ");
}
