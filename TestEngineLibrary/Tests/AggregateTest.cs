using TestEngineLibrary.Common;

namespace TestEngineLibrary.Tests;

public class AggregateTest : TestBase
{
    private AggregateTest() : base(nameof(AggregateTest))
    {
    }

    public static TestBase Create() => new AggregateTest();

    protected override bool DoWork()
    {
        throw new NotImplementedException();
    }
}