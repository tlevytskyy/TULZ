
namespace TULZ
{
    partial class testform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flpTest = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flpTest
            // 
            this.flpTest.Location = new System.Drawing.Point(211, 21);
            this.flpTest.Name = "flpTest";
            this.flpTest.Size = new System.Drawing.Size(599, 485);
            this.flpTest.TabIndex = 0;
            // 
            // testform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 518);
            this.Controls.Add(this.flpTest);
            this.Name = "testform";
            this.Text = "testform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel flpTest;
    }
}