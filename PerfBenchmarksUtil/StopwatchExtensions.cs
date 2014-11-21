namespace PerfBenchmarksUtil
{
    using System.Diagnostics;

    public static class StopwatchExtensions
    {
        /// <summary>
        /// Calculate ops per second as a formatted string.
        /// </summary>
        public static long OpsPerSecond(this Stopwatch sw, int iterations)
        {
            // Nanosecond precision
            var opsPerSecondNano = ((long)iterations * (long)1000L * (long)1000L * (long)1000L) / sw.ElapsedTicks;
            return opsPerSecondNano;
        }
    }
}