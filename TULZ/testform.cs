using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntervalTimers;

namespace TULZ
{
    public partial class testform : Form
    {
        public testform()
        {
            
            InitializeComponent();
            var it = new IntervalTimersControl();
            //it.Size = new Size(flpTest.Width - 23, flpTest.Height - 23);
            it.Dock = DockStyle.Fill;
            flpTest.Controls.Add(it);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new TimerControl(0, 0, 5);
            temp._CustomSountPath = Properties.Resources.Alarm;
            temp.E_CloseControl += (i) => flpTest.Controls.Remove(i);
            temp.Size = new Size(flpTest.Size.Width - 23, temp.Size.Height);
            flpTest.Controls.Add(temp);
        }

        private void flpTest_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
