
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
            this.label1 = new System.Windows.Forms.Label();
            this.FilterFemaleBtn = new System.Windows.Forms.Button();
            this.FilterMaleBtn = new System.Windows.Forms.Button();
            this.FilterTwelthGradeBtn = new System.Windows.Forms.Button();
            this.FilterEleventhGradeBtn = new System.Windows.Forms.Button();
            this.FilterTenthGradeBtn = new System.Windows.Forms.Button();
            this.FilterNinthGradeBtn = new System.Windows.Forms.Button();
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
            this.SaveSwimmerListFormBtn.Location = new System.Drawing.Point(742, 419);
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
            this.EditSwimmerListDataGridView.Location = new System.Drawing.Point(15, 127);
            this.EditSwimmerListDataGridView.Name = "EditSwimmerListDataGridView";
            this.EditSwimmerListDataGridView.Size = new System.Drawing.Size(802, 286);
            this.EditSwimmerListDataGridView.TabIndex = 2;
            this.EditSwimmerListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditSwimmerListDataGridView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filter:";
            // 
            // FilterFemaleBtn
            // 
            this.FilterFemaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterFemaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterFemaleBtn.Location = new System.Drawing.Point(580, 92);
            this.FilterFemaleBtn.Name = "FilterFemaleBtn";
            this.FilterFemaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterFemaleBtn.TabIndex = 18;
            this.FilterFemaleBtn.Text = "Female";
            this.FilterFemaleBtn.UseVisualStyleBackColor = false;
            this.FilterFemaleBtn.Click += new System.EventHandler(this.FilterFemaleBtn_Click);
            // 
            // FilterMaleBtn
            // 
            this.FilterMaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterMaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterMaleBtn.Location = new System.Drawing.Point(499, 92);
            this.FilterMaleBtn.Name = "FilterMaleBtn";
            this.FilterMaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterMaleBtn.TabIndex = 17;
            this.FilterMaleBtn.Text = "Male";
            this.FilterMaleBtn.UseVisualStyleBackColor = false;
            this.FilterMaleBtn.Click += new System.EventHandler(this.FilterMaleBtn_Click);
            // 
            // FilterTwelthGradeBtn
            // 
            this.FilterTwelthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTwelthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTwelthGradeBtn.Location = new System.Drawing.Point(580, 60);
            this.FilterTwelthGradeBtn.Name = "FilterTwelthGradeBtn";
            this.FilterTwelthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTwelthGradeBtn.TabIndex = 16;
            this.FilterTwelthGradeBtn.Text = "12th Grade";
            this.FilterTwelthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterTwelthGradeBtn.Click += new System.EventHandler(this.FilterTwelthGradeBtn_Click);
            // 
            // FilterEleventhGradeBtn
            // 
            this.FilterEleventhGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterEleventhGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterEleventhGradeBtn.Location = new System.Drawing.Point(499, 60);
            this.FilterEleventhGradeBtn.Name = "FilterEleventhGradeBtn";
            this.FilterEleventhGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterEleventhGradeBtn.TabIndex = 15;
            this.FilterEleventhGradeBtn.Text = "11th Grade";
            this.FilterEleventhGradeBtn.UseVisualStyleBackColor = false;
            this.FilterEleventhGradeBtn.Click += new System.EventHandler(this.FilterEleventhGradeBtn_Click);
            // 
            // FilterTenthGradeBtn
            // 
            this.FilterTenthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTenthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTenthGradeBtn.Location = new System.Drawing.Point(580, 29);
            this.FilterTenthGradeBtn.Name = "FilterTenthGradeBtn";
            this.FilterTenthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTenthGradeBtn.TabIndex = 14;
            this.FilterTenthGradeBtn.Text = "10th Grade";
            this.FilterTenthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterTenthGradeBtn.Click += new System.EventHandler(this.FilterTenthGradeBtn_Click);
            // 
            // FilterNinthGradeBtn
            // 
            this.FilterNinthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterNinthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterNinthGradeBtn.Location = new System.Drawing.Point(499, 29);
            this.FilterNinthGradeBtn.Name = "FilterNinthGradeBtn";
            this.FilterNinthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterNinthGradeBtn.TabIndex = 13;
            this.FilterNinthGradeBtn.Text = "9th Grade";
            this.FilterNinthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterNinthGradeBtn.Click += new System.EventHandler(this.FilterNinthGradeBtn_Click);
            // 
            // EditSwimmerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterFemaleBtn);
            this.Controls.Add(this.FilterMaleBtn);
            this.Controls.Add(this.FilterTwelthGradeBtn);
            this.Controls.Add(this.FilterEleventhGradeBtn);
            this.Controls.Add(this.FilterTenthGradeBtn);
            this.Controls.Add(this.FilterNinthGradeBtn);
            this.Controls.Add(this.EditSwimmerListDataGridView);
            this.Controls.Add(this.SaveSwimmerListFormBtn);
            this.Controls.Add(this.BackToSwimmerListFormBtn);
            this.Name = "EditSwimmerListForm";
            this.Text = "EditSwimmerListForm";
            this.Load += new System.EventHandler(this.EditSwimmerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditSwimmerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListFormBtn;
        private System.Windows.Forms.Button SaveSwimmerListFormBtn;
        private System.Windows.Forms.DataGridView EditSwimmerListDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FilterFemaleBtn;
        private System.Windows.Forms.Button FilterMaleBtn;
        private System.Windows.Forms.Button FilterTwelthGradeBtn;
        private System.Windows.Forms.Button FilterEleventhGradeBtn;
        private System.Windows.Forms.Button FilterTenthGradeBtn;
        private System.Windows.Forms.Button FilterNinthGradeBtn;
    }
}