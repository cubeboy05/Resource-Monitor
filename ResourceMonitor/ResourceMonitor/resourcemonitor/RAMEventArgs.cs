using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResourceMonitor
{
    class RAMEventArgs
    {
        /// <summary>
        /// used to store value for current RAM availability
        /// </summary>
        private double _currentRAM;
        /// <summary>
        /// used to store value for average RAM availability
        /// </summary>
        private double _averageRAM;

        /// <summary>
        /// encapsulation for _currentRAM
        /// </summary>
        public double CurrentRAM
        {
            get { return _currentRAM; }
            set { _currentRAM = value; }
        }
        /// <summary>
        /// encapsulation for _averageRAM
        /// </summary>
        public double AverageRAM
        {
            get { return _averageRAM; }
            set { _averageRAM = value; }
        }

        /// <summary>
        /// constructor - set values for current RAM and average RAM available 
        /// </summary>
        /// <param name="currentRAM">used to set value for current ram available</param>
        /// <param name="averageRAM">used to set value for average ram available</param>
        public RAMEventArgs(double currentRAM, double averageRAM)
        {
            CurrentRAM = currentRAM;
            AverageRAM = averageRAM;
        }
    }
}
