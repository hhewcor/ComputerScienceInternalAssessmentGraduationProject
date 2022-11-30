
namespace ComputerScienceInternalAssessment
{
    partial class ImportForm
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
            this.BackToSwimmerListBtn = new System.Windows.Forms.Button();
            this.ImportXMLBtn = new System.Windows.Forms.Button();
            this.ImportExcelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackToSwimmerListBtn
            // 
            this.BackToSwimmerListBtn.Location = new System.Drawing.Point(24, 26);
            this.BackToSwimmerListBtn.Name = "BackToSwimmerListBtn";
            this.BackToSwimmerListBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToSwimmerListBtn.TabIndex = 0;
            this.BackToSwimmerListBtn.Text = "Back";
            this.BackToSwimmerListBtn.UseVisualStyleBackColor = true;
            this.BackToSwimmerListBtn.Click += new System.EventHandler(this.BackToSwimmerListBtn_Click);
            // 
            // ImportXMLBtn
            // 
            this.ImportXMLBtn.Location = new System.Drawing.Point(60, 86);
            this.ImportXMLBtn.Name = "ImportXMLBtn";
            this.ImportXMLBtn.Size = new System.Drawing.Size(280, 41);
            this.ImportXMLBtn.TabIndex = 1;
            this.ImportXMLBtn.Text = "Import XML";
            this.ImportXMLBtn.UseVisualStyleBackColor = true;
            this.ImportXMLBtn.Click += new System.EventHandler(this.ImportXMLBtn_Click);
            // 
            // ImportExcelBtn
            // 
            this.ImportExcelBtn.Location = new System.Drawing.Point(60, 143);
            this.ImportExcelBtn.Name = "ImportExcelBtn";
            this.ImportExcelBtn.Size = new System.Drawing.Size(280, 45);
            this.ImportExcelBtn.TabIndex = 2;
            this.ImportExcelBtn.Text = "Import Excel";
            this.ImportExcelBtn.UseVisualStyleBackColor = true;
            this.ImportExcelBtn.Click += new System.EventHandler(this.ImportExcelBtn_Click);
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.ImportExcelBtn);
            this.Controls.Add(this.ImportXMLBtn);
            this.Controls.Add(this.BackToSwimmerListBtn);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListBtn;
        private System.Windows.Forms.Button ImportXMLBtn;
        private System.Windows.Forms.Button ImportExcelBtn;
    }
}