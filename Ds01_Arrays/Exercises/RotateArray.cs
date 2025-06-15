namespace Ds01.Arrays.Exercises;

public class RotateArray(int[] arr, int rotations)
{
    private int _rotations = rotations;

    public int[] Execute()
    {
        var length = arr.Length;
        if (_rotations >= length)
            _rotations -= length;
        
        if (_rotations == 0)
            return arr;
        
        var result = new List<int>();
        var stack = new Stack<int>();
        for (var rep = 1; rep <= _rotations; rep++)
        {
            stack.Push(arr[length - rep]);
        }
        
        while (stack.Count > 0)
        {
            result.Add(stack.Pop());
        }

        // for (var i = length - _rotations; i < length; i++)
        // {
        //     result.Add(arr[i]);
        // }
        
        for (var i = 0; i < length - _rotations; i++)
        {
            result.Add(arr[i]);
        }
        
        return result.ToArray();
    }
}