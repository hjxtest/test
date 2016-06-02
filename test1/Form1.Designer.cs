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
            this.listBox1 = new Gizmox.WebGUI.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(172, 118);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 173);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTest);
            this.Size = new System.Drawing.Size(644, 473);
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Gizmox.WebGUI.Forms.Button btnTest;
        private Gizmox.WebGUI.Forms.ListBox listBox1;
    }
}