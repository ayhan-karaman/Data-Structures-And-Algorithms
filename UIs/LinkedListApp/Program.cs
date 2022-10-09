// See https://aka.ms/new-console-template for more information
using DataStructures.LinkedList.SinglyLinkedList;
var result = new SinglyLinkedList<int>(new int[]{1, 5, 3, 10, 28});

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.ReadKey();