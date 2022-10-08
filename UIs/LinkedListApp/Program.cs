// See https://aka.ms/new-console-template for more information
using DataStructures.LinkedList.SinglyLinkedList;
var result = new SinglyLinkedList<int>();
result.AddFirst(1);
Console.WriteLine(result.Head.Value);

Console.ReadKey();