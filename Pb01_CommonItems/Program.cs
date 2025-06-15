// See https://aka.ms/new-console-template for more information

Console.WriteLine($"{ContainsCommonItems(['a', 'b', 'c', 'x'],
    ['z', 'y', 'a'])}");

Console.ReadLine();
return;

static bool ContainsCommonItems(char[] arr1, char[] arr2)
{
    var hash = new HashSet<char>(arr1);
    return arr2.Any(x => hash.Contains(x));
}
    