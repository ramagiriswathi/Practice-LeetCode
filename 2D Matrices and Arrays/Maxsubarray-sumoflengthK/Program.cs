internal class Program
{
    private static void Main(string[] args)
    {
        List<int> Array1 = new List<int> { 3, 4, -2, 5, 3, -2, 8, 2, -1, 4 };

        Console.WriteLine("Please enter the length of subarray");
        int K = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i <= Array1.Count - K; i++)
        {
            int Sum = 0;

            for (int j = i; j < i + K; j++)
            {
                Sum = Sum + Array1[j];

            }
            Console.WriteLine(Sum);
        }
    }
}
