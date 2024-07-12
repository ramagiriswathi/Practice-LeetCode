using System;
using System.Reflection;
using System.Security.Authentication.ExtendedProtection;
internal class Program
{
    private static void Main()
    {
        int a = 10;
        change(a);
        Console.WriteLine(a);
    }
    public static void change(int a)
    {
        a = 50;
    }
}