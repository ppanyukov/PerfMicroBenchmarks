namespace SourceInclude
{
    using System;
    using System.IO;

    // Prints out the runtime information to stdout (the specified text writer).
    // Include this in your project as source.
    public static class RuntimeConfiguration
    {
        public static void PrintRunConfig(TextWriter stdout)
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
            #else
                    "WARNING: Undefined: Define PlatformAnyCPU, Platform86, or Platform64 compile-time constants in project.";
            #endif
            #endif
            #endif

            stdout.WriteLine("========= Running on ===========");
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
                stdout.WriteLine("\t{0}: {1}", @var, Environment.GetEnvironmentVariable(@var));
            }
            stdout.WriteLine();
            stdout.WriteLine("========= Compiled as ===========");
            stdout.WriteLine("\tConfiguration: {0}", configuration);
            stdout.WriteLine("\tPlatform: {0}", platform);

            stdout.WriteLine("================================");
            stdout.WriteLine();
        }
    }
}
