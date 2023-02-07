namespace WinCircuitTester
{
    partial class CircuitTesterForm
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
            this.btnStartTest = new System.Windows.Forms.Button();
            this.lstOutputs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnStartTest
            // 
            this.btnStartTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.Location = new System.Drawing.Point(0, 0);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Size = new System.Drawing.Size(800, 35);
            this.btnStartTest.TabIndex = 0;
            this.btnStartTest.Text = "&Start Test";
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // lstOutputs
            // 
            this.lstOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstOutputs.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOutputs.FormattingEnabled = true;
            this.lstOutputs.ItemHeight = 21;
            this.lstOutputs.Location = new System.Drawing.Point(0, 35);
            this.lstOutputs.Name = "lstOutputs";
            this.lstOutputs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstOutputs.Size = new System.Drawing.Size(800, 415);
            this.lstOutputs.TabIndex = 1;
            this.lstOutputs.SelectedIndexChanged += new System.EventHandler(this.lstOutputs_SelectedIndexChanged);
            // 
            // CircuitTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOutputs);
            this.Controls.Add(this.btnStartTest);
            this.Name = "CircuitTesterForm";
            this.Text = "Circuit Tester";
            this.Load += new System.EventHandler(this.CircuitTesterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.ListBox lstOutputs;
    }
}

