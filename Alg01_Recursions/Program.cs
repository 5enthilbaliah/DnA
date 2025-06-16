// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using Alg01.Recursions.Exercises;

var factorial = new Factorial(6);
Console.WriteLine("Factorial");
Console.WriteLine("------------------------------------------");
Console.WriteLine(factorial.Execute());

var fibonnacci = new Fibonacci(6);
Console.WriteLine("Fibonacci");
Console.WriteLine("------------------------------------------");
Console.WriteLine(fibonnacci.Execute());


var permutations = new Permutations("BARK");
Console.WriteLine("Permutations");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(permutations.Execute()));