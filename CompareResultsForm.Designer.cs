
namespace ComputerScienceInternalAssessment
{
    partial class CompareResultsForm
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
            this.BackToCompareTimesFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToCompareTimesFormBtn
            // 
            this.BackToCompareTimesFormBtn.Location = new System.Drawing.Point(51, 40);
            this.BackToCompareTimesFormBtn.Name = "BackToCompareTimesFormBtn";
            this.BackToCompareTimesFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToCompareTimesFormBtn.TabIndex = 0;
            this.BackToCompareTimesFormBtn.Text = "Back";
            this.BackToCompareTimesFormBtn.UseVisualStyleBackColor = true;
            this.BackToCompareTimesFormBtn.Click += new System.EventHandler(this.BackToCompareTimesFormBtn_Click);
            // 
            // CompareResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.BackToCompareTimesFormBtn);
            this.Name = "CompareResultsForm";
            this.Text = "CompareResultsForm";
            this.Load += new System.EventHandler(this.CompareResultsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToCompareTimesFormBtn;
    }
}