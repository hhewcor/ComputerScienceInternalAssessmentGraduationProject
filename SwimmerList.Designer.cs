
namespace ComputerScienceInternalAssessment
{
    partial class SwimmerListForm
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
        /// 
        /// I removed the this. from any reference of SwimmerListFrom!!!!!
        /// </summary>
        private void InitializeComponent()
        {
            this.BackToStartBtn = new System.Windows.Forms.Button();
            this.SwimmerListHelpBtn = new System.Windows.Forms.Button();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchSwimmerNameBtn = new System.Windows.Forms.Button();
            this.FilterFemaleBtn = new System.Windows.Forms.Button();
            this.FilterMaleBtn = new System.Windows.Forms.Button();
            this.FilterTwelthGradeBtn = new System.Windows.Forms.Button();
            this.FilterEleventhGradeBtn = new System.Windows.Forms.Button();
            this.FilterTenthGradeBtn = new System.Windows.Forms.Button();
            this.FilterNinthGradeBtn = new System.Windows.Forms.Button();
            this.SwimmerListDataGridView = new System.Windows.Forms.DataGridView();
            this.resetBtn = new System.Windows.Forms.Button();
            this.FilterLable = new System.Windows.Forms.Label();
            this.AddSwimmerBtn = new System.Windows.Forms.Button();
            this.FirstNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.LastNameRadioBtn = new System.Windows.Forms.RadioButton();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmerListDataGridView)).BeginInit();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackToStartBtn
            // 
            this.BackToStartBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToStartBtn.Location = new System.Drawing.Point(24, 13);
            this.BackToStartBtn.Name = "BackToStartBtn";
            this.BackToStartBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToStartBtn.TabIndex = 0;
            this.BackToStartBtn.Text = "Back";
            this.BackToStartBtn.UseVisualStyleBackColor = false;
            this.BackToStartBtn.Click += new System.EventHandler(this.BackToStartBtn_Click);
            // 
            // SwimmerListHelpBtn
            // 
            this.SwimmerListHelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SwimmerListHelpBtn.Location = new System.Drawing.Point(742, 26);
            this.SwimmerListHelpBtn.Name = "SwimmerListHelpBtn";
            this.SwimmerListHelpBtn.Size = new System.Drawing.Size(78, 23);
            this.SwimmerListHelpBtn.TabIndex = 1;
            this.SwimmerListHelpBtn.Text = "Help";
            this.SwimmerListHelpBtn.UseVisualStyleBackColor = false;
            this.SwimmerListHelpBtn.Click += new System.EventHandler(this.SwimmerListHelpBtn_Click);
            // 
            // SearchTxt
            // 
            this.SearchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SearchTxt.Location = new System.Drawing.Point(15, 95);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(229, 20);
            this.SearchTxt.TabIndex = 2;
            this.SearchTxt.TextChanged += new System.EventHandler(this.SearchFirstNameTxt_TextChanged);
            // 
            // SearchSwimmerNameBtn
            // 
            this.SearchSwimmerNameBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchSwimmerNameBtn.Location = new System.Drawing.Point(258, 68);
            this.SearchSwimmerNameBtn.Name = "SearchSwimmerNameBtn";
            this.SearchSwimmerNameBtn.Size = new System.Drawing.Size(79, 23);
            this.SearchSwimmerNameBtn.TabIndex = 6;
            this.SearchSwimmerNameBtn.Text = "Search";
            this.SearchSwimmerNameBtn.UseVisualStyleBackColor = false;
            this.SearchSwimmerNameBtn.Click += new System.EventHandler(this.SearchSwimmerNameBtn_Click);
            // 
            // FilterFemaleBtn
            // 
            this.FilterFemaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterFemaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterFemaleBtn.Location = new System.Drawing.Point(549, 96);
            this.FilterFemaleBtn.Name = "FilterFemaleBtn";
            this.FilterFemaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterFemaleBtn.TabIndex = 7;
            this.FilterFemaleBtn.Text = "Female";
            this.FilterFemaleBtn.UseVisualStyleBackColor = false;
            this.FilterFemaleBtn.Click += new System.EventHandler(this.FilterFemaleBtn_Click);
            // 
            // FilterMaleBtn
            // 
            this.FilterMaleBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterMaleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterMaleBtn.Location = new System.Drawing.Point(468, 96);
            this.FilterMaleBtn.Name = "FilterMaleBtn";
            this.FilterMaleBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterMaleBtn.TabIndex = 6;
            this.FilterMaleBtn.Text = "Male";
            this.FilterMaleBtn.UseVisualStyleBackColor = false;
            this.FilterMaleBtn.Click += new System.EventHandler(this.FilterMaleBtn_Click);
            // 
            // FilterTwelthGradeBtn
            // 
            this.FilterTwelthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTwelthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTwelthGradeBtn.Location = new System.Drawing.Point(549, 64);
            this.FilterTwelthGradeBtn.Name = "FilterTwelthGradeBtn";
            this.FilterTwelthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTwelthGradeBtn.TabIndex = 5;
            this.FilterTwelthGradeBtn.Text = "12th Grade";
            this.FilterTwelthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterTwelthGradeBtn.Click += new System.EventHandler(this.FilterTwelthGradeBtn_Click);
            // 
            // FilterEleventhGradeBtn
            // 
            this.FilterEleventhGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterEleventhGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterEleventhGradeBtn.Location = new System.Drawing.Point(468, 64);
            this.FilterEleventhGradeBtn.Name = "FilterEleventhGradeBtn";
            this.FilterEleventhGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterEleventhGradeBtn.TabIndex = 4;
            this.FilterEleventhGradeBtn.Text = "11th Grade";
            this.FilterEleventhGradeBtn.UseVisualStyleBackColor = false;
            this.FilterEleventhGradeBtn.Click += new System.EventHandler(this.FilterEleventhGradeBtn_Click);
            // 
            // FilterTenthGradeBtn
            // 
            this.FilterTenthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterTenthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterTenthGradeBtn.Location = new System.Drawing.Point(549, 33);
            this.FilterTenthGradeBtn.Name = "FilterTenthGradeBtn";
            this.FilterTenthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterTenthGradeBtn.TabIndex = 3;
            this.FilterTenthGradeBtn.Text = "10th Grade";
            this.FilterTenthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterTenthGradeBtn.Click += new System.EventHandler(this.FilterTenthGradeBtn_Click);
            // 
            // FilterNinthGradeBtn
            // 
            this.FilterNinthGradeBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterNinthGradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterNinthGradeBtn.Location = new System.Drawing.Point(468, 33);
            this.FilterNinthGradeBtn.Name = "FilterNinthGradeBtn";
            this.FilterNinthGradeBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterNinthGradeBtn.TabIndex = 2;
            this.FilterNinthGradeBtn.Text = "9th Grade";
            this.FilterNinthGradeBtn.UseVisualStyleBackColor = false;
            this.FilterNinthGradeBtn.Click += new System.EventHandler(this.FilterNinthGradeBtn_Click);
            // 
            // SwimmerListDataGridView
            // 
            this.SwimmerListDataGridView.AllowUserToAddRows = false;
            this.SwimmerListDataGridView.AllowUserToDeleteRows = false;
            this.SwimmerListDataGridView.AllowUserToResizeColumns = false;
            this.SwimmerListDataGridView.AllowUserToResizeRows = false;
            this.SwimmerListDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SwimmerListDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SwimmerListDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.SwimmerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SwimmerListDataGridView.Location = new System.Drawing.Point(15, 127);
            this.SwimmerListDataGridView.Name = "SwimmerListDataGridView";
            this.SwimmerListDataGridView.ReadOnly = true;
            this.SwimmerListDataGridView.Size = new System.Drawing.Size(802, 286);
            this.SwimmerListDataGridView.TabIndex = 9;
            this.SwimmerListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SwimmerListDataGridView_CellContentClick);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetBtn.Location = new System.Drawing.Point(643, 64);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 27);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // FilterLable
            // 
            this.FilterLable.AutoSize = true;
            this.FilterLable.Location = new System.Drawing.Point(465, 9);
            this.FilterLable.Name = "FilterLable";
            this.FilterLable.Size = new System.Drawing.Size(32, 13);
            this.FilterLable.TabIndex = 11;
            this.FilterLable.Text = "Filter:";
            // 
            // AddSwimmerBtn
            // 
            this.AddSwimmerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddSwimmerBtn.Location = new System.Drawing.Point(742, 64);
            this.AddSwimmerBtn.Name = "AddSwimmerBtn";
            this.AddSwimmerBtn.Size = new System.Drawing.Size(75, 23);
            this.AddSwimmerBtn.TabIndex = 28;
            this.AddSwimmerBtn.Text = "Add Swimmer";
            this.AddSwimmerBtn.UseVisualStyleBackColor = false;
            this.AddSwimmerBtn.Click += new System.EventHandler(this.AddSwimmerBtn_Click);
            // 
            // FirstNameRadioBtn
            // 
            this.FirstNameRadioBtn.AutoSize = true;
            this.FirstNameRadioBtn.Location = new System.Drawing.Point(6, 17);
            this.FirstNameRadioBtn.Name = "FirstNameRadioBtn";
            this.FirstNameRadioBtn.Size = new System.Drawing.Size(75, 17);
            this.FirstNameRadioBtn.TabIndex = 29;
            this.FirstNameRadioBtn.TabStop = true;
            this.FirstNameRadioBtn.Text = "First Name";
            this.FirstNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // LastNameRadioBtn
            // 
            this.LastNameRadioBtn.AutoSize = true;
            this.LastNameRadioBtn.Location = new System.Drawing.Point(109, 15);
            this.LastNameRadioBtn.Name = "LastNameRadioBtn";
            this.LastNameRadioBtn.Size = new System.Drawing.Size(85, 17);
            this.LastNameRadioBtn.TabIndex = 30;
            this.LastNameRadioBtn.TabStop = true;
            this.LastNameRadioBtn.Text = "radioButton2";
            this.LastNameRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.FirstNameRadioBtn);
            this.SearchGroupBox.Controls.Add(this.LastNameRadioBtn);
            this.SearchGroupBox.Location = new System.Drawing.Point(24, 49);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(200, 38);
            this.SearchGroupBox.TabIndex = 31;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search";
            // 
            // SwimmerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 427);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.AddSwimmerBtn);
            this.Controls.Add(this.FilterLable);
            this.Controls.Add(this.FilterFemaleBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.FilterMaleBtn);
            this.Controls.Add(this.FilterTwelthGradeBtn);
            this.Controls.Add(this.FilterEleventhGradeBtn);
            this.Controls.Add(this.SearchSwimmerNameBtn);
            this.Controls.Add(this.FilterTenthGradeBtn);
            this.Controls.Add(this.FilterNinthGradeBtn);
            this.Controls.Add(this.SearchTxt);
            this.Controls.Add(this.SwimmerListHelpBtn);
            this.Controls.Add(this.BackToStartBtn);
            this.Controls.Add(this.SwimmerListDataGridView);
            this.Name = "SwimmerListForm";
            this.Text = "SwimmerList";
            this.Load += new System.EventHandler(this.SwimmerListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SwimmerListDataGridView)).EndInit();
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToStartBtn;
        private System.Windows.Forms.Button SwimmerListHelpBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.Button SearchSwimmerNameBtn;
        private System.Windows.Forms.Button FilterFemaleBtn;
        private System.Windows.Forms.Button FilterMaleBtn;
        private System.Windows.Forms.Button FilterTwelthGradeBtn;
        private System.Windows.Forms.Button FilterEleventhGradeBtn;
        private System.Windows.Forms.Button FilterTenthGradeBtn;
        private System.Windows.Forms.Button FilterNinthGradeBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label FilterLable;
        private System.Windows.Forms.Button AddSwimmerBtn;
        public  System.Windows.Forms.DataGridView SwimmerListDataGridView;
        private System.Windows.Forms.RadioButton FirstNameRadioBtn;
        private System.Windows.Forms.RadioButton LastNameRadioBtn;
        private System.Windows.Forms.GroupBox SearchGroupBox;
    }
}