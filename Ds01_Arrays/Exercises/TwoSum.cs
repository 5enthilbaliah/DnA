namespace Ds01.Arrays.Exercises;

public class TwoSum(int[] arr, int sum)
{
    public int[] Execute()
    {
        var result = new List<int>();
        
        // Just for fun
        var res = Enumerable.Range(0, arr.Length - 1)
            .SelectMany(oIdx => Enumerable.Range(oIdx + 1, arr.Length - oIdx - 1)
                .Where(iIdx => arr[oIdx] + arr[iIdx] == sum)
                .Select(iIdx => new [] { oIdx, iIdx})
            ).FirstOrDefault();
        
        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] != sum) continue;
                result.Add(i);
                result.Add(j);
                break;
            }
        }

        return result.ToArray();
    }
}