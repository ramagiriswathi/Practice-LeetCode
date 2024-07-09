
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

int[] Array4 = new int[] { 4, 2, 5, 7, 4, 2, 3, 6, 8, 2, 3 };

int result = WaterTrap.maxfinder(Array4);

Console.Write(result + " ");

public class WaterTrap
{
    public static int maxfinder(int[] Array)
    {
        int Size = Array.Length;
        int[] prefixLmaxArray = new int[Size];
        int[] prefixRmaxArray = new int[Size];

        prefixLmaxArray[0] = Array[0];
        for (int i = 1; i < Array.Length; i++)
        {
            prefixLmaxArray[i] = Math.Max(prefixLmaxArray[i - 1], Array[i]);
        }
        prefixRmaxArray[Size - 1] = Array[Size - 1];

        for (int i = Size - 2; i >= 0; i--)
        {
            prefixRmaxArray[i] = Math.Max(prefixRmaxArray[i + 1], Array[i]);
        }

        int Totalwatertrap = 0;

        for (int k = 0; k < Size; k++)
        {
            Totalwatertrap += Math.Min(prefixRmaxArray[k], prefixLmaxArray[k]) - Array[k];
        }
        return Totalwatertrap;
    }
}

