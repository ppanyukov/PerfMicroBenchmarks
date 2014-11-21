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
            // Ticks are not nanoseconds.
            var tickFrequency = Stopwatch.Frequency;
            var ticks = sw.ElapsedTicks;
            var opsPerSecondNano = ((long)iterations * (long)tickFrequency) / ticks;
            return opsPerSecondNano;
        }
    }
}