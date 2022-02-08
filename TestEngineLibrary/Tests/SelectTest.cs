using System;
using TestEngineLibrary.Common;

namespace TestEngineLibrary.Tests
{

    public class SelectTest : TestBase
    {
        private SelectTest() : base(nameof(SelectTest))
        {
        }

        public static TestBase Create() => new SelectTest();

        protected override bool DoWork()
        {
            throw new NotImplementedException();
        }
    }
}