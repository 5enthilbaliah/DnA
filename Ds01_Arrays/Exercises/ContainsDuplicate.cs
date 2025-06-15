namespace Ds01.Arrays.Exercises;

public class ContainsDuplicate(int[] arr)
{
    public bool Execute()
    {
        var hash = new HashSet<int>();

        return arr.Any(item => !hash.Add(item));

        // return arr.GroupBy(x => x)
        //     .Any(x => x.Count() > 1);
    }
}