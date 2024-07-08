using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

String Palindrome = "adaebcdfdcbetggte";

int result = LongestPalindrome.LongestPalindromeFinder(Palindrome);
Console.WriteLine(result);
public class LongestPalindrome
{
    public static int LongestPalindromeFinder(String pal)
    {
        int Max = 0;
        int N = pal.Length;
        int OddAns = 0;
        int EvenAns = 0;

        for (int i = 0; i < N; i++) // Odd Palindrome
        {
            int left = i; int right = i; int Length = 1;

            while (left >= 0 && right < N && pal[left] == pal[right])
            {

                if (Length > OddAns)
                {
                    OddAns = Length;
                }
                Length = Length + 2;
                left--;
                right++;
            }
        }

        for (int i = 0; i < N - 1; i++)
        {
            int left = i; int right = i + 1; int Length = 2;

            while (left >= 0 && right < N && pal[left] == pal[right])
            {
                if (Length > EvenAns)
                {
                    EvenAns = Length;
                }

                Length = Length + 2;
                left--;
                right++;
            }

        }

        Max = Math.Max(OddAns, EvenAns);
        return Max;
    }
}