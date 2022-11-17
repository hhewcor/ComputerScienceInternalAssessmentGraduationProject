
namespace ComputerScienceInternalAssessment
{
    partial class CalculateResultsForm
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
            this.BackToCalculateTimesFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToCalculateTimesFormBtn
            // 
            this.BackToCalculateTimesFormBtn.Location = new System.Drawing.Point(35, 33);
            this.BackToCalculateTimesFormBtn.Name = "BackToCalculateTimesFormBtn";
            this.BackToCalculateTimesFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToCalculateTimesFormBtn.TabIndex = 0;
            this.BackToCalculateTimesFormBtn.Text = "Back";
            this.BackToCalculateTimesFormBtn.UseVisualStyleBackColor = true;
            this.BackToCalculateTimesFormBtn.Click += new System.EventHandler(this.BackToCalculateTimesFormBtn_Click);
            // 
            // CalculateResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.BackToCalculateTimesFormBtn);
            this.Name = "CalculateResultsForm";
            this.Text = "CalculateResultsForm";
            this.Load += new System.EventHandler(this.CalculateResultsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToCalculateTimesFormBtn;
    }
}