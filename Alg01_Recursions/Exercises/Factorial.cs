namespace Alg01.Recursions.Exercises;

public class Factorial(int num)
{
    private static int Recurse(int n)
    {
        if (n == 1) return 1;
        return n * Recurse(n - 1);
    }
    
    
    public int Execute()
    {
        return Recurse(num);
    }
}