
namespace IntervalTimers
{
    partial class BasicTimerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicTimerControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelStopWatch = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panelTimer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelStopWatch);
            this.panel1.Location = new System.Drawing.Point(130, 52);
            this.panel1.MaximumSize = new System.Drawing.Size(372, 436);
            this.panel1.MinimumSize = new System.Drawing.Size(372, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 436);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.numSeconds);
            this.panel3.Controls.Add(this.numMinutes);
            this.panel3.Controls.Add(this.numHours);
            this.panel3.Location = new System.Drawing.Point(35, 345);
            this.panel3.MaximumSize = new System.Drawing.Size(305, 71);
            this.panel3.MinimumSize = new System.Drawing.Size(305, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(305, 71);
            this.panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(164, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Secs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(91, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mins:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hours:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(215, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 71);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numSeconds
            // 
            this.numSeconds.Location = new System.Drawing.Point(164, 33);
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(43, 23);
            this.numSeconds.TabIndex = 2;
            // 
            // numMinutes
            // 
            this.numMinutes.Location = new System.Drawing.Point(91, 33);
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(46, 23);
            this.numMinutes.TabIndex = 1;
            // 
            // numHours
            // 
            this.numHours.Location = new System.Drawing.Point(21, 33);
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(46, 23);
            this.numHours.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(117, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 104);
            this.panel6.TabIndex = 6;
            // 
            // panelTimer
            // 
            this.panelTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimer.BackColor = System.Drawing.Color.Black;
            this.panelTimer.Location = new System.Drawing.Point(5, 275);
            this.panelTimer.MaximumSize = new System.Drawing.Size(360, 62);
            this.panelTimer.MinimumSize = new System.Drawing.Size(360, 62);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(360, 62);
            this.panelTimer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(117, 236);
            this.label1.MaximumSize = new System.Drawing.Size(121, 32);
            this.label1.MinimumSize = new System.Drawing.Size(121, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "~ Timer ~";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(94, 13);
            this.label2.MaximumSize = new System.Drawing.Size(181, 32);
            this.label2.MinimumSize = new System.Drawing.Size(181, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "~ Stop Watch ~";
            // 
            // panelStopWatch
            // 
            this.panelStopWatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStopWatch.BackColor = System.Drawing.Color.Black;
            this.panelStopWatch.Location = new System.Drawing.Point(5, 58);
            this.panelStopWatch.MaximumSize = new System.Drawing.Size(360, 62);
            this.panelStopWatch.MinimumSize = new System.Drawing.Size(360, 62);
            this.panelStopWatch.Name = "panelStopWatch";
            this.panelStopWatch.Size = new System.Drawing.Size(360, 62);
            this.panelStopWatch.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 560);
            this.panel2.TabIndex = 1;
            // 
            // BasicTimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(372, 436);
            this.Name = "BasicTimerControl";
            this.Size = new System.Drawing.Size(638, 560);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelStopWatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Panel panel2;
    }
}
