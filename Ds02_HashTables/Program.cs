// See https://aka.ms/new-console-template for more information

// Merge sorted arrays

using Ds02.HashTables;

var recurringCharacter = new FirstRecurringCharacter([2, 5, 1, 2, 3, 5, 1, 2, 4]);
Console.WriteLine("First recurring character");
Console.WriteLine("------------------------------------------");
var rec = recurringCharacter.Execute();
Console.WriteLine(rec.HasValue ? $"{rec}" : "none");
