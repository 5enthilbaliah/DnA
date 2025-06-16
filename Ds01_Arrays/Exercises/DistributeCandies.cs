namespace Ds01.Arrays.Exercises;

public class DistributeCandies(int [] candyTypes)
{
    public int Execute()
    {
        var length = candyTypes.Length;
        if (length % 2 != 0)
            throw new ArgumentException("length must be even");
        
        var maxCandiesToEat = candyTypes.Length / 2;
        var candyHash = new HashSet<int>();
        var actualCandiesToEat = 0;

        for (var i = 0; i < candyTypes.Length && actualCandiesToEat < maxCandiesToEat; i++)
        {
            if (candyHash.Add(candyTypes[i]))
                actualCandiesToEat++;
        }
        
        return actualCandiesToEat;
    }
}