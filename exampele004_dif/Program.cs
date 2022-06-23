using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    private static void Main(string[] args)
    {
        double numberA = 18;
        double numberB = 5;
        Console.WriteLine(numberA / numberB);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}