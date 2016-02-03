using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceMonitor
{
    class CPUEventArgs
    {
        /// <summary>
        /// used to store value for current CPU usage 
        /// </summary>
        private double _currentCPU;
        /// <summary>
        /// used to store value for average CPU usage
        /// </summary>
        private double _averageCPU;

        /// <summary>
        /// encapsulation for _currentCPU
        /// </summary>
        public double CurrentCPU
        {
            get { return _currentCPU; }
            set { _currentCPU = value; }
        }
        /// <summary>
        /// encapsulation for _averageCPU
        /// </summary>
        public double AverageCPU
        {
            get { return _averageCPU; }
            set { _averageCPU = value; }
        }

        /// <summary>
        /// constructor - set values for current and average cpu usage
        /// </summary>
        /// <param name="currentCPU">used to set value for current cpu usage</param>
        /// <param name="averageCPU">used to set value for average cpu usage</param>
        public CPUEventArgs(double currentCPU, double averageCPU) 
        {
            CurrentCPU = currentCPU;
            AverageCPU = averageCPU; 
        }
    }
}
