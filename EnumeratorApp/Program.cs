using System;
using System.Collections.Generic;
using TestEngineLibrary;
using TestEngineLibrary.Common;
using TestEngineLibrary.Tests;


public class Programm 
{
    public static void Main()
    {
        var testEngine = new TestEngine(GetTests());

        testEngine.RunTests();

        
    }
    public static IEnumerable<Func<TestBase>> GetTests()
    {
        yield return SelectTest.Create;
        yield return WhereTest.Create;
        yield return AggregateTest.Create;
    }
}

