using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MergeSort
{
    //Refactored for the exercise
    //Array
    public static T[] Sort<T>(T[] arr, SortMode mode) where T : IComparable<T>
    {
        //Console.WriteLine("Array: " + ArrayToString.Execute(arr));
        T[][] subs = DivideOnce(arr, mode);

        Sort(subs[0], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(leftArr));
        Sort(subs[1], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(rightArr));

        Merge(ref arr, subs[0], subs[1], mode);

        return arr;
    }
    public static T[][] DivideOnce<T>(T[] arr, SortMode mode) where T : IComparable<T>
    {
        if (arr.Length == 1) return new T[][] { arr };

        var half = arr.Length / 2;
        var extra = arr.Length % 2 == 1 ? 1 : 0;

        var leftArr = new T[half + extra];
        for (var i = 0; i < half; i++)
        {
            leftArr[i] = arr[i];
        }
        if (extra > 0) leftArr[half] = arr[half];

        var rightArr = new T[half];
        for (var i = 0; i < half; i++)
        {
            rightArr[i] = arr[i + half + extra];
        }

        return new T[][] { leftArr, rightArr };
    }
    public static T[] Merge<T>(ref T[] buffer, T[] arr1, T[] arr2, SortMode mode) where T : IComparable<T>
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int index = 0;

        int sortModeValue = mode == SortMode.Asc ? 1 : -1;

        while (leftIndex < arr1.Length && rightIndex < arr2.Length)
        {
            if (arr1[leftIndex].CompareTo(arr2[rightIndex]) == sortModeValue)
            {
                buffer[index] = arr2[rightIndex];
                index++;
                rightIndex++;
            }
            else
            {
                buffer[index] = arr1[leftIndex];
                index++;
                leftIndex++;
            }
        }
        while (leftIndex < arr1.Length)
        {
            buffer[index] = arr1[leftIndex];
            index++;
            leftIndex++;
        }
        while (rightIndex < arr2.Length)
        {
            buffer[index] = arr2[rightIndex];
            index++;
            rightIndex++;
        }
        return buffer;
    }
    public static T[] Merge<T>(T[] arr1, T[] arr2, SortMode mode) where T : IComparable<T>
    {
        var buffer = new T[arr1.Length + arr2.Length];
        Merge(ref buffer, arr1, arr2, mode);
        return buffer;
    }
    public static T[] MergeNoSort<T>(T[] arr1, T[] arr2) where T : IComparable<T>
    {
        T[] buffer = new T[arr1.Length + arr2.Length];
        int index = 0;
        for(int i=0; i<arr1.Length; i++)
        {
            buffer[index] = arr1[i];
            index++;
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            buffer[index] = arr2[i];
            index++;
        }

        return buffer;
    }

    //LIST
    public static List<T> SortList<T>(List<T> list, SortMode mode) where T : IComparable<T>
    {
        //Console.WriteLine("Array: " + ArrayToString.Execute(arr));
        List<T>[] subs = DivideOnceList(list, mode);

        SortList(subs[0], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(leftArr));
        SortList(subs[1], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(rightArr));

        MergeList(ref list, subs[0], subs[1], mode);

        return list;
    }
    public static List<T>[] DivideOnceList<T>(List<T> list, SortMode mode) where T : IComparable<T>
    {
        if (list.Count == 1) return new List<T>[] { list };

        var half = list.Count / 2;
        var extra = list.Count % 2 == 1 ? 1 : 0;

        var leftList = new List<T>();
        for (var i = 0; i < half; i++)
        {
            leftList.Add(list[i]);
        }
        if (extra > 0) leftList.Add(list[half]);

        var rightList = new List<T>();
        for (var i = 0; i < half; i++)
        {
            rightList.Add(list[i + half + extra]);
        }

        return new List<T>[] { leftList, rightList };
    }
    public static List<T> MergeList<T>(ref List<T> buffer, List<T> list1, List<T> list2, SortMode mode) where T : IComparable<T>
    {
        int leftIndex = 0;
        int rightIndex = 0;

        int sortModeValue = mode == SortMode.Asc ? 1 : -1;

        while (leftIndex < list1.Count && rightIndex < list2.Count)
        {
            if (list1[leftIndex].CompareTo(list2[rightIndex]) == sortModeValue)
            {
                buffer.Add(list2[rightIndex]);
                rightIndex++;
            }
            else
            {
                buffer.Add(list1[leftIndex]);
                leftIndex++;
            }
        }
        while (leftIndex < list1.Count)
        {
            buffer.Add(list1[leftIndex]);
            leftIndex++;
        }
        while (rightIndex < list2.Count)
        {
            buffer.Add(list2[rightIndex]);
            rightIndex++;
        }
        return buffer;
    }
    public static List<T> MergeList<T>(List<T> list1, List<T> list2, SortMode mode) where T : IComparable<T>
    {
        var buffer = new List<T>();
        MergeList(ref buffer, list1, list2, mode);
        return buffer;
    }
    public static List<T> MergeNoSortList<T>(List<T> list1, List<T> list2) where T : IComparable<T>
    {
        List<T> buffer = new List<T>();
        for (int i = 0; i < list1.Count; i++)
        {
            buffer.Add(list1[i]);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            buffer.Add(list2[i]);
        }

        return buffer;
    }
    //QUEUE
    public static Queue<T> SortQueue<T>(Queue<T> queue, SortMode mode) where T : IComparable<T>
    {
        //Console.WriteLine("Array: " + ArrayToString.Execute(arr));
        Queue<T>[] subs = DivideOnceQueue(queue, mode);

        SortQueue(subs[0], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(leftArr));
        SortQueue(subs[1], mode);
        //Console.WriteLine("Array: " + ArrayToString.Execute(rightArr));

        MergeQueue(ref queue, subs[0], subs[1], mode);

        return queue;
    }
    public static Queue<T>[] DivideOnceQueue<T>(Queue<T> queue, SortMode mode) where T : IComparable<T>
    {
        if (queue.Count == 1) return new Queue<T>[] { queue };

        var half = queue.Count / 2;
        var extra = queue.Count % 2 == 1 ? 1 : 0;

        var leftQueue = new Queue<T>();
        for (var i = 0; i < half; i++)
        {
            leftQueue.Enqueue( queue.Dequeue() );
        }
        if (extra > 0) leftQueue.Enqueue(queue.Dequeue());

        var rightQueue = new Queue<T>();
        for (var i = 0; i < half; i++)
        {
            rightQueue.Enqueue(queue.Dequeue());
        }

        return new Queue<T>[] { leftQueue, rightQueue };
    }
    public static Queue<T> MergeQueue<T>(ref Queue<T> buffer, Queue<T> queue1, Queue<T> queue2, SortMode mode) where T : IComparable<T>
    {

        int sortModeValue = mode == SortMode.Asc ? 1 : -1;

        T itemBuffer1 = default;
        T itemBuffer2 = default;

        while (queue1.Count > 0 && queue2.Count > 0)
        {
            if(itemBuffer1 == null)
            {
                itemBuffer1 = queue1.Dequeue();
            }
            if (itemBuffer2 == null)
            {
                itemBuffer2 = queue2.Dequeue();
            }
            if (itemBuffer1.CompareTo(itemBuffer2) == sortModeValue)
            {
                buffer.Enqueue(itemBuffer2);
                itemBuffer2 = default;
            }
            else
            {
                buffer.Enqueue(itemBuffer1);
                itemBuffer1 = default;
            }
        }
        while (queue1.Count > 0)
        {
            buffer.Enqueue(queue1.Dequeue() );
        }
        while (queue2.Count > 0)
        {
            buffer.Enqueue(queue2.Dequeue());
        }
        return buffer;
    }
    public static Queue<T> MergeQueue<T>(Queue<T> queue1, Queue<T> queue2, SortMode mode) where T : IComparable<T>
    {
        var buffer = new Queue<T>();
        MergeQueue(ref buffer, queue1, queue2, mode);
        return buffer;
    }
    public static Queue<T> MergeNoSortQueue<T>(Queue<T> queue1, Queue<T> queue2) where T : IComparable<T>
    {
        Queue<T> buffer = new Queue<T>();
        while(queue1.Count > 0)
        {
            buffer.Enqueue(queue1.Dequeue() );
        }
        while (queue2.Count > 0)
        {
            buffer.Enqueue(queue2.Dequeue());
        }

        return buffer;
    }
}
