using System;

namespace Program
{
        class MergeSort
        {

                private int[] Aux;
                public MergeSort(int length)
                {
                        Aux = new int[length];
                }
                public void Sort(ref int[] a)
                {
                        sort(ref a, 0, a.Length);
                }

                private void sort(ref int[] A, int lo, int hi)// lo is included; hi is not included
                {

                        //Console.WriteLine(lo + " " + hi);
                        if (hi - lo <= 1)
                        {
                                return;
                        }
                        int mid = (hi + lo) / 2;
                        sort(ref A, lo, mid);
                        sort(ref A, mid, hi);
                        merge(ref A, lo, mid, hi);
                }
                private void merge(ref int[] A, int lo, int mid, int hi)
                {

                        for (int k = lo; k != hi; ++k)
                        {
                                Aux[k] = A[k];
                        }
                        int i = lo, j = mid;
                        for (int k = lo; k != hi; ++k)
                        {
                                if (i >= mid) A[k] = Aux[j++];
                                else if (j >= hi)
                                        A[k] = Aux[i++];
                                else if (Aux[i] < Aux[j])//ascentive
                                        A[k] = Aux[i++];
                                else A[k] = Aux[j++];
                        }
                }
        }
}
