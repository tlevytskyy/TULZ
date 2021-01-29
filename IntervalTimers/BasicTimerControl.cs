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
        private void button1_Click(object sender, EventArgs e)
        {
            panelTimer.Controls.Clear();
            var temptimer = new TimerControl(Convert.ToInt32(numHours.Value),
                Convert.ToInt32(numMinutes.Value), Convert.ToInt32(numSeconds.Value),false);
            temptimer.E_CloseControl += (i)=> panelTimer.Controls.Clear();        //set closing event on control
            temptimer.Dock = DockStyle.Fill; //set width to fill panel
            panelTimer.Controls.Add(temptimer);
        }
    }
}
