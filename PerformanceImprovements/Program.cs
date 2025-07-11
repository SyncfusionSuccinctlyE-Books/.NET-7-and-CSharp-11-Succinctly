using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace PerformanceImprovements;

public class Program
{
    static void Main(string[] args) => BenchmarkRunner.Run<Bench>();    
}

[MemoryDiagnoser(displayGenColumns: false)]
[DisassemblyDiagnoser]
[HideColumns("Error", "StdDev", "Median", "RatioSD")]
public class Bench
{

    #region Existing Operations
    private IEnumerable<float> _randFloats = CreateRandomFloats();

    [Benchmark]
    public float Min() => _randFloats.Min();

    [Benchmark]
    public float Max() => _randFloats.Max();

    [Benchmark]
    public float Average() => _randFloats.Average();

    [Benchmark]
    public float Sum() => _randFloats.Sum();

    private static float[] CreateRandomFloats()
    {
        var r = new Random(45);
        var results = new float[100_000];
        for (int i = 0; i < results.Length; i++)
        {
            results[i] = (float)r.NextDouble();
        }
        return results;
    }
    #endregion

    #region The New Order Method
    //[Params(1024)]
    //public int Length { get; set; }

    //private int[] _intArray;

    //[GlobalSetup]
    //public void Setup() => _intArray = Enumerable.Range(1, Length).Reverse().ToArray();

    //[Benchmark(Baseline = true)]
    //public void OrderBy()
    //{
    //    foreach (int _ in _intArray.OrderBy(x => x)) { }
    //}

    //[Benchmark]
    //public void Order()
    //{
    //    foreach (int _ in _intArray.Order()) { }
    //}
    #endregion

    #region JSON

    //private JsonSerializerOptions _options = new JsonSerializerOptions();
    //private StudentPoco _student = new StudentPoco();

    //[Benchmark(Baseline = true)]
    //public string ImplicitOptions() => JsonSerializer.Serialize(_student);

    //[Benchmark]
    //public string WithCached() => JsonSerializer.Serialize(_student, _options);

    //[Benchmark]
    //public string WithoutCached() => JsonSerializer.Serialize(_student, new JsonSerializerOptions());

    #endregion

}

public class StudentPoco
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}