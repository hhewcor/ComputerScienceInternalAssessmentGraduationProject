
namespace ComputerScienceInternalAssessment
{
    partial class CompareTimesForm
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
            this.BackToStartFormBtn = new System.Windows.Forms.Button();
            this.CompareResultsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToStartFormBtn
            // 
            this.BackToStartFormBtn.Location = new System.Drawing.Point(39, 33);
            this.BackToStartFormBtn.Name = "BackToStartFormBtn";
            this.BackToStartFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToStartFormBtn.TabIndex = 0;
            this.BackToStartFormBtn.Text = "Back";
            this.BackToStartFormBtn.UseVisualStyleBackColor = true;
            this.BackToStartFormBtn.Click += new System.EventHandler(this.BackToStartFormBtn_Click);
            // 
            // CompareResultsBtn
            // 
            this.CompareResultsBtn.Location = new System.Drawing.Point(329, 394);
            this.CompareResultsBtn.Name = "CompareResultsBtn";
            this.CompareResultsBtn.Size = new System.Drawing.Size(75, 23);
            this.CompareResultsBtn.TabIndex = 1;
            this.CompareResultsBtn.Text = "Compare";
            this.CompareResultsBtn.UseVisualStyleBackColor = true;
            this.CompareResultsBtn.Click += new System.EventHandler(this.CompareResultsBtn_Click);
            // 
            // CompareTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.CompareResultsBtn);
            this.Controls.Add(this.BackToStartFormBtn);
            this.Name = "CompareTimesForm";
            this.Text = "CompareTimesForm";
            this.Load += new System.EventHandler(this.CompareTimesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToStartFormBtn;
        private System.Windows.Forms.Button CompareResultsBtn;
    }
}