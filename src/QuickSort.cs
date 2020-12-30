using System;

namespace Sort.Algorithms
{
    public static class QuickSort
    {
        public static void Sort(int[] arr)
        {
            Console.WriteLine(nameof(QuickSort));
            var startTime = DateTimeOffset.Now;

            int initPos = 0;
            int finalPos = arr.Length - 1;
            Sort(arr, initPos, finalPos);

            Utils.PrintArray(arr, (DateTimeOffset.Now - startTime));
        }

        private static void Sort(int[] arr, int initPos, int finalPos)
        {
            if (initPos < finalPos)
            {
                int value = arr[initPos];
                int i = initPos + 1;
                int j = finalPos;

                while (i <= j)
                {
                    if (arr[i] <= value)
                        i++;
                    else if (value < arr[j])
                        j--;
                    else
                    {
                        Utils.Swap(arr, i, j);
                        i++;
                        j--;
                    }
                }

                arr[initPos] = arr[j];
                arr[j] = value;
                Sort(arr, initPos, j - 1);
                Sort(arr, j + 1, finalPos);
            }
        }
    }
}