using System;
using System.Diagnostics;

namespace TestEngineLibrary.Common
{

    public abstract class TestBase
    {
        private string Name { get; }

        protected TestBase(string name)
        {
            Name = name;
        }

        public void Run()
        {
            var startedTime = DateTime.Now;
            Console.WriteLine($"Test: {Name} started at: {startedTime}");
            bool isSuccessfully = false;
            var st = Stopwatch.StartNew();
            try
            {
                isSuccessfully = DoWork();
                st.Stop();
            }
            catch (NotImplementedException)
            {
                Console.WriteLine($"Test: {Name} not implemented.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Test: {Name} throw an error:");
                Console.WriteLine(e);
            }

            var resultText = isSuccessfully ? "+" : "-";
            Console.WriteLine($"Test: {Name} finished {resultText}: {st.Elapsed}{Environment.NewLine}");
        }

        protected abstract bool DoWork();

    }
}