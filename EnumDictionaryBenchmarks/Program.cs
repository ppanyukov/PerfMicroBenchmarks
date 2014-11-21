namespace EnumDictionaryBenchmarks
{
    static class Program
    {
        static void Main(string[] args)
        {
            var test = new BenchmarkTests();
            test.GetValueTests();
        }
    }
}