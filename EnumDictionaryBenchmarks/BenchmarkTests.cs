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
        private const string ValueToUse = "some string value";

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
            ValueToUse,
            ValueToUse,
            ValueToUse,
            ValueToUse,
            ValueToUse,
        };

        private readonly Dictionary<EnumNumbers, string> StorageMapEnum = new Dictionary<EnumNumbers, string>()
        {
            {EnumNumbers.Zero, ValueToUse},
            {EnumNumbers.One, ValueToUse},
            {EnumNumbers.Two, ValueToUse},
            {EnumNumbers.Three, ValueToUse},
            {EnumNumbers.Four, ValueToUse},
        };

        private readonly Dictionary<string, string> StorageMapString = new Dictionary<string, string>()
        {
            {"0", ValueToUse},
            {"1", ValueToUse},
            {"2", ValueToUse},
            {"3", ValueToUse},
            {"4", ValueToUse},
        };

        private readonly Dictionary<byte, string> StorageMapByte = new Dictionary<byte, string>()
        {
            {0, ValueToUse},
            {1, ValueToUse},
            {2, ValueToUse},
            {3, ValueToUse},
            {4, ValueToUse},
        };


        /// <summary>
        /// The actual tests.
        /// </summary>
        private void GetValueTests(int iterations, string label="")
        {
            Console.WriteLine("Iterations: {0:N} {1}", iterations, label);

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
        }

        /// <summary>
        /// Calculate ops per second as a formatted string.
        /// </summary>
        public static string OpsPerSecond(int iterations, Stopwatch sw)
        {
            return string.Format("({0:N0}) ops/sec", sw.OpsPerSecond(iterations));
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
            }
            sw.Stop();

            return sw;
        }

        private void PrintRunConfig()
        {
            const string configuration = 
            #if DEBUG 
                    "Debug";
            #else
                    "Release";
            #endif


            const string platform = 
            #if PlatformAnyCPU
                    "AnyCPU";
            #else
            #if Platform86
                    "x86";
            #else
            #if Platform64
                    "x64";
            #endif
            #endif
            #endif

            Console.WriteLine("========= Running on ===========");
            var vars = new []
            {
                "PROCESSOR_ARCHITECTURE",
                "PROCESSOR_IDENTIFIER",
                "PROCESSOR_LEVEL",
                "PROCESSOR_REVISION",
                "NUMBER_OF_PROCESSORS",
                "FrameworkVersion",
                "FrameworkVersion32",
            };
            foreach (var @var in vars)
            {
                Console.WriteLine("\t{0}: {1}", @var, Environment.GetEnvironmentVariable(@var));
            }
            Console.WriteLine();
            Console.WriteLine("========= Compiled as ===========");
            Console.WriteLine("\tConfiguration: {0}", configuration);
            Console.WriteLine("\tPlatform: {0}", platform);

            Console.WriteLine("================================");
            Console.WriteLine();
        }
    }
}
