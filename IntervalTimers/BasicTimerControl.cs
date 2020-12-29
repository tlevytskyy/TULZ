using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntervalTimers
{
    public partial class BasicTimerControl : UserControl
    {
        TimerControl stopwatch;
        public BasicTimerControl()
        {
            InitializeComponent();
            stopwatch = new TimerControl();
            stopwatch.Dock = DockStyle.Fill;
            panelStopWatch.Controls.Add(stopwatch);
        }
    }
}
