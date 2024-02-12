using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class InsertionSort
{
    public static T[] Sort<T>(T[] arr, SortMode mode) where T : IComparable<T>
    {
        int sortModeValue = mode == SortMode.Asc ? 1 : -1;
        int index = 1;
        int tempIndex;
        while (index < arr.Length)
        {
            //Console.WriteLine("Array (index: " + index + "): " + ArrayToString.Execute(arr));
            if (arr[index - 1].CompareTo( arr[index] ) == sortModeValue) //EDIT LATER
            {
                tempIndex = index;
                while (index >= 1)
                {
                    if (arr[index - 1].CompareTo(arr[index]) == -sortModeValue) break;
                    Swap.Execute(ref arr[index - 1], ref arr[index]);
                    index--;
                }
                index = tempIndex;
            }
            index++;
        }

        return arr;
    }
    public static List<T> SortList<T>(List<T> arr, SortMode mode) where T : IComparable<T>
    {
        List<T> result = new List<T>();
        List<T> bin = new List<T>();

        int sortModeValue = mode == SortMode.Asc ? 1 : -1;
        bool taken = false;
        T temp = default;
        T lowest = default;
        while (arr.Count > 0)
        {

            temp = arr[0];
            arr.RemoveAt(0);
            if (!taken)
            {
                lowest = temp;
                taken = true;
                continue;
            }
            if (lowest.CompareTo(temp) == sortModeValue) //EDIT LATER
            {
                bin.Add(lowest);
                lowest = temp;
            }
            else
            {
                bin.Add(temp);
            }
            if (arr.Count == 0)
            {
                result.Add(lowest);
                arr.AddRange(bin);
                bin.Clear();
                taken = false;
            }
        }

        if (taken) result.Add(lowest);

        return result;
    }
    public static Queue<T> SortQueue<T>(Queue<T> queue, SortMode mode) where T : IComparable<T>
    {
        Queue<T> result = new Queue<T>();
        Queue<T> bin = new Queue<T>();

        int sortModeValue = mode == SortMode.Asc ? 1 : -1;
        bool taken = false;
        T temp = default;
        T lowest = default;
        while (queue.Count > 0)
        {

            temp = queue.Dequeue();
            if(!taken)
            {
                lowest = temp;
                taken = true;
                continue;
            }
            if (lowest.CompareTo(temp) == sortModeValue) //EDIT LATER
            {
                bin.Enqueue(lowest);
                lowest = temp;
            } else
            {
                bin.Enqueue(temp);
            }
            if(queue.Count == 0)
            {
                result.Enqueue(lowest);
                queue = bin;
                bin = new Queue<T>();
                taken = false;
            }
        }

        if(taken) result.Enqueue(lowest);

        return result;
    }
}
