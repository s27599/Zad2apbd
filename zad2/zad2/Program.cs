// See https://aka.ms/new-console-template for more information


using System.Diagnostics.CodeAnalysis;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public double avg(int[] tab)
    {
        int sum = 0;
        int counter = 0;
        foreach (int val in tab){
             sum += val;
             counter++;
        }
        return sum / counter;
    }
    
    public static double max(int[] tab)
    {
        int max = Int32.MinValue;
        foreach (int val in tab) {
            if (max < val)
            {
                max = val;
            }
        }
        return max;
    }
    
}