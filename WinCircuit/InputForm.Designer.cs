namespace WinCircuit
{
    partial class InputForm
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
            this.lblInput = new System.Windows.Forms.Label();
            this.btnTrue = new System.Windows.Forms.Button();
            this.btnFalse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(15, 18);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(0, 24);
            this.lblInput.TabIndex = 0;
            // 
            // btnTrue
            // 
            this.btnTrue.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrue.Location = new System.Drawing.Point(19, 58);
            this.btnTrue.Name = "btnTrue";
            this.btnTrue.Size = new System.Drawing.Size(90, 42);
            this.btnTrue.TabIndex = 1;
            this.btnTrue.Text = "&True";
            this.btnTrue.UseVisualStyleBackColor = true;
            // 
            // btnFalse
            // 
            this.btnFalse.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFalse.Location = new System.Drawing.Point(124, 58);
            this.btnFalse.Name = "btnFalse";
            this.btnFalse.Size = new System.Drawing.Size(90, 42);
            this.btnFalse.TabIndex = 2;
            this.btnFalse.Text = "&False";
            this.btnFalse.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 115);
            this.ControlBox = false;
            this.Controls.Add(this.btnFalse);
            this.Controls.Add(this.btnTrue);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.Text = "Input";
            this.Load += new System.EventHandler(this.InputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnTrue;
        private System.Windows.Forms.Button btnFalse;
    }
}