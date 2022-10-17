// See https://aka.ms/new-console-template for more information

var customLinkedList = new CustomLinkedList<int>(new int[]{1, 2, 3, 3, 2, 5});

foreach (var item in customLinkedList)
{
    Console.Write($"{item, 2}");
}

Console.ReadKey();