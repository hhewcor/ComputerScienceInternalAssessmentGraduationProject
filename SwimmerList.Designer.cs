
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
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BackToStartBtn = new System.Windows.Forms.Button();
            this.SwimmerListHelpBtn = new System.Windows.Forms.Button();
            this.SearchFirstNameTxt = new System.Windows.Forms.TextBox();
            this.SearchFirstNameLabel = new System.Windows.Forms.Label();
            this.SearchLastNameLabel = new System.Windows.Forms.Label();
            this.SearchLastNameTxt = new System.Windows.Forms.TextBox();
            this.SearchSwimmerNameBtn = new System.Windows.Forms.Button();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterFemaleBtn = new System.Windows.Forms.Button();
            this.FilterMaleBtn = new System.Windows.Forms.Button();
            this.FilterTwelthGradeBtn = new System.Windows.Forms.Button();
            this.FilterEleventhGradeBtn = new System.Windows.Forms.Button();
            this.FilterTenthGradeBtn = new System.Windows.Forms.Button();
            this.FilterNinthGradeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FilterBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EditSwimmerListBtn = new System.Windows.Forms.Button();
            this.SwimmerListDataGridView = new System.Windows.Forms.DataGridView();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.FilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SwimmerListDataGridView)).BeginInit();
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
            this.SwimmerListHelpBtn.Location = new System.Drawing.Point(333, 13);
            this.SwimmerListHelpBtn.Name = "SwimmerListHelpBtn";
            this.SwimmerListHelpBtn.Size = new System.Drawing.Size(78, 23);
            this.SwimmerListHelpBtn.TabIndex = 1;
            this.SwimmerListHelpBtn.Text = "Help";
            this.SwimmerListHelpBtn.UseVisualStyleBackColor = false;
            this.SwimmerListHelpBtn.Click += new System.EventHandler(this.SwimmerListHelpBtn_Click);
            // 
            // SearchFirstNameTxt
            // 
            this.SearchFirstNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SearchFirstNameTxt.Location = new System.Drawing.Point(116, 52);
            this.SearchFirstNameTxt.Name = "SearchFirstNameTxt";
            this.SearchFirstNameTxt.Size = new System.Drawing.Size(89, 20);
            this.SearchFirstNameTxt.TabIndex = 2;
            this.SearchFirstNameTxt.TextChanged += new System.EventHandler(this.SearchFirstNameTxt_TextChanged);
            // 
            // SearchFirstNameLabel
            // 
            this.SearchFirstNameLabel.AutoSize = true;
            this.SearchFirstNameLabel.Location = new System.Drawing.Point(16, 55);
            this.SearchFirstNameLabel.Name = "SearchFirstNameLabel";
            this.SearchFirstNameLabel.Size = new System.Drawing.Size(94, 13);
            this.SearchFirstNameLabel.TabIndex = 3;
            this.SearchFirstNameLabel.Text = "Search First Name";
            // 
            // SearchLastNameLabel
            // 
            this.SearchLastNameLabel.AutoSize = true;
            this.SearchLastNameLabel.Location = new System.Drawing.Point(12, 85);
            this.SearchLastNameLabel.Name = "SearchLastNameLabel";
            this.SearchLastNameLabel.Size = new System.Drawing.Size(95, 13);
            this.SearchLastNameLabel.TabIndex = 4;
            this.SearchLastNameLabel.Text = "Search Last Name";
            // 
            // SearchLastNameTxt
            // 
            this.SearchLastNameTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SearchLastNameTxt.Location = new System.Drawing.Point(114, 85);
            this.SearchLastNameTxt.Name = "SearchLastNameTxt";
            this.SearchLastNameTxt.Size = new System.Drawing.Size(91, 20);
            this.SearchLastNameTxt.TabIndex = 5;
            this.SearchLastNameTxt.TextChanged += new System.EventHandler(this.SearchLastNameTxt_TextChanged);
            // 
            // SearchSwimmerNameBtn
            // 
            this.SearchSwimmerNameBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SearchSwimmerNameBtn.Location = new System.Drawing.Point(215, 62);
            this.SearchSwimmerNameBtn.Name = "SearchSwimmerNameBtn";
            this.SearchSwimmerNameBtn.Size = new System.Drawing.Size(53, 23);
            this.SearchSwimmerNameBtn.TabIndex = 6;
            this.SearchSwimmerNameBtn.Text = "Search";
            this.SearchSwimmerNameBtn.UseVisualStyleBackColor = false;
            this.SearchSwimmerNameBtn.Click += new System.EventHandler(this.SearchSwimmerNameBtn_Click);
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterFemaleBtn);
            this.FilterPanel.Controls.Add(this.FilterMaleBtn);
            this.FilterPanel.Controls.Add(this.FilterTwelthGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterEleventhGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterTenthGradeBtn);
            this.FilterPanel.Controls.Add(this.FilterNinthGradeBtn);
            this.FilterPanel.Controls.Add(this.button1);
            this.FilterPanel.Controls.Add(this.FilterBtn);
            this.FilterPanel.Location = new System.Drawing.Point(284, 52);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(75, 25);
            this.FilterPanel.TabIndex = 7;
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
            this.FilterFemaleBtn.Click += new System.EventHandler(this.FilterFemaleBtn_Click);
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
            this.FilterMaleBtn.Click += new System.EventHandler(this.FilterMaleBtn_Click);
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
            this.FilterTwelthGradeBtn.Click += new System.EventHandler(this.FilterTwelthGradeBtn_Click);
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
            this.FilterEleventhGradeBtn.Click += new System.EventHandler(this.FilterEleventhGradeBtn_Click);
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
            this.FilterTenthGradeBtn.Click += new System.EventHandler(this.FilterTenthGradeBtn_Click);
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
            this.FilterNinthGradeBtn.Click += new System.EventHandler(this.FilterNinthGradeBtn_Click);
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
            // FilterBtn
            // 
            this.FilterBtn.BackColor = System.Drawing.Color.Plum;
            this.FilterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterBtn.Location = new System.Drawing.Point(0, 0);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.Size = new System.Drawing.Size(75, 25);
            this.FilterBtn.TabIndex = 0;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.UseVisualStyleBackColor = false;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            this.FilterBtn.MouseLeave += new System.EventHandler(this.FilterBtn_MouseLeave);
            this.FilterBtn.MouseHover += new System.EventHandler(this.FilterBtn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EditSwimmerListBtn
            // 
            this.EditSwimmerListBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EditSwimmerListBtn.Location = new System.Drawing.Point(365, 52);
            this.EditSwimmerListBtn.Name = "EditSwimmerListBtn";
            this.EditSwimmerListBtn.Size = new System.Drawing.Size(75, 25);
            this.EditSwimmerListBtn.TabIndex = 8;
            this.EditSwimmerListBtn.Text = "Edit";
            this.EditSwimmerListBtn.UseVisualStyleBackColor = false;
            this.EditSwimmerListBtn.Click += new System.EventHandler(this.EditSwimmerListBtn_Click);
            // 
            // SwimmerListDataGridView
            // 
            this.SwimmerListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SwimmerListDataGridView.Location = new System.Drawing.Point(15, 152);
            this.SwimmerListDataGridView.Name = "SwimmerListDataGridView";
            this.SwimmerListDataGridView.Size = new System.Drawing.Size(432, 261);
            this.SwimmerListDataGridView.TabIndex = 9;
            this.SwimmerListDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ImportBtn
            // 
            this.ImportBtn.Location = new System.Drawing.Point(131, 13);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(75, 23);
            this.ImportBtn.TabIndex = 10;
            this.ImportBtn.Text = "Import Data";
            this.ImportBtn.UseVisualStyleBackColor = true;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // SwimmerListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.SwimmerListDataGridView);
            this.Controls.Add(this.EditSwimmerListBtn);
            this.Controls.Add(this.FilterPanel);
            this.Controls.Add(this.SearchSwimmerNameBtn);
            this.Controls.Add(this.SearchLastNameTxt);
            this.Controls.Add(this.SearchLastNameLabel);
            this.Controls.Add(this.SearchFirstNameLabel);
            this.Controls.Add(this.SearchFirstNameTxt);
            this.Controls.Add(this.SwimmerListHelpBtn);
            this.Controls.Add(this.BackToStartBtn);
            this.Name = "SwimmerListForm";
            this.Text = "SwimmerList";
            this.Load += new System.EventHandler(this.SwimmerListForm_Load);
            this.FilterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SwimmerListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToStartBtn;
        private System.Windows.Forms.Button SwimmerListHelpBtn;
        private System.Windows.Forms.TextBox SearchFirstNameTxt;
        private System.Windows.Forms.Label SearchFirstNameLabel;
        private System.Windows.Forms.Label SearchLastNameLabel;
        private System.Windows.Forms.TextBox SearchLastNameTxt;
        private System.Windows.Forms.Button SearchSwimmerNameBtn;
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.Button FilterFemaleBtn;
        private System.Windows.Forms.Button FilterMaleBtn;
        private System.Windows.Forms.Button FilterTwelthGradeBtn;
        private System.Windows.Forms.Button FilterEleventhGradeBtn;
        private System.Windows.Forms.Button FilterTenthGradeBtn;
        private System.Windows.Forms.Button FilterNinthGradeBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FilterBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button EditSwimmerListBtn;
        private System.Windows.Forms.DataGridView SwimmerListDataGridView;
        private System.Windows.Forms.Button ImportBtn;
    }
}