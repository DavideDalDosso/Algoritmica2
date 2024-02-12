using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramMerge
{
    public static void Main(string[] args)
    {
        var toSort = new int[] { 9, 7, 3, 6, -3, 8, 4, 31, 1, 2 };
        var toSortQueue = new Queue<int>();
        var toSortList = new List<int>();

        toSortList.AddRange(toSort);

        foreach (var item in toSort)
        {
            toSortQueue.Enqueue(item);
        }

        Console.WriteLine(ArrayToString.Execute(toSort));

        int[] resultArray = new int[toSort.Length];

        var start = DateTime.Now;

        resultArray = InsertionMergeSort.Sort(toSort, SortMode.Asc);

        var end = DateTime.Now;
        var ticks = (end - start).Ticks / 10000000f;
        Console.WriteLine("\n");
        Console.WriteLine(ArrayToString.Execute(resultArray) );
        Console.WriteLine($"Array: {ticks}");

        List<int> resultList = new List<int>();

        var start1 = DateTime.Now;

        resultList = InsertionMergeSort.SortList(toSortList, SortMode.Asc);

        var end1 = DateTime.Now;
        ticks = (end1 - start1).Ticks / 10000000f;
        Console.WriteLine("\n");
        Console.WriteLine(ArrayToString.Execute( resultList.ToArray()) );
        Console.WriteLine($"List: {ticks}");

        Queue<int> resultQueue = new Queue<int>();

        var start2 = DateTime.Now;

        resultQueue = InsertionMergeSort.SortQueue(toSortQueue, SortMode.Asc);

        var end2 = DateTime.Now;
        ticks = (end2 - start2).Ticks / 10000000f;
        Console.WriteLine("\n");
        Console.WriteLine(ArrayToString.Execute(resultQueue.ToArray()));
        Console.WriteLine($"Queue: {ticks}");
    }
}
