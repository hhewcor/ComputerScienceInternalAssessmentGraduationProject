
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
            this.SelectExcelFileBtn = new System.Windows.Forms.Button();
            this.ExcelFileNameTxtBox = new System.Windows.Forms.TextBox();
            this.SelectXMLFileBtn = new System.Windows.Forms.Button();
            this.XMLFileNameTxtBox = new System.Windows.Forms.TextBox();
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
            this.ImportXMLBtn.Location = new System.Drawing.Point(23, 258);
            this.ImportXMLBtn.Name = "ImportXMLBtn";
            this.ImportXMLBtn.Size = new System.Drawing.Size(353, 41);
            this.ImportXMLBtn.TabIndex = 1;
            this.ImportXMLBtn.Text = "Import XML";
            this.ImportXMLBtn.UseVisualStyleBackColor = true;
            this.ImportXMLBtn.Click += new System.EventHandler(this.ImportXMLBtn_Click);
            // 
            // ImportExcelBtn
            // 
            this.ImportExcelBtn.Location = new System.Drawing.Point(24, 130);
            this.ImportExcelBtn.Name = "ImportExcelBtn";
            this.ImportExcelBtn.Size = new System.Drawing.Size(352, 45);
            this.ImportExcelBtn.TabIndex = 2;
            this.ImportExcelBtn.Text = "Import Excel";
            this.ImportExcelBtn.UseVisualStyleBackColor = true;
            this.ImportExcelBtn.Click += new System.EventHandler(this.ImportExcelBtn_Click);
            // 
            // SelectExcelFileBtn
            // 
            this.SelectExcelFileBtn.Location = new System.Drawing.Point(279, 90);
            this.SelectExcelFileBtn.Name = "SelectExcelFileBtn";
            this.SelectExcelFileBtn.Size = new System.Drawing.Size(97, 23);
            this.SelectExcelFileBtn.TabIndex = 3;
            this.SelectExcelFileBtn.Text = "Select Excel File";
            this.SelectExcelFileBtn.UseVisualStyleBackColor = true;
            this.SelectExcelFileBtn.Click += new System.EventHandler(this.SelectExcelFileBtn_Click);
            // 
            // ExcelFileNameTxtBox
            // 
            this.ExcelFileNameTxtBox.Location = new System.Drawing.Point(23, 93);
            this.ExcelFileNameTxtBox.Name = "ExcelFileNameTxtBox";
            this.ExcelFileNameTxtBox.Size = new System.Drawing.Size(250, 20);
            this.ExcelFileNameTxtBox.TabIndex = 4;
            // 
            // SelectXMLFileBtn
            // 
            this.SelectXMLFileBtn.Location = new System.Drawing.Point(279, 226);
            this.SelectXMLFileBtn.Name = "SelectXMLFileBtn";
            this.SelectXMLFileBtn.Size = new System.Drawing.Size(97, 23);
            this.SelectXMLFileBtn.TabIndex = 5;
            this.SelectXMLFileBtn.Text = "Select XML File";
            this.SelectXMLFileBtn.UseVisualStyleBackColor = true;
            this.SelectXMLFileBtn.Click += new System.EventHandler(this.SelectXMLFileBtn_Click);
            // 
            // XMLFileNameTxtBox
            // 
            this.XMLFileNameTxtBox.Location = new System.Drawing.Point(24, 226);
            this.XMLFileNameTxtBox.Name = "XMLFileNameTxtBox";
            this.XMLFileNameTxtBox.Size = new System.Drawing.Size(249, 20);
            this.XMLFileNameTxtBox.TabIndex = 6;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.XMLFileNameTxtBox);
            this.Controls.Add(this.SelectXMLFileBtn);
            this.Controls.Add(this.ExcelFileNameTxtBox);
            this.Controls.Add(this.SelectExcelFileBtn);
            this.Controls.Add(this.ImportExcelBtn);
            this.Controls.Add(this.ImportXMLBtn);
            this.Controls.Add(this.BackToSwimmerListBtn);
            this.Name = "ImportForm";
            this.Text = "ImportForm";
            this.Load += new System.EventHandler(this.ImportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListBtn;
        private System.Windows.Forms.Button ImportXMLBtn;
        private System.Windows.Forms.Button ImportExcelBtn;
        private System.Windows.Forms.Button SelectExcelFileBtn;
        private System.Windows.Forms.TextBox ExcelFileNameTxtBox;
        private System.Windows.Forms.Button SelectXMLFileBtn;
        private System.Windows.Forms.TextBox XMLFileNameTxtBox;
    }
}