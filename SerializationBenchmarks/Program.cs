namespace SerializationBenchmarks
{
    using System;

    internal static class Program
    {
        public static void Main(string[] args)
        {
            SourceInclude.RuntimeConfiguration.PrintRunConfig(Console.Out);
            var test = new ObjectCreationBenchmarks();
            test.Run();
        }
    }
}