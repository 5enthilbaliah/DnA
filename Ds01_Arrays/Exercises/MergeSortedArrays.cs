namespace Ds01.Arrays.Exercises;

public class MergeSortedArrays(int [] arr1, int[] arr2)
{
    public int[] Execute()
    {
        var result = new List<int>();
        var arr1Idx = 0;
        var arr2Idx = 0;

        while (arr1Idx < arr1.Length || arr2Idx < arr2.Length)
        {
            if (arr2Idx >= arr2.Length || arr1[arr1Idx] < arr2[arr2Idx])
            {
                result.Add(arr1[arr1Idx]);
                arr1Idx++;
                continue;
            }
            
            result.Add(arr2[arr2Idx]);
            arr2Idx++;
        }
        
        return result.ToArray();
    }
}