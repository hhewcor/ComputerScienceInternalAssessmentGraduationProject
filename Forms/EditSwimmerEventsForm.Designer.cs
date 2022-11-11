
namespace ComputerScienceInternalAssessment
{
    partial class EditSwimmerEventsForm
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
            this.BackToViewSwimmerEventsFormBtn = new System.Windows.Forms.Button();
            this.SaveSwimmerEventsFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToViewSwimmerEventsFormBtn
            // 
            this.BackToViewSwimmerEventsFormBtn.Location = new System.Drawing.Point(25, 35);
            this.BackToViewSwimmerEventsFormBtn.Name = "BackToViewSwimmerEventsFormBtn";
            this.BackToViewSwimmerEventsFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToViewSwimmerEventsFormBtn.TabIndex = 0;
            this.BackToViewSwimmerEventsFormBtn.Text = "Back";
            this.BackToViewSwimmerEventsFormBtn.UseVisualStyleBackColor = true;
            this.BackToViewSwimmerEventsFormBtn.Click += new System.EventHandler(this.BackToViewSwimmerEventsFormBtn_Click);
            // 
            // SaveSwimmerEventsFormBtn
            // 
            this.SaveSwimmerEventsFormBtn.Location = new System.Drawing.Point(312, 383);
            this.SaveSwimmerEventsFormBtn.Name = "SaveSwimmerEventsFormBtn";
            this.SaveSwimmerEventsFormBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveSwimmerEventsFormBtn.TabIndex = 1;
            this.SaveSwimmerEventsFormBtn.Text = "Save";
            this.SaveSwimmerEventsFormBtn.UseVisualStyleBackColor = true;
            this.SaveSwimmerEventsFormBtn.Click += new System.EventHandler(this.SaveSwimmerEventsFormBtn_Click);
            // 
            // EditSwimmerEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.SaveSwimmerEventsFormBtn);
            this.Controls.Add(this.BackToViewSwimmerEventsFormBtn);
            this.Name = "EditSwimmerEventsForm";
            this.Text = "EditSwimmerEventsForm";
            this.Load += new System.EventHandler(this.EditSwimmerEventsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToViewSwimmerEventsFormBtn;
        private System.Windows.Forms.Button SaveSwimmerEventsFormBtn;
    }
}