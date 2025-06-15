namespace Ds01.Arrays.Exercises;

public class MovingZeroes(int[] arr)
{
    public int[] Execute()
    {
        var result = new List<int>();
        result.AddRange(arr.Where(x => x > 0));
        var remaining = arr.Length - result.Count;
        for (var i = 1; i <= remaining; i++)
        {
            result.Add(0);
        }
        
        return result.ToArray();
    }
}