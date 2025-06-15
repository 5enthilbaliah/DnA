namespace Ds02.HashTables;

public class FirstRecurringCharacter(int[] arr)
{
    public int? Execute()
    {
        var hash = new HashSet<int>();

        foreach (var item in arr)
        {
            if (!hash.Add(item))
                return item;
        }
        
        return null;
    }
}