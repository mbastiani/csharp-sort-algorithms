using System;

namespace Sort.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Utils.GetRandomArray(99);
            Utils.PrintArray(arr);

            PancakeSort.Sort((int[])arr.Clone());
            BubbleSort.Sort((int[])arr.Clone());
            QuickSort.Sort((int[])arr.Clone());
            SelectionSort.Sort((int[])arr.Clone());

            Console.ReadKey();
        }
    }
}
