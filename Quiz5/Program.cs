internal class Program
{
    private static void Main()
    {
        int a = 10;
        int b = 20;

        Swap(a, b);
        Console.WriteLine(a + " " + b);
    }
    public static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
