using System;

namespace Sort.Algorithms
{
    public static class PancakeSort
    {
        public static void Sort(int[] arr)
        {
            Console.WriteLine(nameof(PancakeSort));
            var startTime = DateTimeOffset.Now;

            for (int currentSize = arr.Length; currentSize > 1; --currentSize)
            {
                int maxIndex = GetMaxValueIndex(arr, currentSize);

                if (maxIndex != currentSize - 1)
                {
                    Flip(arr, maxIndex);
                    Flip(arr, currentSize - 1);
                }
            }

            Utils.PrintArray(arr, (DateTimeOffset.Now - startTime));
        }

        private static int GetMaxValueIndex(int[] arr, int currentPosition)
        {
            int maxIndex, i;

            for (maxIndex = 0, i = 0; i < currentPosition; ++i)
                if (arr[i] > arr[maxIndex])
                    maxIndex = i;

            return maxIndex;
        }

        private static void Flip(int[] arr, int position)
        {
            int temp, start = 0;
            while (start < position)
            {
                temp = arr[start];
                arr[start] = arr[position];
                arr[position] = temp;
                start++;
                position--;
            }
        }
    }
}