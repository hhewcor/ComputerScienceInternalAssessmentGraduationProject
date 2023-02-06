
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
            this.components = new System.ComponentModel.Container();
            this.BackToSwimmerListFormBtn = new System.Windows.Forms.Button();
            this.SaveSwimmerListFormBtn = new System.Windows.Forms.Button();
            this.EditSwimmerListDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterFemaleBtn = new System.Windows.Forms.Button();
            this.FilterMaleBtn = new System.Windows.Forms.Button();
            this.FilterTwelthGradeBtn = new System.Windows.Forms.Button();
            this.FilterEleventhGradeBtn = new System.Windows.Forms.Button();
            this.FilterTenthGradeBtn = new System.Windows.Forms.Button();
            this.FilterNinthGradeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EditSwimmerListDataGridView)).BeginInit();
            this.FilterPanel.SuspendLayout();
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
            // FilterBtn
            // 
            this.FilterBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterBtn.Location = new System.Drawing.Point(0, 0);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterBtn.TabIndex = 3;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = false;
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterFemaleBtn);
            this.FilterPanel.Controls.Add(this.FilterBtn);
            this.FilterPanel.Controls.Add(this.FilterMaleBtn);
            this.FilterPanel.Controls.Add(this.FilterTwelthGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterEleventhGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterTenthGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterNinthGradeBtn);
            this.FilterPanel.Controls.Add(this.button1);
            this.FilterPanel.Location = new System.Drawing.Point(638, 45);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(75, 26);
            this.FilterPanel.TabIndex = 8;
            // 
            // FilterFemaleBtn
            // 
            this.FilterFemaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterFemaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterFemaleBtn.Location = new System.Drawing.Point(0, 150);
            this.FilterFemaleBtn.Name = "FilterFemaleBtn";
            this.FilterFemaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterFemaleBtn.TabIndex = 7;
            this.FilterFemaleBtn.Text = "Female";
            this.FilterFemaleBtn.UseVisualStyleBackColor = false;
            // 
            // FilterMaleBtn
            // 
            this.FilterMaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterMaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterMaleBtn.Location = new System.Drawing.Point(0, 125);
            this.FilterMaleBtn.Name = "FilterMaleBtn";
            this.FilterMaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterMaleBtn.TabIndex = 6;
            this.FilterMaleBtn.Text = "Male";
            this.FilterMaleBtn.UseVisualStyleBackColor = false;
            // 
            // FilterTwelthGradeBtn
            // 
            this.FilterTwelthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTwelthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTwelthGradeBtn.Location = new System.Drawing.Point(0, 100);
            this.FilterTwelthGradeBtn.Name = "FilterTwelthGradeBtn";
            this.FilterTwelthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTwelthGradeBtn.TabIndex = 5;
            this.FilterTwelthGradeBtn.Text = "12th Grade";
            this.FilterTwelthGradeBtn.UseVisualStyleBackColor = false;
            // 
            // FilterEleventhGradeBtn
            // 
            this.FilterEleventhGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterEleventhGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterEleventhGradeBtn.Location = new System.Drawing.Point(0, 75);
            this.FilterEleventhGradeBtn.Name = "FilterEleventhGradeBtn";
            this.FilterEleventhGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterEleventhGradeBtn.TabIndex = 4;
            this.FilterEleventhGradeBtn.Text = "11th Grade";
            this.FilterEleventhGradeBtn.UseVisualStyleBackColor = false;
            // 
            // FilterTenthGradeBtn
            // 
            this.FilterTenthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTenthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTenthGradeBtn.Location = new System.Drawing.Point(0, 50);
            this.FilterTenthGradeBtn.Name = "FilterTenthGradeBtn";
            this.FilterTenthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTenthGradeBtn.TabIndex = 3;
            this.FilterTenthGradeBtn.Text = "10th Grade";
            this.FilterTenthGradeBtn.UseVisualStyleBackColor = false;
            // 
            // FilterNinthGradeBtn
            // 
            this.FilterNinthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterNinthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterNinthGradeBtn.Location = new System.Drawing.Point(0, 25);
            this.FilterNinthGradeBtn.Name = "FilterNinthGradeBtn";
            this.FilterNinthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterNinthGradeBtn.TabIndex = 2;
            this.FilterNinthGradeBtn.Text = "9th Grade";
            this.FilterNinthGradeBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-3, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditSwimmerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.EditSwimmerListDataGridView);
            this.Controls.Add(this.SaveSwimmerListFormBtn);
            this.Controls.Add(this.BackToSwimmerListFormBtn);
            this.Name = "EditSwimmerListForm";
            this.Text = "EditSwimmerListForm";
            this.Load += new System.EventHandler(this.EditSwimmerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EditSwimmerListDataGridView)).EndInit();
            this.FilterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToSwimmerListFormBtn;
        private System.Windows.Forms.Button SaveSwimmerListFormBtn;
        private System.Windows.Forms.DataGridView EditSwimmerListDataGridView;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Button FilterFemaleBtn;
        private System.Windows.Forms.Button FilterMaleBtn;
        private System.Windows.Forms.Button FilterTwelthGradeBtn;
        private System.Windows.Forms.Button FilterEleventhGradeBtn;
        private System.Windows.Forms.Button FilterTenthGradeBtn;
        private System.Windows.Forms.Button FilterNinthGradeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer Timer1;
    }
}