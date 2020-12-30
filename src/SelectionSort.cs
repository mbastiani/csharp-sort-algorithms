using System;

namespace Sort.Algorithms
{
    public static class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            Console.WriteLine(nameof(SelectionSort));
            var startTime = DateTimeOffset.Now;

            int minPos;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                minPos = i;

                for (int j = (i + 1); j < arr.Length; j++)
                    if (arr[j] < arr[minPos])
                        minPos = j;

                if (i != minPos)
                    Utils.Swap(arr, i, minPos);
            }

            Utils.PrintArray(arr, (DateTimeOffset.Now - startTime));
        }
    }
}