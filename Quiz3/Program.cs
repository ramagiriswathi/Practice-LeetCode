internal class Program
{
    private static void Main()
    {
        int[] a = { 10 };
        test(a);
        Console.WriteLine(a[0]);
    }
    public static void test(int[] a)
    {
        a = new int[1];
        a[0] = 50;
    }
}
