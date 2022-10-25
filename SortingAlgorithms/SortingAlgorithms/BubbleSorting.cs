using System;
namespace SortingAlgorithms;
public class BubbleSorting
{
    public static void Sort<T>(T[] array)
    where T : IComparable<T>
    {
        int n = array.Length;
        for (int i = 0; i < n -1; i++)
            for (int j = 0; j < n -i -1; j++)
                if(array[j].CompareTo(array[j +1]) >= 1)
                     Sorting.Swap(array, j, j +1);

    }
}

