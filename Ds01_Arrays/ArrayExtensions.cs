namespace Ds01.Arrays;

public static class ArrayExtensions
{
    public static void Push<T>(this List<T> arr, T item)
    {
        arr.Add(item);
    }
    
    public static T Pop<T>(this List<T> arr)
    {
        var length = arr.Count;
        var toPop = arr[length - 1];
        arr.RemoveAt(length - 1);
        return toPop;
    }

    public static void Unshift<T>(this List<T> arr, T item)
    {
        arr.Insert(0, item);
    }

    public static List<T> Splice<T>(this List<T> arr, int start, int deleteCount, T item)
    {
        var deleted = new List<T>();
        for (var i = start + 1; i < arr.Count && deleteCount > 0; i++, deleteCount--)
        {
            deleted.Add(arr[i]);
            arr.RemoveAt(i);
        }
        
        arr.Insert(start, item);
        
        return deleted;
    }
}