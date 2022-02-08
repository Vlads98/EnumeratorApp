using System;
using TestEngineLibrary.Common;

namespace TestEngineLibrary.Tests
{

    public class WhereTest : TestBase
    {
        private WhereTest() : base(nameof(WhereTest))
        {
        }


        public static TestBase Create() => new WhereTest();

        protected override bool DoWork()
        {
            throw new NotImplementedException();
        }
    }
}