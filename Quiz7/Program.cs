internal class Program
{
    private static void Main()
    {
        int[] a = { 10, 20, 30 };
        Console.WriteLine(a[0]);
        Console.WriteLine(a[1]);
        Console.WriteLine(a[2]);
        a = Fun(a);


        Console.WriteLine(a[0]);
        Console.WriteLine(a[1]);
    }
    public static int[] Fun(int[] a)
    {
        a = new int[2];
        a[0] = 50;
        a[1] = 60;
        return a;
    }
}
