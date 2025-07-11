namespace GenericMathSupport;

internal class Program
{
    static void Main(string[] args)
    {
        var arnold = new Mathinator();
        //var sum = arnold.SumArray(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }); 
        var sum = arnold.SumArray(new[] { 1, 2, 3, 4.5, 5, 6.2, 7, 8.3, 9 });

        Console.WriteLine(sum);
        Console.ReadLine();
    }
}
