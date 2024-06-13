List<int> Array = new List<int> { 3, 5, 2, 1, 0 };
        Console.WriteLine("Please enter the length of subarray");
        int K = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= Array.Count - K; i++)
        {
            Console.WriteLine(i + ", " + (i + K - 1));
            Console.WriteLine();
        }
