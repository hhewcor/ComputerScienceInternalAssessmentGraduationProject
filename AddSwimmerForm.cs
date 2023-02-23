using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerScienceInternalAssessment
{
    public partial class AddSwimmerForm : Form
    {
        public AddSwimmerForm()
        {
            InitializeComponent();
        }

        private void AddSwimmerForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.ControlBox = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            //var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
        }

        private void BackToEditSwimmerListFormBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditSwimmerListForm edsl = new EditSwimmerListForm();
            edsl.Show();
        }

        private void SwimmerListHelpBtn_Click(object sender, EventArgs e)
        {

        }

        //groupbox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Name
        //var buttons = this.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);

        private bool swGradeSelected = false;
        private String swGrade = "";

        private bool swGenderSelected = false;
        private String swGender = "";

        private bool swStrokeSelected = false;
        private String swStroke = "";

        private bool swDistanceSelected = false;
        private String swDistance = "";

        private bool swGoalTimeMinSelected = false;
        private bool swGoalTimeSecSelected = false;
        private bool swGoalTimeMilSelected = false;

        private int swGoalTimeMin;
        private int swGoalTimeSec;
        private int swGoalTimeMil;

        private bool swTimeMinSelected = false;
        private bool swTimeSecSelected = false;
        private bool swTimeMilSelected = false;

        private int swTimeMin;
        private int swTimeSec;
        private int swTimeMil;


        // GRADE ------------------------------------------------------------
        private void NinthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGradeSelected = true;
            swGrade = "9";
        }

        private void TenthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGradeSelected = true;
            swGrade = "10";
        }

        private void EleventhGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGradeSelected = true;
            swGrade = "11";
        }

        private void TwelthGradeRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGradeSelected = true;
            swGrade = "12";
        }

        //Gender ----------------------------------------------
        private void MaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGenderSelected = true;
            swGender = "M";
        }

        private void FemaleRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swGenderSelected = true;
            swGender = "F";
        }

        //Stroke ----------------------------------------------------
        private void FlyStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStrokeSelected = true;
            swStroke = " fl";
        }

        private void BackStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStrokeSelected = true;
            swStroke = " bk";
        }

        private void BreastStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStrokeSelected = true;
            swStroke = " br";
        }

        private void FreeStrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStrokeSelected = true;
            swStroke = " fr";
        }

        private void IMstrRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swStrokeSelected = true;
            swStroke = " IM";
        }

        //Distance -------------------------------------------------------------
        private void Dist50RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistanceSelected = true;
            swDistance = "50";
        }

        private void Dist100RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistanceSelected = true;
            swDistance = "100";
        }

        private void Dist200RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistanceSelected = true;
            swDistance = "200";
        }

        private void Dist500RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            swDistanceSelected = true;
            swDistance = "500";
        }

        //Swimmer Goal Time -----------------------------------------
        private void SwimmerGoalTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SwimmerGoalTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void SwimmerGoalTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            String TimeSec = SwimmerTimeSecTxtBox.Text;
        }

        //Swimmer Time ------------------------------------------------------
        private void SwimmerTimeMinTxtBox_TextChanged(object sender, EventArgs e)
        {
            String TimeSec = SwimmerTimeSecTxtBox.Text;
        }

        private void SwimmerTimeSecTxtBox_TextChanged(object sender, EventArgs e)
        {
            String TimeSec = SwimmerTimeSecTxtBox.Text;
        }

        private void SwimmerTimeMilTxtBox_TextChanged(object sender, EventArgs e)
        {
            String TimeMil = SwimmerTimeMilTxtBox.Text;
        }

        //Swimmer Name -----------------------------------------------------
        private void FirstNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            String FirstName = FirstNameTxtBox.Text;
        }

        private void LastNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            String LastName = LastNameTxtBox.Text;
        }

        private void AddSwimmerBtn_Click(object sender, EventArgs e)
        {

        }

        private void check()
        {

        }
    }
}
