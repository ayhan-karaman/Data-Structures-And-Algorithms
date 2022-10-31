using System;
using System.Collections.Generic;
using PriorityQueue;

var A = new List<int>(new int[] {1, 2, 3, 9, 10, 12}); // new List<int>(new int[] {2, 7, 3, 6, 4, 6});
var k = 7;
Console.WriteLine("The number of steps : {0}", PizzaMenu(k, A));

static int PizzaMenu(int k, List<int> A)
{
     var heap = new MinHeap<int>(A);
     int step = 0;
     while (!CheckAllPizzas(k, heap))
     {
          var p1 = heap.DeleteMinMax();
          var p2 = heap.DeleteMinMax();

          heap.Add(CalculateDeliciousScore(p1, p2));
          step++;
     }
     return step;
}

static int CalculateDeliciousScore(int p1, int p2)=> p1 + 2 * p2;

static bool CheckAllPizzas(int k, MinHeap<int> heap)
{
    foreach (var item in heap)
    {
          if(item < k)
               return false;
    }
    return true;
}