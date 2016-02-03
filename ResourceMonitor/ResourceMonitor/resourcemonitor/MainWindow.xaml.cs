using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls.DataVisualization.Charting;
using System.Windows.Media.Animation;

namespace ResourceMonitor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //creating new instance of PerformanceMonitor
        PerformanceMonitor resource = new PerformanceMonitor();
        public MainWindow()
        {
            InitializeComponent();
            //fire off the CPUHandler and RAMHandler methods everytime the CPUEvent and RAMEvents fires off
            resource.CPUEvent += CPUHandler;
            resource.RAMEvent += RAMHandler;
            //method to start showing the line charts 
            ShowLineChart();
        }
        /// <summary>
        /// Setting data for line chart for CPU usage and RAM availability respectively
        /// </summary>
        public void ShowLineChart() 
        {
            cpulineChart.DataContext = resource.cpuChartList;
            ramlineChart.DataContext = resource.ramChartList;
        }

        /// <summary>
        /// GUI label outputs for Current CPU and Average CPU 
        /// GUI warning output for exceeding CPU Usage threshold
        /// </summary>
        void CPUHandler(object sender, CPUEventArgs args)
        {
            label6.Content = string.Format("{0:0}", args.CurrentCPU.ToString("0.##") + " %");
            label8.Content = string.Format("{0}", args.AverageCPU.ToString("0.##") + " %");
            //activate alert message if cpu usage exceeds threshold
            if (args.CurrentCPU > slider1.Value)
            {
                AlertAnimation(label10);
            }
        }
        /// <summary>
        /// GUI label outputs for Current RAM available and Average RAM available 
        /// GUI warning output for falling below RAM availability threshold
        /// </summary>
        void RAMHandler(object sender, RAMEventArgs args)
        {
            label7.Content = string.Format("{0}", args.CurrentRAM.ToString("0.##") + " MB");
            label9.Content = string.Format("{0}", args.AverageRAM.ToString("0.##") + " MB");
            //activate alert message if ram availability falls below threshold
            if (args.CurrentRAM < slider2.Value)
            {
                AlertAnimation(label11); 
            }
        }

        /// <summary>
        /// Flashing animated label message when the resource is running below threshold.    
        /// </summary>
        /// <param name="label">used to set value for the label name</param>
        void AlertAnimation(Label label)
        {
            label.Foreground.BeginAnimation(SolidColorBrush.ColorProperty,  
                new ColorAnimation
                {
                    To = Colors.Red,
                    Duration = TimeSpan.FromSeconds(0.1),
                    AutoReverse = true,
                    RepeatBehavior = new RepeatBehavior(3)  
                });
        }
    }
}