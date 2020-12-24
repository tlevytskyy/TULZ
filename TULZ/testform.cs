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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var temp = new TimerControl(0, 0, 5);
            temp._CustomSountPath = Properties.Resources.Alarm;
            temp.E_CloseControl += (i) => flpTest.Controls.Remove(i);
            temp.Size = new Size(flpTest.Size.Width - 25, temp.Size.Height);
            flpTest.Controls.Add(temp);
        }
    }
}
