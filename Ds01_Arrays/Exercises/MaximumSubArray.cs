namespace Ds01.Arrays.Exercises;

using System.Collections;

public class MaximumSubArray(int[] arr)
{
    public int[] Execute()
    {
        if (arr.All(x => x >= 0))
            return arr;

        if (arr.All(x => x < 0))
            return [arr.OrderByDescending(x => x).First()];
        
        return Enumerable.Range(0, arr.Length)
            .SelectMany(oIdx => Enumerable.Range(oIdx, arr.Length - oIdx)
                .Select(iIdx => arr.Skip(oIdx).Take(iIdx + 1).ToArray())
            ).OrderByDescending(x => x.Sum())
            .First();
    }

    public int AlterExecute()
    {
        var size = arr.Length;
        var maxSoFar = int.MinValue;
        var maxEndingHere = 0;

        for (var i = 0; i < size; i++)
        {
            maxEndingHere = maxEndingHere + arr[i];
            
            if (maxSoFar < maxEndingHere)
                maxSoFar = maxEndingHere;

            if (maxEndingHere < 0)
                maxEndingHere = 0;
        }
        
        return maxSoFar;
    }
}