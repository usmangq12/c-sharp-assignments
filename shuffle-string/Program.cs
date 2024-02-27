class Program
{
    static void Main()
    {
        var solution = new Solution();
        int[] indices = { 4, 5, 6, 7, 0, 1, 2, 3 };
        var result = solution.RestoreString("leetcode", indices);
        Console.WriteLine($"result: {result}");
    }
}
