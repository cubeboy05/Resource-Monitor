using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ResourceMonitor
{
    /// <summary>
    /// A simple class that provides easy access to statistical information about the computer system.
    /// Author: Francis Williams
    /// Reference: Angel.king.47 - Stackoverflow
    /// Date: 16/12/2012
    /// Version: 1.0
    /// </summary>
    class PerformanceStatistics
    {
        /// <summary>
        /// A PerformanceCounter instance. Used for gathering data about the CPU performance.
        /// </summary>
        private PerformanceCounter cpuCounter;
        /// <summary>
        /// A PerformanceCounter instance. Used for gathering data about the amount of available RAM.
        /// </summary>
        private PerformanceCounter ramCounter;

        /// <summary>
        /// Constructor, Initialises the two instances of PerformanceCounter.
        /// </summary>
        public PerformanceStatistics()
        {
            cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            ramCounter = new PerformanceCounter("Memory", "Available MBytes");
        }

        /// <summary>
        /// A method that returns a percentage value of the current CPU load.
        /// </summary>
        /// <returns>The Current CPU Load</returns>
        public float GetCurrentCpuUsage()
        {
            return cpuCounter.NextValue();
        }

        /// <summary>
        /// A method that returns the amount of available memory in MB
        /// </summary>
        /// <returns>the Current Available Memory</returns>
        public float GetCurrentAvailableRam()
        {
            return ramCounter.NextValue();
        }
    }
}
