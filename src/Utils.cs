using System;

namespace Sort.Algorithms
{
    public static class Utils
    {
        public static int[] GetRandomArray(int length)
        {
            var arr = new int[length];

            for (int i = 1; i <= length; i++)
                arr[i - 1] = i;

            ShuffleArray(arr);

            return arr;
        }

        public static void ShuffleArray(int[] arr)
        {
            var length = arr.Length;

            if (length > 1)
            {
                var rnd = new Random();
                for (int i = length - 1; i > 0; i--)
                {
                    int j = rnd.Next(0, i);

                    Swap(arr, i, j);
                }
            }
        }

        public static void PrintArray(int[] arr, TimeSpan? totalTime = null)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            if (totalTime.HasValue)
                Console.WriteLine($"\nTempo: {totalTime}");

            Console.WriteLine("\n");
        }

        public static void Swap(int[] arr, int pos1, int pos2)
        {
            int aux = arr[pos1];
            arr[pos1] = arr[pos2];
            arr[pos2] = aux;
        }
    }
}