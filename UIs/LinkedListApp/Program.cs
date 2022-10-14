// See https://aka.ms/new-console-template for more information
using DataStructures.LinkedList.DoublyLinkedLists;
using DataStructures.LinkedList.SinglyLinkedList;
var result = new DoublyLinkedList<char>(new char[]{'a', 'z', 'i', 'r', 'd', 't', 'l'});

foreach (var item in result)
{
    Console.WriteLine(item);
}

Console.ReadKey();