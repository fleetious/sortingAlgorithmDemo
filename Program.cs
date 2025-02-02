using System.Diagnostics;

namespace SortingAlgorithmDemo;

class Program
{
    static void Main(string[] args)
    {
        int[] testArray = { 10, 5, 4, 2, 7, 9, 8, 3, 6, 3, 23, 35, 354, 76, 12, 11, 64, 57, 47 };
        Stopwatch s = Stopwatch.StartNew();
        
        int[] sortedArray = Sort.BubbleSort(testArray);
        
        s.Stop();
        
        string sorted = "{\n\t" + string.Join(",\n\t", sortedArray) + "\n}";
        
        Console.WriteLine($"{sorted}, {s.Elapsed.TotalMicroseconds}");
    }
}