
namespace ComputerScienceInternalAssessment
{
    partial class EditSwimmerListForm
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
            this.SaveSwimmerListFormBtn = new System.Windows.Forms.Button();
            this.EditSwimmerListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EditSwimmerListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToSwimmerListFormBtn
            // 
            this.BackToSwimmerListFormBtn.Location = new System.Drawing.Point(27, 29);
            this.BackToSwimmerListFormBtn.Name = "BackToSwimmerListFormBtn";
            this.BackToSwimmerListFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToSwimmerListFormBtn.TabIndex = 0;
            this.BackToSwimmerListFormBtn.Text = "Back";
            this.BackToSwimmerListFormBtn.UseVisualStyleBackColor = true;
            this.BackToSwimmerListFormBtn.Click += new System.EventHandler(this.BackToSwimmerListFormBtn_Click);
            // 
            // SaveSwimmerListFormBtn
            // 
            this.SaveSwimmerListFormBtn.Location = new System.Drawing.Point(317, 398);
            this.SaveSwimmerListFormBtn.Name = "SaveSwimmerListFormBtn";
            this.SaveSwimmerListFormBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveSwimmerListFormBtn.TabIndex = 1;
            this.SaveSwimmerListFormBtn.Text = "Save";
            this.SaveSwimmerListFormBtn.UseVisualStyleBackColor = true;
            this.SaveSwimmerListFormBtn.Click += new System.EventHandler(this.SaveSwimmerListFormBtn_Click);
            // 
            // EditSwimmerListDataGridView
            // 
            this.EditSwimmerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditSwimmerListDataGridView.Location = new System.Drawing.Point(27, 108);
            this.EditSwimmerListDataGridView.Name = "EditSwimmerListDataGridView";
            this.EditSwimmerListDataGridView.Size = new System.Drawing.Size(365, 271);
            this.EditSwimmerListDataGridView.TabIndex = 2;
            // 
            // EditSwimmerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 450);
            this.Controls.Add(this.EditSwimmerListDataGridView);
            this.Controls.Add(this.SaveSwimmerListFormBtn);
            this.Controls.Add(this.BackToSwimmerListFormBtn);
            this.Name = "EditSwimmerListForm";
            this.Text = "EditSwimmerListForm";
            this.Load += new System.EventHandler(this.EditSwimmerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditSwimmerListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListFormBtn;
        private System.Windows.Forms.Button SaveSwimmerListFormBtn;
        private System.Windows.Forms.DataGridView EditSwimmerListDataGridView;
    }
}