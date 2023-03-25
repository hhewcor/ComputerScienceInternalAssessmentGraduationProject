
namespace ComputerScienceInternalAssessment
{
    partial class EditSwimmerForm
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
            this.DistanceGroupBox = new System.Windows.Forms.GroupBox();
            this.Dist50RadioBtn = new System.Windows.Forms.RadioButton();
            this.Dist100RadioBtn = new System.Windows.Forms.RadioButton();
            this.Dist200RadioBtn = new System.Windows.Forms.RadioButton();
            this.Dist500RadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SwimmerTimeSecTxtBox = new System.Windows.Forms.TextBox();
            this.SwimmerTimeMinTxtBox = new System.Windows.Forms.TextBox();
            this.SwimmerTimeLabel = new System.Windows.Forms.Label();
            this.BreastStrRadioBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.FlyStrRadioBtn = new System.Windows.Forms.RadioButton();
            this.BackStrRadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SwimmerGoalTimeMinTxtBox = new System.Windows.Forms.TextBox();
            this.SwimmerGoalTimeLabel = new System.Windows.Forms.Label();
            this.SwimmerGoalTimeMilTxtBox = new System.Windows.Forms.TextBox();
            this.SwimmerGoalTimeSecTxtBox = new System.Windows.Forms.TextBox();
            this.UpdateSwimmerBtn = new System.Windows.Forms.Button();
            this.FreeStrRadioBtn = new System.Windows.Forms.RadioButton();
            this.GradeGroupBox = new System.Windows.Forms.GroupBox();
            this.NinthGradeRadioBtn = new System.Windows.Forms.RadioButton();
            this.TenthGradeRadioBtn = new System.Windows.Forms.RadioButton();
            this.EleventhGradeRadioBtn = new System.Windows.Forms.RadioButton();
            this.TwelthGradeRadioBtn = new System.Windows.Forms.RadioButton();
            this.LastNameTxtBox = new System.Windows.Forms.TextBox();
            this.FirstNameTxtBox = new System.Windows.Forms.TextBox();
            this.BackToSwimmerListFormBtn = new System.Windows.Forms.Button();
            this.SwimmerLastNameLabel = new System.Windows.Forms.Label();
            this.SwimmerFirstNameLabel = new System.Windows.Forms.Label();
            this.GenderGroupBox = new System.Windows.Forms.GroupBox();
            this.FemaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.MaleRadioBtn = new System.Windows.Forms.RadioButton();
            this.SwimmerListHelpBtn = new System.Windows.Forms.Button();
            this.StrokeGroupBox = new System.Windows.Forms.GroupBox();
            this.IMstrRadioBtn = new System.Windows.Forms.RadioButton();
            this.SwimmerTimeMilTxtBox = new System.Windows.Forms.TextBox();
            this.DistanceGroupBox.SuspendLayout();
            this.GradeGroupBox.SuspendLayout();
            this.GenderGroupBox.SuspendLayout();
            this.StrokeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DistanceGroupBox
            // 
            this.DistanceGroupBox.Controls.Add(this.Dist50RadioBtn);
            this.DistanceGroupBox.Controls.Add(this.Dist100RadioBtn);
            this.DistanceGroupBox.Controls.Add(this.Dist200RadioBtn);
            this.DistanceGroupBox.Controls.Add(this.Dist500RadioBtn);
            this.DistanceGroupBox.Location = new System.Drawing.Point(42, 264);
            this.DistanceGroupBox.Name = "DistanceGroupBox";
            this.DistanceGroupBox.Size = new System.Drawing.Size(247, 46);
            this.DistanceGroupBox.TabIndex = 64;
            this.DistanceGroupBox.TabStop = false;
            this.DistanceGroupBox.Text = "Distance:";
            // 
            // Dist50RadioBtn
            // 
            this.Dist50RadioBtn.AutoSize = true;
            this.Dist50RadioBtn.Location = new System.Drawing.Point(19, 23);
            this.Dist50RadioBtn.Name = "Dist50RadioBtn";
            this.Dist50RadioBtn.Size = new System.Drawing.Size(37, 17);
            this.Dist50RadioBtn.TabIndex = 21;
            this.Dist50RadioBtn.TabStop = true;
            this.Dist50RadioBtn.Text = "50";
            this.Dist50RadioBtn.UseVisualStyleBackColor = true;
            this.Dist50RadioBtn.CheckedChanged += new System.EventHandler(this.Dist50RadioBtn_CheckedChanged);
            // 
            // Dist100RadioBtn
            // 
            this.Dist100RadioBtn.AutoSize = true;
            this.Dist100RadioBtn.Location = new System.Drawing.Point(69, 23);
            this.Dist100RadioBtn.Name = "Dist100RadioBtn";
            this.Dist100RadioBtn.Size = new System.Drawing.Size(43, 17);
            this.Dist100RadioBtn.TabIndex = 22;
            this.Dist100RadioBtn.TabStop = true;
            this.Dist100RadioBtn.Text = "100";
            this.Dist100RadioBtn.UseVisualStyleBackColor = true;
            this.Dist100RadioBtn.CheckedChanged += new System.EventHandler(this.Dist100RadioBtn_CheckedChanged);
            // 
            // Dist200RadioBtn
            // 
            this.Dist200RadioBtn.AutoSize = true;
            this.Dist200RadioBtn.Location = new System.Drawing.Point(130, 23);
            this.Dist200RadioBtn.Name = "Dist200RadioBtn";
            this.Dist200RadioBtn.Size = new System.Drawing.Size(43, 17);
            this.Dist200RadioBtn.TabIndex = 23;
            this.Dist200RadioBtn.TabStop = true;
            this.Dist200RadioBtn.Text = "200";
            this.Dist200RadioBtn.UseVisualStyleBackColor = true;
            this.Dist200RadioBtn.CheckedChanged += new System.EventHandler(this.Dist200RadioBtn_CheckedChanged);
            // 
            // Dist500RadioBtn
            // 
            this.Dist500RadioBtn.AutoSize = true;
            this.Dist500RadioBtn.Location = new System.Drawing.Point(179, 23);
            this.Dist500RadioBtn.Name = "Dist500RadioBtn";
            this.Dist500RadioBtn.Size = new System.Drawing.Size(43, 17);
            this.Dist500RadioBtn.TabIndex = 25;
            this.Dist500RadioBtn.TabStop = true;
            this.Dist500RadioBtn.Text = "500";
            this.Dist500RadioBtn.UseVisualStyleBackColor = true;
            this.Dist500RadioBtn.CheckedChanged += new System.EventHandler(this.Dist500RadioBtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = ":";
            // 
            // SwimmerTimeSecTxtBox
            // 
            this.SwimmerTimeSecTxtBox.Location = new System.Drawing.Point(205, 356);
            this.SwimmerTimeSecTxtBox.MaxLength = 2;
            this.SwimmerTimeSecTxtBox.Name = "SwimmerTimeSecTxtBox";
            this.SwimmerTimeSecTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerTimeSecTxtBox.TabIndex = 56;
            this.SwimmerTimeSecTxtBox.TextChanged += new System.EventHandler(this.SwimmerTimeSecTxtBox_TextChanged);
            this.SwimmerTimeSecTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerTimeSecTxtBox_KeyPress);
            // 
            // SwimmerTimeMinTxtBox
            // 
            this.SwimmerTimeMinTxtBox.Location = new System.Drawing.Point(156, 356);
            this.SwimmerTimeMinTxtBox.MaxLength = 2;
            this.SwimmerTimeMinTxtBox.Name = "SwimmerTimeMinTxtBox";
            this.SwimmerTimeMinTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerTimeMinTxtBox.TabIndex = 55;
            this.SwimmerTimeMinTxtBox.TextChanged += new System.EventHandler(this.SwimmerTimeMinTxtBox_TextChanged);
            this.SwimmerTimeMinTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerTimeMinTxtBox_KeyPress);
            // 
            // SwimmerTimeLabel
            // 
            this.SwimmerTimeLabel.AutoSize = true;
            this.SwimmerTimeLabel.Location = new System.Drawing.Point(68, 356);
            this.SwimmerTimeLabel.Name = "SwimmerTimeLabel";
            this.SwimmerTimeLabel.Size = new System.Drawing.Size(78, 13);
            this.SwimmerTimeLabel.TabIndex = 54;
            this.SwimmerTimeLabel.Text = "Swimmer Time:";
            // 
            // BreastStrRadioBtn
            // 
            this.BreastStrRadioBtn.AutoSize = true;
            this.BreastStrRadioBtn.Location = new System.Drawing.Point(101, 19);
            this.BreastStrRadioBtn.Name = "BreastStrRadioBtn";
            this.BreastStrRadioBtn.Size = new System.Drawing.Size(55, 17);
            this.BreastStrRadioBtn.TabIndex = 18;
            this.BreastStrRadioBtn.TabStop = true;
            this.BreastStrRadioBtn.Text = "Breast";
            this.BreastStrRadioBtn.UseVisualStyleBackColor = true;
            this.BreastStrRadioBtn.CheckedChanged += new System.EventHandler(this.BreastStrRadioBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = ".";
            // 
            // FlyStrRadioBtn
            // 
            this.FlyStrRadioBtn.AutoSize = true;
            this.FlyStrRadioBtn.Location = new System.Drawing.Point(7, 19);
            this.FlyStrRadioBtn.Name = "FlyStrRadioBtn";
            this.FlyStrRadioBtn.Size = new System.Drawing.Size(38, 17);
            this.FlyStrRadioBtn.TabIndex = 16;
            this.FlyStrRadioBtn.TabStop = true;
            this.FlyStrRadioBtn.Text = "Fly";
            this.FlyStrRadioBtn.UseVisualStyleBackColor = true;
            this.FlyStrRadioBtn.CheckedChanged += new System.EventHandler(this.FlyStrRadioBtn_CheckedChanged);
            // 
            // BackStrRadioBtn
            // 
            this.BackStrRadioBtn.AutoSize = true;
            this.BackStrRadioBtn.Location = new System.Drawing.Point(45, 18);
            this.BackStrRadioBtn.Name = "BackStrRadioBtn";
            this.BackStrRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.BackStrRadioBtn.TabIndex = 17;
            this.BackStrRadioBtn.TabStop = true;
            this.BackStrRadioBtn.Text = "Back";
            this.BackStrRadioBtn.UseVisualStyleBackColor = true;
            this.BackStrRadioBtn.CheckedChanged += new System.EventHandler(this.BackStrRadioBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = ":";
            // 
            // SwimmerGoalTimeMinTxtBox
            // 
            this.SwimmerGoalTimeMinTxtBox.Location = new System.Drawing.Point(157, 330);
            this.SwimmerGoalTimeMinTxtBox.MaxLength = 2;
            this.SwimmerGoalTimeMinTxtBox.Name = "SwimmerGoalTimeMinTxtBox";
            this.SwimmerGoalTimeMinTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerGoalTimeMinTxtBox.TabIndex = 49;
            this.SwimmerGoalTimeMinTxtBox.TextChanged += new System.EventHandler(this.SwimmerGoalTimeMinTxtBox_TextChanged);
            this.SwimmerGoalTimeMinTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerGoalTimeMinTxtBox_KeyPress);
            // 
            // SwimmerGoalTimeLabel
            // 
            this.SwimmerGoalTimeLabel.AutoSize = true;
            this.SwimmerGoalTimeLabel.Location = new System.Drawing.Point(46, 333);
            this.SwimmerGoalTimeLabel.Name = "SwimmerGoalTimeLabel";
            this.SwimmerGoalTimeLabel.Size = new System.Drawing.Size(103, 13);
            this.SwimmerGoalTimeLabel.TabIndex = 48;
            this.SwimmerGoalTimeLabel.Text = "Swimmer Goal Time:";
            // 
            // SwimmerGoalTimeMilTxtBox
            // 
            this.SwimmerGoalTimeMilTxtBox.Location = new System.Drawing.Point(254, 330);
            this.SwimmerGoalTimeMilTxtBox.MaxLength = 2;
            this.SwimmerGoalTimeMilTxtBox.Name = "SwimmerGoalTimeMilTxtBox";
            this.SwimmerGoalTimeMilTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerGoalTimeMilTxtBox.TabIndex = 51;
            this.SwimmerGoalTimeMilTxtBox.TextChanged += new System.EventHandler(this.SwimmerGoalTimeMilTxtBox_TextChanged);
            this.SwimmerGoalTimeMilTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerGoalTimeMilTxtBox_KeyPress);
            // 
            // SwimmerGoalTimeSecTxtBox
            // 
            this.SwimmerGoalTimeSecTxtBox.Location = new System.Drawing.Point(206, 330);
            this.SwimmerGoalTimeSecTxtBox.MaxLength = 2;
            this.SwimmerGoalTimeSecTxtBox.Name = "SwimmerGoalTimeSecTxtBox";
            this.SwimmerGoalTimeSecTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerGoalTimeSecTxtBox.TabIndex = 50;
            this.SwimmerGoalTimeSecTxtBox.TextChanged += new System.EventHandler(this.SwimmerGoalTimeSecTxtBox_TextChanged);
            this.SwimmerGoalTimeSecTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerGoalTimeSecTxtBox_KeyPress);
            // 
            // UpdateSwimmerBtn
            // 
            this.UpdateSwimmerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateSwimmerBtn.Location = new System.Drawing.Point(254, 412);
            this.UpdateSwimmerBtn.Name = "UpdateSwimmerBtn";
            this.UpdateSwimmerBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateSwimmerBtn.TabIndex = 44;
            this.UpdateSwimmerBtn.Text = "Update";
            this.UpdateSwimmerBtn.UseVisualStyleBackColor = false;
            this.UpdateSwimmerBtn.Click += new System.EventHandler(this.UpdateSwimmerBtn_Click);
            // 
            // FreeStrRadioBtn
            // 
            this.FreeStrRadioBtn.AutoSize = true;
            this.FreeStrRadioBtn.Location = new System.Drawing.Point(160, 19);
            this.FreeStrRadioBtn.Name = "FreeStrRadioBtn";
            this.FreeStrRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.FreeStrRadioBtn.TabIndex = 19;
            this.FreeStrRadioBtn.TabStop = true;
            this.FreeStrRadioBtn.Text = "Free";
            this.FreeStrRadioBtn.UseVisualStyleBackColor = true;
            this.FreeStrRadioBtn.CheckedChanged += new System.EventHandler(this.FreeStrRadioBtn_CheckedChanged);
            // 
            // GradeGroupBox
            // 
            this.GradeGroupBox.Controls.Add(this.NinthGradeRadioBtn);
            this.GradeGroupBox.Controls.Add(this.TenthGradeRadioBtn);
            this.GradeGroupBox.Controls.Add(this.EleventhGradeRadioBtn);
            this.GradeGroupBox.Controls.Add(this.TwelthGradeRadioBtn);
            this.GradeGroupBox.Location = new System.Drawing.Point(62, 120);
            this.GradeGroupBox.Name = "GradeGroupBox";
            this.GradeGroupBox.Size = new System.Drawing.Size(200, 53);
            this.GradeGroupBox.TabIndex = 61;
            this.GradeGroupBox.TabStop = false;
            this.GradeGroupBox.Text = "Grade:";
            // 
            // NinthGradeRadioBtn
            // 
            this.NinthGradeRadioBtn.AutoSize = true;
            this.NinthGradeRadioBtn.Location = new System.Drawing.Point(79, 11);
            this.NinthGradeRadioBtn.Name = "NinthGradeRadioBtn";
            this.NinthGradeRadioBtn.Size = new System.Drawing.Size(40, 17);
            this.NinthGradeRadioBtn.TabIndex = 8;
            this.NinthGradeRadioBtn.TabStop = true;
            this.NinthGradeRadioBtn.Text = "9th";
            this.NinthGradeRadioBtn.UseVisualStyleBackColor = true;
            this.NinthGradeRadioBtn.CheckedChanged += new System.EventHandler(this.NinthGradeRadioBtn_CheckedChanged);
            // 
            // TenthGradeRadioBtn
            // 
            this.TenthGradeRadioBtn.AutoSize = true;
            this.TenthGradeRadioBtn.Location = new System.Drawing.Point(138, 11);
            this.TenthGradeRadioBtn.Name = "TenthGradeRadioBtn";
            this.TenthGradeRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.TenthGradeRadioBtn.TabIndex = 9;
            this.TenthGradeRadioBtn.TabStop = true;
            this.TenthGradeRadioBtn.Text = "10th";
            this.TenthGradeRadioBtn.UseVisualStyleBackColor = true;
            this.TenthGradeRadioBtn.CheckedChanged += new System.EventHandler(this.TenthGradeRadioBtn_CheckedChanged);
            // 
            // EleventhGradeRadioBtn
            // 
            this.EleventhGradeRadioBtn.AutoSize = true;
            this.EleventhGradeRadioBtn.Location = new System.Drawing.Point(79, 33);
            this.EleventhGradeRadioBtn.Name = "EleventhGradeRadioBtn";
            this.EleventhGradeRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.EleventhGradeRadioBtn.TabIndex = 10;
            this.EleventhGradeRadioBtn.TabStop = true;
            this.EleventhGradeRadioBtn.Text = "11th";
            this.EleventhGradeRadioBtn.UseVisualStyleBackColor = true;
            this.EleventhGradeRadioBtn.CheckedChanged += new System.EventHandler(this.EleventhGradeRadioBtn_CheckedChanged);
            // 
            // TwelthGradeRadioBtn
            // 
            this.TwelthGradeRadioBtn.AutoSize = true;
            this.TwelthGradeRadioBtn.Location = new System.Drawing.Point(143, 31);
            this.TwelthGradeRadioBtn.Name = "TwelthGradeRadioBtn";
            this.TwelthGradeRadioBtn.Size = new System.Drawing.Size(46, 17);
            this.TwelthGradeRadioBtn.TabIndex = 11;
            this.TwelthGradeRadioBtn.TabStop = true;
            this.TwelthGradeRadioBtn.Text = "12th";
            this.TwelthGradeRadioBtn.UseVisualStyleBackColor = true;
            this.TwelthGradeRadioBtn.CheckedChanged += new System.EventHandler(this.TwelthGradeRadioBtn_CheckedChanged);
            // 
            // LastNameTxtBox
            // 
            this.LastNameTxtBox.Location = new System.Drawing.Point(143, 91);
            this.LastNameTxtBox.MaxLength = 20;
            this.LastNameTxtBox.Name = "LastNameTxtBox";
            this.LastNameTxtBox.Size = new System.Drawing.Size(119, 20);
            this.LastNameTxtBox.TabIndex = 47;
            this.LastNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNameTxtBox_KeyPress);
            // 
            // FirstNameTxtBox
            // 
            this.FirstNameTxtBox.Location = new System.Drawing.Point(143, 64);
            this.FirstNameTxtBox.MaxLength = 20;
            this.FirstNameTxtBox.Name = "FirstNameTxtBox";
            this.FirstNameTxtBox.Size = new System.Drawing.Size(119, 20);
            this.FirstNameTxtBox.TabIndex = 46;
            this.FirstNameTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTxtBox_KeyPress);
            // 
            // BackToSwimmerListFormBtn
            // 
            this.BackToSwimmerListFormBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackToSwimmerListFormBtn.Location = new System.Drawing.Point(13, 10);
            this.BackToSwimmerListFormBtn.Name = "BackToSwimmerListFormBtn";
            this.BackToSwimmerListFormBtn.Size = new System.Drawing.Size(75, 23);
            this.BackToSwimmerListFormBtn.TabIndex = 45;
            this.BackToSwimmerListFormBtn.Text = "Back";
            this.BackToSwimmerListFormBtn.UseVisualStyleBackColor = false;
            this.BackToSwimmerListFormBtn.Click += new System.EventHandler(this.BackToSwimmerListFormBtn_Click);
            // 
            // SwimmerLastNameLabel
            // 
            this.SwimmerLastNameLabel.AutoSize = true;
            this.SwimmerLastNameLabel.Location = new System.Drawing.Point(59, 94);
            this.SwimmerLastNameLabel.Name = "SwimmerLastNameLabel";
            this.SwimmerLastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.SwimmerLastNameLabel.TabIndex = 43;
            this.SwimmerLastNameLabel.Text = "Last Name:";
            // 
            // SwimmerFirstNameLabel
            // 
            this.SwimmerFirstNameLabel.AutoSize = true;
            this.SwimmerFirstNameLabel.Location = new System.Drawing.Point(59, 64);
            this.SwimmerFirstNameLabel.Name = "SwimmerFirstNameLabel";
            this.SwimmerFirstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.SwimmerFirstNameLabel.TabIndex = 42;
            this.SwimmerFirstNameLabel.Text = "First Name:";
            // 
            // GenderGroupBox
            // 
            this.GenderGroupBox.Controls.Add(this.FemaleRadioBtn);
            this.GenderGroupBox.Controls.Add(this.MaleRadioBtn);
            this.GenderGroupBox.Location = new System.Drawing.Point(62, 174);
            this.GenderGroupBox.Name = "GenderGroupBox";
            this.GenderGroupBox.Size = new System.Drawing.Size(200, 37);
            this.GenderGroupBox.TabIndex = 62;
            this.GenderGroupBox.TabStop = false;
            this.GenderGroupBox.Text = "Gender:";
            // 
            // FemaleRadioBtn
            // 
            this.FemaleRadioBtn.AutoSize = true;
            this.FemaleRadioBtn.Location = new System.Drawing.Point(125, 10);
            this.FemaleRadioBtn.Name = "FemaleRadioBtn";
            this.FemaleRadioBtn.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioBtn.TabIndex = 13;
            this.FemaleRadioBtn.TabStop = true;
            this.FemaleRadioBtn.Text = "Female";
            this.FemaleRadioBtn.UseVisualStyleBackColor = true;
            this.FemaleRadioBtn.CheckedChanged += new System.EventHandler(this.FemaleRadioBtn_CheckedChanged);
            // 
            // MaleRadioBtn
            // 
            this.MaleRadioBtn.AutoSize = true;
            this.MaleRadioBtn.Location = new System.Drawing.Point(71, 10);
            this.MaleRadioBtn.Name = "MaleRadioBtn";
            this.MaleRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioBtn.TabIndex = 12;
            this.MaleRadioBtn.TabStop = true;
            this.MaleRadioBtn.Text = "Male";
            this.MaleRadioBtn.UseVisualStyleBackColor = true;
            this.MaleRadioBtn.CheckedChanged += new System.EventHandler(this.MaleRadioBtn_CheckedChanged);
            // 
            // SwimmerListHelpBtn
            // 
            this.SwimmerListHelpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.SwimmerListHelpBtn.Location = new System.Drawing.Point(251, 10);
            this.SwimmerListHelpBtn.Name = "SwimmerListHelpBtn";
            this.SwimmerListHelpBtn.Size = new System.Drawing.Size(78, 23);
            this.SwimmerListHelpBtn.TabIndex = 60;
            this.SwimmerListHelpBtn.Text = "Help";
            this.SwimmerListHelpBtn.UseVisualStyleBackColor = false;
            this.SwimmerListHelpBtn.Click += new System.EventHandler(this.SwimmerListHelpBtn_Click);
            // 
            // StrokeGroupBox
            // 
            this.StrokeGroupBox.Controls.Add(this.FlyStrRadioBtn);
            this.StrokeGroupBox.Controls.Add(this.BackStrRadioBtn);
            this.StrokeGroupBox.Controls.Add(this.BreastStrRadioBtn);
            this.StrokeGroupBox.Controls.Add(this.FreeStrRadioBtn);
            this.StrokeGroupBox.Controls.Add(this.IMstrRadioBtn);
            this.StrokeGroupBox.Location = new System.Drawing.Point(42, 217);
            this.StrokeGroupBox.Name = "StrokeGroupBox";
            this.StrokeGroupBox.Size = new System.Drawing.Size(260, 41);
            this.StrokeGroupBox.TabIndex = 63;
            this.StrokeGroupBox.TabStop = false;
            this.StrokeGroupBox.Text = "Stroke: ";
            // 
            // IMstrRadioBtn
            // 
            this.IMstrRadioBtn.AutoSize = true;
            this.IMstrRadioBtn.Location = new System.Drawing.Point(212, 19);
            this.IMstrRadioBtn.Name = "IMstrRadioBtn";
            this.IMstrRadioBtn.Size = new System.Drawing.Size(37, 17);
            this.IMstrRadioBtn.TabIndex = 24;
            this.IMstrRadioBtn.TabStop = true;
            this.IMstrRadioBtn.Text = "IM";
            this.IMstrRadioBtn.UseVisualStyleBackColor = true;
            this.IMstrRadioBtn.CheckedChanged += new System.EventHandler(this.IMstrRadioBtn_CheckedChanged);
            // 
            // SwimmerTimeMilTxtBox
            // 
            this.SwimmerTimeMilTxtBox.Location = new System.Drawing.Point(253, 356);
            this.SwimmerTimeMilTxtBox.MaxLength = 2;
            this.SwimmerTimeMilTxtBox.Name = "SwimmerTimeMilTxtBox";
            this.SwimmerTimeMilTxtBox.Size = new System.Drawing.Size(30, 20);
            this.SwimmerTimeMilTxtBox.TabIndex = 57;
            this.SwimmerTimeMilTxtBox.TextChanged += new System.EventHandler(this.SwimmerTimeMilTxtBox_TextChanged);
            this.SwimmerTimeMilTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SwimmerTimeMilTxtBox_KeyPress);
            // 
            // EditSwimmerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.DistanceGroupBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SwimmerTimeSecTxtBox);
            this.Controls.Add(this.SwimmerTimeMinTxtBox);
            this.Controls.Add(this.SwimmerTimeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SwimmerGoalTimeMinTxtBox);
            this.Controls.Add(this.SwimmerGoalTimeLabel);
            this.Controls.Add(this.SwimmerGoalTimeMilTxtBox);
            this.Controls.Add(this.SwimmerGoalTimeSecTxtBox);
            this.Controls.Add(this.UpdateSwimmerBtn);
            this.Controls.Add(this.GradeGroupBox);
            this.Controls.Add(this.LastNameTxtBox);
            this.Controls.Add(this.FirstNameTxtBox);
            this.Controls.Add(this.BackToSwimmerListFormBtn);
            this.Controls.Add(this.SwimmerLastNameLabel);
            this.Controls.Add(this.SwimmerFirstNameLabel);
            this.Controls.Add(this.GenderGroupBox);
            this.Controls.Add(this.SwimmerListHelpBtn);
            this.Controls.Add(this.StrokeGroupBox);
            this.Controls.Add(this.SwimmerTimeMilTxtBox);
            this.Name = "EditSwimmerForm";
            this.Text = "EditSwimmerForm";
            this.Load += new System.EventHandler(this.EditSwimmerForm_Load);
            this.DistanceGroupBox.ResumeLayout(false);
            this.DistanceGroupBox.PerformLayout();
            this.GradeGroupBox.ResumeLayout(false);
            this.GradeGroupBox.PerformLayout();
            this.GenderGroupBox.ResumeLayout(false);
            this.GenderGroupBox.PerformLayout();
            this.StrokeGroupBox.ResumeLayout(false);
            this.StrokeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DistanceGroupBox;
        private System.Windows.Forms.RadioButton Dist50RadioBtn;
        private System.Windows.Forms.RadioButton Dist100RadioBtn;
        private System.Windows.Forms.RadioButton Dist200RadioBtn;
        private System.Windows.Forms.RadioButton Dist500RadioBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SwimmerTimeSecTxtBox;
        private System.Windows.Forms.TextBox SwimmerTimeMinTxtBox;
        private System.Windows.Forms.Label SwimmerTimeLabel;
        private System.Windows.Forms.RadioButton BreastStrRadioBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton FlyStrRadioBtn;
        private System.Windows.Forms.RadioButton BackStrRadioBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SwimmerGoalTimeMinTxtBox;
        private System.Windows.Forms.Label SwimmerGoalTimeLabel;
        private System.Windows.Forms.TextBox SwimmerGoalTimeMilTxtBox;
        private System.Windows.Forms.TextBox SwimmerGoalTimeSecTxtBox;
        private System.Windows.Forms.Button UpdateSwimmerBtn;
        private System.Windows.Forms.RadioButton FreeStrRadioBtn;
        private System.Windows.Forms.GroupBox GradeGroupBox;
        private System.Windows.Forms.RadioButton NinthGradeRadioBtn;
        private System.Windows.Forms.RadioButton TenthGradeRadioBtn;
        private System.Windows.Forms.RadioButton EleventhGradeRadioBtn;
        private System.Windows.Forms.RadioButton TwelthGradeRadioBtn;
        private System.Windows.Forms.TextBox LastNameTxtBox;
        private System.Windows.Forms.TextBox FirstNameTxtBox;
        private System.Windows.Forms.Button BackToSwimmerListFormBtn;
        private System.Windows.Forms.Label SwimmerLastNameLabel;
        private System.Windows.Forms.Label SwimmerFirstNameLabel;
        private System.Windows.Forms.GroupBox GenderGroupBox;
        private System.Windows.Forms.RadioButton FemaleRadioBtn;
        private System.Windows.Forms.RadioButton MaleRadioBtn;
        private System.Windows.Forms.Button SwimmerListHelpBtn;
        private System.Windows.Forms.GroupBox StrokeGroupBox;
        private System.Windows.Forms.RadioButton IMstrRadioBtn;
        private System.Windows.Forms.TextBox SwimmerTimeMilTxtBox;
    }
}