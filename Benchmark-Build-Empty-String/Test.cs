using BenchmarkDotNet.Attributes;

namespace String_Build
{
    [MemoryDiagnoser]
    [RankColumn]
    public class Test
    {
        [Benchmark]
        public void StringEmpty()
        {
            string a = StringBuild.StringEmpty();
        }
        [Benchmark]
        public void Quotes()
        {
            string a = StringBuild.Quotes();
        }
        [Benchmark]
        public void StringBulder()
        {
            string a = StringBuild.StringBulder();
        }
        [Benchmark]
        public void NewString()
        {
            string a = StringBuild.NewString();
        }
    }
}
