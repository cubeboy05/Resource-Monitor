using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Collections.ObjectModel;

namespace ResourceMonitor
{
    /// <summary>
    /// A simple class that monitors the CPU Usage and RAM availability
    /// It triggers events accordingly and does calculations for the average figures and information for the chart updates
    /// Author: Karthik
    /// Date: 01/03/2014
    /// Version: 1.0
    /// </summary>
    class PerformanceMonitor
    {
        //creating an instance of class PerformanceStatistics
        PerformanceStatistics statistics = new PerformanceStatistics();
        //creating an instance of class DispatcherTimer
        DispatcherTimer timer = new DispatcherTimer();

        //creating 2 sets of ObservableCollection to store information on the cpu usage and ram availability
        //this information will be used to update the chart constantly
        public ObservableCollection<KeyValuePair<double, double>> cpuChartList = new ObservableCollection<KeyValuePair<double, double>>();
        public ObservableCollection<KeyValuePair<double, double>> ramChartList = new ObservableCollection<KeyValuePair<double, double>>();  

        //creating delegate and event to be used to handle cpu events
        public delegate void CPUEventHandler(object sender, CPUEventArgs args);
        public event CPUEventHandler CPUEvent;
        //creating delegate and event to be used to handle ram events
        public delegate void RAMEventHandler(object sender, RAMEventArgs args);
        public event RAMEventHandler RAMEvent;

        // static counter used to count number of seconds that has passed
        private static int counter;
        /// <summary>
        /// used to store current CPU Usage and current RAM availability
        /// </summary>
        private double cpuCurrent;
        private double ramCurrent;
        /// <summary>
        /// used to store total values at any point in time for CPU usage and RAM availability
        /// </summary>
        private double totalCPU;
        private double totalRAM; 

        /// <summary>
        /// Constructor 
        /// - set timer to tick every second
        /// - set the method timeChanged to fire off every time the second ticks
        /// - start timer
        /// </summary>
        public PerformanceMonitor() 
        {
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += TimeChanged;
            timer.Start();
        }

        /// <summary>
        /// Triggers the CPU event
        /// </summary>
        /// <param name="args">Event arguments</param>
        private void TriggerCPUEvent(CPUEventArgs args)
        {
            if (CPUEvent != null)
            {
                CPUEvent(this, args);
            }
        }
        /// <summary>
        /// Triggers the RAM event
        /// </summary>
        /// <param name="args">Event arguments</param>
        private void TriggerRAMEvent(RAMEventArgs args)
        {
            if (RAMEvent != null)
            {
                RAMEvent(this, args);
            }
        }

        /// <summary>
        /// used to update the cpuChartList and ramChartList
        /// used to trigger the CPU event and RAM event
        /// used to increment the counter variable which keep counts on how many seconds has passed
        /// </summary>
        private void TimeChanged(object sender, EventArgs e)
        {
            counter += 1; 
            //obtaining current seconds cpu usage and ram availability information
            cpuCurrent = statistics.GetCurrentCpuUsage();
            ramCurrent = statistics.GetCurrentAvailableRam();
            //trigger CPU and RAM events if they are not null value 
            TriggerCPUEvent(new CPUEventArgs(cpuCurrent, AverageCPUCalc()));
            TriggerRAMEvent(new RAMEventArgs(ramCurrent, AverageRAMCalc()));
            //calling the ram and cpu update methods to update the information for the chart
            CpuChartUpdate();
            RamChartUpdate(); 
        }

        /// <summary>
        /// used to find the average CPU usage  
        /// </summary>
        /// <returns>the average CPU usage per second</returns>
        private double AverageCPUCalc()
        {
            //adding up CPU usage for each second
            totalCPU += cpuCurrent;
            return totalCPU / counter;
        }
        /// <summary>
        /// used to find the average RAM available
        /// </summary>
        /// <returns>the average ram available per second</returns>
        private double AverageRAMCalc()
        {   
            //adding up current ram for each second
            totalRAM += ramCurrent;
            return totalRAM / counter; 
        }

        /// <summary>
        /// used to update information for cpu chart
        /// </summary>
        private void CpuChartUpdate()
        {
            //keep track of cpu usage information up to past 30 seconds
            if (cpuChartList.Count > 30)
            {   
                cpuChartList.RemoveAt(0);
            }
            //current time(in secs) and current cpu usage added to list
            //this data will be used to update cpu the chart
            cpuChartList.Add(new KeyValuePair<double, double>(counter, cpuCurrent));
        }    
        /// <summary>
        /// used to update information for ram chart
        /// </summary>
        private void RamChartUpdate()
        {
            //keep track of ram availability up to past 30 seconds
            if (ramChartList.Count > 30)
            {
                ramChartList.RemoveAt(0);
            }
            //current time(in secs) and current ram availability added to list
            //this data will be used to update the ram chart
            ramChartList.Add(new KeyValuePair<double, double>(counter, ramCurrent));
        }
    }
}
