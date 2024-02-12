using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsertionMergeSort
{
    public static T[] Sort<T>(T[] arr, SortMode mode) where T : IComparable<T>
    {
        if (arr.Length > 5)
        {
            T[][] subs = MergeSort.DivideOnce(arr, mode);
            T[] sorted1 = Sort(subs[0], mode);
            T[] sorted2 = Sort(subs[1], mode);

            return InsertionSort.Sort( MergeSort.MergeNoSort(sorted1, sorted2), mode);
        }
        return InsertionSort.Sort(arr, mode);
    }
    public static List<T> SortList<T>(List<T> list, SortMode mode) where T : IComparable<T>
    {
        if (list.Count > 5)
        {
            List<T>[] subs = MergeSort.DivideOnceList(list, mode);
            List<T> sorted1 = SortList(subs[0], mode);
            List<T> sorted2 = SortList(subs[1], mode);

            return InsertionSort.SortList( MergeSort.MergeNoSortList(sorted1, sorted2), mode);
        }
        return InsertionSort.SortList(list, mode);
    }
    public static Queue<T> SortQueue<T>(Queue<T> queue, SortMode mode) where T : IComparable<T>
    {
        if (queue.Count > 5)
        {
            Queue<T>[] subs = MergeSort.DivideOnceQueue(queue, mode);
            Queue<T> sorted1 = SortQueue(subs[0], mode);
            Queue<T> sorted2 = SortQueue(subs[1], mode);

            return InsertionSort.SortQueue( MergeSort.MergeNoSortQueue(sorted1, sorted2), mode);
        }
        return InsertionSort.SortQueue(queue, mode);
    }
}
