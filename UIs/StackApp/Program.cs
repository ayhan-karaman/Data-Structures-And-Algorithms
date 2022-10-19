// See https://aka.ms/new-console-template for more information

string message = "Selam";

var stack = new DataStructures.Stack.Stack<char>(DataStructures.Stack.StackType.Array);
for (var i = 0; i < message.Length; i++)
{
    stack.Push(message[i]);
}

var n = stack.Count;
char[] s = message.ToCharArray();
for (var i = 0; i < n; i++)
{
   s[i] = stack.Pop();
}
Console.WriteLine(new string(s));
Console.ReadKey();
