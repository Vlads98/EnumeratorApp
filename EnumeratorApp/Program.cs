using TestEngineLibrary;
using TestEngineLibrary.Common;
using TestEngineLibrary.Tests;


var testEngine = new TestEngine(GetTests());

testEngine.RunTests();

static IEnumerable<Func<TestBase?>?> GetTests()
{
    yield return SelectTest.Create;
    yield return WhereTest.Create;
    yield return AggregateTest.Create;
}