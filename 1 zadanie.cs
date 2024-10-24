class Program
{
    static void Main()
    {
        int[] arr = { 4, 5, 2, 10, 8 };
        int[] result = Result(arr);

        Console.WriteLine(string.Join(", ", result));
    }

    static int[] Result(int[] arr)
    {
        List<int> stack = new List<int>();
        int[] result = new int[arr.Length];

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            while (stack.Count > 0 && stack[stack.Count - 1] <= arr[i])
            {
                stack.RemoveAt(stack.Count - 1);
            }

            result[i] = stack.Count > 0 ? stack[stack.Count - 1] : -1;
            stack.Add(arr[i]);
        }

        return result;
    }
}