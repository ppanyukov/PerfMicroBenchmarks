namespace SerializationBenchmarks
{
    #region Using Directives

    using System;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.Serialization;

    using PerfBenchmarksUtil;

    #endregion

    /// <summary>
    /// Benchmarks for How fast can we create objects in different ways:
    /// - direct ctor
    /// - FormatterServices.GetUninitializedObject
    /// - Reflection :)
    /// </summary>
    public sealed class ObjectCreationBenchmarks
    {
        #region Public Methods

        public void Run()
        {
            Console.WriteLine("Benchmarks for how quickly we can create objects using different methods.");

            Console.WriteLine("Warmup");
            RunInternal(isWarmup: true);

            Console.WriteLine("Real run");
            RunInternal(isWarmup: false);
        }

        #endregion

        #region Methods

        private static void RunInternal(bool isWarmup)
        {
            var spoiler = 0;

            {
                var iterations = isWarmup ? 1000 : 1000 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    var z = new SomeClass(i);
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("Ctor direct. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            {
                var iterations = isWarmup ? 1000 : 1000 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    var z = SomeClassCtorMethod(i);
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("Ctor via a method call. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            {
                // Fewer iterations for this as this runs for much longer
                var iterations = isWarmup ? 1000 : 100 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    // Does not require any ctor. Ctor is not called.
                    var z = (SomeClass)FormatterServices.GetUninitializedObject(typeof(SomeClass));
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("FormatterServices.GetUninitializedObject. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            {
                // Fewer iterations for this as this runs for much longer
                var iterations = isWarmup ? 1000 : 100 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    // Requires default public ctor
                    var z = Activator.CreateInstance<SomeClass>();
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("Activator.CreateInstance<SomeClass>. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            {
                // Fewer iterations for this as this runs for much longer
                var iterations = isWarmup ? 1000 : 100 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    // Requires default public ctor
                    var z = (SomeClass)Activator.CreateInstance(typeof(SomeClass));
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("Activator.CreateInstance. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            {
                var t = typeof(SomeClass);
                var ctor = t.GetConstructor(BindingFlags.Instance | BindingFlags.Public, binder: null, types: new Type[0], modifiers: new ParameterModifier[0]);
                
                // Fewer iterations for this as this runs for much longer
                var iterations = isWarmup ? 1000 : 100 * 1000 * 1000;
                var sw = new Stopwatch();
                sw.Start();
                for (var i = 0; i < iterations; i++)
                {
                    // Requires default public ctor
                    var z = (SomeClass)ctor.Invoke(new object[0]);
                    spoiler += z.Value;
                }
                sw.Stop();
                Console.WriteLine("Reflection invoke ctor. Iterations: {0:N0}. Elapsed: {1}. Ops/sec: {2:N0}", iterations, sw.Elapsed, sw.OpsPerSecond(iterations));
            }

            Console.WriteLine("Spoiler value: {0}", spoiler);
        }

        private static SomeClass SomeClassCtorMethod(int i)
        {
            return new SomeClass(i);
        }

        #endregion

        private class SomeClass
        {
            #region Constants and Fields

            private readonly int value;

            #endregion

            #region Constructors and Destructors

            public SomeClass(int value)
            {
                this.value = value;
            }

            // For activator
            public SomeClass()
            {
                
            }

            #endregion

            #region Public Properties

            public int Value
            {
                get
                {
                    return this.value;
                }
            }

            #endregion
        }
    }
}