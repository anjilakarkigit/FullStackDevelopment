namespace ConsoleApp2;

public class ReverseNumber
{
    public int[] GenerateNumbers(int n=10)
    {
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    public void PrintNumbers(int[] nums)
    {
        foreach(int i in nums)
        {
            Console.Write($"{i} ");
        }
    }

    public void Reverse(int[] nums)
    {
        for (int i = 0; i < nums.Length/2; i++)
        {
            int temp = nums[i];
            nums[i] = nums[nums.Length - i - 1];
            nums[nums.Length - i - 1] = temp;
        }
    }

    // public static void Main(string[] args)
    // {
    //     ReverseNumber r1 = new ReverseNumber();
    //     int[] numbers = r1.GenerateNumbers();
    //     r1.Reverse(numbers);
    //     r1.PrintNumbers(numbers);
    // }
}