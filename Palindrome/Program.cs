string Palstr = "abmadamtam";

bool val = Palindrome.PalindromeFinder(Palstr, 2, 6);

Console.WriteLine(val);

public class Palindrome
{
    public static bool PalindromeFinder(string str, int s, int e)
    {
        while (s < e)
        {
            if (str[s] != str[e])
                return false;
            s++; e--;
        }
        return true;
    }
}
