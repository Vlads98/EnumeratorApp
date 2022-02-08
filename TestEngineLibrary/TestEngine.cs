using TestEngineLibrary.Common;

namespace TestEngineLibrary;

public class TestEngine

{
    private readonly IReadOnlyCollection<Func<TestBase?>> _testBases;

    public TestEngine(IEnumerable<Func<TestBase?>?> testBases)
    {
        _testBases = testBases.Where(x => x != null).ToList()!;
    }


    public void RunTests()
    {
        Console.WriteLine($"Hello to enumerator test engine.{Environment.NewLine}");

        foreach (var creator in _testBases)
        {
            try
            {
                var test = creator();
                test?.Run();
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}{Environment.NewLine}");
            }
        }

        Console.WriteLine("All tests completed");
    }
}