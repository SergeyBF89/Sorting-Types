using static System.Console;
public static class Infastructure
{
    public static int[] CreateArray(this int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
                .Select(item => Random.Shared.Next(min, max))
                .ToArray();
    }
    public static int[] Show(this int[] array, string separator = ",")
    {
        string output = String.Join(separator, array);
        WriteLine($"[{output}]");
        return array;
    }
}
    