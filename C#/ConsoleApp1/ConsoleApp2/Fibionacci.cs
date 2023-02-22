using System;
namespace ConsoleApp2;

public class Fibionacci
{
    public static int FibonacciCalculation(int n)
    {
        if (n <= 0)
        {
            throw new ArgumentException("Invalid argument. Argument must be greater than 0.");
        }
        
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return FibonacciCalculation(n - 1) + FibonacciCalculation(n - 2);
        }
    }
    
    // static void Main(string[] args)
    // {
    //     for (int i = 1; i <= 10; i++)
    //     {
    //         Console.Write(" "+FibonacciCalculation(i));
    //     }
    // }
}