// See https://aka.ms/new-console-template for more information


var queue = new DataStructures.Queue.Queue<Todo>();
queue.EnQueue(new Todo
{
    Describe = "İşe gidilecek",
    Time = 2
});
queue.EnQueue(new Todo
{
    Describe = "Yemeğe gidilecek",
    Time = 1
});
queue.EnQueue(new Todo
{
    Describe = "Fındık Toplanacak",
    Time = 3
});

var result = queue.DeQueue();
Console.WriteLine(result + " yapıldı \n");

Console.WriteLine(queue.Count);
foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.ReadKey();

