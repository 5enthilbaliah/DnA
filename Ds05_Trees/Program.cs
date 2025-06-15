// See https://aka.ms/new-console-template for more information

// Balanced search tree
// AVL tree
// Red-Black tree

using Ds05.Trees;

var map = new[,]
{
    { 0, 0, 1, 0, 1, 0, 0, 1 },
    { 1, 0, 0, 0, 1, 0, 1, 1 },
    { 1, 0, 0, 1, 1, 0, 1, 0 },
    { 0, 1, 0, 1, 0, 1, 0, 1 },
    { 1, 1, 0, 1, 1, 0, 1, 1 }
};

var largestIsland = new FindLargestIsland(map);
Console.WriteLine("Largest island");
Console.WriteLine("------------------------------------------");
Console.WriteLine(largestIsland.Execute());