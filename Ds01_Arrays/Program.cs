// See https://aka.ms/new-console-template for more information

// C# arrays are only enumerable so we will replicate it with list

using System.Text.Json;
using Ds01.Arrays;
using Ds01.Arrays.Exercises;

var strings = new List<string>
{
    "a", "b", "c", "d"
};

// lookup - O(1)
var lookup = strings[2];

// push - O(1)
strings.Push("e");
Console.WriteLine("After push");
Console.WriteLine("-----------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(strings));

// pop - 0(1)
strings.Pop();
strings.Pop();
Console.WriteLine("After pop");
Console.WriteLine("-----------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(strings));

// unshift - insert - O(n)
strings.Unshift("x");
Console.WriteLine("After unshift");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(strings));

// splice - delete - O(n)
strings.Splice(2, 0, "alien");
Console.WriteLine("After splice");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(strings));

// Merge sorted arrays
var mergeSortedArray = new MergeSortedArrays([0, 3, 4, 31], [4, 6, 30]);
Console.WriteLine("Merge sorted array");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(mergeSortedArray.Execute()));

// Two sum
var twoSum = new TwoSum([3, 2, 4], 6);
Console.WriteLine("Two sum");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(twoSum.Execute()));

// Max subarray
var maxSubArray = new MaximumSubArray([-2, 1, -3, 4, -1, 2, 1, -5, 4]);
Console.WriteLine("Max subarray");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(maxSubArray.Execute()));
Console.WriteLine(maxSubArray.AlterExecute());

// Max subarray
var movingZeoes = new MovingZeroes([0, 1, 0, 3, 12]);
Console.WriteLine("Moving zeroes");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(movingZeoes.Execute()));

// Max subarray
var hasDuplicates = new ContainsDuplicate([1, 2, 3, 1]);
Console.WriteLine("Contains duplicates");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(hasDuplicates.Execute()));

// Rotate array
var rotateArray = new RotateArray([1, 2, 3, 4, 5, 6, 7], 9);
Console.WriteLine("Rotate array");
Console.WriteLine("------------------------------------------");
Console.WriteLine(JsonSerializer.Serialize(rotateArray.Execute()));