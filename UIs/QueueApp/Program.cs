// See https://aka.ms/new-console-template for more information

var queue = new Queue<Todo>();
queue.Enqueue(new Todo
{
    Describe = "İşe gidilecek",
    Time = 2
});
queue.Enqueue(new Todo
{
    Describe = "Yemeğe gidilecek",
    Time = 1
});
queue.Enqueue(new Todo
{
    Describe = "Fındık Toplanacak",
    Time = 3
});

var result = queue.Dequeue();
Console.WriteLine(result + " yapıldı \n");

Console.WriteLine(queue.Count);
foreach (var item in queue)
{
    Console.WriteLine(item);
}

Console.ReadKey();

