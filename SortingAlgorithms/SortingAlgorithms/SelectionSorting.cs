using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Utilities;

namespace SortingAlgorithms
{
    public class SelectionSorting
    {
        public static void Sort<T>(T[] array)
        where T : IComparable
        {
            int n = array.Length;
            for (var i = 0; i < n; i++)
            {
                int minIndex = i;
                T minValue = array[i]; 
                for (var j = i +1; j < n; j++)
                {
                    if (array[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = array[minIndex];
                    }
                }
                Sorting.Swap(array, i, minIndex);
            }
        }

        public static void Sort<T>(T[] array, SortDirection sortDirection = SortDirection.Ascending)
        where T : IComparable
        {
            int n = array.Length;
            var comparer = new CustomComparer<T>(sortDirection, Comparer<T>.Default);
            for (var i = 0; i < n; i++)
            {
               
                for (var j = i +1; j < n; j++)
                {
                    if(comparer.Compare(array[j], array[i]) >= 0)
                        continue;
                        Sorting.Swap(array, i, j);
                }
                
            }
        }
    }
}