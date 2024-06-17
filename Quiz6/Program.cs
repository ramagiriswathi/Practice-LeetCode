internal class Program
{
    private static void Main()
    {
        int[] a = { 10 };
        int[] b = { 20 };

        Swap(a, b);
        Console.WriteLine(a[0] + " " + b[0]);
        Console.WriteLine(a + " " + b);
    }
    public static void Swap(int[] a, int[] b)
    {
        int temp = a[0];
        a[0] = b[0];
        b[0] = temp;
    }
}
