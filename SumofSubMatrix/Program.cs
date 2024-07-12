
List<List<int>> Matrix3 = new List<List<int>>{
new List<int> {1,2},
new List<int> {3,4},
 //new List<int> {10,7,3,2,4,10},
 //new List<int>{0,9,5,6,9,2},
 //new List<int>{1,7,7,11,7,25},
//new List<int>{3,1,2,9,17,72},
//new List<int>{4,5,11,13,79,6},
//new List<int>{6,7,63,2,26,3}
};

Solution sol = new Solution();

long resultsum = sol.solve(Matrix3);

Console.WriteLine(resultsum);
class Solution
{
    public long solve(List<List<int>> A)
    {
        long Sum = 0;
        int rowsize = A.Count;
        int colsize = A[0].Count;

        for (int i = 0; i < rowsize; i++)
        {
            for (int j = 0; j < colsize; j++)
            {
                Sum = Sum + (A[i][j] * (i + 1) * (j + 1) * (rowsize - i) * (colsize - j));
            }
        }
        return Sum;

    }

}