using System;
using DataStructures.Trees.BinaryTrees;
var binaryTree = new BinaryTree<int>(new int[] {1, 2, 3, 4, 5, 6, 7});


foreach (var item in binaryTree)
{
    Console.WriteLine($"{item}");
}

Console.ReadKey();

