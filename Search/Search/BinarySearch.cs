using System;
namespace Search;
public class BinarySearch
{
    public static int Search<T>(T[] array, T key)
    where T : IComparable
    {
        return search(array, 0, array.Length-1, key);
    }
    private static int search<T>(T[] array, int i, int j, T key)
    where T : IComparable
    {
        while (true)
        {
            if(i == j)
            {
                if(array[i].Equals(key))
                    return i;
                return -1;
            }
            
            int middle = (i + j) / 2;
            if(array[middle].Equals(key))
                return middle;
            if(key.CompareTo(array[middle]) == -1)
            {
                 j = middle;
                 continue;
            }
            i = middle +1;
        }
    }
}
