
namespace ComputerScienceInternalAssessment
{
    partial class ViewSwimmerEventsForm
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
            this.BackToSwimmerListFormBtn = new System.Windows.Forms.Button();
            this.EditSwimmerEventsFormBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToSwimmerListFormBtn
            // 
            this.BackToSwimmerListFormBtn.Location = new System.Drawing.Point(43, 29);
            this.BackToSwimmerListFormBtn.Name = "BackToSwimmerListFormBtn";
            this.BackToSwimmerListFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToSwimmerListFormBtn.TabIndex = 0;
            this.BackToSwimmerListFormBtn.Text = "Back";
            this.BackToSwimmerListFormBtn.UseVisualStyleBackColor = true;
            this.BackToSwimmerListFormBtn.Click += new System.EventHandler(this.BackToSwimmerListFormBtn_Click);
            // 
            // EditSwimmerEventsFormBtn
            // 
            this.EditSwimmerEventsFormBtn.Location = new System.Drawing.Point(301, 72);
            this.EditSwimmerEventsFormBtn.Name = "EditSwimmerEventsFormBtn";
            this.EditSwimmerEventsFormBtn.Size = new System.Drawing.Size(75, 23);
            this.EditSwimmerEventsFormBtn.TabIndex = 1;
            this.EditSwimmerEventsFormBtn.Text = "Edit";
            this.EditSwimmerEventsFormBtn.UseVisualStyleBackColor = true;
            this.EditSwimmerEventsFormBtn.Click += new System.EventHandler(this.EditSwimmerEventsFormBtn_Click);
            // 
            // ViewSwimmerEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.EditSwimmerEventsFormBtn);
            this.Controls.Add(this.BackToSwimmerListFormBtn);
            this.Name = "ViewSwimmerEventsForm";
            this.Text = "ViewSwimmerEventsForm";
            this.Load += new System.EventHandler(this.ViewSwimmerEventsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListFormBtn;
        private System.Windows.Forms.Button EditSwimmerEventsFormBtn;
    }
}