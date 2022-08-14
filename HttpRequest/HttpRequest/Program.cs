using BenchmarkDotNet.Running;

namespace HttpRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<BenchmarkTest>();
        }
    }
}