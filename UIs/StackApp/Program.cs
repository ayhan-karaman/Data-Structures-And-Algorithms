// See https://aka.ms/new-console-template for more information
using DataStructures.Stack;
string message = "Selam";

var stack = new ArrayStack<char>();
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
