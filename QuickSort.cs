using System;
using System.Timers;
namespace Program
{
    class QuickSort
    {

        void swap(ref int a, ref int b)
        {

            int p = a;
            a = b;
            b = p;
        }
        public void Sort(ref int[] arr)
        {
           var rng = new Random();
            for (int k = 0; k != arr.Length; ++k)
            {
                int r1 = rng.Next(0, arr.Length);
                int r2 = rng.Next(0, arr.Length);
                swap(ref arr[r1], ref arr[r2]);
            }
            Partition(ref arr, 0, arr.Length);
        }
        void Partition(ref int[] arr, int lo, int hi)// lo included; hi is not included
        {
            if (hi - lo <= 1) return;
            int i = lo + 1;
            int j = hi - 1;

            //foreach(var p in arr)
            //Console.Write(p + " ");

            int pivot = lo;
            while (true)
            {

                while (i < hi && arr[i] < arr[pivot])
                {
                    ++i;
                }
                while (j >= i && arr[j] >= arr[pivot])
                {
                    --j;
                }
                if (i >= j) break;
                swap(ref arr[i], ref arr[j]);
            }
            swap(ref arr[j], ref arr[pivot]);
            Partition(ref arr, lo, j);
            Partition(ref arr, j + 1, hi);

        }

    }
}
