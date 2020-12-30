using System;

namespace Sort.Algorithms
{
    public static class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            Console.WriteLine(nameof(BubbleSort));
            var startTime = DateTimeOffset.Now;

            bool swaped;
            do
            {
                swaped = false;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Utils.Swap(arr, i, i + 1);
                        swaped = true;
                    }
                }
            } while (swaped);

            Utils.PrintArray(arr, (DateTimeOffset.Now - startTime));
        }
    }
}