namespace Alg01.Recursions.Exercises;

public class Fibonacci(int num)
{
    private static int Recurse(int n, Dictionary<int, int> memoize)
    {
        if (n < 2)
            return n;
        
        if (memoize.TryGetValue(n, out var recurse))
            return recurse;

        var n1 = Recurse(n - 1, memoize);
        memoize[n - 1] = n1;
        var n2 = Recurse(n - 2, memoize);
        memoize[n - 2] = n2;
        
        return n1 + n2;
    }
    
    public int Execute()
    {
        return Recurse(num, new Dictionary<int, int>());
    }
}