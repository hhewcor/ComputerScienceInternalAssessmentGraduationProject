
namespace ComputerScienceInternalAssessment
{
    partial class CalculateTimesForm
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
            this.BackToStartBtn = new System.Windows.Forms.Button();
            this.CalculateResultsFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToStartBtn
            // 
            this.BackToStartBtn.Location = new System.Drawing.Point(29, 37);
            this.BackToStartBtn.Name = "BackToStartBtn";
            this.BackToStartBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToStartBtn.TabIndex = 0;
            this.BackToStartBtn.Text = "Back";
            this.BackToStartBtn.UseVisualStyleBackColor = true;
            this.BackToStartBtn.Click += new System.EventHandler(this.BackToStartBtn_Click);
            // 
            // CalculateResultsFormBtn
            // 
            this.CalculateResultsFormBtn.Location = new System.Drawing.Point(305, 388);
            this.CalculateResultsFormBtn.Name = "CalculateResultsFormBtn";
            this.CalculateResultsFormBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateResultsFormBtn.TabIndex = 1;
            this.CalculateResultsFormBtn.Text = "Calculate";
            this.CalculateResultsFormBtn.UseVisualStyleBackColor = true;
            this.CalculateResultsFormBtn.Click += new System.EventHandler(this.CalculateResultsFormBtn_Click);
            // 
            // CalculateTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 450);
            this.Controls.Add(this.CalculateResultsFormBtn);
            this.Controls.Add(this.BackToStartBtn);
            this.Name = "CalculateTimesForm";
            this.Text = "CalculateTimesForm";
            this.Load += new System.EventHandler(this.CalculateTimesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToStartBtn;
        private System.Windows.Forms.Button CalculateResultsFormBtn;
    }
}