namespace Alg01.Recursions.Exercises;

public class Permutations(string input)
{
    private static void Recurse(string str, string answer, List<string> permutations)
    {
        // Console.WriteLine($"{str} - {answer}");
        if (string.IsNullOrEmpty(str))
        {
            permutations.Add(answer);
            return;
        }
        
        for(var i = 0 ;i < str.Length; i++)
        {
            var ch = str[i];
            var leftSubstr = str.Substring(0, i);
            var rightSubstr = str.Substring(i + 1);
            var rest = leftSubstr + rightSubstr;
            Recurse(rest, answer + ch, permutations);
        }
    }

    private static IEnumerable<string> Recurse(string str)
    {
        if (str.Length == 2)
        {
            yield return str;
            yield return $"{str[1]}{str[0]}";
        }

        var clone = $"{str}";
        var length = str.Length;
        for (var i = 0; i < length; i++)
        {
            var right = clone.Substring(1);
            foreach (var permutations in Recurse(right))
            {
                yield return $"{clone[0]}{permutations}";
            }
            
            clone = $"{right}{clone[0]}";
        }
    }
    
    public List<string> Execute()
    {
        var permutations = new List<string>();
        permutations.AddRange(Recurse(input));
        // Recurse(input, "", permutations);
        return permutations;
    }
}