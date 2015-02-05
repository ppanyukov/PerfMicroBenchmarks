namespace YieldBenchmarks
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using PerfBenchmarksUtil;

    using SourceInclude;

    class Program
    {
        private static Random rand = new Random(0);

        static void Main(string[] args)
        {
            RuntimeConfiguration.PrintRunConfig(Console.Out);

            Run("Warmup", 1000);
            Console.WriteLine();

            Run("Run 1", 100000);
            Console.WriteLine();

            Run("Run 2", 1000000);
            Console.WriteLine();
        }

        private static void Run(string name, int iterations)
        {
            var log = Console.Out;

            log.WriteLine("==== Run: {0} over {1:N0} iterations", name, iterations);

            {
                rand = new Random(0);
                var sw = new Stopwatch();
                sw.Start();
                var spoiler = LoopArrayFixed(iterations);
                sw.Stop();
                log.Write("LoopArrayFixed, {0:N0} iterations: ", iterations);
                log.WriteLine("{0} ({1:N0} ops/sec)", sw.Elapsed, sw.OpsPerSecond(iterations));
                log.WriteLine("Spoiler values: {0:N0}", spoiler);
            }

            {
                rand = new Random(0);
                var sw = new Stopwatch();
                sw.Start();
                var spoiler = LoopArrayFixed_ForLoop(iterations);
                sw.Stop();
                log.Write("LoopArrayFixed_ForLoop, {0:N0} iterations: ", iterations);
                log.WriteLine("{0} ({1:N0} ops/sec)", sw.Elapsed, sw.OpsPerSecond(iterations));
                log.WriteLine("Spoiler values: {0:N0}", spoiler);
            }

            {
                rand = new Random(0);
                var sw = new Stopwatch();
                sw.Start();
                var spoiler = LoopYieldFixed(iterations);
                sw.Stop();
                log.Write("LoopYieldFixed, {0:N0} iterations: ", iterations);
                log.WriteLine("{0} ({1:N0} ops/sec)", sw.Elapsed, sw.OpsPerSecond(iterations));
                log.WriteLine("Spoiler values: {0:N0}", spoiler);
            }
        }

        private static int LoopYieldFixed(int iterations)
        {
            var spoiler = 0;

            for (int i = 0; i < iterations; i++)
            {
                var items = StuffWithYieldFixed();
                foreach (var item in items)
                {
                    spoiler = spoiler ^ item;
                }
            }

            return spoiler;
        }

        private static int LoopArrayFixed(int iterations)
        {
            var spoiler = 0;

            for (int i = 0; i < iterations; i++)
            {
                var items = StuffWithArrayFixed();
                foreach (var item in items)
                {
                    spoiler = spoiler ^ item;
                }
            }

            return spoiler;
        }

        private static int LoopArrayFixed_ForLoop(int iterations)
        {
            var spoiler = 0;

            for (int i = 0; i < iterations; i++)
            {
                var items = StuffWithArrayFixed();
                for (int index = 0; index < items.Length; index++)
                {
                    var item = items[index];
                    spoiler = spoiler ^ item;
                }
            }

            return spoiler;
        }

        private static IEnumerable<int> StuffWithYieldFixed()
        {
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
            yield return rand.Next();
        }

        private static int[] StuffWithArrayFixed()
        {
            return new[]
            {
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
                rand.Next(),
            };
        }
    }
}
