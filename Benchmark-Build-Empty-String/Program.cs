using BenchmarkDotNet.Running;
using String_Build;

internal class Program
{
    private static void Main(string[] args)
    {
        BenchmarkRunner.Run<Test>();
    }
}