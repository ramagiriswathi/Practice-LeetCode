namespace _2D_Arrays_ScalarPractise
{
    internal class Program
    {
        static void Main()
        {
            int[,] Array1 = new int[4, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 }, { 16, 17, 18, 19, 20 } };

            //PrintTopRow(Array1);
            //PrintColumn(Array1);
            //Print(Array1);
            //PrintColumnbyRow(Array1);
            //PrintSum(Array1);
            //PrintWaveForm(Array1);
            //ColumnMax(Array1);



        }

        //public static void PrintTopRow(int[,] Array)
        //{
        //    for(int i = 0; i < Array.GetLength(1); i++)
        //    {
        //        Console.Write(Array[0, i] + " ");
        //    }   

        //}

        //public static void PrintColumn(int[,] Array)
        //{
        //    for (int i = 0; i < Array.GetLength(0); i++)
        //    {
        //        Console.Write(Array[i, 0] + " ");
        //    }
        //}

        //public static void Print(int[,] Array)
        //{
        //    for(int i = 0; i < Array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < Array.GetLength(1); j++)
        //        {
        //            Console.Write(Array[i, j] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}


        //public static void PrintColumnbyRow(int[,] Array)
        //{
        //    for (int i =0; i< Array.GetLength(1); i++)
        //    {
        //        for (int j = 0; j< Array.GetLength(0); j++)
        //        {
        //            Console.Write(Array[j, i] + " ");
        //        }
        //        Console.WriteLine();
        //    }
        //}   

        //public static void PrintSum(int[,] Array)
        //{
        //    int PSum = 0;
        //    for (int i = 0; i < Array.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < Array.GetLength(1); j++)
        //        {
        //            PSum =PSum + Array[i, j];
        //        }

        //    }
        //    Console.WriteLine($"The sum of all the elements in the Array is: {PSum}");
        //}

        //public static void PrintWaveForm(int[,] Array)
        //{
        //    for(int i=0; i<Array.GetLength(0); i++)
        //    {
        //        if(i%2 ==0)
        //        {
        //            for(int j=0; j<Array.GetLength(1); j++)
        //            {
        //                Console.Write(Array[i,j] + " ");
        //            }Console.WriteLine();
        //        }
        //        else
        //        {
        //            for(int j=Array.GetLength(1)-1; j>=0; j--)
        //            {
        //                Console.Write(Array[i,j] + " ");
        //            }
        //            Console.WriteLine();
        //        }
        //    }
        //}


        //public static void ColumnMax(int[,] Array)
        //{
        //    int ColumnMax = 0;

        //    int[] ColumnMaxArray = new int[Array.GetLength(1)];

        //    for (int i = 0; i < Array.GetLength(0); i++)
        //    {
        //        ColumnMax = 0;
        //        for (int j = 0; j < Array.GetLength(1); j++)
        //        {
        //            ColumnMax = ColumnMax + Array[i, j];
        //        }
        //        ColumnMaxArray[i] = ColumnMax;
        //    }
        //    for (int i = 0; i < Array.GetLength(0); i++)
        //    {
        //        Console.WriteLine(ColumnMaxArray[i]);
        //    }
        //}


    }
}

