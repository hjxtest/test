namespace test1
{
    partial class Form1
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

        #region Visual WebGui Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTest = new Gizmox.WebGUI.Forms.Button();
            this.button1 = new Gizmox.WebGUI.Forms.Button();
            this.chart1 = new Gizmox.WebGUI.Forms.Charts.Chart();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(47, 118);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "≤‚ ‘";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "»°œ˚";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            this.chart1.AnimationEnabled = false;
            this.chart1.AxisX = null;
            this.chart1.AxisY = null;
            this.chart1.ColorSet = null;
            this.chart1.Location = new System.Drawing.Point(178, 115);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(184, 151);
            this.chart1.TabIndex = 3;
            this.chart1.Theme = Gizmox.WebGUI.Forms.Charts.ThemeTypes.Theme1;
            this.chart1.Title = null;
            this.chart1.View3D = false;
            // 
            // Form1
            // 
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTest);
            this.Size = new System.Drawing.Size(644, 473);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Button btnTest;
        private Gizmox.WebGUI.Forms.Button button1;
        private Gizmox.WebGUI.Forms.Charts.Chart chart1;
    }
}