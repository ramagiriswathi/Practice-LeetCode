internal class Program
{
    private static void Main()
    {
        int[] a = { 10, 20, 30 };
        Fun(a);
        Console.WriteLine(a[0]);
    }
    public static void Fun(int[] a)
    {
        a = new int[1];
        a[0] = 100;
    }
}
