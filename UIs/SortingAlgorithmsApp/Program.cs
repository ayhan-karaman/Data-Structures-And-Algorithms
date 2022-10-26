using System;
using SortingAlgorithms;
int[] arr = {40, 20, 50, 10, 5, 60, 30};

Console.WriteLine("Not Sorting Algorithms!");
ScreenWrite(arr);
SelectionSorting.Sort(arr, Utilities.SortDirection.Descending);

Console.WriteLine("Sorting Algorithms");
ScreenWrite(arr);

static void ScreenWrite<T>(T[] array)
{
    Console.WriteLine();
    foreach (var item in array)
    {
        Console.Write($"{item, -5}");
    }
    Console.WriteLine();
}
