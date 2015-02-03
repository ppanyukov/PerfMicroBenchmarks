namespace EnumDictionaryBenchmarks
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;

    using NUnit.Framework;

    using PerfBenchmarksUtil;

    [TestFixture]
    public sealed class BenchmarkTests
    {
        /// <summary>
        /// A string value we will use in our tests, non-constant, generated using DateTime.Now
        /// so that compiler cannot predict the string lengths and other things to optimise
        /// away our benchmarks and loops.
        /// </summary>
        private static string ValueToUse()
        {
            return DateTime.Now.ToString();
        }

        /// <summary>
        /// We will use this spoiler to increment values to these during our tests to spoof the compiler and prevent any kind of optimisations.
        /// </summary>
        private static long spoiler;

        [Test]
        public void GetValueTests()
        {
            this.PrintRunConfig();
            this.GetValueTests(1000, "(warmup)");
            this.GetValueTests(1000000);
            this.GetValueTests(10000000);
            this.GetValueTests(100000000);
        }

        private enum EnumNumbers : byte
        {
            Zero = 0,
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4,
        }

        private string[] StorageArray = new[]
        {
            ValueToUse(),
            ValueToUse(),
            ValueToUse(),
            ValueToUse(),
            ValueToUse(),
        };

        private readonly Dictionary<EnumNumbers, string> StorageMapEnum = new Dictionary<EnumNumbers, string>()
        {
            {EnumNumbers.Zero, ValueToUse()},
            {EnumNumbers.One, ValueToUse()},
            {EnumNumbers.Two, ValueToUse()},
            {EnumNumbers.Three, ValueToUse()},
            {EnumNumbers.Four, ValueToUse()},
        };

        private readonly Dictionary<string, string> StorageMapString = new Dictionary<string, string>()
        {
            {"0", ValueToUse()},
            {"1", ValueToUse()},
            {"2", ValueToUse()},
            {"3", ValueToUse()},
            {"4", ValueToUse()},
        };

        private readonly Dictionary<byte, string> StorageMapByte = new Dictionary<byte, string>()
        {
            {0, ValueToUse()},
            {1, ValueToUse()},
            {2, ValueToUse()},
            {3, ValueToUse()},
            {4, ValueToUse()},
        };


        /// <summary>
        /// The actual tests.
        /// </summary>
        private void GetValueTests(int iterations, string label="")
        {
            Console.WriteLine("Iterations: {0:N0} {1}", iterations, label);

            {
                var name = "EmptyMethodCall";
                var sw = this.EmptyMethodCall(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            {
                var name = "LoopGetValueArray";
                var sw = this.LoopGetValueArray(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            {
                var name = "LoopGetValueArray_WithMethodCall";
                var sw = this.LoopGetValueArray_WithMethodCall(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            {
                var name = "LoopGetValueMapEnum";
                var sw = this.LoopGetValueMapEnum(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            {
                var name = "LoopGetValueMapString";
                var sw = this.LoopGetValueMapString(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            {
                var name = "LoopGetValueMapByte";
                var sw = this.LoopGetValueMapByte(iterations);
                Console.WriteLine("\t{0}: {1} {2}", name, sw.Elapsed, OpsPerSecond(iterations, sw));
            }

            Console.WriteLine();
            Console.WriteLine("Spoiler values: {0:N0}", spoiler);
        }

        /// <summary>
        /// Calculate ops per second as a formatted string.
        /// </summary>
        public static string OpsPerSecond(int iterations, Stopwatch sw)
        {
            return string.Format("({0:N0}) ops/sec", sw.OpsPerSecond(iterations));
        }

        private Stopwatch EmptyMethodCall(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();

            sw.Stop();

            return sw;
        }

        private Stopwatch LoopGetValueArray(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var v0 = this.StorageArray[(int)EnumNumbers.Zero];
                var v1 = this.StorageArray[(int)EnumNumbers.One];
                var v2 = this.StorageArray[(int)EnumNumbers.Two];
                var v3 = this.StorageArray[(int)EnumNumbers.Three];
                var v4 = this.StorageArray[(int)EnumNumbers.Four];

                // Compiler spoiler
                spoiler = spoiler + v0.Length + v1.Length + v2.Length + v3.Length + v4.Length;
            }
            sw.Stop();

            return sw;
        }

        private Stopwatch LoopGetValueArray_WithMethodCall(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var v0 = this.GetValueFromArray((int)EnumNumbers.Zero);
                var v1 = this.GetValueFromArray((int)EnumNumbers.One);
                var v2 = this.GetValueFromArray((int)EnumNumbers.Two);
                var v3 = this.GetValueFromArray((int)EnumNumbers.Three);
                var v4 = this.GetValueFromArray((int)EnumNumbers.Four);

                // Compiler spoiler
                spoiler = spoiler + v0.Length + v1.Length + v2.Length + v3.Length + v4.Length;
            }
            sw.Stop();

            return sw;
        }

        private string GetValueFromArray(int index)
        {
            return this.StorageArray[index];
        }

        private Stopwatch LoopGetValueMapEnum(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var v0 = this.StorageMapEnum[EnumNumbers.Zero];
                var v1 = this.StorageMapEnum[EnumNumbers.One];
                var v2 = this.StorageMapEnum[EnumNumbers.Two];
                var v3 = this.StorageMapEnum[EnumNumbers.Three];
                var v4 = this.StorageMapEnum[EnumNumbers.Four];

                // Compiler spoiler
                spoiler = spoiler + v0.Length + v1.Length + v2.Length + v3.Length + v4.Length;
            }
            sw.Stop();

            return sw;
        }

        private Stopwatch LoopGetValueMapString(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var v0 = this.StorageMapString["0"];
                var v1 = this.StorageMapString["1"];
                var v2 = this.StorageMapString["2"];
                var v3 = this.StorageMapString["3"];
                var v4 = this.StorageMapString["4"];

                // Compiler spoiler
                spoiler = spoiler + v0.Length + v1.Length + v2.Length + v3.Length + v4.Length;
            }
            sw.Stop();

            return sw;
        }

        private Stopwatch LoopGetValueMapByte(int iterations)
        {
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                var v0 = this.StorageMapByte[(byte)EnumNumbers.Zero];
                var v1 = this.StorageMapByte[(byte)EnumNumbers.One];
                var v2 = this.StorageMapByte[(byte)EnumNumbers.Two];
                var v3 = this.StorageMapByte[(byte)EnumNumbers.Three];
                var v4 = this.StorageMapByte[(byte)EnumNumbers.Four];

                // Compiler spoiler
                spoiler = spoiler + v0.Length + v1.Length + v2.Length + v3.Length + v4.Length;
            }
            sw.Stop();

            return sw;
        }

        private void PrintRunConfig()
        {
            SourceInclude.RuntimeConfiguration.PrintRunConfig(Console.Out);
        }
    }
}
