namespace PerfBenchmarksUtil
{
    using System.Diagnostics;

    public static class StopwatchExtensions
    {
        /// <summary>
        /// Calculate ops per second as a number.
        /// </summary>
        public static double OpsPerSecond(this Stopwatch sw, int iterations)
        {
            return sw.Elapsed.Ticks == 0 ? 0 : iterations / sw.Elapsed.TotalSeconds;
        }
    }
}