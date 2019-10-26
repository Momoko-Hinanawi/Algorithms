using System;
namespace Program
{
        static class InsertionSort
        {
                static void swap(ref int a, ref int b)
                {

                        int p = a;
                        a = b;
                        b = p;
                }
                public static void Sort(ref int[] A)
                {
                        if (A.Length == 1) return;
                        for (int i = 1; i != A.Length; ++i)
                        {
                                for (int j = 0; j != i; ++j)
                                {
                                        if (A[j] > A[i])
                                        {
                                                for (int k = j; k != i; ++k)
                                                {
                                                        swap(ref A[k], ref A[i]);
                                                }
                                                break;
                                        }
                                }
                        }
                }

        }
}